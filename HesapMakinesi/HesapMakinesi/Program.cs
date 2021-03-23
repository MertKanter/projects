using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {

            char cikis;
            do
            {
                Console.Clear();
                int sonuc = 0;

                Console.Write("1.Sayıyı giriniz: ");
                int sayi1 = int.Parse(Console.ReadLine());
                Console.Write("2.Sayıyı giriniz: ");
                int sayi2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Toplama İşlemi İçin +");
                Console.WriteLine("Çıkarma İşlemi İçin -");
                Console.WriteLine("Çarpma İşlemi İçin *");
                Console.WriteLine("Bölme İşlemi İçin /");
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz : ");
                char secim = Convert.ToChar(Console.ReadLine());
                switch (secim)
                {

                    case '+':
                        sonuc = sayi1 + sayi2;
                        Console.WriteLine($"İşlem Sonucunuz: {sonuc}");
                        break;

                    case '-':
                        sonuc = sayi1 - sayi2;
                        Console.WriteLine($"İşlem Sonucunuz: {sonuc}");
                        break;

                    case '*':
                        sonuc = sayi1 * sayi2;
                        Console.WriteLine($"İşlem Sonucunuz: {sonuc}");
                        break;

                    case '/':
                        sonuc = sayi1 / sayi2;
                        Console.WriteLine($"İşlem Sonucunuz: {sonuc}");
                        break;

                    default:
                        Console.WriteLine("Hatalı seçim yaptınız!");
                        break;
                }


            Console.WriteLine("Başka işlem yapacak mısınız?(e/h)");
            cikis = Convert.ToChar(Console.ReadLine());
            } while (cikis != 'h') ;

        }
    }
}
