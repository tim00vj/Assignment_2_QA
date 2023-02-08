using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_G12_A2_App
{
    public class Circle
    {
        public int radius;
        public Circle()
        {
            radius = 1;
        }

        public Circle(int user_radius)
        {
            radius = user_radius;
        }

        public int GetCircleRadius()
        {

            return this.radius;
        }
        public void ChangeCircleRadius(int user_radius)
        {

            this.radius = user_radius;
        }

        public double GetCircleCircumference()
        {
            return 2 * 3.14 * radius;
        }
        public double GetCircleArea()
        {
            return 3.14 * radius * radius;
        }
    }
}
