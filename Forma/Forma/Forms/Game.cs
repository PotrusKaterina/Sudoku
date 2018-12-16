using Forma.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Forma.Forms
{
    public partial class Game : Form
    {
        IMatrixController Conection = new MatrixController();

        Form1 form1 = new Form1();

        public Game()
        {
            InitializeComponent();
        }

        private void Matrix_TextChanged(object sender, EventArgs e)
        {
        }   
        
        private void Restart_Click(object sender, EventArgs e)
        {
            Matrix.Clear();
            Conection.StartGame(Matrix); 
        }

        private void EnterAnswer_Click(object sender, EventArgs e)
        {           
            Conection.Result(Matrix);
        }

        private void EnterAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {          

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void Game_Close(object sender, EventArgs e)
        {

        }

        private void ToMainMenu_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }

        private void ResartGame_Click(object sender, EventArgs e)
        {
            Matrix.Clear();
            Conection.RestartGame(Matrix);
        }
    }
}
