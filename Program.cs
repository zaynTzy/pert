using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi";

            int a = 30;
            int b = 6;

            Console.WriteLine("Hasil Penambahan" + a + "+" + b + "=" + penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
            Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
    
    }
}
