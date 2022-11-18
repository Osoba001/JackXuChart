using JackXu.Library._2DTransform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackXu.Test._2DTransform.Fixtures
{
    public struct MatrixFixture
    {
        public static CustomMatrix Matrix1()
        {
            return new CustomMatrix(1,2,3,4,0,0);
        }
        public static CustomMatrix Matrix2()
        {
            return new CustomMatrix(1, 2, 3, 4, 0, 1);
        }
        public static CustomMatrix ScaledMatrix2by1xHalf()
        {
            return new CustomMatrix(1, 1, 3, 2, 0, 0.5);
        }
        public static CustomMatrix IdentityMatrix()
        {
            return new CustomMatrix(1, 0, 0, 1, 0, 0);
        }
        public static CustomMatrix TranslatedMatrix2by1xHalf()
        {
            return new CustomMatrix(1, 2, 3, 4, 1, 1.5);
        }
        public static CustomMatrix RotatedMatrix2By45()
        {
            return new CustomMatrix(-0.707, 2.121, -0.707, 4.949, -0.707, 0.707);
        }
    }
}
