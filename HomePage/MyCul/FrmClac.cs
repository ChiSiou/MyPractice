using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage.MyCul
{
    public partial class FrmClac : Form
    {
        public FrmClac()
        {
            InitializeComponent();
        }
         float num1;
        float num2;
        string answer;


        private void btnplus_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtnum1.Text);
            num2 = int.Parse(txtnum2.Text);
            answer = (num1 + num2).ToString();
            txtanswer.Text = answer;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtnum1.Text);
            num2 = int.Parse(txtnum2.Text);
            answer = (num1 - num2).ToString();
            txtanswer.Text = answer;

        }

        private void btbtime_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtnum1.Text);
            num2 = int.Parse(txtnum2.Text);
            answer = (num1 * num2).ToString();
            txtanswer.Text = answer;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtnum1.Text);
            num2 = float.Parse(txtnum2.Text);
            if (num1 == 0 && num2 == 0)
            {
                txtanswer.Text = "無解";
            }
            else if(num2 == 0)
            {
                txtanswer.Text = "∞";
            }
            else if (num1 == 0)
            {
                txtanswer.Text = "0";
            }
            else
            {
                txtanswer.Text = (num1 / num2).ToString();
            }
        }
    }
}
