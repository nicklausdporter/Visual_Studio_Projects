using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingMortyApp
{
    public partial class frmOrderingMorty : Form
    {
        private OrderingMorty orderingMorty;
        public frmOrderingMorty()
        {
            InitializeComponent();
            orderingMorty = new OrderingMorty();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(comboBox1.Text);
       
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
                comboBox1.Items.RemoveAt(0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have ordered "+ comboBox1.Items.Count + " Morty(s)");
        }

        private void cowboyRB_CheckedChanged(object sender, EventArgs e)
        {
            pictureCB.Checked = false;
            pictureBox2.Image = WindowsFormsApplication13.Properties.Resources.cowboy_morty;
        }

        private void evilMortyRB_CheckedChanged(object sender, EventArgs e)
        {
            pictureCB.Checked = false;
            pictureBox2.Image = WindowsFormsApplication13.Properties.Resources.evil_morty;
        }

        private void presidentMortyRB_CheckedChanged(object sender, EventArgs e)
        {
            pictureCB.Checked = false;
            pictureBox2.Image = WindowsFormsApplication13.Properties.Resources.president_morty;
        }

        private void robotMortyRB_CheckedChanged(object sender, EventArgs e)
        {
            pictureCB.Checked = false;
            pictureBox2.Image = WindowsFormsApplication13.Properties.Resources.robot_morty;
        }

        private void tinyRB_CheckedChanged(object sender, EventArgs e)
        {
            pictureCB.Checked = false;
            pictureBox2.Image = WindowsFormsApplication13.Properties.Resources.tiny_rick_morty;
        }

        private void pictureCB_CheckedChanged(object sender, EventArgs e)
        { 
                pictureBox2.Image = null;

            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureCB.Checked = false;
            tinyRB.Checked = false;
            cowboyRB.Checked = false;
            presidentMortyRB.Checked = false;
            evilMortyRB.Checked = false;
            robotMortyRB.Checked = false;

            comboBox1.Items.Clear();
            comboBox1.Text = "";


        }
    }
}
