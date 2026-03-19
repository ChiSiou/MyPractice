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
        string hightsub;
        string lowsub;
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

                hightsub = $"{maxsubject}{maxscore}";
                lowsub = $"{minsubject}{minscore}";

                ListViewItem student_score = new ListViewItem(name);
                student_score.SubItems.Add((chinese).ToString());
                student_score.SubItems.Add((english).ToString());
                student_score.SubItems.Add((math).ToString());
                student_score.SubItems.Add((total).ToString());
                student_score.SubItems.Add((avg).ToString());
                student_score.SubItems.Add((hightsub).ToString());
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

                hightsub = $"{maxsubject}{maxscore}";
                lowsub = $"{minsubject}{minscore}";

                ListViewItem student_score = new ListViewItem(name);
                student_score.SubItems.Add((chinese).ToString());
                student_score.SubItems.Add((english).ToString());
                student_score.SubItems.Add((math).ToString());
                student_score.SubItems.Add((total).ToString());
                student_score.SubItems.Add((avg).ToString());
                student_score.SubItems.Add((hightsub).ToString());
                student_score.SubItems.Add((lowsub).ToString());
                lvstudent_score.Items.Insert(0,student_score);

            }
            catch
            {
                MessageBox.Show("請填入正確資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
