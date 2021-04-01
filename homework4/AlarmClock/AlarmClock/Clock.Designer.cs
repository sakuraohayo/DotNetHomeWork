namespace AlarmClock
{
    partial class AlarmClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmClock));
            this.Alarm_Time = new System.Windows.Forms.Label();
            this.Alarm_Bell = new System.Windows.Forms.Label();
            this.Alarm_Hour = new System.Windows.Forms.Label();
            this.Alarm_Minute = new System.Windows.Forms.Label();
            this.HourBox = new System.Windows.Forms.ComboBox();
            this.MinuteBox = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NoUse = new System.Windows.Forms.ToolStripStatusLabel();
            this.Now_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.BeginButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Count_Down = new System.Windows.Forms.Label();
            this.HourLabel = new System.Windows.Forms.Label();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.CountDown_Hour = new System.Windows.Forms.Label();
            this.CountDown_Minute = new System.Windows.Forms.Label();
            this.CountDown_Second = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.Time1 = new System.Windows.Forms.RadioButton();
            this.Time2 = new System.Windows.Forms.RadioButton();
            this.Time3 = new System.Windows.Forms.RadioButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Alarm_Time
            // 
            this.Alarm_Time.AutoSize = true;
            this.Alarm_Time.BackColor = System.Drawing.Color.Transparent;
            this.Alarm_Time.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Alarm_Time.Location = new System.Drawing.Point(88, 56);
            this.Alarm_Time.Name = "Alarm_Time";
            this.Alarm_Time.Size = new System.Drawing.Size(109, 20);
            this.Alarm_Time.TabIndex = 0;
            this.Alarm_Time.Text = "起床时间：";
            // 
            // Alarm_Bell
            // 
            this.Alarm_Bell.AutoSize = true;
            this.Alarm_Bell.BackColor = System.Drawing.Color.Transparent;
            this.Alarm_Bell.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Alarm_Bell.Location = new System.Drawing.Point(88, 145);
            this.Alarm_Bell.Name = "Alarm_Bell";
            this.Alarm_Bell.Size = new System.Drawing.Size(109, 20);
            this.Alarm_Bell.TabIndex = 1;
            this.Alarm_Bell.Text = "闹钟铃声：";
            // 
            // Alarm_Hour
            // 
            this.Alarm_Hour.AutoSize = true;
            this.Alarm_Hour.BackColor = System.Drawing.Color.Transparent;
            this.Alarm_Hour.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Alarm_Hour.Location = new System.Drawing.Point(320, 56);
            this.Alarm_Hour.Name = "Alarm_Hour";
            this.Alarm_Hour.Size = new System.Drawing.Size(29, 20);
            this.Alarm_Hour.TabIndex = 2;
            this.Alarm_Hour.Text = "时";
            // 
            // Alarm_Minute
            // 
            this.Alarm_Minute.AutoSize = true;
            this.Alarm_Minute.BackColor = System.Drawing.Color.Transparent;
            this.Alarm_Minute.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Alarm_Minute.Location = new System.Drawing.Point(470, 56);
            this.Alarm_Minute.Name = "Alarm_Minute";
            this.Alarm_Minute.Size = new System.Drawing.Size(29, 20);
            this.Alarm_Minute.TabIndex = 3;
            this.Alarm_Minute.Text = "分";
            // 
            // HourBox
            // 
            this.HourBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HourBox.FormattingEnabled = true;
            this.HourBox.Items.AddRange(new object[] {
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.HourBox.Location = new System.Drawing.Point(230, 53);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(70, 28);
            this.HourBox.TabIndex = 4;
            this.HourBox.Text = "13";
            // 
            // MinuteBox
            // 
            this.MinuteBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinuteBox.FormattingEnabled = true;
            this.MinuteBox.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.MinuteBox.Location = new System.Drawing.Point(380, 53);
            this.MinuteBox.Name = "MinuteBox";
            this.MinuteBox.Size = new System.Drawing.Size(70, 28);
            this.MinuteBox.TabIndex = 5;
            this.MinuteBox.Text = "30";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimeLabel,
            this.NoUse,
            this.Now_Time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 372);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(636, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TimeLabel
            // 
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(50, 17);
            this.TimeLabel.Text = "000000";
            this.TimeLabel.TextChanged += new System.EventHandler(this.TimeLabel_TextChanged);
            // 
            // NoUse
            // 
            this.NoUse.Name = "NoUse";
            this.NoUse.Size = new System.Drawing.Size(452, 17);
            this.NoUse.Spring = true;
            // 
            // Now_Time
            // 
            this.Now_Time.Name = "Now_Time";
            this.Now_Time.Size = new System.Drawing.Size(119, 17);
            this.Now_Time.Text = "2015/11/6 08:30:00";
            // 
            // BeginButton
            // 
            this.BeginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BeginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.BeginButton.FlatAppearance.BorderSize = 0;
            this.BeginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BeginButton.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BeginButton.Location = new System.Drawing.Point(240, 298);
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(172, 40);
            this.BeginButton.TabIndex = 10;
            this.BeginButton.Text = "开  始";
            this.BeginButton.UseVisualStyleBackColor = false;
            this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Count_Down
            // 
            this.Count_Down.AutoSize = true;
            this.Count_Down.BackColor = System.Drawing.Color.Transparent;
            this.Count_Down.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Count_Down.ForeColor = System.Drawing.Color.Red;
            this.Count_Down.Location = new System.Drawing.Point(39, 258);
            this.Count_Down.Name = "Count_Down";
            this.Count_Down.Size = new System.Drawing.Size(120, 27);
            this.Count_Down.TabIndex = 12;
            this.Count_Down.Text = "倒计时：";
            this.Count_Down.Visible = false;
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.BackColor = System.Drawing.Color.Transparent;
            this.HourLabel.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HourLabel.Location = new System.Drawing.Point(180, 241);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HourLabel.Size = new System.Drawing.Size(44, 47);
            this.HourLabel.TabIndex = 13;
            this.HourLabel.Text = "0";
            this.HourLabel.Visible = false;
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.AutoSize = true;
            this.MinuteLabel.BackColor = System.Drawing.Color.Transparent;
            this.MinuteLabel.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinuteLabel.Location = new System.Drawing.Point(330, 241);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(44, 47);
            this.MinuteLabel.TabIndex = 14;
            this.MinuteLabel.Text = "0";
            this.MinuteLabel.Visible = false;
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.BackColor = System.Drawing.Color.Transparent;
            this.SecondLabel.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SecondLabel.Location = new System.Drawing.Point(480, 241);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(44, 47);
            this.SecondLabel.TabIndex = 15;
            this.SecondLabel.Text = "0";
            this.SecondLabel.Visible = false;
            // 
            // CountDown_Hour
            // 
            this.CountDown_Hour.AutoSize = true;
            this.CountDown_Hour.BackColor = System.Drawing.Color.Transparent;
            this.CountDown_Hour.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CountDown_Hour.Location = new System.Drawing.Point(250, 258);
            this.CountDown_Hour.Name = "CountDown_Hour";
            this.CountDown_Hour.Size = new System.Drawing.Size(39, 27);
            this.CountDown_Hour.TabIndex = 16;
            this.CountDown_Hour.Text = "时";
            this.CountDown_Hour.Visible = false;
            // 
            // CountDown_Minute
            // 
            this.CountDown_Minute.AutoSize = true;
            this.CountDown_Minute.BackColor = System.Drawing.Color.Transparent;
            this.CountDown_Minute.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CountDown_Minute.Location = new System.Drawing.Point(400, 258);
            this.CountDown_Minute.Name = "CountDown_Minute";
            this.CountDown_Minute.Size = new System.Drawing.Size(39, 27);
            this.CountDown_Minute.TabIndex = 17;
            this.CountDown_Minute.Text = "分";
            this.CountDown_Minute.Visible = false;
            // 
            // CountDown_Second
            // 
            this.CountDown_Second.AutoSize = true;
            this.CountDown_Second.BackColor = System.Drawing.Color.Transparent;
            this.CountDown_Second.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CountDown_Second.Location = new System.Drawing.Point(550, 258);
            this.CountDown_Second.Name = "CountDown_Second";
            this.CountDown_Second.Size = new System.Drawing.Size(39, 27);
            this.CountDown_Second.TabIndex = 18;
            this.CountDown_Second.Text = "秒";
            this.CountDown_Second.Visible = false;
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Transparent;
            this.StopButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.StopButton.FlatAppearance.BorderSize = 0;
            this.StopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StopButton.ForeColor = System.Drawing.Color.Red;
            this.StopButton.Location = new System.Drawing.Point(555, 321);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(65, 31);
            this.StopButton.TabIndex = 19;
            this.StopButton.Text = "取消";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Visible = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // TestButton
            // 
            this.TestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TestButton.FlatAppearance.BorderSize = 0;
            this.TestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestButton.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TestButton.Location = new System.Drawing.Point(555, 141);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(59, 30);
            this.TestButton.TabIndex = 20;
            this.TestButton.Text = "测试";
            this.TestButton.UseVisualStyleBackColor = false;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // PathBox
            // 
            this.PathBox.BackColor = System.Drawing.Color.White;
            this.PathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathBox.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PathBox.ForeColor = System.Drawing.Color.Blue;
            this.PathBox.Location = new System.Drawing.Point(230, 145);
            this.PathBox.Multiline = true;
            this.PathBox.Name = "PathBox";
            this.PathBox.ReadOnly = true;
            this.PathBox.Size = new System.Drawing.Size(250, 20);
            this.PathBox.TabIndex = 22;
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.Color.Transparent;
            this.SelectButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SelectButton.FlatAppearance.BorderSize = 0;
            this.SelectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectButton.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectButton.ForeColor = System.Drawing.Color.Red;
            this.SelectButton.Location = new System.Drawing.Point(488, 144);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(50, 25);
            this.SelectButton.TabIndex = 23;
            this.SelectButton.Text = "选择";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // Time1
            // 
            this.Time1.AutoSize = true;
            this.Time1.BackColor = System.Drawing.Color.Transparent;
            this.Time1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Time1.Location = new System.Drawing.Point(110, 208);
            this.Time1.Name = "Time1";
            this.Time1.Size = new System.Drawing.Size(88, 18);
            this.Time1.TabIndex = 25;
            this.Time1.Text = "起床时间1";
            this.Time1.UseVisualStyleBackColor = false;
            this.Time1.CheckedChanged += new System.EventHandler(this.Time1_CheckedChanged);
            // 
            // Time2
            // 
            this.Time2.AutoSize = true;
            this.Time2.BackColor = System.Drawing.Color.Transparent;
            this.Time2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Time2.Location = new System.Drawing.Point(280, 208);
            this.Time2.Name = "Time2";
            this.Time2.Size = new System.Drawing.Size(88, 18);
            this.Time2.TabIndex = 26;
            this.Time2.Text = "起床时间2";
            this.Time2.UseVisualStyleBackColor = false;
            this.Time2.CheckedChanged += new System.EventHandler(this.Time2_CheckedChanged);
            // 
            // Time3
            // 
            this.Time3.AutoSize = true;
            this.Time3.BackColor = System.Drawing.Color.Transparent;
            this.Time3.Checked = true;
            this.Time3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Time3.Location = new System.Drawing.Point(450, 208);
            this.Time3.Name = "Time3";
            this.Time3.Size = new System.Drawing.Size(95, 18);
            this.Time3.TabIndex = 27;
            this.Time3.TabStop = true;
            this.Time3.Text = "自定义时间";
            this.Time3.UseVisualStyleBackColor = false;
            this.Time3.CheckedChanged += new System.EventHandler(this.Time3_CheckedChanged);
            // 
            // AlarmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 394);
            this.Controls.Add(this.Time3);
            this.Controls.Add(this.Time2);
            this.Controls.Add(this.Time1);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.BeginButton);
            this.Controls.Add(this.CountDown_Second);
            this.Controls.Add(this.CountDown_Minute);
            this.Controls.Add(this.CountDown_Hour);
            this.Controls.Add(this.SecondLabel);
            this.Controls.Add(this.MinuteLabel);
            this.Controls.Add(this.HourLabel);
            this.Controls.Add(this.Count_Down);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MinuteBox);
            this.Controls.Add(this.HourBox);
            this.Controls.Add(this.Alarm_Minute);
            this.Controls.Add(this.Alarm_Hour);
            this.Controls.Add(this.Alarm_Bell);
            this.Controls.Add(this.Alarm_Time);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AlarmClock";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "闹钟";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Clock_FormClosing);
            this.Load += new System.EventHandler(this.Clock_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Alarm_Time;
        private System.Windows.Forms.Label Alarm_Bell;
        private System.Windows.Forms.Label Alarm_Hour;
        private System.Windows.Forms.Label Alarm_Minute;
        private System.Windows.Forms.ComboBox HourBox;
        private System.Windows.Forms.ComboBox MinuteBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Now_Time;
        private System.Windows.Forms.Button BeginButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Count_Down;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.Label CountDown_Hour;
        private System.Windows.Forms.Label CountDown_Minute;
        private System.Windows.Forms.Label CountDown_Second;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.ToolStripStatusLabel NoUse;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.ToolStripStatusLabel TimeLabel;
        private System.Windows.Forms.RadioButton Time1;
        private System.Windows.Forms.RadioButton Time2;
        private System.Windows.Forms.RadioButton Time3;
    }
}

