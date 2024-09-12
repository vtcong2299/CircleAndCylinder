using System;
using System.Net.NetworkInformation;

namespace CircleAndCylinder
{
    class Circle
    {
        const double pi = 3.14;
        protected double radius =1.0;
        protected string color = "blue";
        public double Radius 
        {
            get => radius ; set => radius = value;
        }
        public string Color 
        {
            get => color ; set => color = value;
        }
        public Circle(){}
        public Circle(double radius, string color)
        {
            this.radius= radius;
            this.color = color;
        }
        public double GetCircleArea()
        {
            return Math.Round(radius*radius*pi,2);
        }
        public double GetCircleParimeter()
        {
            return Math.Round(2*pi*radius,2);
        }
        public override string ToString()
        {
            return $"Hinh tron co ban kinh la: {radius} \nMau sac: {color}" 
                    +$"\nDien tich la: {GetCircleArea()} \nChu vi la: {GetCircleParimeter()}";
        }
    }
}