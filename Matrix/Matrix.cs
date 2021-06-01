using System;

namespace Matrix
{
    public static class Matrix
    {
        private static void ZeroingRow(int[,] matrix, int row)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[row, i] = 0;
            }
        }

        private static void ZeroingColumn(int[,] matrix, int col)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[i, col] = 0;
            }
        }

        public static void SetMatrixZero(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException();
            }

            bool[] rows = new bool[matrix.GetLength(0)];
            bool[] columns = new bool[matrix.GetLength(1)];

            for (int indexRow = 0; indexRow < matrix.GetLength(0); indexRow++)
            {
                for (int indexColumn = 0; indexColumn < matrix.GetLength(1); indexColumn++)
                {
                    if (matrix[indexRow, indexColumn] == 0)
                    {
                        rows[indexRow] = true;
                        columns[indexColumn] = true;
                    }
                }
            }

            for (int i = 0; i < rows.Length; i++)
            {
                if (rows[i])
                {
                    ZeroingRow(matrix, i);
                }
            }

            for (int i = 0; i < columns.Length; i++)
            {
                if (columns[i])
                {
                    ZeroingColumn(matrix, i);
                }
            }
        }
    }
}