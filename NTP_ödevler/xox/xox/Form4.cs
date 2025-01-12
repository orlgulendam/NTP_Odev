using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xox
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void xoxtıklama(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (label1.Text == "x")
            {
                bt.Text = "X";
                bt.Enabled = false;
                label1.Text = "o";
            }
            else
            {
                bt.Text = "O";
                bt.Enabled = false;
                label1.Text = "x";
            }
            kontrol();
        }
        private void kontrol()
        {
            if (bt1.Text == "X" && bt2.Text == "X" && bt3.Text == "X" && bt4.Text == "X" && bt5.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }

            if ( bt6.Text == "X" && bt7.Text == "X" && bt8.Text == "X" && bt9.Text == "X" && bt10.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }

            if (bt11.Text == "X" && bt12.Text == "X" && bt13.Text == "X" && bt14.Text == "X" && bt15.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }

            if (bt16.Text == "X" && bt17.Text == "X" && bt18.Text == "X" && bt19.Text == "X" && bt20.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }

            if (bt21.Text == "X" && bt22.Text == "X" && bt23.Text == "X" && bt24.Text == "X" && bt25.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }

            if (bt1.Text == "X" && bt7.Text == "X" && bt13.Text == "X" && bt17.Text == "X" && bt25.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }

            if (bt5.Text == "X" && bt9.Text == "X" && bt13.Text == "X" && bt17.Text == "X" && bt21.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }

            if (bt1.Text == "X" && bt6.Text == "X" && bt11.Text == "X" && bt16.Text == "X" && bt21.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }
            if (bt2.Text == "X" && bt7.Text == "X" && bt12.Text == "X" && bt17.Text == "X" && bt22.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }
            if (bt3.Text == "X" && bt8.Text == "X" && bt13.Text == "X" && bt18.Text == "X" && bt23.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }
            if (bt4.Text == "X" && bt9.Text == "X" && bt14.Text == "X" && bt19.Text == "X" && bt24.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }
            if (bt5.Text == "X" && bt10.Text == "X" && bt15.Text == "X" && bt20.Text == "X" && bt25.Text == "X")
            {
                MessageBox.Show("X KAZANDI");
                yeniOyun();
            }

            if (bt1.Text == "O" && bt2.Text == "O" && bt3.Text == "O" && bt4.Text == "O" && bt5.Text == "X")
            {
                MessageBox.Show("O KAZANDI");
                yeniOyun();
            }

            if (bt6.Text == "O" && bt7.Text == "O" && bt8.Text == "O" && bt9.Text == "O" && bt10.Text == "O")
            {
                MessageBox.Show("O KAZANDI");
                yeniOyun();
            }

            if (bt11.Text == "O" && bt12.Text == "X" && bt13.Text == "X" && bt14.Text == "X" && bt15.Text == "O")
            {
                MessageBox.Show("O KAZANDI");
                yeniOyun();
            }

            if (bt16.Text == "O" && bt17.Text == "X" && bt18.Text == "X" && bt19.Text == "X" && bt20.Text == "O")
            {
                MessageBox.Show("O KAZANDI");
                yeniOyun();
            }

            if (bt21.Text == "O" && bt22.Text == "O" && bt23.Text == "O" && bt24.Text == "O" && bt25.Text == "O")
            {
                MessageBox.Show("O KAZANDI");
                yeniOyun();
            }

            if (bt1.Text == "O" && bt7.Text == "O" && bt13.Text == "O" && bt17.Text == "O" && bt25.Text == "O")
            {
                MessageBox.Show("O KAZANDI");
                yeniOyun();
            }

            if (bt5.Text == "O" && bt9.Text == "O" && bt13.Text == "O" && bt17.Text == "O" && bt21.Text == "O")
            {
                MessageBox.Show("O KAZANDI");
                yeniOyun();
            }

            if (bt1.Text == "O" && bt6.Text == "O" && bt11.Text == "O" && bt16.Text == "O" && bt21.Text == "O")
            {
                MessageBox.Show("O KAZANDI");
                yeniOyun();
            }
            if (bt2.Text == "O" && bt7.Text == "O" && bt12.Text == "O" && bt17.Text == "O" && bt22.Text == "O")
            {
                MessageBox.Show("O KAZANDI");
                yeniOyun();
            }
            if (bt3.Text == "O" && bt8.Text == "O" && bt13.Text == "O" && bt18.Text == "O" && bt23.Text == "O")
            {
                MessageBox.Show("O KAZANDI");
                yeniOyun();
            }
            if (bt4.Text == "O" && bt9.Text == "O" && bt14.Text == "O" && bt19.Text == "O" && bt24.Text == "O")
            {
                MessageBox.Show("O KAZANDI");
                yeniOyun();
            }
            if (bt5.Text == "O" && bt10.Text == "O" && bt15.Text == "O" && bt20.Text == "O" && bt25.Text == "O")
            {
                MessageBox.Show(" O KAZANDI");
                yeniOyun();
            }

            else if (bt1.Text != "" && 
                bt2.Text != "" && 
                bt3.Text != "" && 
                bt4.Text != "" &&
                bt5.Text != "" &&
                bt6.Text != "" &&
                bt7.Text != "" &&
                bt8.Text != "" &&
                bt9.Text != "" &&
                bt10.Text != "" &&
                bt11.Text != "" &&
            bt12.Text != "" &&
            bt13.Text != "" &&
            bt14.Text != "" &&
            bt15.Text != "" &&
            bt16.Text != "" &&
            bt17.Text != "" &&
            bt18.Text != "" &&
            bt19.Text != "" &&
            bt20.Text != "" &&
            bt21.Text != "" &&
            bt22.Text != "" &&
            bt23.Text != "" &&
            bt24.Text != "" &&
            bt25.Text != "")
            {
                MessageBox.Show("KAZANAN YOK");
                yeniOyun();
            }
        }
        private void yeniOyun()
        {
            label1.Text = "X";
            bt1.Text = "";
            bt2.Text = "";
            bt3.Text = "";
            bt4.Text = "";
            bt5.Text = "";
            bt6.Text = "";
            bt7.Text = "";
            bt8.Text = "";
            bt9.Text = "";
            bt10.Text = "";
            bt11.Text = "";
            bt12.Text = "";
            bt13.Text = "";
            bt14.Text = "";
            bt15.Text = "";
            bt16.Text = "";
            bt17.Text = "";
            bt18.Text = "";
            bt19.Text = "";
            bt20.Text = "";
            bt21.Text = "";
            bt22.Text = "";
            bt23.Text = "";
            bt24.Text = "";
            bt25.Text = "";
            bt1.Enabled = true;
            bt2.Enabled = true;
            bt3.Enabled = true;
            bt4.Enabled = true;
            bt5.Enabled = true;
            bt6.Enabled = true;
            bt7.Enabled = true;
            bt8.Enabled = true;
            bt9.Enabled = true;
            bt10.Enabled = true;
            bt11.Enabled = true;
            bt12.Enabled = true;
            bt13.Enabled = true;
            bt14.Enabled = true;
            bt15.Enabled = true;
            bt16.Enabled = true;
            bt17.Enabled = true;
            bt18.Enabled = true;
            bt19.Enabled = true;
            bt20.Enabled = true;
            bt21.Enabled = true;
            bt22.Enabled = true;
            bt23.Enabled = true;
            bt24.Enabled = true;
            bt25.Enabled = true;
        }
    }
}
