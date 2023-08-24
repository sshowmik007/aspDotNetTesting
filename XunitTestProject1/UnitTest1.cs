using Xunit;
using System;
using SampleAppRazorPage.Services;
using Math = SampleAppRazorPage.Services.Math;

namespace XunitTestProject1

{
    public class MathTests
    {
        [Fact]
        public void TestAddition_PositiveNumbers()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = Math.Add(a, b);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestAddition_NegativeNumbers()
        {
            // Arrange
            int a = -2;
            int b = -3;

            // Act
            int result = Math.Add(a, b);

            // Assert
            Assert.Equal(-5, result);
        }

        [Fact]
        public void TestAddition_Zero()
        {
            // Arrange
            int a = 0;
            int b = 0;

            // Act
            int result = Math.Add(a, b);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestAddition_MaxValue()
        {
            // Arrange
            int a = int.MaxValue - 1;
            int b = 1;

            // Act
            int result = Math.Add(a, b);

            // Assert
            Assert.Equal(int.MaxValue, result);
        }

        [Fact]
        public void TestAddition_MinValue()
        {
            // Arrange
            int a = int.MinValue + 1;
            int b = -1;

            // Act
            int result = Math.Add(a, b);

            // Assert
            Assert.Equal(int.MinValue, result);
        }
    }
}