using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class TestiranjeUKonzoli
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesi prvi broj: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi broj: ");
            int b = int.Parse(Console.ReadLine());

            int[,] matrica = new int[10, 10]; 

            // pravilno formatira i unosi tablicu mnozenja
            for(int i = 0; i < 10;i++)
            {
                for(int j = 0;j < 10;j++)
                {
                    matrica[i, j] = (i+1) * (j+1);
                    Console.Write(matrica[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            // iznosi rezultat mnozenja a i b iz tablice

            //Console.WriteLine(matrica[a -1,b - 1]);

            Console.WriteLine();

            int[] matricaA = new int[10];

            for (int i = 0; i < 10;i++)
            {
                matricaA[i] = (i + 1) * a;
                Console.Write(matricaA[i] + "\t");
            }
            Console.WriteLine();

            int[] matricaB = new int[10];
            
            for(int i = 0; i < 10; i++)
            {
                matricaB[i] = (i+1) * b;
                Console.Write(matricaB[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            int[,] matricaC = new int[a,b];


            for(int i = 0; i < a;i++)
            {
                matricaA[i] = ((i + 1) * a);
                 
                for (int j = 0; j < b;j++)
                {
                    matricaC[i,j] = matricaB[j];
                    Console.Write(i +  j + 
                        "array :"+ matrica[i, j] + "\t");

                }
            }

            Console.WriteLine();
            Console.WriteLine();



        }


        public static void CiklicnaMatrica()
        {
            Console.WriteLine("Unesi broj redaka: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi broj stupaca: ");
            int b = int.Parse(Console.ReadLine());
            int[,] matrica = new int[a, b];
            SpiralFill(a, b, matrica); 
            
            for(int i = 0; i < a;i++)
            {
                for(int j = 0;j < b;j++)
                {
                    Console.WriteLine(matrica[i,j] + " ");
                }
               
            }


            

        }

        public static void SpiralFill(int a, int b, int[,] matrica)
        {

            int number = a * b;

           

            int k = 0, l = 0;


            while (k < a && l < b)
            {
                for (int i = l; i < b; i++)
                {
                    matrica[k, i] = number--;

                }
                k++;

                for (int i = k; i < a; i++)
                {
                    matrica[i, a - 1] = number--;
                }
                b--;

                if (k < a)
                {
                    for (int i = b - 1; i >= 1; i--)
                    {
                        matrica[b - 1, i] = number--;
                    }
                    b--;
                }
                if (l < b)
                {
                    for (int i = b - 1; i >= k; i--)
                    {
                        matrica[i, l] = number--;
                    }
                    l++;
                }
            }
        }
    }
}
