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
        [InlineData(20,4)]
        public void IsArrayElementSumEqualToNumber_ReturnsTrue(int number, int parts)
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


        public void IsDifferenceZero_ReturnsTrue(){
            
        }
    }
}
