using FluentAssertions;
using JackXu.Library._2DTransform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JackXu.Test._2DTransform.Systems
{
    public class VectorTest
    {

        [Theory]
        [InlineData(3,4)]
        [InlineData(0.34, 19.711)]
        [InlineData(-5,-6)]
        [InlineData(11,0)]
        [InlineData(0,20)]
        public void Normalized_WhenBothXAndYAreNotZero_LengthMustBeOne(double x, double y)
        {
            CustomVector v= new(x,y);

            v.Normalize();

            v.Length.Should().Be(1);
        }
        [Fact]
        public void Normalized_WhenBothXAndYAreZero_LengthMustBeZero()
        {
            CustomVector v = new CustomVector(0, 0);

            v.Normalize();

            v.Length.Should().Be(0);
        }

        [Fact]
       public void AngleBtw2Vector_When2VectorsPassed_ReturnDouble()
        {
            CustomVector v1 = new(20, 10);
            CustomVector v2 = new(10, 20);
           

            var res= CustomVector.AngleBtw2Vectors(v1 ,v2);

            res.Should().BeApproximately(36.87, 0.01);
        }

        [Fact]
        public void CrossProductOverLoad()
        {
            CustomVector v1 = new(20, 10);
            CustomVector v2 = new(10, 20);
            var res = CustomVector.CrossProduct(v1,v2);
            res.Should().Be(300);
        }
        
    }
}
