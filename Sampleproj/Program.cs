using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleproj
{
    class Program
    {
        void GetNumbers() 
        {
            int iNum1 = 0, iNum2 = 0;
            iNum1 = int.MaxValue;
            Console.WriteLine("The value of Num1 is " + iNum1);
            iNum1++;
            Console.WriteLine("The value of Num1 after increment is " + iNum1);
            
        }
        static void Main(string[] args)
        {
            new Program().GetNumbers();
            Console.ReadKey();
        }
    }
}
