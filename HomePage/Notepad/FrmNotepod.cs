using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage.Notepad
{
    public partial class FrmNotepod : Form
    {
        public FrmNotepod()
        {
            InitializeComponent();
        }
        private string currentFilePath = "";
        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opfile = new OpenFileDialog())
            {
                opfile.Filter = "文字檔(*.txt)|*.txt|所有檔案(*.*)|*.*";
                opfile.ValidateNames = true;
                if (opfile.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Text = File.ReadAllText(opfile.FileName, Encoding.UTF8);
                    currentFilePath = opfile.FileName;
                }
            }
        }

        private void 存檔SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                File.WriteAllText(currentFilePath, richTextBox1.Text, Encoding.UTF8);
            }
            else
            {
                using (SaveFileDialog savefile = new SaveFileDialog())
                {
                    savefile.Filter = "文字檔(*.txt)|*.txt|所有檔案(*.*)|*.*";
                    savefile.ValidateNames = true;
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(savefile.FileName, richTextBox1.Text, Encoding.UTF8);
                        currentFilePath = savefile.FileName;
                    }

                }
            }
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                using (SaveFileDialog savefile = new SaveFileDialog())
                {
                    savefile.Filter = "文字檔(*.txt)|*.txt|所有檔案(*.*)|*.*";
                    savefile.ValidateNames = true;
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(savefile.FileName, richTextBox1.Text, Encoding.UTF8);
                        currentFilePath = savefile.FileName;
                    }
                }
            }
            else
            {
                MessageBox.Show("沒有內容可供另存新檔", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 復原UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void 取消復原RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void 剪下XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void 字型VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void toUpperUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToUpper();
        }

        private void toLowerLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToLower();    
        }

        private void 字型換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = !richTextBox1.WordWrap;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;   
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Black;  
        }
    }
}
