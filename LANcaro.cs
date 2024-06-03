
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CaroSpeedRun.Socketdata;

namespace CaroSpeedRun
{
    public partial class LANcaro : Form
    {
        #region Properties
        SocketManager socket;
       

        #endregion
        public LANcaro()
        {
            InitializeComponent();
            Graphics graphics = CreateGraphics();
            float dpiX = graphics.DpiX;
            SQUARE_SIZE = Convert.ToInt32(SCALE100_BUTTON_SIZE * (dpiX / 96));  
            tablechess.Width = SQUARE_SIZE * (TABLE_WIDTH - 1);
            tablechess.Height = SQUARE_SIZE * (TABLE_HEIGHT - 1) + SQUARE_SIZE;
            PlayerMarked += ChessBoard_PlayerMarker;
            EndedGame += ChessBoard_EndedGame; 
            socket = new SocketManager();
            Changeplayer();
            graphics.Dispose();
        }
        void ChessBoard_PlayerMarker(object sender, ButtonClickEvent e)
        {

            tablechess.Enabled = false;
            socket.Send(new SocketData((int)SocketComand.SEND_POINT, "", e.ClickedPoint));
            button2.Enabled = false;
            listen();
        }
        void ketthuc()
        {

           
            tablechess.Enabled = false;
           

        }
        void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            ketthuc();
            socket.Send(new SocketData((int)SocketComand.END_GAME_LOSS, "", new Point()));
        }

