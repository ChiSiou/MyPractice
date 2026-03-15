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
    public partial class Pos : Form
    {
        public Pos()
        {
            InitializeComponent();
        }
        private void btnbeer_Click(object sender, EventArgs e)
        {
            string productName = "啤酒Beer";
            int productPrice = 120;
            bool isExist = false;

            foreach (ListViewItem item in lvbuy.Items)
            {
                if (productName == item.Text)
                {
                    item.SubItems[1].Text = (int.Parse(item.SubItems[1].Text) + 1).ToString();
                    item.SubItems[2].Text = (int.Parse(item.SubItems[1].Text) * productPrice).ToString();
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                ListViewItem itembeer = new ListViewItem(productName);
                itembeer.SubItems.Add("1");
                itembeer.SubItems.Add(productPrice.ToString());
                lvbuy.Items.Add(itembeer);
            }
            int totalprice = 0;
            foreach (ListViewItem item in lvbuy.Items)
            {
                totalprice += int.Parse(item.SubItems[2].Text);
                txttotalprice.Text = $"NT ${totalprice}";
            }
        }

        private void btntequila_Click(object sender, EventArgs e)
        {
            string productName = "龍舌蘭Tequila";
            int productPrice = 180;
            bool isExist = false;
            foreach (ListViewItem item in lvbuy.Items)
            {
                if (item.Text == productName)
                {
                    item.SubItems[1].Text = (int.Parse(item.SubItems[1].Text) + 1).ToString();
                    item.SubItems[2].Text = (int.Parse(item.SubItems[1].Text) * productPrice).ToString();
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                ListViewItem tequila = new ListViewItem(productName);
                tequila.SubItems.Add("1");
                tequila.SubItems.Add((productPrice).ToString());
                lvbuy.Items.Add(tequila);
            }
            int totalprice = 0;
            foreach (ListViewItem item in lvbuy.Items)
            {
                totalprice += int.Parse(item.SubItems[2].Text);
                txttotalprice.Text = $"NT ${totalprice}";
            }
        }

        private void btnwhisky_Click(object sender, EventArgs e)
        {
            string productName = "威士忌Whisky";
            int productPrice = 350;
            bool isExist = false;
            foreach (ListViewItem item in lvbuy.Items)
            {
                if (item.Text == productName)
                {
                    item.SubItems[1].Text = (int.Parse(item.SubItems[1].Text) + 1).ToString();
                    item.SubItems[2].Text = (int.Parse(item.SubItems[1].Text) * productPrice).ToString();
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                ListViewItem whisky = new ListViewItem(productName);
                whisky.SubItems.Add("1");
                whisky.SubItems.Add((productPrice).ToString());
                lvbuy.Items.Add(whisky);
            }
            int totalprice = 0;
            foreach (ListViewItem item in lvbuy.Items)
            {
                totalprice += int.Parse(item.SubItems[2].Text);
                txttotalprice.Text = $"NT ${totalprice}";
            }

        }

        private void btnwine_Click(object sender, EventArgs e)
        {
            string productName = "紅酒Wine";
            int productPrice = 320;
            bool isExist = false;

            foreach (ListViewItem item in lvbuy.Items)
            {
                if (item.Text == productName)
                {
                    item.SubItems[1].Text = (int.Parse(item.SubItems[1].Text) + 1).ToString();
                    item.SubItems[2].Text = (int.Parse(item.SubItems[1].Text) * productPrice).ToString();
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                ListViewItem wine = new ListViewItem(productName);
                wine.SubItems.Add("1");
                wine.SubItems.Add((productPrice).ToString());
                lvbuy.Items.Add(wine);
            }
            int totalprice = 0;
            foreach (ListViewItem item in lvbuy.Items)
            {
                totalprice += int.Parse(item.SubItems[2].Text);
                txttotalprice.Text = $"NT ${totalprice}";
            }
        }

        private void btnpaycash_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"總金額 : { txttotalprice.Text}");
        }

        private void btnpaycredit_Click(object sender, EventArgs e)
        {
            int totalprice = 0;
            foreach (ListViewItem item in lvbuy.Items)
            {
                totalprice += int.Parse(item.SubItems[2].Text);
            }
            int discountprice = (int)(totalprice * 0.9);
            MessageBox.Show($"打折後金額 : NT ${discountprice} (信用卡享9折優惠)");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            lvbuy.Items.Clear();
        }
    }
}
