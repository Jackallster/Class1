using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
             Musteriler ekle = new Musteriler();
            ekle.adi = "ataberk";
            ekle.soyadi = "can";

            Musteriler ekle1 = new Musteriler();
            ekle1.adi = "veli";
            ekle1.soyadi = "karan";

            Console.Write("isim :");
            string ad=Console.ReadLine();
            Console.Write("soyisim :");
            string soyisim = Console.ReadLine();
            Console.WriteLine("--------------");
            Musteriler ekle2 = new Musteriler();
            ekle2.adi = ad;
            ekle2.soyadi = soyisim;
            


            Musteriler[] dizi=new Musteriler[]{ekle,ekle1,ekle2};

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i].adi+" "+dizi[i].soyadi);
            }
            
            Console.ReadKey();
            
        }
      
        }
    }

