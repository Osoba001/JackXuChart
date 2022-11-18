using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackXu.Library._2DTransform
{
    public struct CustomVector
    {
        public CustomVector(double xCoordinate, double yCoordinate)
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
            get { return XCoordinate / Length; }
        }
        public double NormalizedY
        {
            get { return YCoordinate / Length; }
        }
        private double ComputeLength()
        {
            return Math.Sqrt(XCoordinate * XCoordinate + YCoordinate * YCoordinate);
        }
        public static CustomVector operator +(CustomVector vector1, CustomVector vector2)
        {

            var xcoordinate = vector1.XCoordinate + vector2.XCoordinate;
            var ycoordinate = vector1.YCoordinate + vector2.YCoordinate;
            return new CustomVector(xcoordinate, ycoordinate);
        }

        public static CustomVector operator -(CustomVector vector1, CustomVector vector2)
        {
            var xcoordinate = vector1.XCoordinate - vector2.XCoordinate;
            var ycoordinate = vector1.YCoordinate - vector2.YCoordinate;
            return new CustomVector(xcoordinate, ycoordinate);
        }
    }
}
