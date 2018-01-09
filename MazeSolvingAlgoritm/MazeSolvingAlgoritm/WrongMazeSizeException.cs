using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolvingAlgoritm {
    public class WrongMazeSizeException : Exception{
        public WrongMazeSizeException() { }

        public WrongMazeSizeException(string message) : base(message) { }

        public WrongMazeSizeException(string message, Exception inner) : base(message, inner) { }
    }
}
