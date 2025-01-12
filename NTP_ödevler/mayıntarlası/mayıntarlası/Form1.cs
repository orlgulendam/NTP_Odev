using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayıntarlası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       // Image mayin_resmi = Image.FromFile(@"mayın.png");
        mayintarlasi mayintarlamiz;
        List<mayın> mayinim;
        private void Form1_Load(object sender, EventArgs e)
        {
            mayintarlamiz = new mayintarlasi(new Size(400, 400),60);
            panel1.Size = mayintarlamiz.buyuklugu;
            mayinekle();
          
        }
        public void mayinekle()
        {
            for (int x = 0; x < panel1.Width; x = x + 20)
            {
                for (int y = 0; y < panel1.Height; y = y + 20)
                {
                    button_ekle(new Point(x, y));
                }
            }
        }
        public void button_ekle(Point loc)
        {
            Button btn = new Button();
            btn.Name = loc.X+"" + loc.Y;
            btn.Size = new Size(20, 20);
            btn.Location = loc;
            btn.Click += new EventHandler(btn_click);
            panel1.Controls.Add(btn);

        }
       public  void btn_click(object sender , EventArgs e)
        {
            Button btn = (sender as Button);
            mayın myn = mayintarlamiz.mayinal(btn.Location);
            mayinim = new List<mayın>();
            if (myn.mayın_varmi)
            {
                MessageBox.Show("kaybettin");
              //  mayingoster();
            }
            else
            {
                int s = Etrafta_kac_mayinvar(myn);
                if (s == 0)
                {
                    mayinim.Add(myn);
                    for (int  i = 0; i < mayinim.Count; i++)
                    {
                        mayın item = mayinim[i];
                        if (item != null)
                        {
                            if (item.bakildimi == false && item.mayın_varmi == false)
                            {
                                Button btnx = (Button)panel1.Controls.Find(item.konumal.X + "" + item.konumal.Y, false)[0];

                                if (Etrafta_kac_mayinvar(mayinim[i]) == 0)
                                {

                                    btnx.Enabled = false;

                                    cevreekle(item);
                                }
                                else
                                {
                                    btnx.Text = Etrafta_kac_mayinvar(item).ToString();
                                }
                                item.bakildimi = true;
                            }
                        }
                    }
                }
                else
                {
                    btn.Text = s.ToString();
                }
            }
        }
        public int Etrafta_kac_mayinvar(mayın m) 
        {
            int sayi=0;
            if (m.konumal.X > 0)
            {
                if (mayintarlamiz.mayinal(new Point(m.konumal.X - 20, m.konumal.Y)).mayın_varmi)
                {
                    sayi++;
                }
            }
            if (m.konumal.X <panel1.Width-20)
            {
                if (mayintarlamiz.mayinal(new Point(m.konumal.X + 20, m.konumal.Y)).mayın_varmi)
                {
                    sayi++;
                }
            }
            if (m.konumal.X >0&&m.konumal.Y>0)
            {
                if (mayintarlamiz.mayinal(new Point(m.konumal.X - 20, m.konumal.Y - 20)).mayın_varmi)
                {
                    sayi++;
                }
            }
            if (m.konumal.Y > 0)
            {
                if (mayintarlamiz.mayinal(new Point(m.konumal.X, m.konumal.Y - 20)).mayın_varmi)
                {
                    sayi++;
                }
            }
            if (m.konumal.Y < panel1.Height-20)
            {
                if (mayintarlamiz.mayinal(new Point(m.konumal.X, m.konumal.Y + 20)).mayın_varmi)
                {
                    sayi++;
                }
            }
            if (m.konumal.Y<panel1.Height-20&&m.konumal.X<panel1.Width-20)
            {
                if (mayintarlamiz.mayinal(new Point(m.konumal.X + 20, m.konumal.Y + 20)).mayın_varmi)
                {
                    sayi++;
                }
            }
            if (m.konumal.X>0 && m.konumal.Y<panel1.Height-20)
            {
                if (mayintarlamiz.mayinal(new Point(m.konumal.X - 20, m.konumal.Y + 20)).mayın_varmi)
                {
                    sayi++;
                }
            }
            if (m.konumal.X > panel1.Width-20&&m.konumal.Y>0)
            {
                if (mayintarlamiz.mayinal(new Point(m.konumal.X + 20, m.konumal.Y - 20)).mayın_varmi)
                {
                    sayi++;
                }
            }
            return 0;
        }
        public void cevreekle(mayın m)
        {
            bool b1 = false;
            bool b2 = false;
            bool b3 = false;
            bool b4 = false;
            if (m.konumal.X>0)
            {
                mayinim.Add(mayintarlamiz.mayinal(new Point(m.konumal.X - 20+m.konumal.Y)));
                b1 = true;
            }
            if (m.konumal.Y > 0)
            {
                mayinim.Add(mayintarlamiz.mayinal(new Point(m.konumal.X  + m.konumal.Y - 20)));
                b2 = true;
            }
            if (m.konumal.X < panel1.Width)
            {
                mayinim.Add(mayintarlamiz.mayinal(new Point(m.konumal.X + 20 + m.konumal.Y)));
                b3 = true;
            }
            if (m.konumal.Y < panel1.Height)
            {
                mayinim.Add(mayintarlamiz.mayinal(new Point(m.konumal.X  + m.konumal.Y + 20)));
                b4 = true;
            }
            if (b1&&b2)
            {
                mayinim.Add(mayintarlamiz.mayinal(new Point(m.konumal.X - 20 + m.konumal.Y-20)));
            }
            if (b1 && b4)
            {
                mayinim.Add(mayintarlamiz.mayinal(new Point(m.konumal.X - 20 + m.konumal.Y +20)));
            }
            if (b2 && b3)
            {
                mayinim.Add(mayintarlamiz.mayinal(new Point(m.konumal.X + 20 + m.konumal.Y - 20)));
            }
            if (b2 && b4)
            {
                mayinim.Add(mayintarlamiz.mayinal(new Point(m.konumal.X + 20 + m.konumal.Y + 20)));
            }
        }
        public void mayingoster()
        {
            foreach (mayın item in mayintarlamiz.getall())
            {
                if (item.mayın_varmi)
                {
                   Button btn= (Button)panel1.Controls.Find(item.konumal.X+""+ item.konumal.Y, false)[0];
                   // btn.BackgroundImage = mayin_resmi;
                   // btn.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }
    }
}
