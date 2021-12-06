using System;
using System.Collections.Generic;

namespace w13_praktikum
{
    class Program
    {
        static void Main(string[] args)
        {
            int statusProgram = 1;
            Console.WriteLine("Berapa data");
            int input2 = Convert.ToInt32(Console.ReadLine());
            string[] koleksiNIM = new string[1000];
            string[,] list = new string[1000, 6];
            var arrayTerakhir = 1;
            while (statusProgram == 1)
            {
                for (int i = arrayTerakhir; i <= input2; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Data ke- {i} ");
                    Console.Write("NIM           :");
                    string nim = Convert.ToString(Console.ReadLine());
                    for (int c = i; c < koleksiNIM.Length; c++)
                    {
                        if (nim == koleksiNIM[c])
                        {
                            Console.WriteLine("NIM sudah ada !!!!");
                            Console.Write("NIM           :");
                            nim = Convert.ToString(Console.ReadLine());
                        }
                        koleksiNIM[c] = nim;
                    }
                    Console.Write("NAMA          :");
                    list[i, 0] = Convert.ToString(Console.ReadLine());
                    Console.Write("JENIS KELAMIN :");
                    list[i, 1] = Convert.ToString(Console.ReadLine());
                    Console.Write("TAHUN MASUK   :");
                    list[i, 2] = Convert.ToString(Console.ReadLine());
                    Console.Write("PROGRAM STUDI :");
                    list[i, 3] = Convert.ToString(Console.ReadLine());
                    Console.Write("KELAS         :");
                    list[i, 4] = Convert.ToString(Console.ReadLine());
                }
                Console.WriteLine();
                Console.Write("PRINT HASIL ? (y/n) ...");
                string pilihan = Convert.ToString(Console.ReadLine());


                if (pilihan == "y")
                {
                    Console.Clear();
                    string nomor = "NO";
                    string number = "NIM";
                    string name = "NAMA";
                    string jenis1 = "JENIS KELAMIN";
                    string year = "TAHUN MASUK";
                    string prodi1 = "PROGRAM STUDI";
                    string kelas1 = "KELAS";
                    Console.WriteLine(String.Format("{0,-7}{1,-5}{2,-20}{3,-20}  {4,-10}  {5,-20}{6,-10}", nomor, number, name, jenis1, year, prodi1, kelas1));
                    for (int i = 1; i <= input2; i++)
                    {
                        Console.WriteLine(String.Format("{0,-7}{1,-5}{2,-20}{3,-20}  {4,-10}  {5,-20}{6,-10}", i , koleksiNIM[i], list[i, 0], list[i, 1], list[i, 2], list[i, 3], list[i, 4]));
                    }
                }
                if (pilihan == "n")
                {
                    break;
                }
                Console.WriteLine();
                Console.Write("Tambah Data ? (y/n) ...");
                string pilihan2 = Convert.ToString(Console.ReadLine());
               
                if (pilihan2 == "y")
                {
                    Console.Write("Berapa data= ");
                    int lala = Convert.ToInt32(Console.ReadLine());
                    list = new string[input2 + lala, 6];
                    arrayTerakhir = input2+1;
                    input2 = input2 + lala;
                }

                if (pilihan2=="n")
                {
                    break;
                }
            }
        }
    }

        
    }

