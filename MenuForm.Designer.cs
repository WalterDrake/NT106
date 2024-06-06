using System.Windows.Forms;

namespace CaroSpeedRun
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.online_bt = new CaroSpeedRun.Addon_Custom_Button();
            this.offline_bt = new CaroSpeedRun.Addon_Custom_Button();
            this.setting_bt = new CaroSpeedRun.Addon_Custom_Button();
            this.about_bt = new CaroSpeedRun.Addon_Custom_Button();
            this.help_bt = new CaroSpeedRun.Addon_Custom_Button();
            this.SuspendLayout();
            // 
            // online_bt
            // 
            this.online_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.online_bt.BackColor = System.Drawing.Color.Transparent;
            this.online_bt.BackgroundColor = System.Drawing.Color.Transparent;
            this.online_bt.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.online_bt.BorderRadius = 0;
            this.online_bt.BorderSize = 0;
            this.online_bt.FlatAppearance.BorderSize = 0;
            this.online_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.online_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.online_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.online_bt.ForeColor = System.Drawing.Color.Transparent;
            this.online_bt.Location = new System.Drawing.Point(613, 423);
            this.online_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.online_bt.Name = "online_bt";
            this.online_bt.Size = new System.Drawing.Size(353, 102);
            this.online_bt.TabIndex = 0;
            this.online_bt.TextColor = System.Drawing.Color.Transparent;
            this.online_bt.UseVisualStyleBackColor = false;
            this.online_bt.Click += new System.EventHandler(this.online_bt_Click);
            // 
            // offline_bt
            // 
            this.offline_bt.BackColor = System.Drawing.Color.Transparent;
            this.offline_bt.BackgroundColor = System.Drawing.Color.Transparent;
            this.offline_bt.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.offline_bt.BorderRadius = 0;
            this.offline_bt.BorderSize = 0;
            this.offline_bt.FlatAppearance.BorderSize = 0;
            this.offline_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.offline_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.offline_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.offline_bt.ForeColor = System.Drawing.Color.White;
            this.offline_bt.Location = new System.Drawing.Point(635, 572);
            this.offline_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.offline_bt.Name = "offline_bt";
            this.offline_bt.Size = new System.Drawing.Size(304, 91);
            this.offline_bt.TabIndex = 1;
            this.offline_bt.TextColor = System.Drawing.Color.White;
            this.offline_bt.UseVisualStyleBackColor = false;
            this.offline_bt.Click += new System.EventHandler(this.offline_bt_Click);
            // 
            // setting_bt
            // 
            this.setting_bt.BackColor = System.Drawing.Color.Transparent;
            this.setting_bt.BackgroundColor = System.Drawing.Color.Transparent;
            this.setting_bt.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.setting_bt.BorderRadius = 0;
            this.setting_bt.BorderSize = 0;
            this.setting_bt.FlatAppearance.BorderSize = 0;
            this.setting_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.setting_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.setting_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting_bt.ForeColor = System.Drawing.Color.White;
            this.setting_bt.Location = new System.Drawing.Point(1284, 599);
            this.setting_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setting_bt.Name = "setting_bt";
            this.setting_bt.Size = new System.Drawing.Size(243, 44);
            this.setting_bt.TabIndex = 2;
            this.setting_bt.TextColor = System.Drawing.Color.White;
            this.setting_bt.UseVisualStyleBackColor = false;
            this.setting_bt.Click += new System.EventHandler(this.setting_bt_Click);
            // 
            // about_bt
            // 
            this.about_bt.BackColor = System.Drawing.Color.Transparent;
            this.about_bt.BackgroundColor = System.Drawing.Color.Transparent;
            this.about_bt.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.about_bt.BorderRadius = 0;
            this.about_bt.BorderSize = 0;
            this.about_bt.FlatAppearance.BorderSize = 0;
            this.about_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.about_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.about_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_bt.ForeColor = System.Drawing.Color.White;
            this.about_bt.Location = new System.Drawing.Point(1311, 662);
            this.about_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.about_bt.Name = "about_bt";
            this.about_bt.Size = new System.Drawing.Size(201, 43);
            this.about_bt.TabIndex = 3;
            this.about_bt.TextColor = System.Drawing.Color.White;
            this.about_bt.UseVisualStyleBackColor = false;
            this.about_bt.Click += new System.EventHandler(this.about_bt_Click);
            // 
            // help_bt
            // 
            this.help_bt.BackColor = System.Drawing.Color.Transparent;
            this.help_bt.BackgroundColor = System.Drawing.Color.Transparent;
            this.help_bt.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.help_bt.BorderRadius = 0;
            this.help_bt.BorderSize = 0;
            this.help_bt.FlatAppearance.BorderSize = 0;
            this.help_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.help_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.help_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_bt.ForeColor = System.Drawing.Color.White;
            this.help_bt.Location = new System.Drawing.Point(1339, 724);
            this.help_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.help_bt.Name = "help_bt";
            this.help_bt.Size = new System.Drawing.Size(133, 38);
            this.help_bt.TabIndex = 4;
            this.help_bt.TextColor = System.Drawing.Color.White;
            this.help_bt.UseVisualStyleBackColor = false;
            this.help_bt.Click += new System.EventHandler(this.help_bt_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1581, 800);
            this.Controls.Add(this.help_bt);
            this.Controls.Add(this.about_bt);
            this.Controls.Add(this.setting_bt);
            this.Controls.Add(this.offline_bt);
            this.Controls.Add(this.online_bt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caro Speedrun";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Addon_Custom_Button online_bt;
        private Addon_Custom_Button offline_bt;
        private Addon_Custom_Button setting_bt;
        private Addon_Custom_Button about_bt;
        private Addon_Custom_Button help_bt;
    }
}

