﻿using CaroSpeedRun;
using CaroSpeedRun.Properties;
using System.Collections.Generic;
using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LAN_Caro
{
    public abstract class Player_OBJ
    {
        public NetworkStream netStream;
        public Table tableManager;
        public abstract void ReceiveMessage(Socket tcpClient_Client);
        public abstract void messageSend(string dataS);
        public abstract void ready();


        public void btReadyHide()
        {
            // Check if the button control exists and is accessible from this thread
            if (tableManager.btReady.InvokeRequired)
            {
                // Use marshaling to invoke the DisableButton method on the thread that created the button
                tableManager.btReady.Invoke(new Action(btReadyHide));
            }
            else
            {
                // Disable the button
                tableManager.btReady.Visible = false;
            }
        }

    }



    #region Client
    public class Client_OBJ : Player_OBJ
    {
        TcpClient tcpClient = new TcpClient();
        public Client_OBJ(Table table, string ipAddress)
        {
            try
            {
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), 8082);
                tcpClient.Connect(ipEndPoint);
                netStream = tcpClient.GetStream();
                tableManager = table;
                tableManager.rtbLog.Text += tableManager.tbIPAdress.Text + ":8082\nConnected!\n";
                Task.Run(() =>
                {
                    ReceiveMessage(tcpClient.Client);
                });
                messageSend("//" + tableManager.tbClientName.Text);
            }
            catch
            {
                tableManager.rtbLog.Text += "Error, Server not found!\n";
                return;
            }
        }

        ~Client_OBJ()
        {
            tcpClient.Close();
            netStream.Close();
        }


        public override void ReceiveMessage(Socket tcpClient_Client)
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];
            while (tcpClient_Client.Connected)
            {
                string Chr;
                string temp = "";
                while (true)
                {

                    bytesReceived = tcpClient_Client.Receive(recv);
                    Chr = Encoding.UTF8.GetString(recv);
                    if (Chr == "\n")
                        break;
                    temp += Chr;

                }
                tableManager.rtbLog.Text += "Receive: " + temp + "\n";
                switch (temp)
                {
                    case string s when s.StartsWith("//"):
                        tableManager.tbServerName.Text = s.Substring(2);
                        break;
                    case "Switch":
                        tableManager.SwitchPlayer();
                        break;
                    case string s when s.StartsWith("Restart"):
                        string[] partsRestart = temp.Split('_');
                        tableManager.Restart(int.Parse(partsRestart[1]));
                        break;
                    case "Play":
                        btReadyHide();
                        Task.Run(() =>
                        {
                            tableManager.caro1.Invoke(new Action(() =>
                            {
                                // Cập nhật giao diện người dùng trên thread chính
                                //tableManager.ptbPlay.Size = new Size(1480, 788);
                                tableManager.ptbPlay.Dock = DockStyle.Fill;
                                tableManager.ptbPlay.Location = new Point(0, 0);
                                tableManager.ptbPlay.Visible = true;
                            }));
                            Thread.Sleep(2000); //Sau khi hết animation thì chuyền sang ảnh menu để tránh việc các button phải load lại
                            tableManager.caro1.Invoke(new Action(() =>
                            {
                                tableManager.ptbPlay.Image = CaroSpeedRun.Properties.Resources.game;
                            }));
                            Thread.Sleep(1);
                            tableManager.caro1.Invoke(new Action(() =>
                            {
                                tableManager.ptbPlay.Visible = false;
                            }));
                        });

                        break;
                    case "Lose":
                        tableManager.YouWin();
                        break;
                    case "Pause":
                        tableManager.StopTimer();
                        tableManager.caro1.Invoke(new Action(() =>
                        {
                            // Cập nhật giao diện người dùng trên thread chính
                         //   tableManager.caro1.ShowPausePanel_Click(null, null);

                        }));
                        break;
                    case "Resume":
                        tableManager.caro1.Invoke(new Action(() =>
                        {
                            // Cập nhật giao diện người dùng trên thread chính
                          //  tableManager.caro1.ShowPausePanel_Click(null, null);
                            if (tableManager.isClientPlayer == tableManager.isClientTurn)
                            {
                                tableManager.StartTimer();
                            }
                        }));
                        break;
                    case "Leave":
                        DialogResult dg = MessageBox.Show("Server disconnected, leave match?", "Disconected", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        //if (dg == DialogResult.Yes)
                          //  tableManager.caro1.lbLeaveMatch_Click(null, null);
                        break;
                    default:
                        //tableManager.StartTimer();
                        string[] parts = temp.Split(':');
                        int x = int.Parse(parts[0]);
                        int y = int.Parse(parts[1]);
                        tableManager.clickReceive(x, y);
                        break;
                }

            }
        }

        public override void messageSend(string dataS)
        {
            if (netStream != null)
            {
                tableManager.rtbLog.Text += "Send: " + dataS + "\n";
                if (dataS.Contains(":"))
                    tableManager.StopTimer();
                byte[] data = System.Text.Encoding.UTF8.GetBytes(dataS + "\n");
                netStream.Write(data, 0, data.Length);

            }

        }

        public override void ready()
        {
            if (tableManager.btReady.Text == "CANCEL")
            {
                tableManager.btReady.Text = "READY";
                messageSend("Cancel");
                return;
            }
            messageSend("Ready");
            tableManager.btReady.Text = "CANCEL";
        }

    }
    #endregion

















    #region Server
    public class Server_OBJ : Player_OBJ
    {
        TcpListener tcpListener;
        IPEndPoint ipepServer;

        List<TcpClient> clients = new List<TcpClient>();

        public Server_OBJ(Table tableManager)
        {
            tableManager.rtbLog.Text += "Waiting connect...\n";
            ipepServer = new IPEndPoint(IPAddress.Any, 8082);
            tcpListener = new TcpListener(ipepServer);
            tcpListener.Start();

            Task.Run(() =>
            {
                AcceptConnection();
            });
            this.tableManager = tableManager;
        }

        public override void ReceiveMessage(Socket tcpClient_Client)
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];
            while (tcpClient_Client.Connected)
            {
                string Chr;
                string temp = "";
                while (true)
                {

                    bytesReceived = tcpClient_Client.Receive(recv);
                    Chr = Encoding.UTF8.GetString(recv);
                    if (Chr == "\n")
                        break;
                    temp += Chr;

                }
                tableManager.rtbLog.Text += "Receive: " + temp + "\n";
                switch (temp)
                {
                    case string s when s.StartsWith("//"):
                        tableManager.tbClientName.Text = s.Substring(2);
                        break;
                    case "Ready":
                        tableManager.btReady.Tag = "1";
                        tableManager.btReady.ForeColor = Color.White;
                        break;
                    case "Cancel":
                        tableManager.btReady.Tag = "0";
                        tableManager.btReady.ForeColor = Color.Silver;
                        break;
                    case "Switch":
                        tableManager.SwitchPlayer();
                        break;
                    case string s when s.StartsWith("Restart"):
                        string[] partsRestart = temp.Split('_');
                        tableManager.lbTimer.Text = partsRestart[1];
                        tableManager.Restart(int.Parse(partsRestart[1]));
                        break;
                    case "Pause":
                        tableManager.StopTimer();
                        tableManager.caro1.Invoke(new Action(() =>
                        {
                            // Cập nhật giao diện người dùng trên thread chính
                        //    tableManager.caro1.ShowPausePanel_Click(null, null);
                        }));
                        break;
                    case "Resume":
                        tableManager.caro1.Invoke(new Action(() =>
                        {
                            // Cập nhật giao diện người dùng trên thread chính
                           // tableManager.caro1.ShowPausePanel_Click(null, null);
                            if (tableManager.isClientPlayer == tableManager.isClientTurn)
                            {
                                tableManager.StartTimer();
                            }
                        }));
                        break;
                    case "Lose":
                        tableManager.YouWin();
                        break;
                    case "Leave":
                        DialogResult dg = MessageBox.Show("Client disconnected, leave match?", "Disconected", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                       // if (dg == DialogResult.Yes)
                            //tableManager.caro1.lbLeaveMatch_Click(null, null);
                        break;
                    default:
                        string[] parts = temp.Split(':');
                        int x = int.Parse(parts[0]);
                        int y = int.Parse(parts[1]);
                        tableManager.clickReceive(x, y);
                        break;
                }

            }

        }


        public override void messageSend(string message)
        {
            foreach (TcpClient client in clients)
            {
                netStream = client.GetStream();
                if (netStream != null)
                {
                    if (message.Contains(":"))
                        tableManager.timer.Stop();
                    tableManager.rtbLog.Text += "Send: " + message + "\n";
                    byte[] data = Encoding.UTF8.GetBytes(message + "\n");
                    netStream.Write(data, 0, data.Length);

                }
            }
        }

        public void AcceptConnection()
        {
            while (true)
            {
                try
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    clients.Add(tcpClient); // thêm client vào danh sách
                    IPEndPoint clientEndPoint = (IPEndPoint)tcpClient.Client.RemoteEndPoint;
                    string clientIPAddress = clientEndPoint.ToString();
                    tableManager.rtbLog.Text += clientEndPoint + " Connected!\n";

                    Task.Run(() =>
                    {
                        ReceiveMessage(tcpClient.Client);
                    });
                }
                catch (Exception ex)
                {
                    break;
                }
            }

        }
        public override void ready()
        {
            btReadyHide();
            messageSend("Play");
            messageSend("//" + tableManager.tbServerName.Text);

            Task.Run(() =>
            {
                tableManager.caro1.Invoke(new Action(() =>
                {
                    // Cập nhật giao diện người dùng trên thread chính
                    //tableManager.ptbPlay.Size = new Size(1480, 788);
                    tableManager.ptbPlay.Dock = DockStyle.Fill;
                    tableManager.ptbPlay.Location = new Point(0, 0);
                    tableManager.ptbPlay.Visible = true;
                }));
                Thread.Sleep(2000); //Sau khi hết animation thì chuyền sang ảnh menu để tránh việc các button phải load lại
                tableManager.caro1.Invoke(new Action(() =>
                {
                    tableManager.ptbPlay.Image = CaroSpeedRun.Properties.Resources.game;
                }));
                Thread.Sleep(1);
                tableManager.caro1.Invoke(new Action(() =>
                {
                    tableManager.ptbPlay.Visible = false;
                    tableManager.StartTimer();
                }));
            });

        }

    }
    #endregion
}