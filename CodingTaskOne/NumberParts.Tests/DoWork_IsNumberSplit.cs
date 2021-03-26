using System;
using Xunit;
using NumberPartsLibrary;

namespace NumberParts.Tests
{
    public class DoWork_SplitNumber
    {
        [Theory]
        [InlineData(9,3)]
        [InlineData(25,5)]
        [InlineData(11,4)]
        [InlineData(20,4)]
        public void IsArrayElementSumEqualToNumber_ReturnsArray(int number, int parts)
        {
            var processor = new Processor();
            int[] result = processor.DoWork(number,parts);
            int sum = 0;
            for (int i = 0; i < result.Length; i++)
            {
                sum += result[i];
            }

            Assert.True(sum.Equals(number), $"Sum {sum}  not equal to number {number} !");
        }

        [Theory]
        [InlineData(9,3)]
        [InlineData(25,5)]
        [InlineData(11,4)]
        [InlineData(20,4)]
        public void IsDifferenceZero_ReturnsArray(int number, int parts){
            var processor = new Processor();
            int[] result = processor.DoWork(number,parts);
            int difference = result[result.Length - 1] - result[0];

            Assert.True(difference.Equals(0), $"Difference {difference}  not equal to 0 !");
        }

        [Theory]
        [InlineData(11,4)]
        [InlineData(20,6)]
        public void IsDifferenceOne_ReturnsArray(int number, int parts){
            var processor = new Processor();
            int[] result = processor.DoWork(number,parts);
            int difference = result[result.Length - 1] - result[0];

            Assert.True(difference.Equals(1), $"Difference {difference}  not equal to 1 !");
        }
    }
}
