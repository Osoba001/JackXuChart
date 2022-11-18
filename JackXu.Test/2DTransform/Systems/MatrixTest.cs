using FluentAssertions;
using JackXu.Library._2DTransform;
using JackXu.Test._2DTransform.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JackXu.Test._2DTransform.Systems
{
    public class MatrixTest
    {
        [Fact]
        public void MultiplyMatrix_WhenTwoMatrixPassIn_ReturnProduct()
        {

            CustomMatrix m1 = MatrixFixture.Matrix1();
            CustomMatrix m2 = MatrixFixture.IdentityMatrix();

            var result = m1 * m2;

            result.Should().BeEquivalentTo(m1);
        }

        [Fact]
        public void CompareMatrix_WhenTwoMatrixNotSame_ReturnFalse()
        {
            CustomMatrix m1 = MatrixFixture.Matrix1();
            CustomMatrix m2 = MatrixFixture.Matrix2();

            var result = m1 ==m2;
            result.Should().BeFalse();
        }

       [Fact]
       public void Scale_whenPassedXAndY_ScaleMatrix()
        {
            var m = MatrixFixture.Matrix2();
            m.Scale(1,0.5);
            m.Should().BeEquivalentTo(MatrixFixture.ScaledMatrix2by1xHalf());
        }

        [Fact]
        public void Translate_WhenPassedDxAndDy_Translated()
        {
            var m = MatrixFixture.Matrix2();
            m.Translate(1,0.5);
            m.Should().BeEquivalentTo(MatrixFixture.TranslatedMatrix2by1xHalf());
        }
        [Fact]
        public void Rotate_WhenPassedAngle_RotatedMatrix()
        {
            var m = MatrixFixture.Matrix2();
            m.Rotate(45);
            m.Should().BeEquivalentTo(MatrixFixture.RotatedMatrix2By45());
        }
    }
}
