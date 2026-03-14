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
    public partial class loan : Form
    {
        public loan()
        {
            InitializeComponent();
        }

        private void btnpmt_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(txtloan.Text);
            int year = Convert.ToInt32(txtterm.Text);
            float r = Convert.ToSingle(txtrate.Text);
            int initial = Convert.ToInt32(txtinitial.Text);
            int month = year * 12;
            float pay = (p - initial) * r / 12 / 100 * (float)Math.Pow(1 + r / 12 / 100, month) / ((float)Math.Pow(1 + r / 12 / 100, month) - 1);
            int monthpay = (int)pay;
            MessageBox.Show($"月付額: {monthpay}");
        }

        private void bnttotal_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(txtloan.Text);
            int year = Convert.ToInt32(txtterm.Text);
            float r = Convert.ToSingle(txtrate.Text);
            int initial = Convert.ToInt32(txtinitial.Text);
            int month = year * 12;
            float pay = (p - initial) * r / 12 / 100 * (float)Math.Pow(1 + r / 12 / 100, month) / ((float)Math.Pow(1 + r / 12 / 100, month) - 1);
            int monthpay = (int)pay;
            int totalpay = monthpay * month;
            MessageBox.Show($"總付款: {totalpay}");
        }

        private void bntreport_Click(object sender, EventArgs e)
        {
            int loan = Convert.ToInt32(txtloan.Text);
            int term = Convert.ToInt32(txtterm.Text);
            int rate = Convert.ToInt32(txtrate.Text);
            int initial = Convert.ToInt32(txtinitial.Text);
            int year = Convert.ToInt32(txtterm.Text);
            int month = year * 12;
            int monthpay = (int)((loan - initial) * rate / 12 / 100 * (float)Math.Pow(1 + rate / 12 / 100, term * 12) / ((float)Math.Pow(1 + rate / 12 / 100, term * 12) - 1));
            int totalpay = monthpay * month;

            LoanReport open = new LoanReport(loan, term, rate, monthpay, totalpay);
            open.Show();
        }
    }
}
