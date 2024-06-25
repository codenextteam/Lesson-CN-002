using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MyGeneric<T>
    {
        public T[] values;

        //constructor => qurucu method default method
        public MyGeneric()
        {
            values = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = values;
            values = new T[values.Length+1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                values[i] = tempArray[i];
            }
            values[values.Length-1] = item;
            Console.WriteLine(values.Length);
        }
  
    }
}
