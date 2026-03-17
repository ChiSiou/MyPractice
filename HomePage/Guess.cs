using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class Guess : Form
    {
        private GuessNumber _parentForm;
        public Guess(GuessNumber guessNumber)
        {
            InitializeComponent();
            _parentForm = guessNumber;
            Random random = new Random();
            answer = random.Next(1, 101);
        }
        public static int answer ;
        int big_number = 100;
        int smallest_number = 0;
        private void btnEnterNum_Click(object sender, EventArgs e)
        {
            try
            {
                int GuessNum = int.Parse(txtInputNum.Text);
                if(GuessNum < 1 || GuessNum >99)
                {
                    throw new Exception();
                }
                if (GuessNum == answer)
                {
                    MessageBox.Show($"Congrats, you got {answer} !!!");
                }
                else
                {
                    if (GuessNum < answer)
                    {
                        smallest_number = GuessNum;
                        string result = $"Too Small !\nBetween {GuessNum} and {big_number}";
                        _parentForm.UpdateTxt_GuessNumber(result);
                    }
                    else
                    {
                        big_number = GuessNum;
                        string result = $"Too Big !\nBetween {smallest_number} and {GuessNum}";
                        _parentForm.UpdateTxt_GuessNumber(result);
                    }
                }
            }
            catch
            {
                MessageBox.Show("請輸入0~100之間的數字", "輸入", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
