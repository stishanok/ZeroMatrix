using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Matrix.Matrix;

namespace MatrixTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void SetMatrixZero_1230_1000()
        {
            //arrange
            int[,] matrix =
            {
                {1, 2}, {3, 0}
            };

            int[,] expected =
            {
                {1, 0}, {0, 0}
            };

            //act
            SetMatrixZero(matrix);

            //assert
            CollectionAssert.AreEqual(expected, matrix);
        }

        [TestMethod]
        public void SetMatrixZero_123406789_103000709()
        {
            //arrange
            int[,] matrix =
            {
                {1, 2, 3}, {4, 0, 6}, {7, 8, 9}
            };

            int[,] expected =
            {
                {1, 0, 3}, {0, 0, 0}, {7, 0, 9}
            };

            //act
            SetMatrixZero(matrix);

            //assert
            CollectionAssert.AreEqual(expected, matrix);
        }

        [TestMethod]
        public void SetMatrixZero_Null_ThrowArgumentNullException()
        {
            //arrange
            int[,] matrix = null;
            
            //act + assert
            Assert.ThrowsException<ArgumentNullException>(() => SetMatrixZero(matrix));
        }
    }
}