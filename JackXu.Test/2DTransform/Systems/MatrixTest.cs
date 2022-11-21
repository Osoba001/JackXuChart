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
        public void RotateAt_WhenPassedAngle_RotatedMatrix()
        {
            var m = MatrixFixture.Matrix2();
            
            m.Rotate(45);
            double preci = 0.01;
            m.M11.Should().BeApproximately(MatrixFixture.RotatedMatrix2By45().M11, preci);
            m.M12.Should().BeApproximately(MatrixFixture.RotatedMatrix2By45().M12, preci);
            m.M21.Should().BeApproximately(MatrixFixture.RotatedMatrix2By45().M21, preci);
            m.M22.Should().BeApproximately(MatrixFixture.RotatedMatrix2By45().M22, preci);
            m.OffsetX.Should().BeApproximately(MatrixFixture.RotatedMatrix2By45().OffsetX, preci);
            m.OffsetY.Should().BeApproximately(MatrixFixture.RotatedMatrix2By45().OffsetY, preci);
        }

        [Fact]
        public void Rotate_WhenPassedAngle_RotatedMatrix()
        {
            var m = MatrixFixture.Matrix2();
            m.RotateAt(45,1,2);
            double preci = 0.01;
            m.M11.Should().BeApproximately(MatrixFixture.RotatedAtMatrix2By45().M11, preci);
            m.M12.Should().BeApproximately(MatrixFixture.RotatedAtMatrix2By45().M12, preci);
            m.M21.Should().BeApproximately(MatrixFixture.RotatedAtMatrix2By45().M21, preci);
            m.M22.Should().BeApproximately(MatrixFixture.RotatedAtMatrix2By45().M22, preci);
            m.OffsetX.Should().BeApproximately(MatrixFixture.RotatedAtMatrix2By45().OffsetX, preci);
            m.OffsetY.Should().BeApproximately(MatrixFixture.RotatedAtMatrix2By45().OffsetY, preci);
        }

        [Fact]
        public void Determinant_GetDeterminant()
        {
            var m = MatrixFixture.IdentityMatrix();
            m.Determinant.Should().Be(1);
            m.HasInverse.Should().BeTrue();
            m.IsIdentity.Should().BeTrue();
        }
    }
}
