using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Classes
{
    //        Problem 1. Generic class    //
    public class GenericList<T> : IEnumerable  where T : IComparable<T>
    {
        //Prop
        public int Capacity { get; private set; }
        public int Count { get; private set; }
        private T[] genericList { get; set; }

        // Constructors
        public GenericList(int capacity) // class constructor with fixed p_capacity
        {
            this.Capacity = capacity;
            this.genericList = new T[capacity];
        }

        // Add element
        public void AddElement(T element)
        {
            if (this.Count == this.Capacity - 1)
            {
                AutoGrow();
            }
            genericList[Count++] = element;
        }


        // Access element by index
        public T this[int index]
        {
            get
            {
                Exception(index);
                return this.genericList[index];
            }
            set
            {
                genericList[index] = value;
            }
        }


        // Remove element by index
        public void RemoveElement(int index)
        {
            Exception(index);
            for (int i = index; i < this.Count - 1; i++)
            {
                genericList[i] = genericList[i + 1];
            }
            genericList[Count - 1] = default;
            Count--;
        }


        // Insert element at given position
        public void InsertElement(int index, T element)
        {
            Exception(index);
            if (this.Count == this.Capacity - 1)
            {
                AutoGrow();
            }

            for (int i = Count - 1; i >= index; i--)
            {
                this[i + 1] = this[i];
            }
            this[index] = element;
            Count++;
        }


        // Clear the list
        public void ClearList()
        {
            for (int i = 0; i < this.Count; i++)
            {
                this[i] = default;
            }
            this.genericList = new T[0];
            Count = 0;
            Capacity = 0;
        }


        // Find element by its value
        public int? IndexOf(T element)
        {
            for (int i = 0; i < genericList.Length; i++)
            {
                if (genericList[i].Equals(element))
                {
                    return i;
                }
            }
            return null;
        }

        // ToString()
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var element in genericList)
            {
                sb.Append($"{element}, ");
            }
            return sb.ToString();
        }

        //Check all input parameters to avoid accessing elements at invalid positions.
        public void Exception(int index)
        {
            if ((index < 0) || (index > genericList.Length - 1))
            {
                throw new IndexOutOfRangeException();
            }
        }


        //         Problem 2. Auto-grow        //
        public void AutoGrow()
        {
            // create a new array of double size
            int newSize = Capacity * 2;
            T[] secondList = new T[newSize];

            //move all elements to it
            for (int i = 0; i < genericList.Length; i++)
            {
                secondList[i] = this.genericList[i];
            }
        }


        //       Problem 3. Min and Max       //
        public T Min<T>() 
        {
            dynamic min = genericList[0];
            for (int i = 0; i < genericList.Length; i++)
            {
                if (genericList[i].CompareTo(min) < 0)
                {
                    min = genericList[i];
                }
            }
            return min;
        }

        public T Max<T>() where T: struct
        {
            dynamic max = genericList[0];
            for (int i = 0; i < genericList.Length; i++)
            {
                if (genericList[i].CompareTo(max) > 0)
                {
                    max = genericList[i];
                }
            }
            return max;
        }

        public void Print()
        {
            Console.Write("Elementele sirului sunt: ");
            for (int i = 0; i < Count; i++)
            {
                Console.Write(this[i] + ", ");
            }
            Console.WriteLine();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
                yield return genericList[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
