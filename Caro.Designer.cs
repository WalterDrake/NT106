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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caro));
            this.label1 = new System.Windows.Forms.Label();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.tbNameClient = new System.Windows.Forms.TextBox();
            this.tbNameServer = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.Panel();
            this.customLabel4 = new CaroSpeedRun.CustomLabel();
            this.customLabel3 = new CaroSpeedRun.CustomLabel();
            this.customLabel2 = new CaroSpeedRun.CustomLabel();
            this.btShowPausePanel = new CaroSpeedRun.Addon_Custom_Button();
            this.btHost = new CaroSpeedRun.Addon_Custom_Button();
            this.btClient = new CaroSpeedRun.Addon_Custom_Button();
            this.addon_Round_Panel1 = new CaroSpeedRun.Addon_Round_Panel();
            this.cbbIP = new CaroSpeedRun.CustomComboBox();
            this.customLabel1 = new CaroSpeedRun.CustomLabel();
            this.lblCountdown = new CaroSpeedRun.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 7F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(348, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server IP address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.BackColor = System.Drawing.Color.Black;
            this.tbIPAddress.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Bold);
            this.tbIPAddress.ForeColor = System.Drawing.SystemColors.Window;
            this.tbIPAddress.Location = new System.Drawing.Point(227, 12);
            this.tbIPAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(213, 28);
            this.tbIPAddress.TabIndex = 3;
            // 
            // tbNameClient
            // 
            this.tbNameClient.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbNameClient.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tbNameClient.ForeColor = System.Drawing.SystemColors.Window;
            this.tbNameClient.Location = new System.Drawing.Point(92, 196);
            this.tbNameClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNameClient.Name = "tbNameClient";
            this.tbNameClient.Size = new System.Drawing.Size(197, 29);
            this.tbNameClient.TabIndex = 6;
            this.tbNameClient.TextChanged += new System.EventHandler(this.tbNameClient_TextChanged);
            // 
            // tbNameServer
            // 
            this.tbNameServer.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbNameServer.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tbNameServer.ForeColor = System.Drawing.SystemColors.Window;
            this.tbNameServer.Location = new System.Drawing.Point(92, 353);
            this.tbNameServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNameServer.Name = "tbNameServer";
            this.tbNameServer.Size = new System.Drawing.Size(197, 29);
            this.tbNameServer.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 101);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(483, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 65);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Controls.Add(this.customLabel4);
            this.menu.Controls.Add(this.customLabel3);
            this.menu.Controls.Add(this.customLabel2);
            this.menu.Location = new System.Drawing.Point(1284, 39);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(215, 304);
            this.menu.TabIndex = 12;
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.BackColor = System.Drawing.Color.Transparent;
            this.customLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.ForeColor = System.Drawing.Color.DarkOrange;
            this.customLabel4.Location = new System.Drawing.Point(65, 228);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(81, 31);
            this.customLabel4.TabIndex = 15;
            this.customLabel4.Text = "Thoát";
            this.customLabel4.Click += new System.EventHandler(this.customLabel4_Click);
            this.customLabel4.MouseLeave += new System.EventHandler(this.customLabel4_MouseLeave);
            this.customLabel4.MouseHover += new System.EventHandler(this.customLabel4_MouseHover);
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.BackColor = System.Drawing.Color.Transparent;
            this.customLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.ForeColor = System.Drawing.Color.DarkOrange;
            this.customLabel3.Location = new System.Drawing.Point(51, 51);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(133, 37);
            this.customLabel3.TabIndex = 14;
            this.customLabel3.Text = "Ván Mới";
            this.customLabel3.Click += new System.EventHandler(this.customLabel3_Click);
            this.customLabel3.MouseLeave += new System.EventHandler(this.customLabel3_MouseLeave);
            this.customLabel3.MouseHover += new System.EventHandler(this.Back);
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.BackColor = System.Drawing.Color.Transparent;
            this.customLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.ForeColor = System.Drawing.Color.DarkOrange;
            this.customLabel2.Location = new System.Drawing.Point(64, 136);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(95, 37);
            this.customLabel2.TabIndex = 13;
            this.customLabel2.Text = "Đi Lại";
            this.customLabel2.Click += new System.EventHandler(this.customLabel2_Click);
            this.customLabel2.MouseLeave += new System.EventHandler(this.customLabel2_MouseLeave);
            this.customLabel2.MouseHover += new System.EventHandler(this.customLabel2_MouseHover);
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
            this.btShowPausePanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btShowPausePanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btShowPausePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowPausePanel.ForeColor = System.Drawing.SystemColors.Window;
            this.btShowPausePanel.Location = new System.Drawing.Point(1468, 0);
            this.btShowPausePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btShowPausePanel.Name = "btShowPausePanel";
            this.btShowPausePanel.Size = new System.Drawing.Size(91, 71);
            this.btShowPausePanel.TabIndex = 9;
            this.btShowPausePanel.TextColor = System.Drawing.SystemColors.Window;
            this.btShowPausePanel.UseVisualStyleBackColor = false;
            this.btShowPausePanel.Click += new System.EventHandler(this.btShowPausePanel_Click);
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
            this.btHost.Location = new System.Drawing.Point(31, 633);
            this.btHost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHost.Name = "btHost";
            this.btHost.Size = new System.Drawing.Size(487, 84);
            this.btHost.TabIndex = 8;
            this.btHost.TextColor = System.Drawing.SystemColors.Window;
            this.btHost.UseVisualStyleBackColor = false;
            this.btHost.Click += new System.EventHandler(this.btHost_Click);
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
            this.btClient.Location = new System.Drawing.Point(31, 537);
            this.btClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btClient.Name = "btClient";
            this.btClient.Size = new System.Drawing.Size(487, 74);
            this.btClient.TabIndex = 0;
            this.btClient.TextColor = System.Drawing.SystemColors.Window;
            this.btClient.UseVisualStyleBackColor = false;
            this.btClient.Click += new System.EventHandler(this.btClient_Click);
            // 
            // addon_Round_Panel1
            // 
            this.addon_Round_Panel1.BackColor = System.Drawing.Color.Transparent;
            this.addon_Round_Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addon_Round_Panel1.CornerRadius = 25;
            this.addon_Round_Panel1.Location = new System.Drawing.Point(583, 86);
            this.addon_Round_Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addon_Round_Panel1.Name = "addon_Round_Panel1";
            this.addon_Round_Panel1.Size = new System.Drawing.Size(900, 630);
            this.addon_Round_Panel1.TabIndex = 5;
            this.addon_Round_Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.addon_Round_Panel1_Paint);
            // 
            // cbbIP
            // 
            this.cbbIP.DropDownWidth = 283;
            this.cbbIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbIP.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbbIP.ForeColor = System.Drawing.Color.Ivory;
            this.cbbIP.FormattingEnabled = true;
            this.cbbIP.Location = new System.Drawing.Point(449, 12);
            this.cbbIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbIP.Name = "cbbIP";
            this.cbbIP.Size = new System.Drawing.Size(29, 29);
            this.cbbIP.TabIndex = 4;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.BackColor = System.Drawing.Color.Transparent;
            this.customLabel1.ForeColor = System.Drawing.Color.White;
            this.customLabel1.Location = new System.Drawing.Point(97, 71);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(76, 16);
            this.customLabel1.TabIndex = 1;
            this.customLabel1.Text = "MIN      SEC";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdown.ForeColor = System.Drawing.Color.White;
            this.lblCountdown.Location = new System.Drawing.Point(89, 28);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(31, 16);
            this.lblCountdown.TabIndex = 0;
            this.lblCountdown.Text = "1:00";
            // 
            // Caro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1540, 752);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
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
            this.Controls.Add(this.lblCountdown);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Caro";
            this.Text = "Caro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Caro_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Caro_FormClosed);
            this.Load += new System.EventHandler(this.Caro_Load);
            this.Shown += new System.EventHandler(this.Caro_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomLabel lblCountdown;
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel menu;
        private CustomLabel customLabel2;
        private CustomLabel customLabel3;
        private CustomLabel customLabel4;
    }
}