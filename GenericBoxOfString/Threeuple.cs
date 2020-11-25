using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Threeuple<TFirst, TSecond, TThird>
    {
        public Threeuple()
        {

        }
        public Threeuple(TFirst first, TSecond second, TThird third)
        {
            Item1 = first;
            Item2 = second;
            Item3 = third;
        }
        public TFirst Item1 { get; set; }
        public TSecond Item2 { get; set; }
        public TThird Item3 { get; set; }


        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }
    }

}
