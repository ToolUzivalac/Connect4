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
        public int[,] Grid { get; private set; }
        public event Action GameOver;
        public event EventHandler Placed;
        public int potez;

        public Engine(int rows, int cols)
        {
            potez = 0;
            Rows = rows;
            Cols = cols;
            Grid = new Field[rows, cols];
        }

        public void Postavi(int kolona) {
            for (int i = Rows - 1; i >= 0; i--){
                if(!Grid[i, kolona].Filled){
                    Grid[i, kolona].Filled = true;
                    Placed.Invoke(this, new PlacedArgs(i, kolona, potez%2));
                }
            }
            potez++;
        }


    }
}
