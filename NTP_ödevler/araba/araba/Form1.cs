using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace araba
{
    public partial class Form1 : Form
    {
        bool My_car_running = false;
        int may_car_vecor = 0;
        bool My_car_stop = true;
        bool my_car_left = false;
        bool my_car_rigth = false;
        bool my_car_break = false;



        public Form1()
        {
            InitializeComponent();
        }

        private void araba_Tick(object sender, EventArgs e)
        {
            if(My_car_running && may_car_vecor < 80)
            {
                may_car_vecor = may_car_vecor + 5;
            }
            if (!My_car_running && may_car_vecor >0)
            {
                may_car_vecor = may_car_vecor - 5;
            }
            if (my_car_break && may_car_vecor >0)
            {
                may_car_vecor = may_car_vecor - 5;
            }
            if(may_car_vecor == 0)
            {
                My_car_stop = true;
            }
            else
            {
                My_car_stop = false;
            }
        }

        private void araba2_Tick(object sender, EventArgs e)
        {
            if (!My_car_stop)
            {
                Move_lanes();
                if(my_car_left && araba_1.Left > 30)
                {
                    araba_1.Left = araba_1.Left - 5;
                }
                if (my_car_rigth && araba_1.Left < 218)
                {
                    araba_1.Left = araba_1.Left + 5;
                }
            }
        }
        public void Move_lanes()
        {
            lane1.Top = lane1.Top + may_car_vecor;
            lane2.Top = lane2.Top + may_car_vecor;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                my_car_break = false;
                My_car_running = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                my_car_break = false;
                My_car_running = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                my_car_rigth = false;
                my_car_left = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                my_car_left = false;
                my_car_rigth = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

                My_car_running = false;
            }
            if (e.KeyCode == Keys.Down)
            {

                My_car_running = false;
            }
            if (e.KeyCode == Keys.Left)
            {

                my_car_left = false;
            }
            if (e.KeyCode == Keys.Right)
            {

                my_car_rigth = false;
            }
        }
    }
}
