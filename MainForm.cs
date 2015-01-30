using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace ASAFocuser
{
    public partial class MainForm : Form
    {
        FocuserUser focuserUser;
        FocuserNet focuserNet;
        Thread focNetThd;
        public MainForm()
        {
            InitializeComponent();
            timerFocUpdateStat.Interval = 100;
            timerFocUpdateStat.Enabled = true;

            //connect to device driver
            focuserUser = new FocuserUser();
            focuserUser.ConnectDevice();

            //connect to host
            focuserNet = new FocuserNet(focuserUser);
            focNetThd = new Thread(new ThreadStart(focuserNet.ConnectToHost));
            focNetThd.IsBackground = true;
            focNetThd.Start();

        }

        ~MainForm()
        {
            Console.WriteLine("main form disposed..");
        }

        private void buttonFocusMove_Click(object sender, EventArgs e)
        {
            focuserUser.FocuserMoveToPos(
                Convert.ToDouble(textBoxFocusSetPos.Text));
        }

        private void buttonFocusStop_Click(object sender, EventArgs e)
        {
            focuserUser.FocuserStop();
        }

        private void buttonFocusStepMoveInc_Click(object sender, EventArgs e)
        {
            focuserUser.FocuserStepMove(
                Convert.ToDouble(textBoxFocusStep.Text));
        }

        private void buttonFocusStepMoveDec_Click(object sender, EventArgs e)
        {
            focuserUser.FocuserStepMove(
                -Convert.ToDouble(textBoxFocusStep.Text));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateStatus()
        {
            //连接状态
            switch (focuserUser.GetLink())
            {
                case true:
                    labelFocusLinkStat.Text = "Focuser driver is connected.";
                    labelFocusLinkStat.ForeColor = Color.Green;
                    break;
                case false:
                default:
                    labelFocusLinkStat.Text = "Focuser driver is not connected.";
                    labelFocusLinkStat.ForeColor = Color.Red;
                    break;
            }

            //当前位置
            textBoxFocusCurPos.Text = focuserUser.GetCurPos().ToString("f3");

            //移动状态
            switch (focuserUser.GetMoveStatus())
            {
                case true:
                    textBoxFocusCurStatus.Text = "Moving...";
                    break;
                case false:
                default:
                    textBoxFocusCurStatus.Text = "Stopped";
                    break;
            }

            //温度
            textBoxFocusCurTemp.Text = focuserUser.GetCurTemp().ToString("f1");

            //进度条
            progressBarFocus.Value = (int)(focuserUser.GetCurPos() / 30.0 * 100);

        }

        private void timerFocUpdateStat_Tick(object sender, EventArgs e)
        {

            UpdateStatus();
        }

        private void connectDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            focuserUser.ConnectDevice();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}