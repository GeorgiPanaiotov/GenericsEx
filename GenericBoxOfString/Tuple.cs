using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Tuple<TFirst, TSecond>
    {
        public Tuple(TFirst first, TSecond second)
        {
            Item1 = first;
            Item2 = second;
        }
        public TFirst Item1 { get; set; }
        public TSecond Item2 { get; set; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
    }
}
