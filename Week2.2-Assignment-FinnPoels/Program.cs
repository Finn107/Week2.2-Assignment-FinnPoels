using System;

namespace Week2._2_Assignment_FinnPoels
{
    class Program
    {
        static void Main(string[] args)
        {
            // ASSIGNMENT : METHODS

            #region Assignment 01
            // 01. Create a method which accepts height and base (width) of a triangle as parameters,
            void Triangle()
            {
                int width = 10;
                int totalwidth;
                int height = 10;
                int area;

                Console.WriteLine("Assignment 1:");
                Console.WriteLine();

                Console.WriteLine("The width of your triangles each side is 10");
                Console.WriteLine("The height of your triangle is 10");
                //     with that calculates and returns the area the triangle.

                totalwidth = width * 3;
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("The total width = " + totalwidth);
                System.Threading.Thread.Sleep(500);

                //     The formula to calculate the area of a trinagle is:
                //     Area = 0.5 * (base * height)
                area = totalwidth * height;
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("The area = " + area);
            }
            Triangle();
            #endregion

            #region Assignment 02
            // 02. Rewrite the ArrowDamageCalculator in such a way that damage is also provided as a parameter
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Assignment 2:");
            Console.WriteLine();

            int ArrowDamage = 50;
            int distance = 50;
            if (distance == 50)
            {
                ArrowDamage = ArrowDamage;
                Console.WriteLine("You did " + ArrowDamage + " damage!");
            }
            if (distance > 50 && distance < 100)
            {
                ArrowDamage = ArrowDamage;
                Console.WriteLine("You did " + ArrowDamage + " damage!");
            }
            if (distance < 50)
            {
                ArrowDamage = ArrowDamage * 2;
                Console.WriteLine("Your close range damage will be multiplied!");
                Console.WriteLine("You did " + ArrowDamage + " damage!");
            }
            if (distance > 100)
            {
                ArrowDamage = ArrowDamage / 2;
                Console.WriteLine("Your Long range damage will be decreased!");
                Console.WriteLine("You did " + ArrowDamage + " damage!");
            }
            #endregion

            #region Assignment 03
            // 03. Rewrite the ArrowDamageCalculator again implementing the following:
            //       - The method has the following parameters [pull] and [distance].
            //       - When [pull = 10] and [distance = 10], [damage = 50].
            //       - When [pull = 50] and [distance = 10], [damage = 250].
            //       - when [pull = 9000] and [distance = 1], [damage = 4500].
            //       - Do not use IF statements, but try to figure out the formula
            //         and use it in the method to calculate the damage.

            

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Assignment 3:");
            Console.WriteLine();

            void ArrowDamageCalculator()
            {
                // Pull = 10 - Distance = 10 - Damage = 10
                Console.WriteLine("1. Pull = 10 - Distance = 10 - Damage = 50");
                int ArrowDamage;
                int distance;
                int pull;

                ArrowDamage = 0;
                distance = 10;
                pull = 10;

                ArrowDamage = (int)(distance * (pull * 0.5));
                Console.WriteLine(ArrowDamage);
                Console.WriteLine("You did " + ArrowDamage + " damage!");

                // Pull = 50 - Distance = 10 - Damage = 250
                System.Threading.Thread.Sleep(500);
                Console.WriteLine();
                Console.WriteLine("2. Pull = 10 - Distance = 50 - Damage = 250");
                ArrowDamage = 0;
                distance = 50;
                pull = 10;

                ArrowDamage = (int)(distance * (pull * 0.5));
                Console.WriteLine(ArrowDamage);
                Console.WriteLine("You did " + ArrowDamage + " damage!");

                // Pull = 9000 - Distance = 1 - Damage = 4500
                System.Threading.Thread.Sleep(500);
                Console.WriteLine();
                Console.WriteLine("3. Pull = 9000 - Distance = 1 - Damage = 4500");
                ArrowDamage = 0;
                distance = 1;
                pull = 9000;

                ArrowDamage = (int)(distance * (pull * 0.5));
                Console.WriteLine(ArrowDamage);
                Console.WriteLine("You did " + ArrowDamage + " damage!");

            }
            ArrowDamageCalculator();
            #endregion

            #region Assignment 04
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Assignment 4:");
            Console.WriteLine();
            // 04. Create a method called TargetHit() and add the following:
            void TargetHit()
            {
                //       - Input parameters are damage and distance.
                int damage = 1000;
                int distance = 500;
                bool target;

                //       - The target is destroyed when damage > distance to the target.

                if (damage > distance)
                {
                    Console.WriteLine("You have exploded on your ship!");
                    //       - Return False when the target is destroyed.
                    target = false;
                    Console.WriteLine(target);
                }
                if (damage < distance)
                {
                    Console.WriteLine("You have exploded your enemies ship!");
                    target = true;
                    Console.WriteLine(target);
                }
            }
            //       - Return True when the target is destroyed.
            TargetHit();
            #endregion

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
