using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraiMunka
{
    class Feladatok
    {
        static int N; // Tömb elem száma
        static int szam; // tömbbe menő számok
        static bool kilep = true;
        static int[] tomb;

        public void init()
        {
            tombBeker();
            szamokBeker();
            maxKeres();
            minKeres();

        }


        private void tombBeker()
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

            tomb = new int[N];

            Console.Clear();
        }
            
        public void szamokBeker()
        {
            Console.WriteLine("Kérem adja meg a számokat!");

            for (int i = 0; i < N; i++)
            {
                do
                {
                    kilep = true;
                    try
                    {
                        szam = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Hiba: Nem szám");
                        kilep = false;
                    }
                } while (!kilep);
                tomb[i] = szam;
            }
            //Console.ReadKey();
            Console.Clear();
        }

        public void maxKeres()
        {
            int max = tomb[0];
            for (int i = 1; i < N; i++)
            {
                if (max<tomb[i])
                {
                    max = tomb[i];
                }
            }

            kiir();
            Console.WriteLine("A legnagyobb szám: " + max);
        }

        public void minKeres()
        {
            int min = 0;
            for (int i = 1; i < N; i++)
            {
                if (tomb[min]>tomb[i])
                {
                    min = i;
                }
            }
            Console.WriteLine("A legkissebb szám: {0}", tomb[min]);
        }

        public void kiir()
        {
            Console.Write("A tömb elemei: ");
            for (int i = 0; i < N-1; i++)
            {
                Console.Write(tomb[i] + ", ");
            }
            Console.WriteLine("{0}.", tomb[N-1]);
        }

    }
}
