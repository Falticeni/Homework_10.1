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
            // Generic list
            GenericList<string> Lista = new GenericList<string>(5);


            // Add element
            Lista.AddElement("Victor");
            Lista.AddElement("Ana");
            Lista.AddElement("Ioana");
            Lista.AddElement("Emilia");
            Lista.AddElement("Mina");
            Console.WriteLine(Lista);
            Console.WriteLine();

            // Access element by index
            var x = Lista[2];
            Console.WriteLine("Elementul de pe indexul {0} are valoarea {1}.", 2, x);
            Console.WriteLine();

            // Remove element by index
            Lista.RemoveElement(3);
            Console.Write("Dupa ce am sters elementul de pe indexul 3: ");
            Lista.Print();
            Console.WriteLine();

            // Insert element at given position
            Lista.InsertElement(2, "Robert");
            Console.Write("Dupa ce am inserat elementul Robert pe indexul 2: ");
            Console.WriteLine(Lista);
            Console.WriteLine();

            ////Clear the list
            //Lista.ClearList();
            //Console.WriteLine(Lista);
            //Console.WriteLine();

            // Find element by its value            
            Console.WriteLine($"Elementul \"Robert\" se afla pe indexul {Lista.IndexOf("Robert")}.");
            Console.WriteLine();

            // ToString()
            Console.Write("Elementele sirului (folosind ToString) sunt: ");
            Console.WriteLine(Lista);
            Console.WriteLine();

            //         Problem 2. Auto-grow  
            Lista.AutoGrow();
            Console.Write("AutoGrow: ");
            Console.WriteLine(Lista);
            Console.WriteLine();

            //       Problem 3. Min and Max
            var min = Lista.Min();
            Console.WriteLine("Minimul sirului este {0}.", min);
            Console.WriteLine();

            var max = Lista.Max();
            Console.WriteLine("Maximul sirului este {0}.", max);
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
