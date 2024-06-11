using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Connect4
{
    class Field : IGridElement
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public bool Filled { get; set; }

        public Field(int row, int col)
        {
            Row = row;
            Col = col;
            Filled = false;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Field))
                return false;
            Field f = (Field)obj;
            return f.Col == Col && f.Row == Row;
        }
    }
}
