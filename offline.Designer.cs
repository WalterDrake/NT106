namespace CaroSpeedRun
{
    partial class offline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(offline));
            this.btQuit = new CaroSpeedRun.Addon_Custom_Button();
            this.btAgain = new CaroSpeedRun.Addon_Custom_Button();
            this.pnTable = new CaroSpeedRun.Addon_Round_Panel();
            this.SuspendLayout();
            // 
            // btQuit
            // 
            this.btQuit.BackColor = System.Drawing.Color.Transparent;
            this.btQuit.BackgroundColor = System.Drawing.Color.Transparent;
            this.btQuit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btQuit.BorderRadius = 0;
            this.btQuit.BorderSize = 0;
            this.btQuit.FlatAppearance.BorderSize = 0;
            this.btQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuit.ForeColor = System.Drawing.Color.White;
            this.btQuit.Location = new System.Drawing.Point(1534, 3);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(204, 105);
            this.btQuit.TabIndex = 2;
            this.btQuit.TextColor = System.Drawing.Color.White;
            this.btQuit.UseVisualStyleBackColor = false;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // btAgain
            // 
            this.btAgain.BackColor = System.Drawing.Color.Transparent;
            this.btAgain.BackgroundColor = System.Drawing.Color.Transparent;
            this.btAgain.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btAgain.BorderRadius = 0;
            this.btAgain.BorderSize = 0;
            this.btAgain.FlatAppearance.BorderSize = 0;
            this.btAgain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btAgain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgain.ForeColor = System.Drawing.Color.White;
            this.btAgain.Location = new System.Drawing.Point(16, 3);
            this.btAgain.Name = "btAgain";
            this.btAgain.Size = new System.Drawing.Size(228, 105);
            this.btAgain.TabIndex = 1;
            this.btAgain.TextColor = System.Drawing.Color.White;
            this.btAgain.UseVisualStyleBackColor = false;
            this.btAgain.Click += new System.EventHandler(this.btAgain_Click);
            // 
            // pnTable
            // 
            this.pnTable.CornerRadius = 25;
            this.pnTable.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnTable.Location = new System.Drawing.Point(16, 298);
            this.pnTable.Name = "pnTable";
            this.pnTable.Size = new System.Drawing.Size(1722, 625);
            this.pnTable.TabIndex = 0;
            this.pnTable.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTable_Paint);
            // 
            // offline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1755, 940);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.btAgain);
            this.Controls.Add(this.pnTable);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "offline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.offline_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Addon_Round_Panel pnTable;
        private Addon_Custom_Button btAgain;
        private Addon_Custom_Button btQuit;
    }
}