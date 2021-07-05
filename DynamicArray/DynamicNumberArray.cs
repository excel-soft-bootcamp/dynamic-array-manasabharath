using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    public class DynamicNumberArray
    {
        int[] buffer;
        public void DynamicArray()
        {
            buffer = new int[5];
            
        }
            public void DynamicArray(int initialSize)             
            { 
            buffer = new int[initialSize]; 
            }

            public void Set(int index, int value)
            {

                buffer[index] = value;
            }
            public int Get(int index)
            {
                return buffer[index];
            }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            DynamicNumberArray _dynamic = new DynamicNumberArray();
            _dynamic.DynamicArray();
            _dynamic.Set(4, 60);


            int value = _dynamic.Get(4);
            Console.WriteLine(value);
        }
    }
}
