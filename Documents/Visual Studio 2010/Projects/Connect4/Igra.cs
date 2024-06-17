using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Connect4
{
    public partial class Igra : Form
    {
        Engine engine;
        GridLayout<UIField> grid;
        TimeSpan start;
        TimeSpan end;
        int rows, cols;

        public Igra(int rows, int cols)
        {
            InitializeComponent();
            this.AutoSize = true;
            this.rows = rows;
            this.cols = cols;
            engine = new Engine(rows, cols);
        }

        private void Igra_Load(object sender, EventArgs e)
        {
            grid = new GridLayout<UIField>(rows, cols);
            this.Controls.Add(grid);
            grid.Resize();
            start = DateTime.Now.TimeOfDay;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    grid[i, j].Klik += HandleCardClick;
                }
        }


        private void HandleCardClick(object sender, EventArgs e)
        {
            UIField card = (UIField)sender;
            UIFieldArgs args = (UIFieldArgs)e;
            int i = args.Row;
            int j = args.Col;
            int k = engine.Postavi(j);
            grid[k, j].Enabled = false;

            if (engine.potez == rows * cols)
            {
                end = DateTime.Now.TimeOfDay;
                Console.WriteLine(end - start);
                MessageBox.Show("Nereseno");
            }

            if (engine.Grid[k, j].Filled == 1)
            {
                grid[k, j].BackColor = Color.Red;
            }
            else if(engine.Grid[k, j].Filled == 2)
            {
                grid[k, j].BackColor = Color.Yellow;
            }

            int a = engine.Grid[i, j].Filled;
            for (int p = Math.Max(0, j-3); p <= Math.Min(cols-4, j); p++) {
                if (engine.Grid[k, p] == engine.Grid[k, p+1] && engine.Grid[k, p] == engine.Grid[k, p + 2] && engine.Grid[k, p] == engine.Grid[k, p + 3]) {
                    MessageBox.Show(String.Format("Igrac {0} je pobednik", a));
                }   
            }

            if(k+3 <= rows - 1){
                if (engine.Grid[k, j] == engine.Grid[k+1, j] && engine.Grid[k, j] == engine.Grid[k+2, j] && engine.Grid[k, j] == engine.Grid[k+3, j]) {
                    MessageBox.Show(String.Format("Igrac {0} je pobednik", a));
                }
            }

            for (int p = Math.Max(0,  Math.Max(j-3, j-(rows-k-1))); p <= Math.Min(j, Math.Min(cols-4, j-(3-k))); p++){
                if (engine.Grid[k-(j-p), p] == engine.Grid[k-(j-p)-1, p + 1] && engine.Grid[k-(j-p), p] == engine.Grid[k-(j-p)-2, p+2] && engine.Grid[k-(j-p), p] == engine.Grid[k-(j-p)-3, p+3])  
                {
                    MessageBox.Show(String.Format("Igrac {0} je pobednik", a));
                }
            }

            for (int p = Math.Max(0, Math.Max(j - 3, j - k)); p <= Math.Min(j, Math.Min(cols-4, j-k)); p++)
            {
                if (engine.Grid[k - (j - p), p] == engine.Grid[k - (j - p) - 1, p + 1] && engine.Grid[k - (j - p), p] == engine.Grid[k - (j - p) - 2, p + 2] && engine.Grid[k - (j - p), p] == engine.Grid[k - (j - p) - 3, p + 3])
                {
                    MessageBox.Show(String.Format("Igrac {0} je pobednik", a));
                }
            }

        }

    }
}
