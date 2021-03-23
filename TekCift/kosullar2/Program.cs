using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosullar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tekrar:
            Console.WriteLine("Bir sayı giriniz: ");
            
            int sayi = int.Parse(Console.ReadLine());

            if (sayi%2==0)
            {

                Console.WriteLine($"Girilen Sayı {sayi} ve çifttir.");

            }
            else
            {
                Console.WriteLine($"Girilen Sayı {sayi} ve tektir.");
            }
            if (sayi!=0)
            {
                goto Tekrar;

            }

            Console.ReadKey();
        }
    }
}
