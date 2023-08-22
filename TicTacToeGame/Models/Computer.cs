using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame.Models
{
    public class Computer
    {
        private string[] textBoxes;  // Declare an array to hold text boxes
        public Computer(string name, string[] textBoxes)
        {
            Name = name;
            this.textBoxes = textBoxes;
        }

        public string Name { get; set; }
       

        //public void move()
        //{

        //}
    }
}
