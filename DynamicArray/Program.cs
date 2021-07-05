using System;

namespace DynamicArray
{

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
