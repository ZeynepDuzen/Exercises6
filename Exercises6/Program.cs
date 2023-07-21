using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bilgisayar rastgele bir sayi tutsun
            //1-11 arasinda olsun sayi, yani 1 dahil olacak fakat 11 dahil olmayacak sekilde
            //kullanıcıdan alınan sayi rastgele tutulan sayi ile ayni mi degil mi kont edilsin 
            //kullanicinin sayiyi kacinci defada buldugu bilgisi de verilsin

            Random rdm = new Random();

            int sayi = rdm.Next(1,11);
            int kull;
            int sayac = 1;


        git:
            Console.WriteLine("Lütfen 1-10 arasi bir sayi giriniz : ");
            kull = Convert.ToInt32(Console.ReadLine());

            if (kull == sayi)
            {
                Console.WriteLine("Tebrikler " + sayac +" " +  " . defada tahmin ettiniz");
                
            }
            else if (kull > sayi)
            {
                Console.WriteLine("Büyük sayi girdiniz" + sayac++);
                
                Console.WriteLine("Tekrar denemek ister misiniz? <e/h>");
                char cevap1 = Convert.ToChar(Console.ReadLine());

                if (cevap1 == 'E' || cevap1 == 'e') { 
                    Console.Clear();
                    goto git;
                }
                else {
                    Console.WriteLine("Katıldıgınız icin tesekkürler");
                }
            }
            else
                { 
                Console.WriteLine("Kucuk sayi girdiniz" + sayac++);
                Console.WriteLine("Tekrar denemek ister misiniz? <e/h>");
                char cevap2 = Convert.ToChar(Console.ReadLine());

                if(cevap2 == 'E' || cevap2 == 'e')
                {
                    Console.Clear();
                    goto git;
                }
                else
                {
                    Console.WriteLine("Katildiginiz icin tesekkurler");
                }
            }

            
            Console.Read();
        }
    }
}
