
namespace QB_to_ESX_and_reverse
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.esxToQbRadioButton = new System.Windows.Forms.RadioButton();
            this.qbToEsxRadioButton = new System.Windows.Forms.RadioButton();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.folderPathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // esxToQbRadioButton
            // 
            this.esxToQbRadioButton.AutoSize = true;
            this.esxToQbRadioButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esxToQbRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.esxToQbRadioButton.Location = new System.Drawing.Point(66, 70);
            this.esxToQbRadioButton.Name = "esxToQbRadioButton";
            this.esxToQbRadioButton.Size = new System.Drawing.Size(124, 23);
            this.esxToQbRadioButton.TabIndex = 0;
            this.esxToQbRadioButton.TabStop = true;
            this.esxToQbRadioButton.Text = "ESX     to     QB";
            this.esxToQbRadioButton.UseVisualStyleBackColor = true;
            // 
            // qbToEsxRadioButton
            // 
            this.qbToEsxRadioButton.AutoSize = true;
            this.qbToEsxRadioButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Bold);
            this.qbToEsxRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.qbToEsxRadioButton.Location = new System.Drawing.Point(281, 72);
            this.qbToEsxRadioButton.Name = "qbToEsxRadioButton";
            this.qbToEsxRadioButton.Size = new System.Drawing.Size(124, 23);
            this.qbToEsxRadioButton.TabIndex = 1;
            this.qbToEsxRadioButton.TabStop = true;
            this.qbToEsxRadioButton.Text = "QB     to     ESX";
            this.qbToEsxRadioButton.UseVisualStyleBackColor = true;
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.outputTextBox.Enabled = false;
            this.outputTextBox.Location = new System.Drawing.Point(12, 133);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(437, 213);
            this.outputTextBox.TabIndex = 2;
            // 
            // folderPathTextBox
            // 
            this.folderPathTextBox.Enabled = false;
            this.folderPathTextBox.Location = new System.Drawing.Point(12, 44);
            this.folderPathTextBox.Name = "folderPathTextBox";
            this.folderPathTextBox.ReadOnly = true;
            this.folderPathTextBox.Size = new System.Drawing.Size(348, 20);
            this.folderPathTextBox.TabIndex = 3;
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browseButton.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(366, 41);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(83, 25);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "BROWSE";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.convertButton.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(12, 97);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(437, 23);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "CONVERT";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(426, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 31);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Impact", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "ESX - QB / QB - ESX  / Converter by HaterOnlineNoob";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(391, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "_";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(461, 358);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.folderPathTextBox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.qbToEsxRadioButton);
            this.Controls.Add(this.esxToQbRadioButton);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESX-QB Converter by HaterOnlineNoob";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton esxToQbRadioButton;
        private System.Windows.Forms.RadioButton qbToEsxRadioButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TextBox folderPathTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

