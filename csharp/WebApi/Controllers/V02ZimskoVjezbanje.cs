using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Diagnostics.CodeAnalysis;

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

            return a * (a + 1);
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
       
            if(b > a)
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
                for(int i = b; i <= a; i++)
                {
                    if(i % 2 == 0)
                    {
                        niz[broj++] = i; 
                    }
                }
            }

            return niz;
        }

        [HttpGet]
        [Route("Vjezba6")]

        public int[] NizNeparnihBrojevaIzmedu(int a, int b)
        {
            int velicinaNiza = 0;
            if(a > b)
            {
                velicinaNiza = a;
            } else
            {
                velicinaNiza = b; 
            }

            int[] niz = new int[velicinaNiza / 2];
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
            return niz;
        }

        [HttpGet]
        [Route("Vjezba7")]

        public int ZbrojIzmedu(int a, int b)
        {
            
            if(b > a)
            {
                int c = b;
                b = a;
                
                return  ((b-c) *(-1)) * (((b - c) * (-1)) + 1) /2;
            }

            return (a - b) * (a-b+1)/2; 
        }

        [HttpGet]
        [Route("Vjezba 8")]

        public int ZbrojModulo3Izmedu(int a, int b)
        {
            int velicinaNiza = 0;
            if (a  > b)
            {
                velicinaNiza = a;
            } else
            {
                velicinaNiza = b;
            }
            int[] niz = new int[velicinaNiza / 3];
            int broj = 0;
            int suma = 0;

            if(b > a)
            {
               
                for (int i = a; i < b; i++)
                {
                    if(i % 3 == 0)
                    {
                        niz[broj++] = i; 
                    }
                }
               
            } 
            if(a > b)
            {
 
                for (int i = b; i < a; i++) 
                { 
                if((i % 3) == 0) 
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

            if(b > a)
            {
                for(int i = a; i < b;i++)
                {
                    if(i %3 == 0)
                    {
                        nizMod3[brojMod3++] = i;
                    }
                }
            } else
            {
                for(int i = b; i < a;i++)
                {
                    if(i % 3 == 0)
                    {
                        nizMod3[brojMod3++] = i;
                    }
                }
            }
            sumaMod3 = nizMod3.Sum();

            if(b > a)
            {
                for( int i = a; i < b; i++)
                {
                    if(i % 5 == 0)
                    {
                        nizMod5[brojMod5++] = i;
                    }
                }
            } else
            {
                for (int i = b; i < a; i++)
                {
                    if(i % 5 == 0)
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
        
        public void Matrica2d(int a, int b)
        {
            int[,] matrica = new int[a,b];
          
        }
        
    }
}
