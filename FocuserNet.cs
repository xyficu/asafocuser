using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Threading;

namespace ASAFocuser
{
    class FocuserNet
    {
        private IPAddress m_ip;
        private IPEndPoint m_ep;
        Socket m_sktDev;
        string m_errMsg;
        bool m_connected;
        FocuserUser m_focUser;
        Timer m_timerHousekeep;
        public FocuserNet(FocuserUser focUser)
        {
            m_focUser = focUser;
            m_ip = IPAddress.Parse("190.168.1.115");
            m_ep = new IPEndPoint(m_ip, 30001);
            m_sktDev = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
                ProtocolType.IP);
            m_errMsg = "";
            m_connected = false;

            //启动消息接收线程
            Thread thd = new Thread(new ThreadStart(ReceiveMessage));
            thd.IsBackground = true;
            thd.Start();

            //启动housekeeping线程
            m_timerHousekeep = new Timer(new TimerCallback(HouseKeeping), null ,0, 10000);
            m_timerHousekeep.Change(0, 10000);

        }

        ~FocuserNet()
        {
            try
            {
                SendMessage("RFOCUSER");
                if (m_sktDev != null)
                {
                    m_sktDev.Shutdown(SocketShutdown.Both);
                    m_sktDev.Close();
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Dispose error: " + ex.Message);
            }
        }

        private void HouseKeeping(object o)
        {
            //获取系统时间
            string lt = GetLocalTime(); 
            //每隔10s由设备端发给服务器
            SendMessage("RF,HOUSEKEEPING," + lt);
        }

        //设备端反向连接
        public void ConnectToHost()
        {
            try
            {
                while (m_connected == false)
                {
                    Console.WriteLine("try to connect to host ...");
                    m_sktDev.Connect(m_ep);
                    m_connected = true;
                    //连接成功后发送注册消息
                    SendMessage("FOCUSER");
                    
                }

            }
            catch (System.Exception ex)
            {
                Thread.Sleep(5000);
            	m_errMsg=ex.Message;
                m_connected = false;
                ConnectToHost();
            }
        }

        
        public void SendMessage(string msg)
        {
            try
            {
                byte[] buf = Encoding.ASCII.GetBytes(msg);
                if (true == m_connected)
                {
                    m_sktDev.Send(buf);

                }
            }
            catch (System.Exception ex)
            {
                Console.Write("send message error: " + ex.Message);
            }

        }

        //接收远程指令
        public void ReceiveMessage()
        {
            try
            {
                string msg = "";
                byte[] buf = new byte[1024];
                int length = 0;
                while ((length = m_sktDev.Receive(buf)) != 0)
                {
                    msg = Encoding.ASCII.GetString(buf, 0, length);
                    Console.WriteLine("message received: {0}", msg);
                    ResolveCmds(msg);
                }
            }
            catch (System.Exception ex)
            {
                m_errMsg = ex.Message;
                Console.WriteLine("resolve message error: " + ex.Message);
                ReceiveMessage();
            }
        }

        //解析远程指令
        public void ResolveCmds(string msg)
        {
            try
            {
                string deviceType, cmd, pos, step, temp, ismoving, lt;
                string[] cmdList = msg.Split(',');
                string reply = "";
                deviceType = cmdList[0];
                if (cmdList.Length < 3)
                    return;
                if (deviceType != "F")
                    return;
                cmd = cmdList[1];
                lt = cmdList.Last();

                if (cmd == "MOVE")
                {
                    pos = cmdList[2];
                    //control device
                    m_focUser.FocuserMoveToPos(Convert.ToDouble(pos));
                    //send reply message
                    reply = "R" + string.Join(",", cmdList, 0, cmdList.Length - 1);
                    reply += "," + "0" + "," + lt;
                    SendMessage(reply);
                    
                }
                else if (cmd == "STOP")
                {
                    //control device
                    m_focUser.FocuserStop();

                    //send reply message
                    reply = "R" + string.Join(",", cmdList, 0, cmdList.Length - 1);
                    reply += "," + "0" + "," + lt;
                    SendMessage(reply);

                }
                else if (cmd=="STEP")
                {
                    step = cmdList[2];
                    //control device
                    m_focUser.FocuserStepMove(Convert.ToDouble(step));
                    //send reply message
                    reply = "R" + string.Join(",", cmdList, 0, cmdList.Length - 1);
                    reply += "," + "0" + "," + lt;
                    SendMessage(reply);
                }
                else if (cmd == "STATUS")
                {
                    //control device
                    pos = m_focUser.GetCurPos().ToString("f3");
                    temp = m_focUser.GetCurTemp().ToString("f1");
                    ismoving = (m_focUser.GetMoveStatus() ? 1 : 0).ToString();
                    //send reply message
                    reply = "R" + string.Join(",", cmdList, 0, cmdList.Length - 1);
                    reply += "," + pos;
                    reply += "," + temp;
                    reply += "," + ismoving;
                    reply += "," + lt;
                    SendMessage(reply);
                }
                Console.WriteLine("send: {0}", reply);
   
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("cmds error: {0}", ex.Message);
            }
        }

        //获取local time
        private string GetLocalTime()
        {
            return DateTime.Now.Year.ToString() +
                        DateTime.Now.Month.ToString("d2") +
                        DateTime.Now.Day.ToString("d2") +
                        "T" +
                        DateTime.Now.Hour.ToString("d2") +
                        DateTime.Now.Minute.ToString("d2") +
                        DateTime.Now.Second.ToString("d2") +
                        "." +
                        DateTime.Now.Millisecond.ToString("d3");
        }
    }
}
