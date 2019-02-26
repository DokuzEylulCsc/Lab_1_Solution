using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Ogrenci
    {
        public int no;
        public string isim;
        static int max_ders_sayisi = 5;
        int i = 0;
        string[] dersler = new string[max_ders_sayisi];

        public void isim_gir(string isim)
        {
            this.isim = isim;
        }

        public void no_gir(int numara)
        {
            no = numara;
        }

        public bool ders_al(string ders_kod)
        {
            if (i < max_ders_sayisi)
            {
                dersler[i] = ders_kod;
                i++;
                return true;
            }
            else return false;
        }
    }
}
