using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Connect4
{
    interface IGridElement
    {
        int Row { get; set; }
        int Col { get; set; }
    }
}
