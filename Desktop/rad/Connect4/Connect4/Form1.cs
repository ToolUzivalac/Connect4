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
    public partial class Form1 : Form
    {
        int rows;
        int cols;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void prvi_Click(object sender, EventArgs e)
        {
            rows = 6;
            cols = 7;
            Close();
            Igra forma = new Igra();
            forma.Show();
        }

        private void drugi_Click(object sender, EventArgs e)
        {
            rows = 6;
            cols = 5;
            Close();
            Igra forma = new Igra();
            forma.Show();
        }

        private void treci_Click(object sender, EventArgs e)
        {
            rows = 10;
            cols = 7;
            Close();
            Igra forma = new Igra();
            forma.Show();
        }

    }
}
