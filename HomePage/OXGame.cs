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
    public partial class OXGame : Form
    {
        public OXGame()
        {
            InitializeComponent();
            char[][] OX = new char[3][];
            OX[0] = new char[3];
            OX[1] = new char[3];
            OX[2] = new char[3];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn00.Text = "X";
        }
    }
}
