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
    public partial class GuessNumber : Form
    {
        public GuessNumber()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Guess open = new Guess(this);
            open.ShowDialog();
        }
        public void UpdateTxt_GuessNumber(string NewContent)
        {
            lbshowGuessResult.Text = NewContent;
        }


        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            int answer = Guess.answer;
            MessageBox.Show($"Answer :{answer}");
        }
    }
}
