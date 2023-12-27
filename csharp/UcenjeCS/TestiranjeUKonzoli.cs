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

            int[] matricaC = new int[10];

            for (int i = 0; i < 10;i++)
            {
                matricaC[i] = i;
                Console.Write(matricaC[i] + "\t");
                matricaA[i] = (i+1) * a;
                Console.Write(matricaA[i] + "\t");
                for(int j = 0; j < 10;j++)
                {
                    matricaB[j] = (j+1) * b;
                    Console.Write(matricaB[i] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
