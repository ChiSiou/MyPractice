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
    public partial class LoanReport : Form
    {
        public LoanReport(int loan, int year, int rate, int monthpay, int total)
        {
            InitializeComponent();
            lbloan.Text = $"{loan}";
            lbterm.Text = $"{year}";
            lbrate.Text = $"{rate}";
            lbmonthpay.Text = $"{monthpay}";
            lbtotal.Text = $"{total}";
        }
    }
}
