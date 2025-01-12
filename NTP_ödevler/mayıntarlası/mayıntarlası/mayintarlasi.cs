using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace mayıntarlası
{
     class mayintarlasi
    {
        Size buyukluk_;
        List<mayın> mayınlar;
        int dolu_mayinsayısı;
        Random rnd = new Random();
        public mayintarlasi(Size buyukluk,int dolumayinSayisi)
        {
            mayınlar = new List<mayın>();
            buyukluk_ = buyukluk;
            dolu_mayinsayısı = dolumayinSayisi;
           
            for (int x = 0; x < buyukluk.Width; x=x+20)
            {
                for (int y = 0; y < buyukluk.Height; y=y+20)
                {
                    mayın m = new mayın(new Point(x, y));
                    mayinekle(m);
                }
            }
            mayinlari_doldur();
        }
        public void mayinekle(mayın m)
        {
            mayınlar.Add(m);
        }
        public mayın mayinal(Point loc)
        {
            foreach (mayın item in mayınlar)
            {
                if(item.konumal == loc)
                {
                    return item;
                }
            }
            return null; 
        }
        public Size buyuklugu
        {
            get { return buyukluk_; }
        }
        public List<mayın> getall()
        {
            return mayınlar;
        }
        private void mayinlari_doldur()
        { int sayi = 0;
            while (sayi < dolu_mayinsayısı) {

                int i = rnd.Next(0, mayınlar.Count);
                mayın item = mayınlar[i];
                if (item.mayın_varmi == false)
                {
                    item.mayın_varmi = true;
                    i++;
                }

            }
        }
    }
}
