using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        Random generator = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radScissors_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.scissors_clip_art_cartoon_vector_1509551;
        }

        private void radRock_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.dwayne_the_rock_johnson_gettyimages_1061959920;
        }
        private void radPaper_CheckedChanged_1(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.istockphoto_186804075_1024x1024;
        }
    
        
    }

}
