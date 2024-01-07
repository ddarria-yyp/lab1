using Labs._14;

namespace Tests
{
    public class MatrixTests
    {
        [Theory]
        [InlineData(-1, - 5)]
        public void GetRandomMatrixThrowsErrorIfLengthIsNegativeOrZero(int rows, int columns)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => MatrixFunctions.GetRandomMatrix(rows, columns));
        }

        [Fact]
        public void GetColumnNumberWithZeroReturnsFirstColumn()
        {
            var matrix = new int[,] {{1, 0, 3}, {1, 1, 4}};
            Assert.Equal(1, MatrixFunctions.GetColumnNumberWithZero(matrix));
        }

        [Fact]
        public void GetColumnNumberWithZeroReturnsNegativeIfNowColumnsWithZero()
        {
            var matrix = new int[,] { { 1, 1, 3 }, { 1, 1, 4 } };
            Assert.Equal(-1, MatrixFunctions.GetColumnNumberWithZero(matrix));
        }

        [Fact]
        public void GetSortedMatrixRetursSortedResult()
        {
            var matrix = new int[,] { { 1, 0, 3, -2, -6 }, { 1, 1, 4, -10, -1 } };
            var sortedMatrix = MatrixFunctions.GetSortedMatrix(matrix);
            Assert.Equal(matrix, sortedMatrix);
            matrix = new int[,] { { 1, 0, 3, -2, -8 }, { 1, 1, 4, -3, -10 } };
            sortedMatrix = MatrixFunctions.GetSortedMatrix(matrix);
            Assert.Equal(matrix, sortedMatrix);
            matrix = new int[,] { { 1, 0, 3, -2, -8 }, { 1, 1, 4, -3, -11 } };
            sortedMatrix = MatrixFunctions.GetSortedMatrix(matrix);
            Assert.NotEqual(matrix, sortedMatrix);
        }
    }
}
