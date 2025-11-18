using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Game
    {
        public required string title { get; set; }
        public string? Genre { get; set; }
        public int ReleaseYear { get; set; }
        public double Rating { get; set; }
        public int Price { get; set; }

    }
}
