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
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void btnsayhello_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string ename = txtenglishname.Text;
            string gender = txtgender.Text;
            string zodiac = txtzodiac.Text;
            MessageBox.Show($"Hello! 我是{name}, 英文名子是{ename},性別為{gender},星座是{zodiac},很高興認識你");
        }

        private void btnsayhi_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string ename = txtenglishname.Text;
            string gender = txtgender.Text;
            string zodiac = txtzodiac.Text;
            MessageBox.Show($"HI! 我是{name}, 英文名子是{ename},性別為{gender},星座是{zodiac},很高興認識你");
        }
    }
}
