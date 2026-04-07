using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HomePage.StudentGrade;
using static HomePage.StudentGrade_List;

namespace HomePage
{
    public partial class StudentGrade : Form
    {
        public StudentGrade()
        {
            InitializeComponent();
        }
        string name;
        int chinese;
        int english;
        int math;
        int total;
        float avg;
        string highsub;
        string lowsub;

        List<student_score> student_Scores = new List<student_score>();
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                name = txtName.Text;
                chinese = int.Parse(txtChinese.Text);
                english = int.Parse(txtEnglish.Text);
                math = int.Parse(txtMath.Text);
                total = chinese + english + math;
                avg = total / 3f;

                Dictionary<string, int> score = new Dictionary<string, int>();
                score.Add("國文", chinese);
                score.Add("英文", english);
                score.Add("數學", math);


                int maxscore = -1;
                string maxsubject ="";
                foreach (var item in score)
                {
                    if (item.Value > maxscore)
                    {
                        maxscore = item.Value;
                        maxsubject = item.Key;
                    }
                }

                int minscore =101;
                string minsubject = "";
                foreach (var item in score)
                {
                    if (item.Value < minscore)
                    {
                        minscore = item.Value;
                        minsubject = item.Key;
                    }
                }

                highsub = $"{maxsubject}{maxscore}";
                lowsub = $"{minsubject}{minscore}";

                student_score stu = new student_score(name, chinese, english, math, total, avg, highsub, lowsub);
                student_Scores.Add(stu);

                refreshview(student_Scores);
                btn_Statistics.Enabled = true;

            }
            catch
            {
                MessageBox.Show("請填入正確資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public struct student_score
        {
            public string name;
            public int chinese;
            public int english;
            public int math;
            public int total;
            public float avg;
            public string highsub;
            public string lowsub;
            public student_score(string name, int chinese, int english, int math, int total, float avg, string highsub, string lowsub)
            {
                this.name = name;
                this.chinese = chinese;
                this.english = english;
                this.math = math;
                this.total = total;
                this.avg = avg;
                this.highsub = highsub;
                this.lowsub = lowsub;
            }
        }

        public void refreshview(List<student_score> ToDisplay)
        {
            lvstudent_score.Items.Clear();
            foreach (student_score student in ToDisplay)
            {
                ListViewItem item = new ListViewItem(student.name);
                item.SubItems.Add((student.chinese).ToString());
                item.SubItems.Add((student.english).ToString());
                item.SubItems.Add((student.math).ToString());
                item.SubItems.Add((student.total).ToString());
                item.SubItems.Add((student.avg).ToString("F1"));
                item.SubItems.Add((student.highsub).ToString());
                item.SubItems.Add((student.lowsub).ToString());
                lvstudent_score.Items.Add(item);
            }
        }

        private void btnrandom_Click(object sender, EventArgs e)
        {
            RandomStudent();
            refreshview(student_Scores);
        }
        Random student = new Random();
        public void RandomStudent()
        {
            
            chinese = student.Next(0,100);
            english = student.Next(0, 100);
            math = student.Next(0, 100);
            total = chinese + english + math;
            avg = total / 3f;

            Dictionary<string, int> score = new Dictionary<string, int>();
            score.Add("國文", chinese);
            score.Add("英文", english);
            score.Add("數學", math);

            int maxscore = -1;
            string maxsubject = "";
            foreach (var item in score)
            {
                if (item.Value > maxscore)
                {
                    maxscore = item.Value;
                    maxsubject = item.Key;
                }
            }

            int minscore = 101;
            string minsubject = "";
            foreach (var item in score)
            {
                if (item.Value < minscore)
                {
                    minscore = item.Value;
                    minsubject = item.Key;
                }
            }

            highsub = $"{maxsubject}{maxscore}";
            lowsub = $"{minsubject}{minscore}";

            name = ((student_Scores.Count)+1).ToString();
            student_score stu = new student_score(name, chinese, english, math, total, avg, highsub, lowsub);
            student_Scores.Add(stu);
            btn_Statistics.Enabled = true;

        }

        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            List<int> chinese = new List<int>();
            List<int> english = new List<int>();
            List<int> math = new List<int>();
            foreach (student_score student in student_Scores)
            {
                chinese.Add(student.chinese);
                english.Add(student.english);
                math.Add(student.math);
            }

            int max_chinese = chinese.Max();
            int min_chinese = chinese.Min();
            double avg_chinese = chinese.Average();
            int sum_chinese = chinese.Sum();

            int min_english = english.Min();
            int max_english = english.Max();
            double avg_english = english.Average();
            int sum_english = english.Sum();


            int min_math = math.Min();
            int max_math = math.Max();
            double avg_math = math.Average();
            int sum_math = math.Sum();

            lt_Statistics.Items.Add($"總分        {sum_chinese}        {sum_english}        {sum_math}");
            lt_Statistics.Items.Add($"平均       {avg_chinese:F1}       {avg_english:F1}       {avg_math:F1}");
            lt_Statistics.Items.Add($"最高分       {max_chinese}       {max_english}       {max_math}");
            lt_Statistics.Items.Add($"最低分       {min_chinese}       {min_english}       {min_math}");

            btnAddStudent.Enabled = false;
            btn_Statistics.Enabled = false;
            btnrandom.Enabled = false;
            btnrandom20.Enabled = false;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            btnrandom.Enabled = true;
            btnrandom20.Enabled = true;
            btnAddStudent.Enabled = true;
            btn_Statistics.Enabled = false;
            lvstudent_score.Items.Clear();
            lt_Statistics.Items.Clear();
            student_Scores.Clear();
        }

        private void btnrandom20_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                RandomStudent();
            }
            refreshview(student_Scores);
        }
    }
}
