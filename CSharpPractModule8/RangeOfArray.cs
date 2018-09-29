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
        private int size;
        public int Size
        {
            get
            {
                size = HighIndexArray - LowIndexArray;
                return size;
            }
   
        }


        

        private string[] customArray;
        public string this[int index]
        {   
            get { return customArray[index]; }
            set { customArray[index] = value; }
        }
    }
}
