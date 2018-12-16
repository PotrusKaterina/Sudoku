using Forma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma.Controllers
{
    interface IMatrixController
    {
        void StartGame(TextBox Matrix);
        void Result(TextBox Matrix);
        void RestartGame(TextBox Matrix);
    }
}
