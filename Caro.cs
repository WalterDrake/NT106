using LAN_Caro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static CaroSpeedRun.Socketdata;


namespace CaroSpeedRun
{
    public partial class Caro : Form
    {
        #region Properties
        SocketManager socket;
        public Table tableManager;

        #endregion
        private TimeSpan timeLeft;
        // Thời gian đếm ngược (ví dụ: 1 phút)
        private TimeSpan initialTime;
        public static int SCALE100_BUTTON_SIZE = 26;
        public static int SQUARE_SIZE;
        public static int TABLE_WIDTH = 25;
        public static int TABLE_HEIGHT = 17;
        private int number;

        private string IPaddress = "";
        public Caro()
        {
            InitializeComponent();
            Graphics graphics = CreateGraphics();
            float dpiX = graphics.DpiX;
            SQUARE_SIZE = Convert.ToInt32(SCALE100_BUTTON_SIZE * (dpiX / 96));
            addon_Round_Panel1.Width = SQUARE_SIZE * (TABLE_WIDTH - 1);
            addon_Round_Panel1.Height = SQUARE_SIZE * (TABLE_HEIGHT - 1) + SQUARE_SIZE;
            PlayerMarked += ChessBoard_PlayerMarker;
            EndedGame += ChessBoard_EndedGame;
            socket = new SocketManager();
            Changeplayer();
            graphics.Dispose();
            timer1.Tick += Timer1_Tick;

            // Đặt thời gian ban đầu (ví dụ: 1 phút)
            initialTime = TimeSpan.FromMinutes(1);
            // Đặt thời gian đếm ngược bằng thời gian ban đầu
            timeLeft = initialTime;

            // Hiển thị thời gian ban đầu
            lblCountdown.Text = timeLeft.ToString("mm\\:ss");
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Giảm thời gian còn lại mỗi giây
            if (timeLeft.TotalSeconds > 0)
            {
                timeLeft = timeLeft.Subtract(TimeSpan.FromSeconds(1));
                // Cập nhật hiển thị thời gian
                lblCountdown.Text = timeLeft.ToString("mm\\:ss");
            }
            else
            {
                // Hết thời gian, dừng Timer
                timer1.Stop();
                MessageBox.Show("Time's up!");
            }
        }
        private void ResetTimer()
        {
            // Dừng Timer
            timer1.Stop();
            // Đặt thời gian đếm ngược về thời gian ban đầu
            timeLeft = initialTime;
            // Cập nhật hiển thị thời gian
            lblCountdown.Text = timeLeft.ToString("mm\\:ss");
        }

        private void StartTimer()
        {
            // Bắt đầu Timer
            timer1.Start();
        }

        void ChessBoard_PlayerMarker(object sender, ButtonClickEvent e)
        {
            addon_Round_Panel1.Enabled = false;
            socket.Send(new SocketData((int)SocketComand.SEND_POINT, "", e.ClickedPoint));
            customLabel2.Enabled = false;
            listen();
        }

