using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doNetCSharpTut
{
    class Program
    {
        static void Main(string[] args)
        {
            int searchParam;
            Console.WriteLine("LinearSearchOnInt");
            searchParam = Convert.ToInt32(Console.ReadLine());
            int[] testArr = { 44, 55, 1, 2, 5, 588, 7, 7, 1, 0, 4, 78 };
            //int searchDataPosition;
            SapSearch s = new SapSearch();
            //Console.WriteLine(s.LinearSearchOnInt(testArr, searchParam, out searchDataPosition));
            //Console.WriteLine(searchDataPosition);


            StartPattern SP = new StartPattern();
            //SP.printTriangle(searchParam);

            SP.printDiagonal(searchParam);

            Console.ReadLine();
        }
    }
}
