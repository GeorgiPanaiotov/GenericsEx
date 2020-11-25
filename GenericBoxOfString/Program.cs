using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            Threeuple<string, string, string> threeuple1 = new Threeuple<string, string, string>();
            if (firstInput.Length == 5)
            {
                Threeuple<string, string, string> threeupleOne = new Threeuple<string, string, string>(firstInput[0] + " " + firstInput[1]
                    , firstInput[2]
                    , firstInput[3] + " " + firstInput[4]
                    );
                threeuple1 = threeupleOne;
            }
            else
            {
                Threeuple<string, string, string> threeupleOne = new Threeuple<string, string, string>(firstInput[0] + " " + firstInput[1]
                    , firstInput[2]
                    , firstInput[3]
                    );
                threeuple1 = threeupleOne;
            }

            string[] secondInput = Console.ReadLine().Split();
            bool isDrunk = false;
            if (secondInput[2] == "drunk")
            {
                isDrunk = true;
            }
            else
            {
                isDrunk = false;
            }

            Threeuple<string, int, bool> threeuple2 = new Threeuple<string, int, bool>(secondInput[0], int.Parse(secondInput[1])
                , isDrunk
                );

            string[] thirdInput = Console.ReadLine().Split();

            Threeuple<string, double, string> threeuple3 = new Threeuple<string, double, string>(thirdInput[0], double.Parse(thirdInput[1])
                , thirdInput[2]
                );

            Console.WriteLine(threeuple1);
            Console.WriteLine(threeuple2);
            Console.WriteLine(threeuple3);
        }
    }
}
