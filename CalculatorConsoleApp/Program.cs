using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";

            Console.WriteLine("1. Penambahan\n2. Pengurangan\n3. Perkalian\n4. Pembagian");

            //mendapatkan input user dan memasukannya ke variabel
            Console.Write("\nInput nomor menu [1..4] : ");
            int operasi = Convert.ToInt32(Console.ReadLine());

            if (operasi == 1 || operasi == 2 || operasi == 3 || operasi == 4)
            {
                double a, b;
                Console.Write("Masukan Nilai A : ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukan Nilai B : ");
                b = Convert.ToDouble(Console.ReadLine());

                switch (operasi)
                {
                    case 1:
                        Console.WriteLine("\nHasil Penambahan" + a + "+" + b + "=" + Penambahan(a, b));
                        break;
                    case 2:
                        Console.WriteLine("\nHasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                        break;
                    case 3:
                        Console.WriteLine("\nHasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                        break;
                    case 4:
                        Console.WriteLine("\nHasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                        break;
                }

            }
            else
            {
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia!");
            }
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        // TODO: menambahkan method untuk perkalian dan pembagian
        static double Perkalian(double a, double b)
        {
            return a * b;
        }
        static double Pembagian(double a, double b)
        {
            return a / b;
        }
        static double Penambahan(double a, double b)
        {
            return a + b;
        }
        static double Pengurangan(double a, double b)
        {
            return a - b;
        }
    }
}