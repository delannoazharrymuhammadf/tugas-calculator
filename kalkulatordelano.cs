using System;


namespace kalkulator delano
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator desain dinamis";
            int pilihan;

            Console.Write("Program Kalkulator Sederhana");
            Console.WriteLine();
            Console.Write("============================");
            Console.WriteLine();
            Console.Write(" Pilih Menu :");
            Console.WriteLine();
            Console.Write("1.Menu Penjumlahan");
            Console.WriteLine();
            Console.Write("2.Menu Pengurangan");
            Console.WriteLine();
            Console.Write("3.Menu Perkalian");
            Console.WriteLine();
            Console.Write("4.Menu Pembagian");
            Console.WriteLine();

            Console.Write("Silahkan Pilih Nomor berapa (1-4) = ");
            pilihan = int.Parse(Console.ReadLine());
			// gaskeun kalkulator dinamis
            if (pilihan == 1 || pilihan == 1)
            {
                Console.Write("Masukkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukkan Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pertambahan " + a + " + " + b + " = " + Penjumlahan(a, b));
            }

            else if (pilihan == 2 || pilihan == 2)
            {
                Console.Write("Masukkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukkan Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, Pengurangan(a, b));
            }

            else if (pilihan == 3 || pilihan == 3)
            {
                Console.Write("Masukkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2} ", a, b, Perkalian(a, b));
            }

           else  if (pilihan == 4 || pilihan == 4)
            {
                Console.Write("Masukkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2} ", a, b, Pembagian(a, b));

            }
            else
            {
                Console.Write("Maaf menu yang anda pilih tidak tersedia pada pilihan yang telah kami sediakan");
            }
                Console.WriteLine();
                Console.WriteLine("\nTekan sembarang tombol untuk keluar dari program...");
                Console.ReadKey();
        }
        static int Penjumlahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a,int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
