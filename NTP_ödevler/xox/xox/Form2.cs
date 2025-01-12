using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xox
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void xoxtiklama(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (lblXO.Text == "x")
            {
                bt.Text = "X";
                bt.Enabled = false;
                lblXO.Text = "o";
            }
            else
            {
                bt.Text = "O";
                bt.Enabled = false;
                lblXO.Text = "x";
            }
            kontrol();
        }
        private void kontrol()
        {
            if (bt1.Text == "X" && bt2.Text == "X" && bt3.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }

            if (bt4.Text == "X" && bt5.Text == "X" && bt6.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }

            if (bt7.Text == "X" && bt8.Text == "X" && bt9.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }

            if (bt1.Text == "X" && bt4.Text == "X" && bt7.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }

            if (bt2.Text == "X" && bt5.Text == "X" && bt8.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }

            if (bt3.Text == "X" && bt6.Text == "X" && bt9.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }

            if (bt1.Text == "X" && bt5.Text == "X" && bt9.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }

            if (bt3.Text == "X" && bt5.Text == "X" && bt7.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }

            if (bt1.Text == "O" && bt2.Text == "O" && bt3.Text == "O")
            {
                MessageBox.Show("O KAZANDI");
                yeniOyun();
            }

            if (bt4.Text == "O" && bt5.Text == "O" && bt6.Text == "O")
            {
                MessageBox.Show("O KAZANDI");
                yeniOyun();
            }

            if (bt7.Text == "O" && bt8.Text == "O" && bt9.Text == "O")
            {
                MessageBox.Show("O KAZANDI");
                yeniOyun();
            }

            if (bt1.Text == "O" && bt4.Text == "O" && bt7.Text == "O")
            {
                MessageBox.Show("O KAZANDI");
                yeniOyun();
            }

            if (bt2.Text == "O" && bt5.Text == "O" && bt8.Text == "O")
            {
                MessageBox.Show("O KAZANDI");
                yeniOyun();
            }

            if (bt3.Text == "O" && bt6.Text == "O" && bt9.Text == "O")
            {
                MessageBox.Show("O KAZANDI");
                yeniOyun();
            }

            if (bt1.Text == "O" && bt5.Text == "O" && bt9.Text == "O")
            {
                MessageBox.Show("O KAZANDI");
                yeniOyun();
            }

            if (bt3.Text == "O" && bt5.Text == "O" && bt7.Text == "O")
            {
                MessageBox.Show("O KAZANDI");
                yeniOyun();
            }

            else if (bt1.Text != "" && bt2.Text != "" && bt3.Text != "" && bt4.Text != "" && bt5.Text != "" && bt6.Text != "" && bt7.Text != "" && bt8.Text != "" && bt9.Text != "")
            {
                MessageBox.Show("KAZANAN YOK");
                yeniOyun();
            }
        }
        private void yeniOyun()
        {
            lblXO.Text = "X";
            bt1.Text = "";
            bt2.Text = "";
            bt3.Text = "";
            bt4.Text = "";
            bt5.Text = "";
            bt6.Text = "";
            bt7.Text = "";
            bt8.Text = "";
            bt9.Text = "";
            bt1.Enabled = true;
            bt2.Enabled = true;
            bt3.Enabled = true;
            bt4.Enabled = true;
            bt5.Enabled = true;
            bt6.Enabled = true;
            bt7.Enabled = true;
            bt8.Enabled = true;
            bt9.Enabled = true;
        }
    }
}
