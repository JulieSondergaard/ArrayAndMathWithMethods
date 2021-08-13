using System;
using System.Collections.Generic;

namespace ArrayAndMathWithMethods
{
    class Program
    {
        public static List<int> listeB = new List<int>();

        static void Main(string[] args)
        {
            GetListOfNumbers();
            Console.WriteLine();
            GetRemoveNumbers();
            Console.WriteLine();
            GetInsertAndReverse();

        }
        public static void GetListOfNumbers()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    listeB.Add(i);
                }
            }
            for (int i = 0; i < listeB.Count; i++)
            {
                Console.WriteLine(listeB[i]);
            }
        }
        public static void GetRemoveNumbers()
        {
            int index = 0;

            while (true)
            {
                if (listeB[index] % 3 == 0)
                {
                    listeB.RemoveAt(index);
                }
                else
                {
                    index++;
                }

                if (index >= listeB.Count)
                {
                    break;
                }
            }
            for (index = 0; index < listeB.Count; index++)
            {
                Console.WriteLine(listeB[index]);
            }
            Console.WriteLine();
            Console.WriteLine($"Der er nu {listeB.Count} tal på listen.");
        }
        public static void GetInsertAndReverse()
        {
            Console.WriteLine();
            listeB.Insert(2, 17);
            listeB.Reverse();

            for (int i = 0; i < listeB.Count; i++)
            {
                Console.WriteLine(listeB[i]);
            }
        }
    }
}
