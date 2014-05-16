using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeTheGame
{
    public partial class Snake : Form
    {
        public Snake()
        {
            InitializeComponent();

        }

        private void scoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Score()).ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new About()).ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
