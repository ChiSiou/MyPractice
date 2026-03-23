using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class StudentScore : Form
    {
        public StudentScore()
        {
            InitializeComponent();
            txtstudentname.Text = "";
            txtchinese.Text = "0";
            txtenglish.Text = "0";
            txtmath.Text = "0";
        }

        public struct Student
        {
            public string studentname;
            public int chinese_score;
            public int english_score;
            public int math_score;

            public Student(string studentname, int chinese_score, int english_score, int math_score)
            {
                this.studentname = studentname;
                this.chinese_score = chinese_score;
                this.english_score = english_score;
                this.math_score = math_score;
            }
        }
        public Student txtin(string studentname, int chinese_score, int english_score, int math_score)
        {
            Student student = new Student(studentname, chinese_score, english_score, math_score);
            return student;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentname = txtstudentname.Text;
            int chinese_score = int.Parse(txtchinese.Text);
            int english_score = int.Parse(txtenglish.Text);
            int math_score = int.Parse(txtmath.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string studentname = txtstudentname.Text;
            int chinese_score = int.Parse(txtchinese.Text);
            int english_score = int.Parse(txtenglish.Text);
            int math_score = int.Parse(txtmath.Text);
            Student student = txtin(studentname, chinese_score, english_score, math_score);

            ltscore.Items.Add($"姓名 : {student.studentname}");
            ltscore.Items.Add($"國文 : {student.chinese_score}");
            ltscore.Items.Add($"英文 : {student.english_score}");
            ltscore.Items.Add($"數學 : {student.math_score}");
        }

        private void btnhighlow_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> score = new Dictionary<string, int> { };

            score.Add("國文", int.Parse(txtchinese.Text));
            score.Add("英文", int.Parse(txtenglish.Text));
            score.Add("數學", int.Parse(txtmath.Text));
            int highscore = score.Values.Max();
            int lowscore = score.Values.Min();
            string highsubject = score.Keys.Max();
            string lowsubject = score.Keys.Min();
            lthighlow.Items.Add($"最高科目成績為 : {highsubject}{highscore}分");
            lthighlow.Items.Add($"最低科目成績為 : {lowsubject}{lowscore}分");
        }

        private void ltscore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
