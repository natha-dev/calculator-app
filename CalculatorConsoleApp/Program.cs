using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            // int a = 10;
            // int b = 6;

            Console.WriteLine("Pilih menu calculator : ");
            Console.WriteLine();
            Console.WriteLine("1.Penambahan\n2.Pengurangan\n3.Perkalian\n4.Pembagian");
            Console.WriteLine();
            Console.Write("Input nomor menu [1 - 4] = ");
            int pilihan = int.Parse(Console.ReadLine());

           // if(pilihan == 1 - 4)
          //  {
                
          //  }
            //else
           // {
            //    Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
           // }

            if (pilihan == 1)
            {
                Console.Write("inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + penambahan(a, b));
            }
            else if (pilihan == 2)
            {
                Console.Write("inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
            }
            else if (pilihan == 3)
            {
                Console.Write("inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
            }
            else if (pilihan == 4)
            {
                Console.Write("inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
            }

            Console.WriteLine();

            Console.WriteLine("\nTekan Sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int penambahan(int a,int b)
        {
            return a+b;
        }

        static int pengurangan(int a,int b)
        {
            return a-b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }

        static float pembagian(float a, float b)
        {
            return a / b;
        }
    }
}
