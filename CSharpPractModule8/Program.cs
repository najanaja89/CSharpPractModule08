using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractModule8
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndexInt;
            int endIndexInt;

            Console.WriteLine("Enter start array index ");
            string startIndex = Console.ReadLine();
            if (int.TryParse(startIndex, out startIndexInt)) { }
            else { Console.WriteLine("Value must be a number!"); }
           

            Console.WriteLine("Enter end array index");
            string endIndex = Console.ReadLine();

            if (int.TryParse(endIndex, out endIndexInt)) { }
            else { Console.WriteLine("Value must be a number!"); }
            if (endIndexInt <= startIndexInt) { Console.WriteLine("end index must be bigger than start index!"); }
            
            RangeOfArray array = new RangeOfArray
            {
                HighIndexArray = startIndexInt,
                LowIndexArray = endIndexInt
            };
            Console.ReadLine();
        }
    }
}
