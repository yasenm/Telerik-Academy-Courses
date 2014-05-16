using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SnakeTheGame
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            using (SoundPlayer player = new SoundPlayer(@"music/Addams Family - Theme Song [8-Bit Version] HQ.wma"))
            {
                player.PlayLooping();
            }
        }

        private void About_Load(object sender, EventArgs e)
        {

        }
    }
}
