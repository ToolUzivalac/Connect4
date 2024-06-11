using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Connect4
{
    class Engine
    {
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        public Field[,] Grid { get; private set; }
        public event Action GameOver;
        public int potez;

        public Engine(int rows, int cols)
        {
            potez = 0;
            Rows = rows;
            Cols = cols;
            Grid = new Field[rows, cols];
        }

        public Field Postavi(int kolona) {
            if(){

            }
        }

    }
}
