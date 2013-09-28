using System;
//using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
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
        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            songLabel.Text = openFileDialog1.SafeFileName;
            player.Open(openFileDialog1.FileName);
        }
        
            // KeyDown Event
        private void o(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.O:
                    openFileDialog1.ShowDialog();
                    break;
                case Keys.P:
                    player.Play();
                    break;
                case Keys.Space:
                    player.Pause();
                    break;
                case Keys.S:
                    player.Stop();
                    break;
                case Keys.R:
                    player.ReturnToStart();
                    break;
                case Keys.F:
                    player.FFW();
                    break;
                default:
                    break;
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

               
                
    }
}
