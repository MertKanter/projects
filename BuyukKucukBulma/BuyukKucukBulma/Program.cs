using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukKucukBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            tekrar:
            Console.WriteLine("3 adet sayı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            int sayi2 = int.Parse(Console.ReadLine());
            int sayi3 = int.Parse(Console.ReadLine());

            int eb = sayi1;

            if (eb<sayi2)
            {
                eb = sayi2;
            }
            if (eb<sayi3)
            {
                eb = sayi3;
            }
            Console.WriteLine("En büyük sayı :" + eb);

            goto tekrar;

        }
    }
}
