using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects
{
    public class Circle
    {
        private double Radius {  get; set; }

        public Circle(double radius) 
        { 
            Radius = radius;
        }   


        public double CalculateDiamter(double radius)
        {
            double diameter = radius * 2;
            return diameter;
        }
        public double CalculateCircumference(double radius)
        {
            double cirdumference = 2 * radius * System.Math.PI;
            return cirdumference;
        }
        public double CalculateArea(double radius)
        {
            double area = radius * radius * System.Math.PI;
            return area;
        }

        public void Grow(Circle circle)
        {
            Radius *= 2;
        }

        public double GetRadius(Circle circle)
        {
            double radius = Radius;
            return radius;
        }


    }
}
