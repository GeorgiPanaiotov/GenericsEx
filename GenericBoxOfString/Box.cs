using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T> where T: IComparable
    {
        public List<T> Values { get; set; } = new List<T>();

        public Box(List<T> input)
        {
            this.Values = input;
        }
        public int CountGreaterValues(T input)
        {
            int count = 0;

            foreach (var value in Values)
            {
                if (value.CompareTo(input) > 0)
                {
                    count++;
                }
            }
            return count;
        }
        public void Swap(int indexOne, int indexTwo)
        {
            var item = Values[indexOne];
            var secondItem = Values[indexTwo];
            Values.RemoveAt(indexOne);
            Values.Insert(indexOne, secondItem);
            Values.RemoveAt(indexTwo);
            Values.Insert(indexTwo, item);
        }
        public override string ToString()
        {
            return $"{Values[0].GetType()}: ";
        }
    }
}
