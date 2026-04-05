using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage.Alarm
{
    public partial class FrmAlarm : Form
    {
        public FrmAlarm()
        {
            InitializeComponent();
            
        }
        string targetAlarmTime = "";
        bool Start_Alarm = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");

            lblCurrentTime.Text = currentTime;
            if (Start_Alarm && currentTime == targetAlarmTime)
            {
                Start_Alarm = false;
                btnset.Text = "Set";
                maskedTextBox1.Enabled = true;

                MessageBox.Show("時間到囉！", "鬧鐘提醒");
            }


        }

        private void btnset_Click(object sender, EventArgs e)
        {
            if (!Start_Alarm)
            {
                
                targetAlarmTime = maskedTextBox1.Text; 
                Start_Alarm = true;
                btnset.Text = "Cancel";
                maskedTextBox1.Enabled = false; 
            }
            else
            {
                
                Start_Alarm = false;
                btnset.Text = "Set";
                maskedTextBox1.Enabled = true; 
            }
        }
    }
}
