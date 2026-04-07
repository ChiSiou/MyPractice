using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class OXGame : Form
    {
        string[,] OX = new string[3, 3];
        int countstep = 0;

        public OXGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (countstep == 0 || (countstep % 2 ==0))
            {
                btn00.Text = "X";
            }
            else
            {
                btn00.Text = "O";
            }
            OX[0,0] = btn00.Text;
            countstep++;
            if (countstep < 9)
            {
                checkwin(OX);
            }
            else
            {
                MessageBox.Show($"這局平手");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (countstep == 0 || (countstep % 2 == 0))
            {
                btn01.Text = "X";
            }
            else
            {
                btn01.Text = "O";
            }
            OX[0, 1] = btn01.Text;
            countstep++;
            if (countstep < 9)
            {
                checkwin(OX);
            }
            else
            {
                MessageBox.Show($"這局平手");
            }
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            if (countstep == 0 || (countstep % 2 == 0))
            {
                btn02.Text = "X";
            }
            else
            {
                btn02.Text = "O";
            }
            OX[0, 2] = btn02.Text;
            countstep++;
            if (countstep < 9)
            {
                checkwin(OX);
            }
            else
            {
                MessageBox.Show($"這局平手");
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (countstep == 0 || (countstep % 2 == 0))
            {
                btn10.Text = "X";
            }
            else
            {
                btn10.Text = "O";
            }
            OX[1, 0] = btn10.Text;
            countstep++;
            if (countstep < 9)
            {
                checkwin(OX);
            }
            else
            {
                MessageBox.Show($"這局平手");
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (countstep == 0 || (countstep % 2 == 0))
            {
                btn11.Text = "X";
            }
            else
            {
                btn11.Text = "O";
            }
            OX[1, 1] = btn11.Text;
            countstep++;
            if (countstep < 9)
            {
                checkwin(OX);
            }
            else
            {
                MessageBox.Show($"這局平手");
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (countstep == 0 || (countstep % 2 == 0))
            {
                btn12.Text = "X";
            }
            else
            {
                btn12.Text = "O";
            }
            OX[1, 2] = btn12.Text;
            countstep++;
            if (countstep < 9)
            {
                checkwin(OX);
            }
            else
            {
                MessageBox.Show($"這局平手");
            }
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            if (countstep == 0 || (countstep % 2 == 0))
            {
                btn20.Text = "X";
            }
            else
            {
                btn20.Text = "O";
            }
            OX[2, 0] = btn20.Text;
            countstep++;
            if (countstep < 9)
            {
                checkwin(OX);
            }
            else
            {
                MessageBox.Show($"這局平手");
            }
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (countstep == 0 || (countstep % 2 == 0))
            {
                btn21.Text = "X";
            }
            else
            {
                btn21.Text = "O";
            }
            OX[2, 1] = btn21.Text;
            countstep++;
            if (countstep < 9)
            {
                checkwin(OX);
            }
            else
            {
                MessageBox.Show($"這局平手");
            }
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (countstep == 0 || (countstep % 2 == 0))
            {
                btn22.Text = "X";
            }
            else
            {
                btn22.Text = "O";
            }
            OX[2, 2] = btn22.Text;
            countstep++;
            if (countstep < 9)
            {
                checkwin(OX);
            }
            else
            {
                MessageBox.Show($"這局平手");
            }

        }
        private void checkwin(string[,] OX)
        {
            for (int i = 0; i < 3; i++)
            {
                if (!string.IsNullOrEmpty(OX[i, 0]) && OX[i, 0] == OX[i, 1] && OX[i, 1] == OX[i, 2])
                {
                    MessageBox.Show($"勝利者為 :{OX[i, 0]}"); 
                    return;
                }
                else if (!string.IsNullOrEmpty(OX[0, i]) && OX[0,i] == OX[1,i] && OX[1,i] == OX[2,i])
                {
                    MessageBox.Show($"勝利者為 :{OX[0, i]}");
                    return;
                }
                else if (!string.IsNullOrEmpty(OX[1,1]))
                {
                    if ((OX[0, 0] == OX[1, 1] && OX[1, 1] == OX[2, 2]) ||(OX[0, 2] == OX[1, 1] && OX[1, 1] == OX[2, 0]))
                    {
                        MessageBox.Show($"勝利者為 :{OX[1, 1]}");
                        return;
                    }
                }
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            OX = new string[3,3];
            countstep = 0;
            foreach(Control c in this.Controls)
            {
                if (c is Button && (c.Name != "btnreset" || c.Name != "btnexit"))
                {
                    c.Text = "";
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OXGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                btnreset_Click( sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnexit_Click( sender, e);
            }
        }
    }
}
