using HomePage.ScreenSavers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btn0703_Hello_Click(object sender, EventArgs e)
        {
            Hello openhelleform = new Hello();
            openhelleform.Show();
        }

        private void btnloan_Click(object sender, EventArgs e)
        {
            loan open = new loan();
            open.Show();
        }

        private void btnpos_Click(object sender, EventArgs e)
        {
            Pos open = new Pos();
            open.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentScore open = new StudentScore();
            open.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OXGame open = new OXGame();
            open.Show();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            GuessNumber open = new GuessNumber();
            open.Show();
        }

        private void btnStudentGradeList_Click(object sender, EventArgs e)
        {
            StudentGrade_List open = new StudentGrade_List();
            open.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentGrade open = new StudentGrade();
            open.Show();
        }

        private void btnForDoWhile_Click(object sender, EventArgs e)
        {
            ForDoWhile open = new ForDoWhile();
            open.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Paint open = new Paint();
            open.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ScreenSaver().Show();
        }
    }
}
