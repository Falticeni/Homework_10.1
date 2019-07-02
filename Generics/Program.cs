using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics.Classes;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Feneric list
            GenericList<string> Lista = new GenericList<string>(5);


            // Add element
            Lista.AddElement("Victor");
            Lista.AddElement("Ana");
            Lista.AddElement("Ioana");
            Lista.AddElement("Emilia");
            Lista.AddElement("Mina");
            Lista.Print();
            Console.WriteLine();

            // Access element by index
            var x = Lista[2];
            Console.WriteLine("Elementul de pe indexul {0} are valoarea {1}", 2, x);
            Console.WriteLine();

            // Remove element by index
            Lista.RemoveElement(3);
            Lista.Print();
            Console.WriteLine();

            // Insert element at given position
            Lista.InsertElement(2, "Robert");
            Lista.Print();
            Console.WriteLine();

            ////Clear the list
            //Lista.ClearList();
            //Lista.Print();
            //Console.WriteLine();

            // Find element by its value            
            Console.WriteLine($"Elementul \"Robert\" se afla pe indexul {Lista.IndexOf("Robert")}");
            Console.WriteLine();

            // ToString()
            Console.Write("Elementele sirului (folosind ToString) sunt: ");
            Console.WriteLine(Lista);
            Console.WriteLine();

            //         Problem 2. Auto-grow  
            Lista.AutoGrow();
            Lista.Print();

            //       Problem 3. Min and Max
            var min = Lista.Min();
            Console.WriteLine("Minimul sirului este {0}.", min);

            var max = Lista.Max();
            Console.WriteLine("Maximul sirului este {0}.", max);


            Console.ReadKey();
        }
    }
}
