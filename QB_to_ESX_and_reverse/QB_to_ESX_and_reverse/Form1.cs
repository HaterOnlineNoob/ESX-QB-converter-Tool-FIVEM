using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QB_to_ESX_and_reverse
{
    public partial class Form1 : Form
    {
        private FolderBrowserDialog folderBrowserDialog;
        public Point mouseLocation;
        public Form1()
        {
            InitializeComponent();
            folderBrowserDialog = new FolderBrowserDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPathTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string folderPath = folderPathTextBox.Text;
            if (string.IsNullOrEmpty(folderPath) || !Directory.Exists(folderPath))
            {
                MessageBox.Show("Please select a valid folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string direction = esxToQbRadioButton.Checked ? "ESX to QB-Core" : "QB-Core to ESX";
            outputTextBox.Clear();
            outputTextBox.AppendText($"Starting conversion: {direction}\r\n");

            try
            {
                string[] files = Directory.GetFiles(folderPath, "*.lua", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    ProcessFile(file, direction);
                    outputTextBox.AppendText($"Processed: {file}\r\n");
                }
                outputTextBox.AppendText("Conversion successfully!");
            }
            catch (Exception ex)
            {
                outputTextBox.AppendText($"An error occurred: {ex.Message}");
            }
        }

        private void ProcessFile(string filePath, string direction)
        {
            string content = File.ReadAllText(filePath);

            // Convert the script based on the selected direction
            string convertedContent = ConvertScript(content, direction);

            // Overwrite the file only if changes were made
            if (content != convertedContent)
            {
                File.WriteAllText(filePath, convertedContent);
            }
        }

        private string ConvertScript(string script, string direction)
        {
            var patterns = LoadConversionPatterns();

            if (direction == "ESX to QB-Core")
            {
                foreach (var pattern in patterns)
                {
                    script = Regex.Replace(script, pattern.Item1, pattern.Item2);
                }
            }
            else if (direction == "QB-Core to ESX")
            {
                foreach (var pattern in patterns)
                {
                    script = Regex.Replace(script, pattern.Item2, pattern.Item1);
                }
            }
            script = ManualReplace(script, direction);

            return script;
        }

        private string ManualReplace(string script, string direction)
        {
            if (direction == "ESX to QB-Core")
            {
                script = script.Replace(
                    "ESX = exports['es_extended']:getSharedObject()",
                    "local QBCore = exports['qb-core']:GetCoreObject()"
                );
            }
            else if (direction == "QB-Core to ESX")
            {
                script = script.Replace(
                    "local QBCore = exports['qb-core']:GetCoreObject()",
                    "ESX = exports['es_extended']:getSharedObject()"
                );
            }
            return script;
        }

        private (string, string)[] LoadConversionPatterns()
        {
            return new (string, string)[]
            {
            //("ESX = exports['es_extended']:getSharedObject()", "local QBCore = exports['qb-core']:GetCoreObject()"),
            ("esx:onPlayerDeath", "hospital:server:SetDeathStatus"),
            ("esx:playerLoaded", "QBCore:Client:OnPlayerLoaded"),
            ("esx:showAdvancedNotification", "QBCore:Notify"),
            ("esx:showHelpNotification", "QBCore:Notify"),
            ("esx:showNotification", "QBCore:Notify"),
            ("ESX.GetPlayerData", "QBCore.Functions.GetPlayerData"),
            ("ESX.IsPlayerLoaded", "QBCore.Functions.GetPlayerData().citizenid ~= nil"),
            ("ESX.SetPlayerData", "QBCore:Player:SetPlayerData"),
            ("ESX.TriggerServerCallback", "QBCore.Functions.TriggerCallback"),
            ("ESX.Game.DeleteVehicle", "QBCore.Functions.DeleteVehicle"),
            ("ESX.Game.GetClosestPed", "QBCore.Functions.GetClosestPed"),
            ("ESX.Game.GetClosestPlayer", "QBCore.Functions.GetClosestPlayer"),
            ("ESX.Game.GetClosestVehicle", "QBCore.Functions.GetClosestVehicle"),
            ("ESX.Game.GetPlayers", "QBCore.Functions.GetPlayers"),
            ("ESX.Game.GetVehicles", "QBCore.Functions.GetVehicles"),
            ("ESX.Game.SetVehicleProperties", "QBCore.Functions.SetVehicleProperties"),
            ("ESX.Game.SpawnVehicle", "QBCore.Functions.SpawnVehicle"),
            ("ESX.Game.Utils.DrawText3D", "QBCore.Functions.DrawText3D"),
            ("ESX.GetPlayerFromId", "QBCore.Functions.GetPlayer"),
            ("ESX.GetPlayerFromIdentifier", "QBCore.Functions.GetPlayerByCitizenId"),
            ("ESX.GetPlayers", "QBCore.Functions.GetPlayers"),
            ("ESX.RegisterServerCallback", "QBCore.Functions.CreateCallback"),
            ("ESX.RegisterUsableItem", "QBCore.Functions.CreateUseableItem"),
            ("ESX.SavePlayer", "QBCore.Player.Save"),
            ("ESX.UseItem", "QBCore.Functions.UseItem"),
            ("xPlayer.removeWeaponComponent", "xPlayer.Functions.RemoveItem"),
            ("xPlayer.setAccountMoney", "xPlayer.Functions.SetMoney"),
            ("xPlayer.setInventoryItem", "xPlayer.Functions.AddItem"),
            ("xPlayer.setJob", "xPlayer.Functions.SetJob"),
            ("xPlayer.setMoney", "xPlayer.Functions.SetMoney"),
            ("xPlayer.showHelpNotification", "TriggerClientEvent('QBCore:Notify')"),
            ("xPlayer.showNotification", "TriggerClientEvent('QBCore:Notify')"),
            ("esx:getSharedObject", "QBCore:GetObject"),
            ("esx:setJob", "QBCore:Client:OnJobUpdate"),
            ("esx:onPlayerSpawn", "QBCore:Client:OnPlayerLoaded"),
            ("playerSpawned", "QBCore:Client:OnPlayerLoaded"),
            ("esx:addInventoryItem", "QBCore:Server:AddItem"),
            ("esx:removeInventoryItem", "QBCore:Server:RemoveItem"),
            ("esx:useItem", "QBCore:Server:UseItem"),
            ("ESX.Game.DeleteObject", "DeleteEntity"),
            ("ESX.Game.GetClosestObject", "GetClosestObjectOfType"),
            ("ESX.Game.GetPedMugshot", "RegisterPedheadshot"),
            ("ESX.Game.SpawnObject", "CreateObject"),
            ("ESX.Game.Teleport", "SetEntityCoords and SetEntityHeading"),
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
