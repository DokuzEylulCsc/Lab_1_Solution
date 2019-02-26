using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1;
namespace Lab_1_deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.isim_gir("Baris");
            ogr.no_gir(1);
            for (int i = 0; i < 10; i++)
            {
                string ders_kod = "Bil100" + i;
                if (ogr.ders_al(ders_kod))
                    Console.WriteLine(ogr.no + " numaralı öğrenci " + ders_kod + " kodlu dersi aldı");
                else
                    Console.WriteLine(ogr.no + " numaralı öğrenci " + ders_kod + " kodlu dersi alamadı");
            }

        }
    
    }
}
