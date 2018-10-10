using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractModule8
{
    public class RangeOfArray
    {
        public int LowIndexArray { get; set; }
        public int HighIndexArray { get; set; }
        public int Size { get; }
        string[] customArray;

        public RangeOfArray(int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                HighIndexArray = highIndex;
                LowIndexArray = lowIndex;
                int size = (HighIndexArray - LowIndexArray) + 1;
                Size = size;
                customArray = new string[size];

                int tmp = LowIndexArray;
                for (int i = 0; i < size; i++)
                {
                    customArray[i] = ("\tstring " + tmp);
                    tmp++;
                }
            }
            else throw new Exception("RangeOfArray object error: low index must be smaller than high index");
        }

        public string this[int index]
        {   
            get { return customArray[index]; }
            set { customArray[index] = value; }
        }
    }
}
