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
        int wins = 0;
        int loss = 0;
        int ties = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRock.Checked = false;
            imgPlayer.Image = Properties.Resources._2020_02_12_19_13_36;
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

        private void btnStart_Click(object sender, EventArgs e)
        {

            int random = generator.Next(1, 4);
            if (random == 1)
                imgOpponent.Image = Properties.Resources.dwayne_the_rock_johnson_gettyimages_1061959920;
            else if (random == 2)
                imgOpponent.Image = Properties.Resources.istockphoto_186804075_1024x1024;
            else if (random == 3)
                imgOpponent.Image = Properties.Resources.scissors_clip_art_cartoon_vector_1509551;
            if (radRock.Checked && random == 1 || radPaper.Checked && random == 2 || radScissors.Checked && random == 3)
            {
                lblOutcome.Text = ("You have tied");
                ties = ties + 1;
                lblTies.Text = ($"{ties}");
            }
            else if (radRock.Checked && random == 3 || radPaper.Checked && random == 1 || radScissors.Checked && random == 2)
            {
                lblOutcome.Text = ("You have won!  Congratulations");
                wins = wins + 1;
                lblWins.Text = ($"{wins}");
            }

            else if (radRock.Checked && random == 2 || radPaper.Checked && random == 3 || radScissors.Checked && random == 1)
            {
                lblOutcome.Text = ("You have lost!  Congratulations");
                loss = loss + 1;
                lblLoss.Text = ($"{loss}");
            }
            radRock.Checked = false;
            radScissors.Checked = false;
            radPaper.Checked = false;
            timerPlyr.Enabled = true;
            timerOpp.Enabled = true;









        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblLoss_Click(object sender, EventArgs e)
        {

        }

        private void timerOpp_Tick(object sender, EventArgs e)
        {
            imgOpponent.Image = Properties.Resources._2020_02_12_19_13_36;
        }

        private void timerPlyr_Tick(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources._2020_02_12_19_13_36;
        }
    }

}
