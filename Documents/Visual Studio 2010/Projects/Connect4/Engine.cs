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
        //public event Action GameOver;
        //public event EventHandler Placed;
        public int potez = 0;

        public Engine(int rows, int cols)
        {
            potez = 0;
            Rows = rows;
            Cols = cols;
            Grid = new Field[rows, cols];
        }

        public int Postavi(int kolona) {
            for (int i = Rows - 1; i >= 0; i--){
                if(Grid[i, kolona].Filled == 0){
                    Grid[i, kolona].Filled = potez%2 + 1;
                    potez++;
                    return i;
                    //Placed.Invoke(this, new PlacedArgs(i, kolona, potez%2));
                }
            }
            return -1;
        }


    }
}
