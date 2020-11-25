using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int lenght, T item)
        {
            T[] tArr = new T[lenght];
            for (int i = 0; i < tArr.Length; i++)
            {
                tArr[i] = item;
            }
            return tArr;
        }
        
    }
}
