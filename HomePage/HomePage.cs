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
    }
}
