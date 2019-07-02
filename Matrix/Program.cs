using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrix.Class;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
            Matrix<int> First = new Matrix<int>(2, 3);
            Matrix<int> Second = new Matrix<int>(2, 3);

            // Insert element into matrices
            var rand = new Random();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    First[i, j] = rand.Next(9);
                    Second[i, j] = rand.Next(9);
                }
            }
            Console.WriteLine();

            // Read element from First
            Console.WriteLine("Elementele matricii First sunt: ");
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Row ({0}): ", i);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(First[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Read element from Second
            Console.WriteLine("Elementele matricii Second sunt: ");
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Row ({0}): ", i);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Second[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            // Implement an indexer this[row, col] to access the inner matrix cells.
            Console.WriteLine("Valoarea elementului de pe pozitia [0][0], din matricea First este: " + First[0, 0]);
            Console.WriteLine("Valoarea elementului de pe pozitia [0][0], din matricea Second este: " + Second[0, 0]);
            Console.WriteLine();

            //Implement the operator +
            Matrix<int> Plus = First + Second;
            Console.WriteLine("Elementele matricii Plus sunt: ");
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Row ({0}): ", i);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Plus[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //Implement the operator -
            Matrix<int> Minus = First - Second;
            Console.WriteLine("Elementele matricii Minus sunt: ");
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Row ({0}): ", i);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Minus[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //Implement the operator *
            Matrix<int> Inmultire = First * Second;
            Console.WriteLine("Elementele matricii Inmultire sunt: ");
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Row ({0}): ", i);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Inmultire[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //Implement the operator true
            if (Inmultire)
            {
                Console.WriteLine("In matricea Inmultire sunt elemente de 0.");
            }
            else
            {
                Console.WriteLine("In matricea Inmultire nu  sunt elemente de 0.");
            }


            Console.ReadKey();
        }
    }
}
