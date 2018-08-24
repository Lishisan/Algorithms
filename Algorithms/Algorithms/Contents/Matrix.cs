using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Contents
{
    public class Matrix
    {
        public int[][] SquareMatrixMultiply(int[][] leftMatrix, int[][] rightMatrix)
        {
            var dimension = leftMatrix.Length;
            var intDim = int.Parse(dimension.ToString());
            var result = new int[intDim][];
            for (int i = 0; i < dimension; i++)
            {
                result[i] = new int[dimension];
                for (int j = 0; j < dimension; j++)
                {                   
                    for (int k = 0; k < dimension; k++)
                    {                       
                        result[i][j] = result[i][j] + leftMatrix[i][k] * rightMatrix[k][j];
                    }
                }
            }
            return result;
        }
    }
}
