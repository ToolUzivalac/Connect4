using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Connect4
{
    class PlacedArgs : EventArgs
    {
        int Row { get; set; }
        int Col { get; set; }
        int Potez { get; set; }

        public PlacedArgs(int row, int col, int potez) {
            Row = row;
            Col = col;
            Potez = potez;
        }
    }
}
