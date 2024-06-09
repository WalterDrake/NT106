using System;
using System.Drawing;
using System.Windows.Forms;

namespace CaroSpeedRun
{
    public class CustomMessageBox : Form
    {
        private Button button1;

        public CustomMessageBox(Image url)
        {
            // Đặt kích thước của form
            this.Size = new Size(402, 237);

            // Đặt hình nền và kiểu hiển thị hình nền
            this.BackgroundImage = url ;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Loại bỏ đường viền của form
            this.FormBorderStyle = FormBorderStyle.None;

            // Đặt form xuất hiện ở trung tâm màn hình
            this.StartPosition = FormStartPosition.CenterScreen;

            // Thêm button để đóng form
            Button closeButton = new Button();
            closeButton.Size = new Size(30, 30);
            closeButton.Location = new Point(361, 3);
            closeButton.Text = "X"; // Bạn có thể thay đổi văn bản của nút
            closeButton.Click += new EventHandler(CloseButton_Click);

            // Thêm button vào form
            this.Controls.Add(closeButton);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form khi nút được nhấn
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CustomMessageBox
            // 
            this.ClientSize = new System.Drawing.Size(402, 237);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageBox";
            this.ResumeLayout(false);

        }
    }
}
