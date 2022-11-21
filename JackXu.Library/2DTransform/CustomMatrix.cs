using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JackXu.Library._2DTransform
{
    public struct CustomMatrix
    {
        public CustomMatrix(double m11, double m12, double m21, double m22, double offsetX, double offsetY)
        {
            M11 = m11;
            M12 = m12;
            M21 = m21;
            M22 = m22;
            OffsetX = offsetX;
            OffsetY = offsetY;
        }

        public double M11 { get; private set; }
        public double M12 { get; private set; }
        public double M21 { get; private set; }
        public double M22 { get; private set; }
        public double OffsetX { get; private set; }
        public double OffsetY { get; private set; }

        public double Determinant { get { return M11 * M22 - M12 * M21; } }
        public bool IsIdentity { get { return Determinant == 1; } }
        public bool HasInverse { get { return Determinant != 0; } }
        public CustomMatrix Inverse { get { return ComputeDeterminant(); } }

        private CustomMatrix ComputeDeterminant()
        {
            CustomMatrix inverse = new();
            if (HasInverse)
            {
                inverse = new CustomMatrix(
                                M22 / Determinant, -M12 / Determinant,
                                -M21 / Determinant, M11 / Determinant,
                                OffsetX, OffsetY
                                );
            }
            return inverse;
        }


        public void Scale(double x=1, double y=1)
        {
            var homogenous = new CustomMatrix(x, 0, 0, y, 0, 0);
            this *=homogenous;
        }

        public void Translate(double dx = 0, double dy = 0)
        {
            var homogenous = new CustomMatrix(1, 0, 0, 1, dx, dy);
            this *= homogenous;
        }

        public void Rotate(double angle)
        {
            angle*=Math.PI/180;
            var homogenous = new CustomMatrix(Math.Cos(angle), Math.Sin(angle), -Math.Sin(angle), Math.Cos(angle), 0, 0);
            this *= homogenous;
        }
        public void RotateAt(double angle, double x,double y)
        {
            angle = angle * Math.PI / 180;
            var HomogenousStart = new CustomMatrix(1, 0, 0, 1, -x, -y);
            var HomogenousMid = new CustomMatrix(Math.Cos(angle), Math.Sin(angle), -Math.Sin(angle), Math.Cos(angle), 0, 0);
            var Homogenousend = new CustomMatrix(1, 0, 0, 1, x, y);

            var Homogenous = HomogenousStart * HomogenousMid * Homogenousend;
            this *= Homogenous;
        }

        public void Skew(double angleX, double angleY)
        {
            angleX = angleX * Math.PI / 180;
            angleY = angleY * Math.PI / 180;
            var Homogenous = new CustomMatrix(1, Math.Tan(angleY), Math.Tan(angleX), 1, 0, 0);
            this *=  Homogenous;
        }

        public static CustomMatrix operator * (CustomMatrix m1, CustomMatrix m2)
        {
            double m11= m1.M11 * m2.M11 + m1.M12 * m2.M21;
            double m12= m1.M11 * m2.M12 + m1.M12 * m2.M22;
            double m21= m1.M21 * m2.M11 + m1.M22 * m2.M21;
            double m22= m1.M21 * m2.M12 + m1.M22 * m2.M22; 
            double offsetX= m1.OffsetX * m2.M11 + m1.OffsetY * m2.M21 + m2.OffsetX;
            double offsetY= m1.OffsetX * m2.M12 + m1.OffsetY * m2.M22 + m2.OffsetY;
            return new CustomMatrix(m11, m12,m21,m22,offsetX,offsetY);  
                
        }

        public static bool operator == (CustomMatrix m1, CustomMatrix m2)
        {
            if (
                m1.M11== m2.M11 &&
                m1.M12== m2.M12 &&
                m1.M21== m2.M21 &&
                m1.M22== m2.M22 &&
                m1.OffsetX== m2.OffsetX &&
                m1.OffsetY== m2.OffsetY
                )
                return true;
            else
                return false;
        }
        public static bool operator !=(CustomMatrix m1, CustomMatrix m2)
        {
            return !(m1 == m2);
        }

       


    }
    
}