        public static int SCALE100_BUTTON_SIZE = 26;
        public static int SQUARE_SIZE;
        public static int TABLE_WIDTH = 25;
        public static int TABLE_HEIGHT = 17;      
        private int number;
        //ve ban co
        private void InitializeBoard()
        {
            playtimeline = new Stack<Point>();

            tablechess.Enabled = true;
            tablechess.Controls.Clear();

            buttonList = new List<List<Button>>();
            Button oldbutton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < TABLE_HEIGHT; i++)
            {
                buttonList.Add(new List<Button>());
                for (int j = 0; j < TABLE_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        BackColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Height = SQUARE_SIZE,
                        Width = SQUARE_SIZE,
                        Tag = i.ToString(),
                        Location = new Point(oldbutton.Location.X + oldbutton.Width, oldbutton.Location.Y),
                        Name = "bt" + j + "_" + i,
                    };
                    btn.FlatAppearance.BorderColor = Color.Gainsboro;
                    btn.Parent = tablechess;
                    btn.BackColor = Color.White;
                    btn.Click += Btn_Click;
                    tablechess.Controls.Add(btn);
                    buttonList[i].Add(btn);
                    oldbutton = btn;
                }
                oldbutton.Location = new Point(0, oldbutton.Location.Y + SQUARE_SIZE);
                oldbutton.Height = 0;
                oldbutton.Width = 0;
            }
        }
        private void LANcaro_Load(object sender, EventArgs e)    
        {
            InitializeBoard();
        }
        //end
        //event button click thay doi mau - doi nguoi choi
        private int now = 0;
        private List<Player> Players = new List<Player>()
        {
            new Player("Player 1", Color.Blue),
            new Player("Player 2", Color.Black),
        };
     
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor != Color.White) return;
            btn.BackColor = Players[now].Color;
            now = now == 0 ? 1 : 0;
            Changeplayer();
            if (playerMarked != null)
                playerMarked(this, new ButtonClickEvent(Getchesspoint(btn)));
            if (isEndGame(btn))
            {

                CustomMessageBox message = new CustomMessageBox("You win!", Color.Green);
                message.ShowDialog();
            }

            playtimeline.Push(Getchesspoint(btn));

        }
        private void Changeplayer()
        {
            textBox1.Text = Players[now].Name;
            label3.BackColor = Players[now].Color;
        }
        // end 
        // xử lí thắng thua 
        public List<List<Button>> buttonList = new List<List<Button>>();
        private void EndGame()
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());

        }
        private bool isEndGame(Button btn)
        {
            return isEndGamengang(btn) || isEndGamedoc(btn) || isEndGamecheochinh(btn) || isEndGamesub(btn);
        }
        private Point Getchesspoint(Button btn)
        {
           
            int doc = Convert.ToInt32(btn.Tag);
            int ngang =buttonList[doc].IndexOf(btn);
            Point point = new Point(ngang,doc);
            return point;
        }
        private bool isEndGamengang(Button btn)
        { 
            Point point = Getchesspoint(btn);
            int countleft= 0;
           
            for(int i = point.X;i>=0;i--)
            {
                if (buttonList[point.Y][i].BackColor == btn.BackColor)
                {
                    countleft++;
                }
                else break;

            }
            int countright = 0;
            for (int i = point.X +1; i < TABLE_WIDTH; i++)
            {
                if (buttonList[point.Y][i].BackColor == btn.BackColor)
                {
                    countright++;
                }
                else break;

            }
            return countleft + countright == 5;
        }
        private bool isEndGamedoc(Button btn)
        {
            Point point = Getchesspoint(btn);
            int countleft = 0;

            for (int i = point.Y; i >= 0; i--)
            {
                if (buttonList[i][point.X].BackColor == btn.BackColor)
                {
                    countleft++;
                }
                else break;

            }
            int countright = 0;
            for (int i = point.Y + 1; i < TABLE_HEIGHT; i++)
            {
                if (buttonList[i][point.X].BackColor == btn.BackColor)
                {
                    countright++;
                }
                else break;

            }
            return countleft + countright == 5;
        }
        private bool isEndGamecheochinh(Button btn)
        {
           
                Point point = Getchesspoint(btn);
                int countTop = 0;
                for (int i = 0; i <= point.X; i++)
                {
                    if (point.Y - i < 0 || point.X - i < 0)
                        break;
                    if (buttonList[point.Y - i][point.X - i].BackColor == btn.BackColor)
                        countTop++;
                    else break;
                }

                int countBottom = 0;
                for (int i = 1; i <= TABLE_WIDTH - point.X; i++)
                {
                    if (point.Y + i >= TABLE_HEIGHT || point.X + i >= TABLE_WIDTH)
                        break;
                    if (buttonList[point.Y + i][point.X + i].BackColor == btn.BackColor)
                        countBottom++;
                    else break;
                }
                return countBottom + countTop == 5;
            

        }
        private bool isEndGamesub(Button btn)
        {
            Point point = Getchesspoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i >TABLE_WIDTH || point.Y - i < 0)
                    break;
                if (buttonList[point.Y - i][point.X + i].BackColor == btn.BackColor)
                    countTop++;
                else break;
            }

            int countBottom = 0;
            for (int i = 1; i <= TABLE_WIDTH - point.X; i++)
            {
                if (point.Y + i >= TABLE_HEIGHT || point.X - i <0)
                    break;
                if (buttonList[point.Y + i][point.X - i].BackColor == btn.BackColor)
                    countBottom++;
                else break;
            }
            return countBottom + countTop == 5;
        }
        //end
        //new game 
        private void button1_Click(object sender, EventArgs e) // newgame
        {
            now = 0;
            textBox1.Text = Players[0].Name;
            label3.BackColor = Players[0].Color;
            button2.Enabled = true; // di lai
            InitializeBoard(); 
            socket.Send(new SocketData((int)SocketComand.NEW_GAME, "", new Point()));
            tablechess.Enabled = true;
        }
        //end
        //đi lại
        public bool undo()
        {
             
            return UNdostep() && UNdostep();
            
        }
        private Stack<Point> playtimeline;
        private void button2_Click(object sender, EventArgs e)
        {
            undo();
            socket.Send(new SocketData((int)SocketComand.UNDO, "", new Point()));
        } //di lai
          // event
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

        //end

        //kết nối với sever 
        private bool UNdostep()
        {
            if (playtimeline.Count <= 0) return false;
            Point oldPoint = playtimeline.Pop();
            Button button = buttonList[oldPoint.Y][oldPoint.X];
            button.BackColor = Color.White;

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
        private void Play_Click(object sender, EventArgs e)
        {
            socket.IP = server.Text;
            if (!socket.ConnectSever())
            {
                
                socket.isServer = true;
                tablechess.Enabled = true;
                socket.CreateServer();
              
                
            }
            else
            {
                
                socket.isServer = false;

                tablechess.Enabled = false;

                
                listen();
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
                        textBox1.Text = Players[now].Name;
                        label3.BackColor = Players[now].Color;
                        InitializeBoard();

                        tablechess.Enabled=false;
                    }));

                    break;
                case (int)SocketComand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        
                        tablechess.Enabled = true;

                        button2.Enabled = true;
                        OtherMark(data.Point);
                    }));
                    break;
                case (int)SocketComand.UNDO:
                    undo();
                  
                    
                    break;
                case (int)SocketComand.END_GAME_WIN:
                    
                    CustomMessageBox message = new CustomMessageBox("You Win!", Color.Green);
                    message.ShowDialog();
                    break;
                case (int)SocketComand.END_GAME_LOSS:
                   
                    CustomMessageBox message1 = new CustomMessageBox("Game Over! You loss!", Color.BlueViolet);
                    message1.ShowDialog();
                    break;
                
                case (int)SocketComand.QUIT:
                   
                    MessageBox.Show("người chơi đã rời đi");
                    break;
                case (int)SocketComand.CONNECT_SUCCESS:
                    
                    break;

            }
            listen();
        }
        private void LANcaro_Shown(object sender, EventArgs e)
        {
            server.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if (string.IsNullOrEmpty(server.Text))
            {
                server.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }
        //end  

        public void OtherMark(Point point)
        {
          
            Button btn = buttonList[point.Y][point.X];
            if (btn.BackColor != Color.White) return;
            
            btn.BackColor = Players[now].Color;
            now = now == 0 ? 1 : 0;
            Changeplayer();
            if (isEndGame(btn))
            {
                EndGame();
            }
            playtimeline.Push(Getchesspoint(btn));
        }

        private void LANcaro_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to exit the game ?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
            else
            {
                try
                {
                    socket.Send(new SocketData((int)SocketComand.QUIT, "", new Point()));
                }
                catch (Exception)
                {
                    throw;
                }
            }
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