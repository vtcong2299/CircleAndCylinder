using System;

namespace CircleAndCylinder
{
    class Cylinder:Circle
    {
        private double width = 1.0;
        public double Width
        {
            get => width; set => width = value;
        }
        public Cylinder(){}
        public Cylinder(double width, double radius, string color):base (radius,color)
        {
            this.width =  width;
        }
        public double GetCylinderArea()
        {
            return Math.Round((width*GetCircleParimeter())+(2*GetCircleArea()),2);
        }
        public double GetCylinderVolume()
        {
            return Math.Round(width*GetCircleArea(),2);
        }
        public override string ToString()
        {
            return $"Hinh tru co chieu cao la: {width} \nBan kinh day la: {radius} \nMau sac: {color}" 
                    +$"\nDien tich la: {GetCylinderArea()} \nThe tich la: {GetCylinderVolume()}";
        }
    }
}