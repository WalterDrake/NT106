namespace CaroSpeedRun
{
    partial class Caro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caro));
            this.lbTimer = new CaroSpeedRun.CustomLabel();
            this.customLabel1 = new CaroSpeedRun.CustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.cbbIP = new CaroSpeedRun.CustomComboBox();
            this.addon_Round_Panel1 = new CaroSpeedRun.Addon_Round_Panel();
            this.tbNameClient = new System.Windows.Forms.TextBox();
            this.tbNameServer = new System.Windows.Forms.TextBox();
            this.btClient = new CaroSpeedRun.Addon_Custom_Button();
            this.btHost = new CaroSpeedRun.Addon_Custom_Button();
            this.btShowPausePanel = new CaroSpeedRun.Addon_Custom_Button();
            this.SuspendLayout();
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.BackColor = System.Drawing.Color.Transparent;
            this.lbTimer.ForeColor = System.Drawing.Color.White;
            this.lbTimer.Location = new System.Drawing.Point(100, 36);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(40, 20);
            this.lbTimer.TabIndex = 0;
            this.lbTimer.Text = "1:00";
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.BackColor = System.Drawing.Color.Transparent;
            this.customLabel1.ForeColor = System.Drawing.Color.White;
            this.customLabel1.Location = new System.Drawing.Point(109, 90);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(95, 20);
            this.customLabel1.TabIndex = 1;
            this.customLabel1.Text = "MIN      SEC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 7F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(391, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server IP address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.BackColor = System.Drawing.Color.Black;
            this.tbIPAddress.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Bold);
            this.tbIPAddress.ForeColor = System.Drawing.SystemColors.Window;
            this.tbIPAddress.Location = new System.Drawing.Point(259, 15);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(240, 32);
            this.tbIPAddress.TabIndex = 3;
            // 
            // cbbIP
            // 
            this.cbbIP.DropDownWidth = 283;
            this.cbbIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbIP.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbbIP.ForeColor = System.Drawing.Color.Ivory;
            this.cbbIP.FormattingEnabled = true;
            this.cbbIP.Location = new System.Drawing.Point(505, 15);
            this.cbbIP.Name = "cbbIP";
            this.cbbIP.Size = new System.Drawing.Size(32, 33);
            this.cbbIP.TabIndex = 4;
            // 
            // addon_Round_Panel1
            // 
            this.addon_Round_Panel1.BackColor = System.Drawing.Color.Transparent;
            this.addon_Round_Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addon_Round_Panel1.CornerRadius = 25;
            this.addon_Round_Panel1.Location = new System.Drawing.Point(655, 107);
            this.addon_Round_Panel1.Name = "addon_Round_Panel1";
            this.addon_Round_Panel1.Size = new System.Drawing.Size(1013, 788);
            this.addon_Round_Panel1.TabIndex = 5;
            // 
            // tbNameClient
            // 
            this.tbNameClient.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbNameClient.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tbNameClient.ForeColor = System.Drawing.SystemColors.Window;
            this.tbNameClient.Location = new System.Drawing.Point(104, 244);
            this.tbNameClient.Name = "tbNameClient";
            this.tbNameClient.Size = new System.Drawing.Size(221, 33);
            this.tbNameClient.TabIndex = 6;
            // 
            // tbNameServer
            // 
            this.tbNameServer.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbNameServer.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tbNameServer.ForeColor = System.Drawing.SystemColors.Window;
            this.tbNameServer.Location = new System.Drawing.Point(104, 442);
            this.tbNameServer.Name = "tbNameServer";
            this.tbNameServer.Size = new System.Drawing.Size(221, 33);
            this.tbNameServer.TabIndex = 7;
            // 
            // btClient
            // 
            this.btClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btClient.BackColor = System.Drawing.Color.Transparent;
            this.btClient.BackgroundColor = System.Drawing.Color.Transparent;
            this.btClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClient.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btClient.BorderRadius = 0;
            this.btClient.BorderSize = 0;
            this.btClient.FlatAppearance.BorderSize = 0;
            this.btClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClient.ForeColor = System.Drawing.SystemColors.Window;
            this.btClient.Location = new System.Drawing.Point(35, 652);
            this.btClient.Name = "btClient";
            this.btClient.Size = new System.Drawing.Size(547, 104);
            this.btClient.TabIndex = 0;
            this.btClient.TextColor = System.Drawing.SystemColors.Window;
            this.btClient.UseVisualStyleBackColor = false;
            // 
            // btHost
            // 
            this.btHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btHost.BackColor = System.Drawing.Color.Transparent;
            this.btHost.BackgroundColor = System.Drawing.Color.Transparent;
            this.btHost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btHost.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btHost.BorderRadius = 0;
            this.btHost.BorderSize = 0;
            this.btHost.FlatAppearance.BorderSize = 0;
            this.btHost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHost.ForeColor = System.Drawing.SystemColors.Window;
            this.btHost.Location = new System.Drawing.Point(35, 774);
            this.btHost.Name = "btHost";
            this.btHost.Size = new System.Drawing.Size(547, 104);
            this.btHost.TabIndex = 8;
            this.btHost.TextColor = System.Drawing.SystemColors.Window;
            this.btHost.UseVisualStyleBackColor = false;
            // 
            // btShowPausePanel
            // 
            this.btShowPausePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btShowPausePanel.BackColor = System.Drawing.Color.Transparent;
            this.btShowPausePanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.btShowPausePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btShowPausePanel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btShowPausePanel.BorderRadius = 0;
            this.btShowPausePanel.BorderSize = 0;
            this.btShowPausePanel.FlatAppearance.BorderSize = 0;
            this.btShowPausePanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btShowPausePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowPausePanel.ForeColor = System.Drawing.SystemColors.Window;
            this.btShowPausePanel.Location = new System.Drawing.Point(1583, 1);
            this.btShowPausePanel.Name = "btShowPausePanel";
            this.btShowPausePanel.Size = new System.Drawing.Size(102, 90);
            this.btShowPausePanel.TabIndex = 9;
            this.btShowPausePanel.TextColor = System.Drawing.SystemColors.Window;
            this.btShowPausePanel.UseVisualStyleBackColor = false;
            // 
            // Caro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1684, 917);
            this.Controls.Add(this.btShowPausePanel);
            this.Controls.Add(this.btHost);
            this.Controls.Add(this.btClient);
            this.Controls.Add(this.tbNameServer);
            this.Controls.Add(this.tbNameClient);
            this.Controls.Add(this.addon_Round_Panel1);
            this.Controls.Add(this.cbbIP);
            this.Controls.Add(this.tbIPAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.lbTimer);
            this.DoubleBuffered = true;
            this.Name = "Caro";
            this.Text = "Caro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomLabel lbTimer;
        private CustomLabel customLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIPAddress;
        private CustomComboBox cbbIP;
        private Addon_Round_Panel addon_Round_Panel1;
        private System.Windows.Forms.TextBox tbNameClient;
        private System.Windows.Forms.TextBox tbNameServer;
        private Addon_Custom_Button btClient;
        private Addon_Custom_Button btHost;
        private Addon_Custom_Button btShowPausePanel;
    }
}