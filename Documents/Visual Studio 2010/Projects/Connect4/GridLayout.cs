using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Connect4
{
    class GridLayout<T> : FlowLayoutPanel where T : Control, IGridElement, new()
    {
        public int Rows { get; private set; }
        public int Cols { get; private set; }


        public GridLayout(int rows, int cols)
            : base()
        {
            this.Rows = rows;
            this.Cols = cols;

            this.FlowDirection = FlowDirection.TopDown;
            this.Padding = new Padding(5);
            this.Margin = new Padding(5);
            for (int i = 0; i < Rows; i++)
            {
                FlowLayoutPanel row = new FlowLayoutPanel();
                row.FlowDirection = FlowDirection.LeftToRight;
                row.Padding = new Padding(0);
                row.Margin = new Padding(0);
                
                for (int j = 0; j < Cols; j++)
                {
                    T element = new T();
                    element.BackColor = Color.Black;
                    element.Row = i;
                    element.Col = j;
                    element.Padding = new Padding(5);
                    element.Margin = new Padding(5);
                    row.Controls.Add(element);
                }
                
                this.Controls.Add(row);
            }
            this.AutoSize = true;
        }

        public T this[int i, int j]
        {
            get
            {
                return (T)this.Controls[i].Controls[j];
            }
        }

        public void Resize()
        {
            this.Size = this.Parent.Size;
            foreach (FlowLayoutPanel row in Controls)
            {
                row.Width = this.Width;
                row.AutoSize = true;
            }
        }
    }
}
