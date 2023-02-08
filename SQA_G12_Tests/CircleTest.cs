﻿using NUnit.Framework;
using SQA_G12_A2_App;
using System;

namespace SQA_G12_A2.Test
{
        public class CircleTest
    {
        [Test]
        public void GetCircleRadius_Positive_Test()
        {
            Circle c = new Circle(5);

            var radius = c.GetCircleRadius();
            Assert.AreEqual(5, radius);
        }

        [Test]
        public void GetCircleRadius_Neg_Test()
        {
            Circle c = new Circle(5);
            var radius = c.GetCircleRadius();
            Assert.AreNotEqual(1, radius);
        }

        [Test]
        public void ChangeCircleRadius_Positive_Test()
        {
            Circle c = new Circle(10);
           
            c.ChangeCircleRadius(4);
           
            var radius = c.GetCircleRadius();
            Assert.AreEqual(4, radius);
        }

        [Test]
        public void ChangeCircleRadius_Neg_Test()
        {
            Circle c = new Circle(10);

            c.ChangeCircleRadius(4);

            var radius = c.GetCircleRadius();
            Assert.AreNotEqual(10, radius);
        }

        [Test]
        public void GetCircleCircumference_Positive_Test()
        {
            Circle c = new Circle(10);
            Assert.AreEqual(2 * 3.14 * 10, c.GetCircleCircumference());
        }

  
        [Test]
        public void GetCircleArea_Positive_Test()
        {
            Circle c = new Circle(10);
            Assert.AreEqual(3.14 *10* 10, c.GetCircleArea());
        }
    }
}