        void ketthuc()
        {
            addon_Round_Panel1.Enabled = false;
        }
        void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            ketthuc();
           
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool isPanelVisible = false;
        private void Caro_Load(object sender, EventArgs e)
        {
            menu.Visible = false;
            
            InitializeBoard();
        }
        private void InitializeBoard()
        {
            playtimeline = new Stack<Point>();

            addon_Round_Panel1.Enabled = false;
            addon_Round_Panel1.Controls.Clear();

            buttonList = new List<List<Button>>();
            Button oldbutton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < TABLE_HEIGHT; i++)
            {
                buttonList.Add(new List<Button>());
                for (int j = 0; j < TABLE_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        BackColor = Color.Black,
                        FlatStyle = FlatStyle.Flat,
                        Height = SQUARE_SIZE,
                        Width = SQUARE_SIZE,
                        Tag = i.ToString(),
                        Location = new Point(oldbutton.Location.X + oldbutton.Width, oldbutton.Location.Y),
                        Name = "bt" + j + "_" + i,
                    };
                    btn.FlatAppearance.BorderColor = Color.Gainsboro;
                    btn.Parent = addon_Round_Panel1;
                    btn.BackColor = Color.Black;
                    btn.Click += Btn_Click;
                    addon_Round_Panel1.Controls.Add(btn);
                    buttonList[i].Add(btn);
                    oldbutton = btn;
                }
                oldbutton.Location = new Point(0, oldbutton.Location.Y + SQUARE_SIZE);
                oldbutton.Height = 0;
                oldbutton.Width = 0;
            }
        }


        private int now = 0;

        private List<Player> Players = new List<Player>()
        {
            new Player("server", Properties.Resources.x, Properties.Resources.x),
                new Player("client", Properties.Resources.o, Properties.Resources.o),
        };
        private void Btn_Click(object sender, EventArgs e)
        {
           
            Button btn = sender as Button;
            int index = btn.Name.IndexOf("_");
            int x = Int32.Parse(btn.Name.Substring(2, index - 2));
            int y = Int32.Parse(btn.Name.Substring(index + 1));
            if (buttonList[y][x].Image != null)
                return;
            buttonList[y][x].Image = Players[now].Image;
            now = now == 0 ? 1 : 0;
            Changeplayer();
            if (playerMarked != null)
                playerMarked(this, new ButtonClickEvent(Getchesspoint(btn)));
            if (isEndGame(btn))
            {
                socket.Send(new SocketData((int)SocketComand.END_GAME_LOSS, "", new Point()));

                // Hiển thị thông báo thắng sau khi gửi thông điệp
                CustomMessageBox message2 = new CustomMessageBox("You Win!", Color.Green);
                message2.ShowDialog();

            }

            playtimeline.Push(Getchesspoint(btn));

        }
        private void Changeplayer()
        {
            // textBox1.Text = Players[now].Name;
            pictureBox1.Image = Players[now].Image;
        }
        public List<List<Button>> buttonList = new List<List<Button>>();
        private void EndGame()
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());

        }
        private bool isEndGame(Button btn)
        {
            int index = btn.Name.IndexOf("_");
            int x = Int32.Parse(btn.Name.Substring(2, index - 2));
            int y = Int32.Parse(btn.Name.Substring(index + 1));
            return isEndGamengang(x, y) || isEndGamedoc(x, y) || isEndGamecheochinh(x, y) || isEndGamesub(x, y);
        }
        private Point Getchesspoint(Button btn)
        {
            int doc = Convert.ToInt32(btn.Tag);
            int ngang = buttonList[doc].IndexOf(btn);
            Point point = new Point(ngang, doc);
            return point;
        }
        private bool isEndGamengang(int x, int y)
        {
            Image thisButtonImage = buttonList[y][x].Image;
            int count = 0;
            for (int i = x - 1; i >= 0; i--)
            {
                if (buttonList[y][i].Image == thisButtonImage)
                    count++;
                else
                    break;
            }

            for (int i = x + 1; i < TABLE_WIDTH; i++)
            {
                if (buttonList[y][i].Image == thisButtonImage)
                    count++;
                else
                    break;
            }

            if (count >= 4)
            {
                for (int i = x - 1; i >= 0; i--)
                {
                    if (buttonList[y][i].Image == thisButtonImage)
                        buttonList[y][i].BackColor = Color.Black;
                    else
                        break;
                }

                for (int i = x + 1; i < TABLE_WIDTH; i++)
                {
                    if (buttonList[y][i].Image == thisButtonImage)
                        buttonList[y][i].BackColor = Color.Black;
                    else
                        break;
                }
                buttonList[y][x].BackColor = Color.Black;
                return true;
            }
            return false;
        }
        private bool isEndGamedoc(int x, int y)
        {
            Image thisButtonImage = buttonList[y][x].Image;
            int count = 0;
            for (int i = y - 1; i >= 0; i--)
            {
                if (buttonList[i][x].Image == thisButtonImage)
                    count++;
                else
                    break;
            }
            for (int i = y + 1; i < TABLE_HEIGHT; i++)
            {
                if (buttonList[i][x].Image == thisButtonImage)
                    count++;
                else
                    break;
            }
            if (count >= 4)
            {
                for (int i = y - 1; i >= 0; i--)
                {
                    if (buttonList[i][x].Image == thisButtonImage)
                        buttonList[i][x].BackColor = Color.Black;
                    else
                        break;
                }
                for (int i = y + 1; i < TABLE_HEIGHT; i++)
                {
                    if (buttonList[i][x].Image == thisButtonImage)
                        buttonList[i][x].BackColor = Color.Black;
                    else
                        break;
                }
                buttonList[y][x].BackColor = Color.Black;
                return true;
            }

            return false;
        }
        private bool isEndGamecheochinh(int x, int y)
        {

            Image thisButtonImage = buttonList[y][x].Image;
            int count = 0;
            for (int i = x - 1, j = y - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (buttonList[j][i].Image == thisButtonImage)
                    count++;
                else break;
            }
            for (int i = x + 1, j = y + 1; i < TABLE_WIDTH && j < TABLE_HEIGHT; i++, j++)
            {
                if (buttonList[j][i].Image == thisButtonImage)
                    count++;
                else break;
            }

            if (count >= 4)
            {
                for (int i = x - 1, j = y - 1; i >= 0 && j >= 0; i--, j--)
                {
                    if (buttonList[j][i].Image == thisButtonImage)
                        buttonList[j][i].BackColor = Color.Black;
                    else break;
                }
                for (int i = x + 1, j = y + 1; i < TABLE_WIDTH && j < TABLE_HEIGHT; i++, j++)
                {
                    if (buttonList[j][i].Image == thisButtonImage)
                        buttonList[j][i].BackColor = Color.Black;
                    else break;
                }
                buttonList[y][x].BackColor = Color.Black;
                return true;
            }
            return false;


        }
        private bool isEndGamesub(int x, int y)
        {
            Image thisButtonImage = buttonList[y][x].Image;
            int count = 0;
            for (int i = x - 1, j = y + 1; i >= 0 && j < TABLE_HEIGHT; i--, j++)
            {
                if (buttonList[j][i].Image == thisButtonImage)
                    count++;
                else
                    break;
            }
            for (int i = x + 1, j = y - 1; i < TABLE_WIDTH && j >= 0; i++, j--)
            {
                if (buttonList[j][i].Image == thisButtonImage)
                    count++;
                else
                    break;
            }
            if (count >= 4)
            {
                for (int i = x - 1, j = y + 1; i >= 0 && j < TABLE_HEIGHT; i--, j++)
                {
                    if (buttonList[j][i].Image == thisButtonImage)
                        buttonList[j][i].BackColor = Color.Black;
                    else
                        break;
                }
                for (int i = x + 1, j = y - 1; i < TABLE_WIDTH && j >= 0; i++, j--)
                {
                    if (buttonList[j][i].Image == thisButtonImage)
                        buttonList[j][i].BackColor = Color.Black;
                    else
                        break;
                }
                buttonList[y][x].BackColor = Color.Black;
                return true;
            }
            return false;
        }
        private Stack<Point> playtimeline;
        private event EventHandler<ButtonClickEvent> playerMarked;
        public event EventHandler<ButtonClickEvent> PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }
        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }
        void listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();
                    ProcessData(data);
                }
                catch (Exception)
                {

                    throw;
                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
        }
        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketComand.NOTIFY:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketComand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        now = 0;
                        // textBox1.Text = Players[now].Name;
                        pictureBox1.Image = Players[now].Image;
                        InitializeBoard();

                        addon_Round_Panel1.Enabled = false;
                    }));

                    break;
                case (int)SocketComand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        addon_Round_Panel1.Enabled = true;
                        customLabel2.Enabled = true;
                        OtherMark(data.Point);
                    }));
                    break;
                case (int)SocketComand.UNDO:
                     undo();
                    break;
                case (int)SocketComand.END_GAME_LOSS:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        CustomMessageBox message1 = new CustomMessageBox("Game Over! You loss!", Color.BlueViolet);
                        message1.ShowDialog();
                    }));
                    break;

                case (int)SocketComand.QUIT:
                    MessageBox.Show("người chơi đã rời đi");
                    break;
                case (int)SocketComand.CONNECT_SUCCESS:
                    MessageBox.Show("đôi thủ của bạn đã vào phòng");
                    break;

            }
            listen();
        }
        public void OtherMark(Point point)
        {

            Button btn = buttonList[point.Y][point.X];
            if (btn.Image!=null) return;

            btn.Image = Players[now].Image;
            now = now == 0 ? 1 : 0;
            Changeplayer();
            if (isEndGame(btn))
            {
                EndGame();
            }
            playtimeline.Push(Getchesspoint(btn));
        }


        private void btHost_Click(object sender, EventArgs e)
        {
            btHost.Enabled = false;
            btClient.Enabled = false;
            // tbIPAddress.Text = tbNameClient.Text.ToString();
            // socket.IP = tbNameClient.Text;
            // tbNameServer.Text = tbNameClient.Text.ToString();
            tbIPAddress.Text = IPaddress.ToString();
            socket.IP = IPaddress;
            tbNameServer.Text = IPaddress.ToString();
            if (!socket.ConnectSever())
            {

                socket.isServer = true;
                addon_Round_Panel1.Enabled = true;
                socket.CreateServer();
            }
            else
            {
                socket.isServer = false;
                addon_Round_Panel1.Enabled = false;
              
                listen();
            }

        }
        private void Caro_Shown(object sender, EventArgs e)
        {
            IPaddress = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
           /* tbNameClient.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);*/
           /* if (string.IsNullOrEmpty(tbNameClient.Text))
            {
                tbNameClient.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }*/
            if (String.IsNullOrEmpty(IPaddress))
            {
                IPaddress = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }
        private void tbNameClient_TextChanged(object sender, EventArgs e)
        {
        }
        private void btClient_Click(object sender, EventArgs e)
        {
            /*if (string.IsNullOrEmpty(tbNameServer.Text))
            {
                MessageBox.Show("Bạn chưa điền server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/
            if (string.IsNullOrEmpty(tbIPAddress.Text))
            {
                MessageBox.Show("Bạn chưa điền server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            btClient.Enabled = false;
            btHost.Enabled = false;

            // socket.IP = tbNameServer.Text;
            socket.IP = IPaddress;
            if (!socket.ConnectSever())
            {

                socket.isServer = true;
                addon_Round_Panel1.Enabled = true;
                socket.CreateServer();
            }
            else
            {
                socket.isServer = false;
                addon_Round_Panel1.Enabled = false;  
                listen();
                     
            }
        }

        private void btShowPausePanel_Click(object sender, EventArgs e)
        {
            if (isPanelVisible)
            {
                // Ẩn Panel
               menu.Visible = false;
                isPanelVisible = false;
            }
            else
            {
                // Hiển thị Panel
                menu.Visible = true;
                isPanelVisible = true;
            }
        }

        private void Back(object sender, EventArgs e)
        {
            customLabel3.BackColor = Color.White;
        }

        private void customLabel3_MouseLeave(object sender, EventArgs e)
        {
            customLabel3.BackColor = Color.Transparent;

        }

        private void customLabel2_MouseHover(object sender, EventArgs e)
        {
            customLabel2.BackColor = Color.White;
        }

        private void customLabel2_MouseLeave(object sender, EventArgs e)
        {
            customLabel2.BackColor = Color.Transparent;
        }

        private void customLabel4_MouseHover(object sender, EventArgs e)
        {
            customLabel4.BackColor = Color.White;
        }

        private void customLabel4_MouseLeave(object sender, EventArgs e)
        {
            customLabel4.BackColor = Color.Transparent;
        }

        private void customLabel2_Click(object sender, EventArgs e)
        {
            undo();
            socket.Send(new SocketData((int)SocketComand.UNDO, "", new Point()));
            
        }
        public bool undo()
        {

            return UNdostep() && UNdostep();

        }
        private bool UNdostep()
        {
            if (playtimeline.Count <= 0) return false;
            Point oldPoint = playtimeline.Pop();
            Button button = buttonList[oldPoint.Y][oldPoint.X];
            button.Image = null;

            if (playtimeline.Count <= 0)
            {
                now = 0;
            }
            else
            {
                oldPoint = playtimeline.Peek();

            }
            Changeplayer();
            return true;
        }

        private void customLabel3_Click(object sender, EventArgs e)
        {
            now = 0;
            // textBox1.Text = Players[0].Name;
            pictureBox1.Image = Players[0].Image;
            customLabel2.Enabled = true; // di lai
            InitializeBoard();
            socket.Send(new SocketData((int)SocketComand.NEW_GAME, "", new Point()));
            addon_Round_Panel1.Enabled = true;
        }

        private void customLabel4_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void Caro_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                    try
                    {
                        socket.Send(new SocketData((int)SocketComand.QUIT, "", new Point()));
                    }
                    catch (Exception)
                    {                    
                        MessageBox.Show("Hẹn gặp lại.", "thông báo", MessageBoxButtons.OK);              
                    }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void addon_Round_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Caro_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
    public class ButtonClickEvent : EventArgs
    {
        private Point clickedPoint;

        public ButtonClickEvent(Point point)
        {
            this.ClickedPoint = point;
        }
        public Point ClickedPoint { get => clickedPoint; set => clickedPoint = value; }
    }
}
