using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Connect4
{
    class UIFieldArgs : EventArgs
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public UIFieldArgs(int row, int col)
            : base()
        {
            Row = row;
            Col = col;
        }
    }
}
