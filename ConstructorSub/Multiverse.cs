using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSub
{
    public class Multiverse
    {
        public int Wins { get; set; }
        public string Username {get; set;}

        //creates class with my username and wins in Multiverse

        public Multiverse(string username, int wins)
        {
            Username = username;
            Wins = wins;
        }

        public Multiverse(string username) : this (username, 27)
        {

        }
    }
}
