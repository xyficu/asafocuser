namespace ASAFocuser
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBarFocus = new System.Windows.Forms.ProgressBar();
            this.buttonFocusStop = new System.Windows.Forms.Button();
            this.buttonFocusMove = new System.Windows.Forms.Button();
            this.textBoxFocusSetPos = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFocusStepMoveDec = new System.Windows.Forms.Button();
            this.buttonFocusStepMoveInc = new System.Windows.Forms.Button();
            this.textBoxFocusStep = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelFocusLinkStat = new System.Windows.Forms.Label();
            this.timerFocUpdateStat = new System.Windows.Forms.Timer(this.components);
            this.labelFocusCurPos = new System.Windows.Forms.Label();
            this.labelFocusCurStat = new System.Windows.Forms.Label();
            this.labelFocusCurTemp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position(mm):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Move status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Temperature(C):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBarFocus);
            this.groupBox1.Controls.Add(this.buttonFocusStop);
            this.groupBox1.Controls.Add(this.buttonFocusMove);
            this.groupBox1.Controls.Add(this.textBoxFocusSetPos);
            this.groupBox1.Location = new System.Drawing.Point(24, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 113);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move to position(0~30mm):";
            // 
            // progressBarFocus
            // 
            this.progressBarFocus.Location = new System.Drawing.Point(10, 81);
            this.progressBarFocus.Name = "progressBarFocus";
            this.progressBarFocus.Size = new System.Drawing.Size(175, 23);
            this.progressBarFocus.TabIndex = 3;
            this.progressBarFocus.Value = 30;
            // 
            // buttonFocusStop
            // 
            this.buttonFocusStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFocusStop.ForeColor = System.Drawing.Color.Red;
            this.buttonFocusStop.Location = new System.Drawing.Point(110, 48);
            this.buttonFocusStop.Name = "buttonFocusStop";
            this.buttonFocusStop.Size = new System.Drawing.Size(75, 23);
            this.buttonFocusStop.TabIndex = 2;
            this.buttonFocusStop.Text = "Stop";
            this.buttonFocusStop.UseVisualStyleBackColor = true;
            this.buttonFocusStop.Click += new System.EventHandler(this.buttonFocusStop_Click);
            // 
            // buttonFocusMove
            // 
            this.buttonFocusMove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFocusMove.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonFocusMove.Location = new System.Drawing.Point(110, 19);
            this.buttonFocusMove.Name = "buttonFocusMove";
            this.buttonFocusMove.Size = new System.Drawing.Size(75, 23);
            this.buttonFocusMove.TabIndex = 1;
            this.buttonFocusMove.Text = "Move";
            this.buttonFocusMove.UseVisualStyleBackColor = true;
            this.buttonFocusMove.Click += new System.EventHandler(this.buttonFocusMove_Click);
            // 
            // textBoxFocusSetPos
            // 
            this.textBoxFocusSetPos.Location = new System.Drawing.Point(10, 34);
            this.textBoxFocusSetPos.Name = "textBoxFocusSetPos";
            this.textBoxFocusSetPos.Size = new System.Drawing.Size(64, 21);
            this.textBoxFocusSetPos.TabIndex = 0;
            this.textBoxFocusSetPos.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFocusStepMoveDec);
            this.groupBox2.Controls.Add(this.buttonFocusStepMoveInc);
            this.groupBox2.Controls.Add(this.textBoxFocusStep);
            this.groupBox2.Location = new System.Drawing.Point(24, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 87);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step move(mm):";
            // 
            // buttonFocusStepMoveDec
            // 
            this.buttonFocusStepMoveDec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFocusStepMoveDec.Location = new System.Drawing.Point(110, 50);
            this.buttonFocusStepMoveDec.Name = "buttonFocusStepMoveDec";
            this.buttonFocusStepMoveDec.Size = new System.Drawing.Size(75, 23);
            this.buttonFocusStepMoveDec.TabIndex = 2;
            this.buttonFocusStepMoveDec.Text = "-";
            this.buttonFocusStepMoveDec.UseVisualStyleBackColor = true;
            this.buttonFocusStepMoveDec.Click += new System.EventHandler(this.buttonFocusStepMoveDec_Click);
            // 
            // buttonFocusStepMoveInc
            // 
            this.buttonFocusStepMoveInc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFocusStepMoveInc.Location = new System.Drawing.Point(110, 21);
            this.buttonFocusStepMoveInc.Name = "buttonFocusStepMoveInc";
            this.buttonFocusStepMoveInc.Size = new System.Drawing.Size(75, 23);
            this.buttonFocusStepMoveInc.TabIndex = 1;
            this.buttonFocusStepMoveInc.Text = "+";
            this.buttonFocusStepMoveInc.UseVisualStyleBackColor = true;
            this.buttonFocusStepMoveInc.Click += new System.EventHandler(this.buttonFocusStepMoveInc_Click);
            // 
            // textBoxFocusStep
            // 
            this.textBoxFocusStep.Location = new System.Drawing.Point(10, 36);
            this.textBoxFocusStep.Name = "textBoxFocusStep";
            this.textBoxFocusStep.Size = new System.Drawing.Size(64, 21);
            this.textBoxFocusStep.TabIndex = 0;
            this.textBoxFocusStep.Text = "0.1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(244, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectDeviceToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileFToolStripMenuItem.Text = "&File";
            // 
            // connectDeviceToolStripMenuItem
            // 
            this.connectDeviceToolStripMenuItem.Name = "connectDeviceToolStripMenuItem";
            this.connectDeviceToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.connectDeviceToolStripMenuItem.Text = "Connect Device";
            this.connectDeviceToolStripMenuItem.Click += new System.EventHandler(this.connectDeviceToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // labelFocusLinkStat
            // 
            this.labelFocusLinkStat.AutoSize = true;
            this.labelFocusLinkStat.Location = new System.Drawing.Point(24, 358);
            this.labelFocusLinkStat.Name = "labelFocusLinkStat";
            this.labelFocusLinkStat.Size = new System.Drawing.Size(197, 12);
            this.labelFocusLinkStat.TabIndex = 9;
            this.labelFocusLinkStat.Text = "Focuser driver is not connected.";
            // 
            // timerFocUpdateStat
            // 
            this.timerFocUpdateStat.Tick += new System.EventHandler(this.timerFocUpdateStat_Tick);
            // 
            // labelFocusCurPos
            // 
            this.labelFocusCurPos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFocusCurPos.Location = new System.Drawing.Point(132, 35);
            this.labelFocusCurPos.Name = "labelFocusCurPos";
            this.labelFocusCurPos.Size = new System.Drawing.Size(72, 15);
            this.labelFocusCurPos.TabIndex = 10;
            this.labelFocusCurPos.Text = "0";
            // 
            // labelFocusCurStat
            // 
            this.labelFocusCurStat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFocusCurStat.Location = new System.Drawing.Point(132, 63);
            this.labelFocusCurStat.Name = "labelFocusCurStat";
            this.labelFocusCurStat.Size = new System.Drawing.Size(72, 15);
            this.labelFocusCurStat.TabIndex = 11;
            this.labelFocusCurStat.Text = "Stopped";
            // 
            // labelFocusCurTemp
            // 
            this.labelFocusCurTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFocusCurTemp.Location = new System.Drawing.Point(132, 91);
            this.labelFocusCurTemp.Name = "labelFocusCurTemp";
            this.labelFocusCurTemp.Size = new System.Drawing.Size(72, 15);
            this.labelFocusCurTemp.TabIndex = 12;
            this.labelFocusCurTemp.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 386);
            this.Controls.Add(this.labelFocusCurTemp);
            this.Controls.Add(this.labelFocusCurStat);
            this.Controls.Add(this.labelFocusCurPos);
            this.Controls.Add(this.labelFocusLinkStat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Focuser Controller";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBarFocus;
        private System.Windows.Forms.Button buttonFocusStop;
        private System.Windows.Forms.Button buttonFocusMove;
        private System.Windows.Forms.TextBox textBoxFocusSetPos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonFocusStepMoveDec;
        private System.Windows.Forms.Button buttonFocusStepMoveInc;
        private System.Windows.Forms.TextBox textBoxFocusStep;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelFocusLinkStat;
        private System.Windows.Forms.Timer timerFocUpdateStat;
        private System.Windows.Forms.ToolStripMenuItem connectDeviceToolStripMenuItem;
        private System.Windows.Forms.Label labelFocusCurPos;
        private System.Windows.Forms.Label labelFocusCurStat;
        private System.Windows.Forms.Label labelFocusCurTemp;
    }
}

