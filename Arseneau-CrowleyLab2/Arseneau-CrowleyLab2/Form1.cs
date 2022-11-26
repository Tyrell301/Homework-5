using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arseneau_CrowleyLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Tyler Arseneau-Crowley, October 3rd 2022
         * This Lab is to prctise using buttons, labels, textboxs and pictureboxs.
         * The Lab also helps with how to deal with math in C#
         * 
         */
        private void Multiplier_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
        private void btnPicture_Click(object sender, EventArgs e)
        {
            // show picture box
            picCats.Show();
            lblInformation.Hide();
        }
        private void btnHide_Click(object sender, EventArgs e)
        {
            //hide label and picbox

            lblInformation.Visible = false;
            picCats.Hide();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            //clear data
            txtNum.Text = "";
            txtMultiplier.Text = "";
            lblFinalAnswer.Text = "";

            //put cursor on top textbox
            txtNum.Focus();

        }
        private void btnData_Click(object sender, EventArgs e)
        {
            //change text
            lblInformation.Text = "My topic is about my cats " + lblTopic.Text + ".\r\n\r\nOn October 24 2020 I got Chester and Ritz from the SPCA. They are brothers so I felt like I couldn't seperate them.\r\n\r\nChester is very timid and Ritz super energetic and nosey. They like to sleep all day and play all night.\r\n\r\nI love them a lot.\r\n";


            //show text
            lblInformation.Show();
            picCats.Hide();
        }
        private void picCats_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Cats Chester and Ritz", "Tyler Arseneau-Crowley");
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare variable for number and multiplier
            int number;
            int multipier;
            int answer;

            //get number from textboxs
            number = Convert.ToInt32(txtNum.Text);
            multipier = Convert.ToInt32(txtMultiplier.Text);

            //mulitply number and muliplier
            answer = number * multipier;

            //disply answer in answer label

            lblFinalAnswer.Text = answer.ToString();
        }
    }
}
