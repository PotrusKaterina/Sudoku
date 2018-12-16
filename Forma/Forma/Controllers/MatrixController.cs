using Forma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma.Controllers
{
    class MatrixController : IMatrixController
    {
        private MatrixModel Data = new MatrixModel();
        private Random rand = new Random();
        private int[,] ControlMatrix = new int[9,9];
        private const int MATRIX_SIZE = 9;

        public void StartGame(TextBox Matrix)
        {
            EnterMatrix();           
            RandomizeRowAndColumn();
            PrintMatrix(Matrix, Data.MatrixSudoku);
        }

        public void RestartGame(TextBox Matrix)
        {
            PrintMatrix(Matrix, Data.MatrixSudoku);
        }

        public void Result (TextBox Matrix)
        {
            GetUsersMatrix(Matrix);
            Matrix.Clear();
            MessageBox.Show(Convert.ToString(Data.ifResultCorrect()));
        }

        private void EnterMatrix()
        {                      
            for (int i = 0; i < MATRIX_SIZE; i++)
            {
                for (int j = 0; j < MATRIX_SIZE; j++)
                {
                    if ((j + i + 1) > 9)
                    {
                        ControlMatrix[i,j] = ((j + i + 1) - 9);
                    }
                    else
                    {
                        ControlMatrix[i, j] = (j + i + 1);
                    }
                }
            }
             Data.MatrixSudoku = ControlMatrix;
        }

        private void WriteToTextBox(string element, TextBox Matrix)
        {
            Matrix.Text += (element);
        }

        private int [,] RandomizeRowAndColumn()
        {           
            int Row = rand.Next(9); 
            int[] Column = new int[MATRIX_SIZE];
            
            for (int i = 0; i < MATRIX_SIZE; i++)
            {
                Column[i] = ControlMatrix[0, i];
                ControlMatrix[0, i] = ControlMatrix[Row, i];
                ControlMatrix[Row, i] = Column[i];
            }

            for (int i = 0; i < MATRIX_SIZE; i++)
            {
                Column[i] = ControlMatrix[i, 0];
                ControlMatrix[i, 0] = ControlMatrix[i, Row];
                ControlMatrix[i, Row] = Column[i];
            }
            Data.WriteAnswer = new int[9, 9];

            for (int i = 0; i < MATRIX_SIZE; i++)
            {
                for (int j = 0; j < MATRIX_SIZE; j++)
                {
                    Data.WriteAnswer[i, j] = ControlMatrix[i, j];
                }
            }
            Data.MatrixSudoku = CreateZero(ControlMatrix);
            
            return ControlMatrix;
        }

        private int[,] CreateZero(int[,] firstMatrix)
        {

            var result = firstMatrix;

            int Quolity = 0;

            while (Quolity != 12)
            {
                int randRow = rand.Next(9);
                int randColumn = rand.Next(9);
                result[randRow, randColumn] = 0;
                Quolity++;
            }
            return result;
        }

        private void PrintMatrix(TextBox Matrix, int [,] GameMatrix)
        {
            for (int i = 0; i < MATRIX_SIZE; i++)
            {
                WriteToTextBox(" ", Matrix);
                for (int j = 0; j < MATRIX_SIZE; j++)
                {
                    WriteToTextBox(Convert.ToString(GameMatrix[i, j])  + " ", Matrix);
                }
                WriteToTextBox(Environment.NewLine, Matrix);
            }
        }

        private int [,] GetUsersMatrix (TextBox Matrix)
        {
            int[,] UserAndwerInt = new int[MATRIX_SIZE, MATRIX_SIZE+1]; int[,] UserAndwerInt1 = new int[MATRIX_SIZE, MATRIX_SIZE];
            string[] UserAnswerStr = new string [MATRIX_SIZE+1];
            if (string.IsNullOrWhiteSpace(Matrix.Text)) { MessageBox.Show("Let's START new game."); }
            else {
                for (int i = 0; i < MATRIX_SIZE; i++)
                {
                    UserAnswerStr = Matrix.Lines[i].Split(' ');
                    for (int j = 1; j < MATRIX_SIZE+1; j++)
                    {
                        UserAndwerInt[i, j] = Convert.ToInt32(UserAnswerStr[j]);
                    }
                }
                for (int i = 0; i < MATRIX_SIZE; i++)
                {
                    for (int j = 0; j < MATRIX_SIZE; j++)
                    {
                        UserAndwerInt1[i, j] = UserAndwerInt[i, j + 1];
                    }
                }
            }
            Data.UserAnswer = UserAndwerInt1;
            return Data.UserAnswer;
        }
    }
}
