using System;

namespace JackXu.WPF._2DTransformation.ViewModels
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

        public double M11 { get; }
        public double M12 { get; }
        public double M21 { get; }
        public double M22 { get; }
        public double OffsetX { get; }
        public double OffsetY { get; }

        public CustomMatrix Scale(double sx, double sy)
        {
            var customMatrix=new CustomMatrix(M11, M12,M21,M22, OffsetX,OffsetY);
            var Homogenous = new CustomMatrix(sx, 0, 0, sy, 0, 0);

            var m3= customMatrix* Homogenous;
            return m3;
        }

        public CustomMatrix Translate(double dx, double dy)
        {
            var customMatrix = new CustomMatrix(M11, M12, M21, M22, OffsetX, OffsetY);
            var Homogenous = new CustomMatrix(1, 0, 0, 1, dx, dy);

            var m3 = customMatrix* Homogenous;
            return m3;
        }
        public CustomMatrix Rotate(double angle)
        {
            angle = angle * Math.PI / 180;
            var customMatrix = new CustomMatrix(M11, M12, M21, M22, OffsetX, OffsetY);
            var Homogenous = new CustomMatrix(Math.Cos(angle), Math.Sin(angle), -Math.Sin(angle), Math.Cos(angle), 0, 0);

            var m3 = customMatrix * Homogenous;
            return m3;
        }

        public CustomMatrix RotateAt(double angle, double x, double y)
        {
            angle = angle * Math.PI / 180;
            var customMatrix = new CustomMatrix(M11, M12, M21, M22, OffsetX, OffsetY);
            var HomogenousStart = new CustomMatrix(1, 0, 0, 1, -x, -y);
            var HomogenousMid = new CustomMatrix(Math.Cos(angle), Math.Sin(angle), -Math.Sin(angle), Math.Cos(angle), 0, 0);
            var Homogenousend = new CustomMatrix(1, 0, 0, 1, x, y);

            var Homogenous = HomogenousStart * HomogenousMid * Homogenousend;

            var m3 = customMatrix * Homogenous;
            return m3;
        }



        public CustomMatrix Skew(double angleX, double angleY)
        {
            angleX = angleX * Math.PI / 180;
            angleY = angleY * Math.PI / 180;
            var customMatrix = new CustomMatrix(M11, M12, M21, M22, OffsetX, OffsetY);
            var Homogenous = new CustomMatrix(1, Math.Tan(angleY), Math.Tan(angleX), 1, 0, 0);
            var m3 = customMatrix * Homogenous;
            return m3;
        }

        public static CustomMatrix operator * (CustomMatrix matrix1, CustomMatrix matrix2)
        {
            var m1=MatrixToArray(matrix1);
            var m2=MatrixToArray(matrix2);

            var m3=ArrayMultiply(m1,m2);

            return ArrayToMatrix(m3);
        }

        public static double [,] MatrixToArray(CustomMatrix matrix)
        {
            double[,] arrMatrix=new double[3,3];

            arrMatrix[0,0] = matrix.M11;
            arrMatrix[1,0] = matrix.M21;
            arrMatrix[2,0] = matrix.OffsetX;

            arrMatrix[0, 1] = matrix.M12;
            arrMatrix[1, 1] = matrix.M22;
            arrMatrix[2, 1] = matrix.OffsetY;

            arrMatrix[0, 2] = 0;
            arrMatrix[1, 2] = 0;
            arrMatrix[2, 2] = 1;


            return arrMatrix;

        }

        public static CustomMatrix ArrayToMatrix(double[,] arr)
        {
            return new CustomMatrix( arr[0,0], arr[0,1], arr[1,0],arr[1,1],arr[2,0],arr[2,1]); 
        }

        private static double[,] ArrayMultiply(double[,] A, double[,] B)
        {
            double[,] C= new double[3, 3];
            double sumC = 0;
            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < 3; i++)
                {
                    sumC = 0;
                    for (int j = 0; j < 3; j++)
                    {
                        sumC += A[i, j] * B[j, k];
                    }
                    C[i, k] = sumC;
                }
            }
            return C;
        }
    }
}
