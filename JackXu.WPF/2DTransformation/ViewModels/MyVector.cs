using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace JackXu.WPF._2DTransformation.ViewModels
{
    public struct MyVector
    {
        public MyVector(double xCoordinate, double yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }
       

        public double XCoordinate { get; set; }
        public double YCoordinate { get; set; }

        public double Length
        {
            get { return ComputeLength(); }
        }

        public double NormalizedX
        {
            get { return XCoordinate/Length; }
        }
        public double NormalizedY
        {
            get { return YCoordinate / Length; }
        }

        private double ComputeLength()
        {
           return Math.Sqrt(XCoordinate * XCoordinate + YCoordinate * YCoordinate);
        }

        public static MyVector operator + (MyVector vector1,MyVector vector2)
        {
            var xcoordinate = vector1.XCoordinate + vector2.XCoordinate;
            var ycoordinate = vector1.YCoordinate + vector2.YCoordinate;
            return new MyVector(xcoordinate, ycoordinate);
        }

        public static MyVector operator -(MyVector vector1, MyVector vector2)
        {
            var xcoordinate = vector1.XCoordinate - vector2.XCoordinate;
            var ycoordinate = vector1.YCoordinate - vector2.YCoordinate;
            return new MyVector(xcoordinate, ycoordinate);
        }

        
    }
}
