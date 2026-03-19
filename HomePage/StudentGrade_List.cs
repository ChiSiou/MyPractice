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
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                chinese = int.Parse(txtChinese.Text);
                english = int.Parse(txtEnglish.Text);
                math = int.Parse(txtMath.Text);
                total = chinese + english + math;
                avg = total / 3f;
            }
            catch
            {
                MessageBox.Show("請填入正確資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
