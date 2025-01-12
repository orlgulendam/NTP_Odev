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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        string sira = "X";
        string[] Dz = new string[25];
        private void button1_Click(object sender, EventArgs e)
        {

            Button tiklanilanButon = (Button)sender;
            string butonNo = tiklanilanButon.Tag.ToString();
            int srN = int.Parse(butonNo);
            //MessageBox.Show(butonNo + ". Butona Tıklandı");
            if (tiklanilanButon.Text == "")
            {
                tiklanilanButon.Text = sira;
                Dz[srN] = sira;
                string kazanan = "";

                if (Dz[0] == sira && Dz[1] == sira && Dz[2] == sira) kazanan = sira;
                if (Dz[3] == sira && Dz[4] == sira && Dz[5] == sira) kazanan = sira;
                if (Dz[6] == sira && Dz[7] == sira && Dz[8] == sira) kazanan = sira;
                if (Dz[0] == sira && Dz[3] == sira && Dz[6] == sira) kazanan = sira;
                if (Dz[1] == sira && Dz[4] == sira && Dz[7] == sira) kazanan = sira;
                if (Dz[2] == sira && Dz[5] == sira && Dz[8] == sira) kazanan = sira;
                if (Dz[0] == sira && Dz[4] == sira && Dz[8] == sira) kazanan = sira;
                if (Dz[2] == sira && Dz[4] == sira && Dz[6] == sira) kazanan = sira;

                if (kazanan == sira)
                {
                    DialogResult cevap = MessageBox.Show(sira + " Kazandı \n\r Tekrar Oynamak İster misiniz?", "Oyun Bitti!", MessageBoxButtons.YesNo);
                    if (cevap == DialogResult.Yes) { Application.Restart(); } else { Application.Exit(); }
                }
                else if (Array.IndexOf(Dz, "") == -1)
                {
                    DialogResult cevap = MessageBox.Show("Kazanamadın hıyar! \n\r Tekrar Oynamak İster misiniz?", "Oyun Bitti", MessageBoxButtons.YesNo);
                    if (cevap == DialogResult.Yes) { Application.Restart(); } else { Application.Exit(); }
                }

                if (sira == "X") sira = "O";
                else sira = "X";
            }

        }
    }
}
