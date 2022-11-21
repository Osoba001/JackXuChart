using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
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
            Length= Math.Sqrt(xCoordinate * xCoordinate + yCoordinate * yCoordinate);
        }
        public double XCoordinate { get; private set; }
        public double YCoordinate { get; private set; }
        public double Length { get; private set; }

        public void Normalize()
        {
            if (XCoordinate is not 0 || YCoordinate is not 0)
            {
                this.XCoordinate /= Length;
                this.YCoordinate /= Length;
                this.Length = Math.Sqrt(XCoordinate * XCoordinate + YCoordinate * YCoordinate);
            }
            else
                this.Length = 0;
        }
        public static double AngleBtw2Vectors(CustomVector v1, CustomVector v2)
        {
            return Math.Asin((v1*v2) / (v1.Length * v2.Length))*180/Math.PI;
        }

        //Operators Overload
        public static CustomVector operator +(CustomVector vector1, CustomVector vector2)
        {
            return new CustomVector(vector1.XCoordinate + vector2.XCoordinate, vector1.YCoordinate + vector2.YCoordinate);
        }
        public static CustomVector operator -(CustomVector vector1, CustomVector vector2)
        {
            return new CustomVector(vector1.XCoordinate - vector2.XCoordinate, vector1.YCoordinate - vector2.YCoordinate);
        }
        public static CustomVector operator *(double scalar, CustomVector vector)
        {
            vector.YCoordinate*= scalar;
            vector.XCoordinate*= scalar;
            return vector;
        }
        public static CustomVector operator /(double scalar, CustomVector vector)
        {
            if (scalar is not 0)
            {
                vector.YCoordinate /= scalar;
                vector.XCoordinate /= scalar;
            }
            return vector;
        }   
        public static double operator *(CustomVector v1, CustomVector v2)
        {
            return v1.XCoordinate * v2.YCoordinate - v1.YCoordinate * v2.XCoordinate;
        }
        public static double DotProduct(CustomVector v1, CustomVector v2)
        {
            return v1.XCoordinate * v2.YCoordinate + v1.YCoordinate * v2.XCoordinate;
        }
        public static double CrossProduct(CustomVector v1, CustomVector v2)
        {
            return v1.XCoordinate * v2.YCoordinate -v1.YCoordinate * v2.XCoordinate;
        }
    }
}
