using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z01Metode
    {

        public static void Izvedi()
        {

            CijeliDioZbroja(2.7, 3.7);

        }

        public static int CijeliDioZbroja(float v1, float v2)
        {
         
            return CijeliDioZbroja((double)v1, (double)v2);
        }

        // method overloading
        // potpis metode: naziv + lista parametara 
        public static int CijeliDioZbroja(double v1, double v2, double v3)
        {

            return (int)(v1 + v2 + v3);
        }

        public static int CijeliDioZbroja(double v1, double v2)
        {

            return (int)(v1 + v2);
        }

    }

   

}
