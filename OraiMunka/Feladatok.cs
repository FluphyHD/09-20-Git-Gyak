using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraiMunka
{
    class Feladatok
    {
        static int N;
        static bool kilep = true;

        public void feladat()
        {
            Console.WriteLine("Kérem adja meg hány számot szeretne beírni: ");
            do
            {
                kilep = true;
                try
                {
                    N = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hiba: Nem szám");
                    kilep = false;
                }
            } while (!kilep);
            
            int[] tomb = new int[N];


        }
    }
}
