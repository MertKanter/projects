using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersGecme
{
    class Program
    {
        static void Main(string[] args)
        {
        tekrar:
            Console.WriteLine("Vize notunuzu giriniz: ");
            int vize = int.Parse(Console.ReadLine());
            Console.WriteLine("Final notunuzu giriniz: ");
            int final = int.Parse(Console.ReadLine());
            Console.WriteLine("Ödev notunuzu giriniz: ");
            int odev = int.Parse(Console.ReadLine());

            
            double ort = vize*0.3 + final*0.4 + odev*0.3;

            Console.WriteLine($"Ortalamanız: {ort}");

            if (ort <= 40)
            {
                Console.WriteLine("Dersten başarısız oldunuz.");
            }
            if (ort >= 40 && ort < 60)
            {

                Console.WriteLine("Büte girdiniz.");

            }
            else
            {
                Console.WriteLine("Dersten başarı ile geçtiniz.");
            }

            goto tekrar;

        }
    }
}
