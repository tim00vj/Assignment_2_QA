using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_G12_A2_App
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Please enter the radius of the circle");
            //int ru = Convert.ToInt32(Console.ReadLine());
            int ru = 0;
            Circle c = new Circle();
            // Console.WriteLine("this is the radius you entered "+c.GetRadius());
            int userinput;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Set Radius");
                Console.WriteLine("2.Update Radius");


                Console.WriteLine("3.Get Area");
                Console.WriteLine("4.Get Circumference");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Please select a menu");
                userinput = Convert.ToInt32(Console.ReadLine());
                if (userinput == 1)
                {
                    Console.WriteLine("Please enter the radius of the circle\n");
                    ru = Convert.ToInt32(Console.ReadLine());
                    c.ChangeCircleRadius(ru);
                }
                else if (userinput == 2)
                {
                    // Console.WriteLine("The radius value is" + c.GetRadius());
                    Console.WriteLine("Please enter the radius of the circle\n");
                    ru = Convert.ToInt32(Console.ReadLine());
                    c.ChangeCircleRadius(ru);
                }
                else if (userinput == 3)
                {
                    Console.WriteLine("The radius value is " + c.GetCircleArea());
                }

                else if (userinput == 4)
                {
                    Console.WriteLine("The radius value is " + c.GetCircleCircumference());
                }

                else if (userinput == 5)
                {
                    break;
                }


            } while (userinput != 5);
        }

    }
}
