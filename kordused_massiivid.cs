using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CProgrammerimine3
{
    class Kordused_Massiivid
    {
        static void Main(string[] args)
        {
            int[] arvud = new int[5];
            int a=0;
            int k=0;
            do
            {
                try
                {
                    Console.WriteLine("Sisesta 5 arvud");
                    a = int.Parse(Console.ReadLine());
                    arvud[k] = a;
                    k++;
                }
                catch (Exception exp)
                {

                    Console.WriteLine(exp);
                }

            } while (k<5);
            //Random rnd = new Random();
            //int N = rnd.Next(1, 10);
            //int M = rnd.Next(1, 10);
            //Console.WriteLine($"N={N}");
            //Console.WriteLine($"M={M}");
            //if (N > M)
            //{
            //    int abi = N;
            //    N = M;
            //    M = abi;
            //}
            //int[] N_M = new int[M - N + 1];
            //int j = 0;
            //for (int l = N; l < M + 1; l++)
            //{
            //    N_M[j] = l;
            //    j++;
            //}
            //foreach (int n_m in N_M)
            //{
            //    Console.Write($"{n_m ^ 2,5}");
            //}







            //Console.ReadKey();

            //NM[j]^2, Math.Power(NM[j],2)


            //string[] nimed = new string[8] { "A", "B", "C", "D", "E", "F", "G", "H" };
            //nimed[2] = "Anna";
            //int nr = 0;
            //while (nr < 8)
            //{
            //    Console.WriteLine("Tere, {0} õpilane", nimed[nr]);
            //    nr = nr + 1;
            //}
            //for (int i = 0; i < nimed.Length; i++)
            //{
            //    Console.WriteLine("Tere, {0} õpilane", nimed[i]);
            //}
            //foreach (var nimi in nimed)
            //{
            //    Console.WriteLine("Tere, {0} õpilane", nimi);
            //}
            //nr = 0;
            //do
            //{
            //    Console.WriteLine("Tere, {0} õpilane", nimed[nr]);
            //    nr++;
            //} while (nr != nimed.Length);

            //char[] Tahed = new char[7] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' }; //char - 1 буква в массиве
            //Console.WriteLine($"Esimene täht on {Tahed[0]}");

            //foreach (char taht in Tahed)
            //{
            //    Console.Write($"{taht,3}");

            //}
            //Console.WriteLine();
            //Random rnd = new Random();
            //int [] arvud = new int[10];

            //for (int i = 0; i < arvud.Length; i++)
            //{
            //    arvud[i] = rnd.Next(5, 500);
            //}
            //foreach (int arv in arvud)
            //{
            //    Console.Write($"{arv,4}");
            //}
            //Console.WriteLine();
            //int[,] tabel = new int[5, 20];
            //for (int i = 1; i < 5; i++)
            //{
            //    Console.Write($"rida {i + 1}: ");
            //    for (int j = 1; j < 11; j++)
            //    {
            //        Console.Write($"koht{j + 1} ");

            //    }
            //    Console.WriteLine();

            //}

            //    Console.ReadLine();
        }
    }
}
