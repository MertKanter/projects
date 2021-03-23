using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyuktenKucugeSiralama
{
    class Program
    {
        static void Main(string[] args)
        {
        tekrar:
            Console.WriteLine("3 Adet sayı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            int sayi2 = int.Parse(Console.ReadLine());
            int sayi3 = int.Parse(Console.ReadLine());

            int gecici = 0;

            if (sayi1 < sayi2)
            {

                gecici = sayi1;
                sayi1 = sayi2;
                sayi2 = gecici;

            }
            if (sayi1 < sayi3)
            {

                gecici = sayi1;
                sayi1 = sayi3;
                sayi3 = gecici;

            }
            if (sayi2 < sayi3)
            {

                gecici = sayi2;
                sayi2 = sayi3;
                sayi3 = gecici;

            }

            Console.WriteLine($"{sayi1} > {sayi2} > {sayi3}");
            goto tekrar;
        }
    }
}
