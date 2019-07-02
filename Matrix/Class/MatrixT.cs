using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Class
{
    public class Matrix<T>
    {
        // Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
        private T[,] matrix;
        public int Row { get; private set; }
        public int Col { get; private set; }

        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.matrix = new T[Row, Col];
        }

        // Implement an indexer this[row, col] to access the inner matrix cells.
        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row > this.Row) || (col < 0 || col > this.Col))
                {
                    throw new IndexOutOfRangeException("Invalid row or col!");
                }
                else
                {
                    return this.matrix[row, col];
                }
            }
            set
            {
                if ((row < 0 || row > this.Row) || (col < 0 || col > this.Col))
                {
                    throw new IndexOutOfRangeException("Invalid row or col!");
                }
                else
                {
                    this.matrix[row, col] = value;
                }
            }
        }

        // Problem 6. Matrix operations
        // + Operator
        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            Matrix<T> third = new Matrix<T>(first.Row, first.Col);

            if (first.Row != second.Row || first.Col != second.Col)
            {
                throw new InvalidOperationException("The size of the matrices are different!");
            }
            else
            {
                for (int i = 0; i < third.Row; i++)
                {
                    for (int j = 0; j < third.Col; j++)
                    {
                        third[i, j] = (dynamic)first[i, j] + (dynamic)second[i, j];
                    }
                }
            }
            return third;
        }

        // - Operator
        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            Matrix<T> third = new Matrix<T>(first.Row, first.Col);

            if (first.Row != second.Row || first.Col != second.Col)
            {
                throw new InvalidOperationException("The size of the matrices are different!");
            }
            else
            {
                for (int i = 0; i < third.Row; i++)
                {
                    for (int j = 0; j < third.Col; j++)
                    {
                        third[i, j] = (dynamic)first[i, j] - (dynamic)second[i, j];
                    }
                }
            }
            return third;
        }

        // * Operator
        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            Matrix<T> third = new Matrix<T>(first.Row, second.Col);

            if (first.Row != second.Col || first.Col != second.Row)
            {
                throw new InvalidOperationException("The size of the matrices are different!");
            }
            else
            {
                for (int i = 0; i < first.Row; i++)
                {
                    for (int j = 0; j < second.Col; j++)
                    {
                        for (int k = 0; k < first.Col; k++)
                        {
                            third[i, j] += (dynamic)first[i, k] * (dynamic)second[k, j];
                        }
                    }
                }
            }
            return third;
        }

        // true Operator
        public static bool operator true(Matrix<T> Matrix)
        {
            int count = 0;
            for (int i = 0; i < Matrix.Row; i++)
            {
                for (int j = 0; j < Matrix.Col; j++)
                {
                    if (Matrix[i, j] == (dynamic)0)
                    {
                        count++;
                    }
                }
            }
            if (count == 0) return false; // fals, nu sunt elemente de 0
            else return true;  // adevarat, sunt elemente de 0
        }
        public static bool operator false(Matrix<T> Matrix)
        {
            int count = 0;
            for (int i = 0; i < Matrix.Row; i++)
            {
                for (int j = 0; j < Matrix.Col; j++)
                {
                    if (Matrix[i, j] == (dynamic)0)
                    {
                        count++;
                    }
                }
            }
            if (count != 0) return true; // adevarat, sunt elemente de 0
            else return false; // fals, nu sunt elemente de 0
        }

        public void Print()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("Row ({0}): ", i);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
