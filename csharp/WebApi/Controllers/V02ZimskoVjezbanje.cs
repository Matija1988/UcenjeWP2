﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Swashbuckle.AspNetCore.Annotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace WebApi.Controllers
{

    [ApiController]
    [Route("V02")]
    public class V02ZimskoVjezbanje
    {

        [HttpGet]
        [Route("Vjezba1")]

        public int ZbrojPrvih100()
        {
            return 100 * (100 + 1) / 2;
        }

        [HttpGet]
        [Route("Vjezba2")]

        public int[] NizSParnimBrojevima()
        {

            int[] niz = new int[57 / 2];
            int a = 0;

            for (int i = 1; i <= 57; i++)
            {
                if (i % 2 == 0)
                {
                    niz[a++] = i;
                }


            }

            return niz;

        }


        [HttpGet]
        [Route("Vjezba3")]

        public int ZbrojBrojeva2Do18()
        {
            int suma;
            int[] niz = new int[100];
            int a = 0;

            for (int i = 2; i <= 18; i++)
            {
                if (i % 2 == 0)
                {
                    niz[a++] = i;
                }
            }

            suma = niz.Sum();

            return suma;
        }

        [HttpGet]
        [Route("Vjezba4")]

        public int ZbrojOd1Do(int a)
        {

            return (a * (a + 1))/2;
        }


        [HttpGet]
        [Route("Vjezba5")]

        public int[] NizParnihBrojevaIzmedu(int a, int b)
        {
            int velicinaNiza = 0;
            if (a > b)
            {
                velicinaNiza = a;
            }
            else
            {
                velicinaNiza = b;
            }

            int[] niz = new int[velicinaNiza / 2];
            int broj = 0;

            if (b > a)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 2 == 0)
                    {
                        niz[broj++] = i;
                    }
                }
            } else
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 2 == 0)
                    {
                        niz[broj++] = i;
                    }
                }
            }

            return niz;
        }

        [HttpGet]
        [Route("Vjezba6")]

        public string NizNeparnihBrojevaIzmedu(int a, int b)
        {
            
            int[] niz = new int[b-a / 2];
            int broj = 0;

            if (b > a)
            {
                for (int i = a; i < b; i++)
                {
                    if (i % 2 == 0)
                    {

                        niz[broj++] = i + 1;


                    }
                }
            }
            else
            {
                for (int i = b; i < a; i++)
                {
                    if (i % 2 == 0) { niz[broj++] = i + 1; }

                }


            }
            return string.Join(", ", niz);
        }

        [HttpGet]
        [Route("Vjezba7")]

        public int ZbrojIzmedu(int a, int b)
        {

            if (b > a)
            {
                int c = b;
                b = a;

                return ((b - c) * (-1)) * (((b - c) * (-1)) + 1) / 2;
            }

            return (a - b) * (a - b + 1) / 2;
        }

        [HttpGet]
        [Route("Vjezba 8")]

        public int ZbrojModulo3Izmedu(int a, int b)
        {
            int velicinaNiza = 0;
            if (a > b)
            {
                velicinaNiza = a;
            } else
            {
                velicinaNiza = b;
            }
            int[] niz = new int[velicinaNiza / 3];
            int broj = 0;
            int suma = 0;

            if (b > a)
            {

                for (int i = a; i < b; i++)
                {
                    if (i % 3 == 0)
                    {
                        niz[broj++] = i;
                    }
                }

            }
            if (a > b)
            {

                for (int i = b; i < a; i++)
                {
                    if ((i % 3) == 0)
                    {
                        niz[broj++] = i;
                    }

                }

            }
            suma = niz.Sum();
            return suma;
        }

        [HttpGet]
        [Route("Vjezba 9")]

        public string Modulo3i5Izmedu(int a, int b)
        {
            int maxBrojNiz3 = 0;
            if (a > b)
            {
                maxBrojNiz3 = a;
            } else
            {
                maxBrojNiz3 = b;
            }

            int maxBrojNiz5 = 0;

            if (a > b)
            {
                maxBrojNiz5 = a;
            } else
            {
                maxBrojNiz5 = b;
            }

            int[] nizMod3 = new int[maxBrojNiz3 / 3];
            int[] nizMod5 = new int[maxBrojNiz5 / 5];
            int brojMod3 = 0;
            int brojMod5 = 0;
            int sumaMod3 = 0;
            int sumaMod5 = 0;

            if (b > a)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 3 == 0)
                    {
                        nizMod3[brojMod3++] = i;
                    }
                }
            } else
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 3 == 0)
                    {
                        nizMod3[brojMod3++] = i;
                    }
                }
            }
            sumaMod3 = nizMod3.Sum();

            if (b > a)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 5 == 0)
                    {
                        nizMod5[brojMod5++] = i;
                    }
                }
            } else
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 5 == 0)
                    {
                        nizMod5[brojMod5++] = i;
                    }
                }
            }
            sumaMod5 = nizMod5.Sum();
            return "Sum mod 3 = " + sumaMod3 + " Suma mod 5 = " + sumaMod5;
        }

        [HttpGet]
        [Route("Vjezba 10")]
        
        public string Matrica2d(int a, int b)
        {
            int[] matricaA = new int[10];
            int[] matricaB = new int[10];

            for (int i = 0; i < 10; i++)
            {
                matricaA[i] = (i + 1) * a;
            }

            for (int i = 0; i < 10; i++)
            {
                matricaB[i] = (i + 1) * b;
            }

            string[,] tablica = new string[a, b];

            for(int i = 0; i < a;i++)
            {
                for (int j = 0; j < b; j++)
                {
                    tablica[i,j] = ((i+1) * (j+1)).ToString();  
                }
            }

            StringBuilder matricaNiz = new StringBuilder();
             
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    matricaNiz.Append(tablica[i,j] + "\t");
                }
                matricaNiz.AppendLine();
            }
            return "Tablica množenja za dva broja" + "\n" + string.Join("\t", matricaA) 
                + "\n" + string.Join("\t", matricaB) + "\n" + "Tablica množenja do dva broja" + "\n" + matricaNiz.ToString();
        }

        [HttpGet]
        [Route("Vjezba 11")]

        public int[] OdBrojaDo1(int a)
        {
            int broj = 0;
            int[] niz = new int[a];
            for (int i = a; i >= 1; i--)
            {
                niz[broj++] = i;
            }

            return niz;
        }

        [HttpGet]
        [Route("Vjezba 12")]

        public bool IsItAPrime(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        [HttpGet]
        [Route("Vjezba 13")]

        public string CiklicnaMatrica(int redovi, int kolone)
        {

            // moj neuspjesan pokusaj ... ne radi u slucaju neparnih broja redova npr 3x7
            // ideja je stvoriti ispravnu matricu pa je ispisati unazad
            //int[,] niz = new int[redovi, kolone];
            
            //int broj = redovi * kolone;


            //int min = 0;
            //int kolona = 0, red = 0;
            //int maxRed = redovi - 1;
            //int maxKolona = kolone - 1;


            //for (int i = 1; i <= broj; i++)
            //{
            //    niz[red, kolona] = i;
            //    if (red == maxRed && kolona != min)
            //        kolona--;
            //    else if (kolona == maxKolona)
            //        red++;
            //    else if (red == min)
            //        kolona++;
            //    else if (kolona == min && red != min + 1)
            //        red--;
            //    else
            //    {
            //        maxKolona -= 1;
            //        maxRed -= 1;
            //        min += 1;
            //        kolona++;
            //    }

            //}

            // ispravno. Rjesenje sa interneta.

            int[,] matrica = new int[redovi, kolone];
            int brojac = 1;
            int redPocetak = 0, redKraj = redovi - 1;
            int kolPocetak = 0, kolKraj = kolone - 1;

            while (redPocetak <= redKraj && kolPocetak <= kolKraj)
            {
                for (int i = kolKraj; i >= kolPocetak; i--)
                {
                    matrica[redKraj, i] = brojac++;
                }
                redKraj--;
                for (int i = redKraj; i >= redPocetak; i--)
                {
                    matrica[i, kolPocetak] = brojac++;
                }
                kolPocetak++;
                if (redPocetak <= redKraj)
                {
                    for (int j = kolPocetak; j <= kolKraj; j++)
                    {
                        matrica[redPocetak, j] = brojac++;
                    }
                    redPocetak++;
                }
                if (kolPocetak <= kolKraj)
                {
                    for (int i = redPocetak; i <= redKraj; i++)
                    {
                        matrica[i, kolKraj] = brojac++;
                    }
                    kolKraj--;
                }
            }
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < redovi; i++)
            {
                for(int j =  0; j < kolone; j++)
                {
                    sb.Append(matrica[i, j] + "\t");
                }
                sb.AppendLine();
            }

          return sb.ToString(); 
        }
 
    }
}
