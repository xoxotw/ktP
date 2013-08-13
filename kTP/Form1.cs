using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kTP
{
    public partial class kTP : Form
    {
        MusicPlayer player = new MusicPlayer();
        
        public kTP()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            songLabel.Text = openFileDialog1.FileName;
            player.open(openFileDialog1.FileName);
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            player.play();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            player.pause();
        }

        

    }
}
