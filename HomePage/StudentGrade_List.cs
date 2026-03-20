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

                int maxscore = score.Values.Max();
                string maxsubject = score.Keys.Max();
                int minscore = score.Values.Min();
                string minsubject = score.Keys.Min();

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
                lvstudent_score.Items.Add(student_score);

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

                int maxscore = score.Values.Max();
                string maxsubject = score.Keys.Max();
                int minscore = score.Values.Min();
                string minsubject = score.Keys.Min();

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
                foreach( ListViewItem item in lvstudent_score.Items)
                {
                    if (!(int.Parse(item.SubItems[1].Text) >= lowscore && int.Parse(item.SubItems[1].Text) <= highscore))
                    {
                        item.Remove();
                    }
                }

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
    }
}
