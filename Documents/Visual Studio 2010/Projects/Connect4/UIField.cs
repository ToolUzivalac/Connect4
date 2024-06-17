using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Connect4
{
    class UIField : Button, IGridElement
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public event EventHandler Klik;
        public UIField() : base()
        {
            Width = 50;
            Height = 50;
            Margin = new Padding(0);
            Padding = new Padding(0);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            this.Click += EmitKlik;
        }

        public void EmitKlik(object sender, EventArgs e)
        {
            Klik(this, new UIFieldArgs(Row, Col));
        }

    }
}
