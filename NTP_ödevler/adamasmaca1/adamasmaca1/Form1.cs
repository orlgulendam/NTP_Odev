using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adamasmaca1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        string kelimee = "";
        List<Label> l = new List<Label>(); int adet = 0;
        enum cizim
        {
            kafa,
            gövde,
            sağ_bacak,
            sol_bacak,
            sağ_el,
            sol_el
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            cizi(e.Graphics);
        }

        void cizi(Graphics t)
        {
            Pen p = new Pen(Color.HotPink, 10);
            t.DrawLine(p, new Point(130, 218), new Point(130, 5));
            t.DrawLine(p, new Point(135, 5), new Point(65, 5));
            t.DrawLine(p, new Point(60, 0), new Point(60, 50));
        }
        void ciz(Graphics g)
        {
            Pen p = new Pen(Color.Purple, 10);
            vucut(g, cizim.kafa);
            vucut(g, cizim.gövde);
            vucut(g, cizim.sol_el);
            vucut(g, cizim.sağ_el);
            vucut(g, cizim.sol_bacak);
            vucut(g, cizim.sağ_bacak);
        }
        void vucut(Graphics g, cizim cz)
        {
            Pen p = new Pen(Color.Fuchsia, 2);
            if (cz == cizim.kafa)
            {
                g.DrawEllipse(p, 40, 50, 40, 40);
            }
            else if (cz == cizim.gövde)
            {
                g.DrawLine(p, new Point(60, 90), new Point(60, 170));
            }
            else if (cz == cizim.sol_el)
            {
                g.DrawLine(p, new Point(60, 100), new Point(30, 85));
            }
            else if (cz == cizim.sağ_el)
            {
                g.DrawLine(p, new Point(60, 100), new Point(90, 85));
            }
            else if (cz == cizim.sol_bacak)
            {
                g.DrawLine(p, new Point(60, 170), new Point(30, 190));
            }
            else if (cz == cizim.sağ_bacak)
            {
                g.DrawLine(p, new Point(60, 170), new Point(90, 190));
            }
        }
        void label()
        {
            kelimee = random_kelime();
            char[] k = kelimee.ToCharArray();
            int s = 330 / k.Length - 1;
            for (int i = 0; i < k.Length; i++)
            {
                l.Add(new Label());
                l[i].Location = new Point((i * s) + 10, 80);
                l[i].Text = "-";
                l[i].Parent = groupBox2;
                l[i].BringToFront();
                l[i].CreateControl();
            }

            label1.Text = "uzunluk:" + k.Length;
        }

        string random_kelime()
        {
            string[] kelime = { "istanbul", "izmir", "eskişehir", "ankara", "adana", "kayseri", "elazığ", "mardin", "diyarbakır" };
            Random a = new Random();
            int s = a.Next(kelime.Length);
            string seçilen_kelime = kelime[s];
            return seçilen_kelime;
        }
        
      
       


        private void button1_Click_1(object sender, EventArgs e)
        {
            char ke = textBox1.Text.ToLower().ToCharArray()[0];
            if (!char.IsLetter(ke))
            {
                MessageBox.Show("sadece harf girniz");
                return;
            }

            if (kelimee.Contains(ke))
            {
                char[] kel = kelimee.ToCharArray();
                for (int i = 0; i < kel.Length; i++)
                {
                    if (kel[i] == ke)
                    {
                        l[i].Text = ke.ToString();
                    }
                }
                foreach (Label t in l)
                    if (t.Text == "-") return;
                MessageBox.Show("kazandın");
            }
            else
            {
                label2.Text += "" + ke.ToString() + ",";

                adet++;
                if (adet <= 6)
                {
                    vucut(panel1.CreateGraphics(), (cizim)(adet - 1));


                }
                else
                {
                    MessageBox.Show("oyun bitti");
                }
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == kelimee)
            {

                MessageBox.Show("kazandın");
            }
            else
            {
                MessageBox.Show("kaybettin");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            panel1.Paint += new PaintEventHandler(panel1_Paint);
            label();
        }
    }
}

 