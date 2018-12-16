using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma.Models
{
    class MatrixModel 
    {
        private const int MATRIX_SIZE = 9;

        public int[,] MatrixSudoku { get; set; }
        public int[,] WriteAnswer { get; set; }
        public int[,] UserAnswer { get; set; }

        public bool ifResultCorrect()
        {
            try
            {
                for(int i = 0; i < MATRIX_SIZE; i++)
                {
                    for(int j = 0; j<MATRIX_SIZE; j++)
                    {
                        if (WriteAnswer[i, j] != UserAnswer[i, j])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
