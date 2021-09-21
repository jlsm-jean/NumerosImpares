using System;

namespace NumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, i;

            X = int.Parse(Console.ReadLine());
            i = 1;

            while (i <= X)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
                i++;
            }
             
                                
        }

     }
}
    

