using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame.Models
{
    public class Player
    {
        public Player(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
        public string Name { get; set; } 
        public string LastName { get; set; }
        public string FullName => Name + LastName;

        
    }
}
