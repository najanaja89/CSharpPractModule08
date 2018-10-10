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
            try
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
            if (endIndexInt <= startIndexInt)

            { Console.WriteLine("end index must be bigger than start index!"); }

            RangeOfArray array = new RangeOfArray(startIndexInt, endIndexInt);

                Console.WriteLine();
                for (int i = 0; i < array.Size; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
