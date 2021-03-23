using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosullar1
{
    class Program
    {
        static void Main(string[] args)
        {
        Tekrar:

            Console.WriteLine("Yaşınızı giriniz: ");
            int yas = int.Parse(Console.ReadLine());
            if (yas < 18)
            {
                Console.WriteLine("Seçme ve seçilme hakkınız yoktur");

            }
            else if (yas < 25)
            {
                Console.WriteLine("Seçme hakkınız vardır. Seçilme hakkınız yoktur.");
            }
            else

            {
                Console.WriteLine("Seçme ve seçilme hakkınız vardır.");

            }

            goto Tekrar;
        }
    }
}
