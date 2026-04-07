using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static HomePage.StudentGrade_List;

namespace HomePage
{
    public partial class StudentGrade_List : Form
    {
        
        public StudentGrade_List()
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

                Dictionary <string, int> score = new Dictionary<string, int>();
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

                student_score stu = new student_score(name, chinese, english, math, total, avg, highsub, lowsub);
                student_Scores.Add(stu);

                refreshview(student_Scores);

            }
            catch
            {
                MessageBox.Show("請填入正確資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
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

                student_score stu = new student_score(name, chinese, english, math, total, avg, highsub, lowsub);
                student_Scores.Add(stu);

                ListViewItem student_score = new ListViewItem(name);
                student_score.SubItems.Add((chinese).ToString());
                student_score.SubItems.Add((english).ToString());
                student_score.SubItems.Add((math).ToString());
                student_score.SubItems.Add((total).ToString());
                student_score.SubItems.Add((avg).ToString());
                student_score.SubItems.Add((highsub).ToString());
                student_score.SubItems.Add((lowsub).ToString());
                lvstudent_score.Items.Insert(0,student_score);

            }
            catch
            {
                MessageBox.Show("請填入正確資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lvstudent_score.Items.Clear();
            lt_Statistics.Items.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lvstudent_score.Items.RemoveAt(0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int lowscore = int.Parse(txtlow.Text);
                int highscore = int.Parse(txthigh.Text);
 
                List<student_score> Backup = new List<student_score>();

                foreach(student_score student in student_Scores)
                {
                    if (student.chinese >= lowscore && student.chinese <= highscore)
                    {
                        Backup.Add(student);
                    }
                }
                refreshview(Backup);
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

        public void refreshview(List <student_score> ToDisplay)
        {
            lvstudent_score.Items.Clear();
            foreach(student_score student in ToDisplay)
            {
                ListViewItem item = new ListViewItem(student.name);
                item.SubItems.Add((student.chinese).ToString());
                item.SubItems.Add((student.english).ToString());
                item.SubItems.Add((student.math).ToString());
                item.SubItems.Add((student.total).ToString());
                item.SubItems.Add((student.avg).ToString());
                item.SubItems.Add((student.highsub).ToString());
                item.SubItems.Add((student.lowsub).ToString());
                lvstudent_score.Items.Add(item);
            }
        }

        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            List<int> chinese = new List<int>();
            List<int> english = new List<int>();
            List <int> math = new List<int>();
            foreach(student_score student in student_Scores)
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
            lt_Statistics.Items.Add($"平均        {avg_chinese:F1}        {avg_english:F1}        {avg_math:F1}");
            lt_Statistics.Items.Add($"最高分       {max_chinese}       {max_english}       {max_math}");
            lt_Statistics.Items.Add($"最低分       {min_chinese}       {min_english}       {min_math}");
        }
    }
}
