using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Matris_Hesap_Makinesi_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                              ***********************");
            Console.WriteLine("                              *MATRİS HESAP MAKİNESİ*");
            Console.WriteLine("                              ***********************");

            for (int q = 0; q < 3; q++)
            {
                Console.WriteLine();
            }

            Random r = new Random();

            Console.Write("                               MATRİSİN SATIR SAYISI=");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("                               MATRİSİN SÜTUN SAYISI=");
            int n = int.Parse(Console.ReadLine());


            Console.Clear();

            Console.WriteLine("                              ***********************");
            Console.WriteLine("                              *MATRİS HESAP MAKİNESİ*");
            Console.WriteLine("                              ***********************");

            int[,] matris1 = new int[m, n];
            int[,] matris2 = new int[n, m];

            int[,] transpoze1 = new int[n, m];
            int[,] transpoze2 = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matris1[i, j] = r.Next(10);
                    transpoze1[j, i] = matris1[i, j];

                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matris2[i, j] = r.Next(10);
                    transpoze2[j, i] = matris2[i, j];
                }
            }

            Console.WriteLine("1.MATRİS");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {


                    Console.Write(matris1[i, j] + " ");

                }
                Console.WriteLine();

            }

            Console.WriteLine();

            Console.WriteLine("2.MATRİS");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matris2[i, j] + " ");

                }

                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("1. MATRİSİN TRANPOZESİ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(transpoze1[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("2. MATRİSİN TRANSPOZESİ");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(transpoze2[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            int[,] toplam = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    toplam[i, j] = matris1[i, j] + matris2[i, j];

                }
            }

            Console.WriteLine();

            Console.WriteLine("MATRİSLER TOPLAMI");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(toplam[i, j] + " ");

                }

                Console.WriteLine();
            }

            Console.WriteLine();

            int[,] carpim = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        carpim[i, j] += matris1[i, k] * matris2[k, j];
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("MATRİSLER ÇARPIMI");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(carpim[i, j] + " ");

                }

                Console.WriteLine();
            }

            Console.WriteLine();

            Console.ReadKey();     
        }
    }
}
