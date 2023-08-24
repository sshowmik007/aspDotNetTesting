using Xunit;
using System;
using SampleAppRazorPage.Services;
using Math = SampleAppRazorPage.Services.Math;

namespace TestProject2

{
    public class MathTest
    {
        [Fact]
        public void TestAddition_PositiveNumbers()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = Math.Add(a, b);

            // Assert (Passing assertion)
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

            // Assert (Passing assertion)
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

            // Assert (Failing assertion)
            Assert.Equal(1, result);  // This should fail
        }

        [Fact]
        public void TestAddition_MaxValue()
        {
            // Arrange
            int a = int.MaxValue - 1;
            int b = 1;

            // Act
            int result = Math.Add(a, b);

            // Assert (Passing assertion)
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

            // Assert (Failing assertion)
            Assert.Equal(int.MinValue, result);  // This should fail
        }
    }
}