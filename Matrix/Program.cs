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
            Matrix<int> First = new Matrix<int>(4, 4);
            Matrix<int> Second = new Matrix<int>(4, 4);

            // Insert element into matrices
            var rand = new Random();
            for (int i = 0; i < First.Col; i++)
            {
                for (int j = 0; j < First.Col; j++)
                {
                    First[i, j] = rand.Next(9);
                    Second[i, j] = rand.Next(5);
                }
            }

            // Read element from First
            Console.WriteLine("Elementele matricii First sunt: ");
            First.Print();

            // Read element from Second
            Console.WriteLine("Elementele matricii Second sunt: ");
            Second.Print();

            // Implement an indexer this[row, col] to access the inner matrix cells.
            Console.WriteLine("Valoarea elementului de pe pozitia [0][0], din matricea First este: {0}.", First[0, 0]);
            Console.WriteLine("Valoarea elementului de pe pozitia [0][0], din matricea Second este: {0}. ", Second[0, 0]);
            Console.WriteLine();

            //Implement the operator +
            Matrix<int> Plus = First + Second;
            Console.WriteLine("Elementele matricii Plus sunt: ");
            Plus.Print();

            //Implement the operator -
            Matrix<int> Minus = First - Second;
            Console.WriteLine("Elementele matricii Minus sunt: ");
            Minus.Print();

            //Implement the operator *
            Matrix<int> Inmultire = First * Second;
            Console.WriteLine("Elementele matricii Inmultire sunt: ");
            Inmultire.Print();

            //Implement the operator true
            if (Inmultire)
            {
                Console.WriteLine("In matricea Inmultire sunt elemente de 0.");
            }
            else
            {
                Console.WriteLine("In matricea Inmultire NU sunt elemente de 0.");
            }

            Console.ReadKey();
        }
    }
}
