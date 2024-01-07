using Labs._14;

namespace Tests
{
    public class ArrayFunctionsTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void GetRandomArrayThrowsErrorIfLengthIsNegativeOrZero(int length)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayFunctions.GetRandomArray(length));
        }

        [Fact]
        public void GetRandomArrayReturnMatixWithChoosenLength()
        {
            int length = 2;
            var array = ArrayFunctions.GetRandomArray(length);
            Assert.Equal(length, array.Length);
        }

        [Fact]
        public void CountGreaterThenReturnsRightValue()
        {
            int[] array = { 1, 3, 2, 5, -2 };
            Assert.Equal(3, ArrayFunctions.CountGreaterThen(array, 1));
        }

        [Fact]
        public void GetProductValueAfterMaxReturnsRightValue()
        {
            int[] array = { 1, -13, 5, 4, -2 };
            Assert.Equal(-40, ArrayFunctions.GetProductArrayAfterMax(array));
        }

        [Fact]
        public void IsSortedByAscending()
        {
            int[] array = { 1, 3, 5, 0, 4, -2 };
            var sorted = array.OrderBy(i => i).ToArray();
            Assert.Equal(sorted, ArrayFunctions.SortArray(array));
        }
    }
}