using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AlarmClock
{
    public partial class AlarmClock : Form
    {
        private bool BeginAlarm = false;
        private DateTime AlarmTime;
        private SoundPlayer AlarmBell;
        private long CountDownTime;

        public AlarmClock()
        {
            InitializeComponent();
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            ToolTip testTip = new ToolTip();
            testTip.IsBalloon = true;
            testTip.SetToolTip(TestButton, "测试选择的音乐是否可用");
            timer1.Interval = 1000; 
            timer1.Enabled = true;
            this.AcceptButton = BeginButton;
            PathBox.Text = Application.StartupPath.ToString() + @"\Music\ring.wav";
        }

        private void Clock_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SystemSounds.Exclamation.Play();
            }
            catch { }
            if (MessageBox.Show("请确认是否退出程序？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            if (TestButton.Text == "停止")
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("请先停止测试闹钟铃声！", "提示");
                return;
            }
            if (Time3.Checked)
            {
                try
                {
                    int hour = Convert.ToInt32(HourBox.Text.Trim());
                    int minute = Convert.ToInt32(MinuteBox.Text.Trim());
                    if (hour < 0 || hour > 23 || minute < 0 || minute > 60)
                    {
                        SystemSounds.Hand.Play();
                        MessageBox.Show("起床时间设置有误！", "警告");
                        return;
                    }
                }
                catch (Exception)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("起床时间设置有误！", "警告");
                    return;
                }
            }
            string AlarmTime1 = HourBox.Text.Trim() + ":" + MinuteBox.Text.Trim() + ":" + "00";
            AlarmTime = DateTime.Parse(AlarmTime1);
            if (DateTime.Compare(AlarmTime, DateTime.Now) > 0)
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("请务必测试闹钟铃声是否可用！", "提示");

                BeginAlarm = true;

                HourBox.Enabled = false;
                MinuteBox.Enabled = false;
                BeginButton.Visible = false;
                SelectButton.Visible = false;
                TestButton.Visible = false;
                Time1.Visible = false;
                Time2.Visible = false;
                Time3.Visible = false;
                StopButton.Visible = true;
                Count_Down.Visible = true;
                HourLabel.Visible = true;
                MinuteLabel.Visible = true;
                SecondLabel.Visible = true;
                CountDown_Hour.Visible = true;
                CountDown_Minute.Visible = true;
                CountDown_Second.Visible = true;
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("起床时间小于当前时间！", "警告");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime NowTime = DateTime.Now;
            Now_Time.Text = NowTime.ToString();

            if (BeginAlarm)
            {
                TimeSpan CountDown = AlarmTime - NowTime;
                HourLabel.Text = CountDown.Hours.ToString();
                MinuteLabel.Text = CountDown.Minutes.ToString();
                SecondLabel.Text = CountDown.Seconds.ToString();
                CountDownTime = CountDown.Hours * 3600 + CountDown.Minutes * 60 + CountDown.Seconds;
                TimeLabel.Text = CountDownTime.ToString();
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            if (MessageBox.Show("请确认是否结束倒计时？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                BeginAlarm = false;

                HourBox.Enabled = true;
                MinuteBox.Enabled = true;
                BeginButton.Visible = true;
                SelectButton.Visible = true;
                TestButton.Visible = true;
                Time1.Visible = true;
                Time2.Visible = true;
                Time3.Visible = true;
                StopButton.Visible = false;
                Count_Down.Visible = false;
                HourLabel.Visible = false;
                MinuteLabel.Visible = false;
                SecondLabel.Visible = false;
                CountDown_Hour.Visible = false;
                CountDown_Minute.Visible = false;
                CountDown_Second.Visible = false;

                HourLabel.Text = "0";
                MinuteLabel.Text = "0";
                SecondLabel.Text = "0";
                CountDownTime = 1;
                TimeLabel.Text = "000000";
            }
        }

        private void PlayAlarmBell()
        {
            AlarmBell = new SoundPlayer();
            AlarmBell.SoundLocation = PathBox.Text.Trim();
            try
            {
                AlarmBell.PlayLooping();
                DialogResult res = MessageBox.Show("起床啦！起床啦！起床啦！",
                "提示");
                if (res == DialogResult.OK)
                {
                    AlarmBell.Stop();
                    AlarmBell.Dispose();
                }
            }
            catch (Exception)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("无效闹钟铃声！", "警告");
                AlarmBell.Dispose();
            }
        }

        private void TestAlarmBell()
        {
            if (TestButton.Text == "测试")
            {
                AlarmBell = new SoundPlayer();
                AlarmBell.SoundLocation = PathBox.Text.Trim();
                try
                {
                    AlarmBell.PlayLooping();
                    TestButton.Text = "停止";
                    SelectButton.Enabled = false;
                }
                catch (Exception)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("无效闹钟铃声！", "警告");
                    AlarmBell.Dispose();
                    TestButton.Text = "测试";
                    SelectButton.Enabled = true;
                }
            }
            else
            {
                try
                {
                    AlarmBell.Stop();
                    AlarmBell.Dispose();
                }
                catch (Exception)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("未知错误！", "提示");
                }
                finally
                {
                    TestButton.Text = "测试";
                    SelectButton.Enabled = true;
                }
            }
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            TestAlarmBell();

            //SystemSounds.Asterisk.Play();
            //SystemSounds.Beep.Play();
            //SystemSounds.Exclamation.Play();
            //SystemSounds.Hand.Play();
            //SystemSounds.Question.Play();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"F:\Alarm Clock\";  //默认打开目录
            ofd.Filter = "铃声文件|*.wav";  //显示的文件类型
            ofd.RestoreDirectory = true;  //对话框记忆之前打开的目录
            ofd.FilterIndex = 1;  //文件类型的显示顺序
            if (ofd.ShowDialog() == DialogResult.OK)  //选中文件
            {
                string BellPath = ofd.FileName;
                PathBox.Text = BellPath;
            }
        }

        private void TimeLabel_TextChanged(object sender, EventArgs e)
        {
            if (CountDownTime <= 0)
            {
                BeginAlarm = false;
                PlayAlarmBell();

                HourBox.Enabled = true;
                MinuteBox.Enabled = true;
                BeginButton.Visible = true;
                SelectButton.Visible = true;
                TestButton.Visible = true;
                Time1.Visible = true;
                Time2.Visible = true;
                Time3.Visible = true;
                StopButton.Visible = false;
                Count_Down.Visible = false;
                HourLabel.Visible = false;
                MinuteLabel.Visible = false;
                SecondLabel.Visible = false;
                CountDown_Hour.Visible = false;
                CountDown_Minute.Visible = false;
                CountDown_Second.Visible = false;

                HourLabel.Text = "0";
                MinuteLabel.Text = "0";
                SecondLabel.Text = "0";
                CountDownTime = 1;
                TimeLabel.Text = "000000";
            }
        }

        private void Time1_CheckedChanged(object sender, EventArgs e)
        {
            HourBox.Text = "13";
            MinuteBox.Text = "30";
            HourBox.Enabled = false;
            MinuteBox.Enabled = false;
        }

        private void Time2_CheckedChanged(object sender, EventArgs e)
        {
            HourBox.Text = "14";
            MinuteBox.Text = "00";
            HourBox.Enabled = false;
            MinuteBox.Enabled = false;
        }

        private void Time3_CheckedChanged(object sender, EventArgs e)
        {
            HourBox.Enabled = true;
            MinuteBox.Enabled = true;
        }
    }
}
