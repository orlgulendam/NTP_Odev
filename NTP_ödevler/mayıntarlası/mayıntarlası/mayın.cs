using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace mayıntarlası
{
     public class mayın
    {
        Point loc;
        bool dolu;
        bool bakildi;
        public mayın(Point loca)
        {
            dolu = false;
            loc = loca;

        }
        public Point konumal
        {

            get{ return loc; }
        }
        public bool mayın_varmi
        {
            get { return dolu; }
            set { dolu = value; }

        }
       
        public bool bakildimi
        {
            get { return bakildi; }
            set { bakildi = value; }

        }
    }
}
