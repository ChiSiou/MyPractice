using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class ForDoWhile : Form
    {
        public ForDoWhile()
        {
            InitializeComponent();
        }
        int[] arr0711 = new int[] {1,5, 6, 8, 7, 97, 54, 887, 65, 578};
        string[] arr0711_Str = new string[]
        {
            "mother張",
            "emma",
            "迪克蕭",
            "j40",
            "Candy",
            "Cindy",
            "Coconut",
            "Motherfacker"
        };
        int from_txt ;
        int to_txt ;
        int step_txt ;

        
        private void btnCheckOddEven_Click(object sender, EventArgs e)
        {
            bool Is_Even = false;
            int num = 0;
            bool Is_num= int.TryParse(txtOddEven.Text, out num);
            string result = "";
            if (Is_num)
            {
                Is_Even= CheckEven(num);
                if (Is_Even)
                {
                    result = $"輸入的數: {num} 為偶數";
                }
                else
                {
                    result = $"輸入的數: {num} 為奇數";
                }
                lbresult.Visible = true;
                lbresult.Text = result;
            }
            else
            {
                MessageBox.Show("請輸入正確數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool CheckEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }

        private void btnarr0711OddEven_Click(object sender, EventArgs e)
        {
            int even_count = 0;
            int odd_count = 0;
            foreach (int item in arr0711)
            {
                if (CheckEven(item))
                {
                    even_count ++;
                }
                else
                {
                    odd_count ++;
                }
            }
            lbresult.Text = $"int陣列arr0711 [1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n奇數共 {odd_count}" +
                $"\n偶數共 {even_count}";
            lbresult.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            int big_L = arr0711_Str[0].Length;
            for (int i = 0; i < arr0711_Str.Length; i++)
            {
                if(big_L < arr0711_Str[i].Length);
                {
                    big_L = arr0711_Str[i].Length;
                    index = i;
                }
            }
            lbresult.Visible = true ;
            lbresult.Text = $"陣列arr0711_Str [mother張, emma, 迪克蕭, j40, Candy, Cindy, Coconut, Motherfacker]\n" +
                $"最長名子為{arr0711_Str[index]}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < arr0711_Str.Length; i++)
            {
                string name = arr0711_Str[i].ToLower();
                if(name.Contains('c'))
                {
                    count ++;
                }
            }
            lbresult.Visible = true;
            lbresult.Text = $"陣列arr0711_Str [mother張, emma, 迪克蕭, j40, Candy, Cindy, Coconut, Motherfacker]\n" +
                $"有 C 和 c 的名子共 {count} 個";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            List<int> lott = new List<int>();
            string result = "";

            while(lott.Count < 6)
            {
                int num = rd.Next(0,51);
                if (!(lott.Contains(num)))
                {
                    lott.Add(num);
                }
            }
            foreach (int num in lott)
            {
                result += $"{num} ";
            }

            lbresult.Visible = true;
            lbresult.Text = $"樂透號碼:\n{result}";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string result = "";
            result = Convert.ToString(100,2);
            lbresult.Visible = true;
            lbresult.Text = $"{result}";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    sb.Append($"{j} x {i} = {j * i, 2} |  ");
                }
                sb.AppendLine();
            }
            lbresult.Visible = true;
            lbresult.Text= sb.ToString();
        }

        private int Pick_big(int[] arr0711)
        {
            int big = arr0711[0];
            foreach (int item in arr0711)
            {
                if (item > big)
                {
                    big = item;
                }
            }
            return big;
        }
        private int Pick_small(int[] arr0711)
        {
            int small = arr0711[0];
            foreach (int item in arr0711)
            {
                if (item < small)
                {
                    small = item;
                }
            }
            return small;
        }
        private int Sum_arr(int[] arr0711)
        {
            int sum = 0;
            foreach (int item in arr0711)
            {
                sum += item;
            }
            return sum;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = Pick_big(arr0711);
            lbresult.Visible = true;
            lbresult.Text = $"int陣列arr0711 [1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n最大值為{num}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = Pick_small(arr0711);
            lbresult.Visible = true;
            lbresult.Text = $"int陣列arr0711 [1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n最小值為{num}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num = Sum_arr(arr0711);
            lbresult.Visible = true;
            lbresult.Text = $"int陣列arr0711 [1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n加總為{num}";
        }
        private void Swap(ref int X, ref int Y)
        {
            int Z = 0;
            Z = X;
            X = Y;
            Y = Z;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int n1 = 100;
            int n2 = 200;
            string before = $"換位前 n1 = {n1} n2 = {n2}";
            Swap(ref n1, ref n2);
            string after = $"換位前 n1 = {n1} n2 = {n2}";
            lbresult.Visible = true;
            lbresult.Text = $"{before}\n{after}";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int big = Pick_big(arr0711);
            int small = Pick_small(arr0711);
            lbresult.Visible = true;
            lbresult.Text = $"int陣列arr0711 [1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n最小值為{small}\n最大值為{big}";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            from_txt = int.Parse(txtFrom.Text);
            to_txt = int.Parse(txtTo.Text);
            step_txt = int.Parse(txtStep.Text);

            int sum = 0;

            if (from_txt > to_txt)
            {
                sum = 0;
            }
            else
            {
                for (int i = from_txt; i <= to_txt; i += step_txt)
                {
                    sum += i;
                }
            }
            
            lbresult.Visible = true;
            lbresult.Text = $"{from_txt} 到 {to_txt} 相隔 {step_txt -1}\n加總為 {sum}";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            from_txt = int.Parse(txtFrom.Text);
            to_txt = int.Parse(txtTo.Text);
            step_txt = int.Parse(txtStep.Text);
            List<int> list = new List<int>();
            int num_step = from_txt;
            int sum = 0;

            if (from_txt > to_txt)
            {
                sum = 0;
            }
            else
            {
                while (num_step <= to_txt)
                {
                    list.Add(num_step);
                    sum += num_step;
                    num_step += step_txt;
                }
            }
            lbresult.Visible = true;
            lbresult.Text = $"{from_txt} 到 {to_txt} 相隔 {step_txt - 1}\n加總為 {sum}";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            from_txt = int.Parse(txtFrom.Text);
            to_txt = int.Parse(txtTo.Text);
            step_txt = int.Parse(txtStep.Text);
            List<int> list = new List<int>();
            int num_step = from_txt;
            int sum = 0;

            if (from_txt > to_txt)
            {
                sum = 0;
            }
            else
            {
                do
                {
                    list.Add(num_step);
                    sum += num_step;
                    num_step += step_txt;
                }
                while (num_step <= to_txt);
            }
            lbresult.Visible = true;
            lbresult.Text = $"{from_txt} 到 {to_txt} 相隔 {step_txt - 1}\n加總為 {sum}";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int row = int.Parse(txtRow.Text);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    sb.Append("*");
                }
                sb.AppendLine();
            }
            lbresult.Visible = true;
            lbresult.Text = sb.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbresult.Text = string.Empty;
            lbresult.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int[,] arr_1010 = new int[10,10];
            for (int i = 0; i < 10; i++)
            {
               for (int j = 0; j < 10; j++)
                {
                    if (j == 0 || j == 9 || i == 0 || i == 9)
                    {
                        arr_1010[i,j] = 1; 
                    }
                    else
                    {
                        arr_1010[i,j] = 0;
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sb.Append(arr_1010[i, j] + " ");
                }
                sb.AppendLine();
            }
            string result = sb.ToString();
            lbresult.Visible = true;
            lbresult.Text = $"{result}";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int[,] arr_1010 = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j == 0 || j == 9 || i == 0 || i == 9)
                    {
                        arr_1010[i, j] = 0;
                    }
                    else
                    {
                        arr_1010[i, j] = 1;
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sb.Append(arr_1010[i, j] + " ");
                }
                sb.AppendLine();
            }
            string result = sb.ToString();
            lbresult.Visible = true;
            lbresult.Text = $"{result}";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[,] arr_1010 = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i % 2 == j % 2)
                    {
                        arr_1010[i, j] = 1;
                    }
                    else
                    {
                        arr_1010[i, j] = 0;
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sb.Append(arr_1010[i, j] + " ");
                }
                sb.AppendLine();
            }
            string result = sb.ToString();
            lbresult.Visible = true;
            lbresult.Text = $"{result}";
        }
    }
}
