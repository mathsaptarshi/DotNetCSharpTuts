using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doNetCSharpTut
{
    class StartPattern
    {
        //basic pattern square
        public void printSquare(int n)
        {           
            for(int i = 0; i< n; i++)
            {
                for (int j = 0; j < n; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        //basic pattern square
        public void printTriangle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void printDiagonal(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }


    }
}
