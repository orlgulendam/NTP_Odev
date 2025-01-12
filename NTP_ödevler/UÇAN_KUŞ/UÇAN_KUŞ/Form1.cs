using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UÇAN_KUŞ
{                                               
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int pipeSpeed = 8; 
        int gravity = 15; 
        int score = 0;
        // Oyun bittiğinde tetiklenen fonksiyon
        private void endGame()
        {
            
            timer_kontrol.Stop(); 
            label1.Text += " Game over!!!"; 
        }
        // Oyunun her tik'ında oyun mantığını güncelleyen zamanlayıcı olay
        private void timer_kontrol_Tick(object sender, EventArgs e)
        {
            kus.Top += gravity; 
            sutun2.Left -= pipeSpeed; 
            sutun1.Left -= pipeSpeed; 
       
            if (sutun2.Left < -200)
            {
                sutun2.Left = 490;
                score++;
            }
            if (sutun1.Left < -220)
            {
         
                sutun1.Left = 500;
                score++;
            }
            // Kuşun borulara, yere çarpıp çarpmadığını veya en üst sınırın dışına çıkıp çıkmadığını kontrol et
            if (kus.Bounds.IntersectsWith(sutun2.Bounds) ||
                kus.Bounds.IntersectsWith(sutun1.Bounds) ||
                kus.Bounds.IntersectsWith(yer.Bounds) || kus.Top < -25
                )
            {
                
                endGame();
            }
          
            if (score > 5)
            {
                pipeSpeed = 15;
            }
        }

        private void game_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                
                gravity = -10;
            }
        }
        //
        private void game_keyup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
               
                gravity = 15;
            }
        }
    }
}
