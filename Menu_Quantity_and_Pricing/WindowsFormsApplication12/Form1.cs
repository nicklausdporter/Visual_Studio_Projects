using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NickMenu
{
    public partial class frmNickMenu : Form
    {
        private NickMenu nickMenu;

        public frmNickMenu(NickMenu nickMenu)
        {
            InitializeComponent();
            this.nickMenu = nickMenu;
        }

        public NickMenu GetNickMenu()
        {
            return this.nickMenu;
        }
        public void SetNickMenu(NickMenu nickMenu)
        {
            this.nickMenu = nickMenu;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // list Salads
            fruitSaladRadioButton.Checked = false;
            pastaSaladRadioButton.Checked = false;
            //list of the drinks
            smoothieRadioButton.Checked = false;
            fruitJuiceRadioButton.Checked = false;
            //list of the desserts
            cupCakeRadioButton.Checked = false;
            shortCakeRadioButton.Checked = false;
            //Label Clearing
            saladLabel.Text = "Please Select a Salad:";
            drinksLabel.Text = "Please Select a Beverage:";
            dessertsLabel.Text = "Please Select a Dessert:";
            //Clear the message
            messageLabel.Text = "Estimating your meal cost ...";
            //P & Q textboxes
            saladPriceText.Text = "0";
            dessertPriceText.Text = "0";
            drinkPriceText.Text = "0";
            saladQuantityText.Text = "0";
            dessertQtext.Text = "0";
            saladQuantityText.Text = "0";
            //focus back on exit button
            exitButton.Focus();
        }

        private void fruitSaladRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(fruitSaladRadioButton.Checked)
            {
                saladPriceText.Text = string.Format("{0:C2}", nickMenu.PriceFruitSalad);
                saladLabel.Text = fruitSaladRadioButton.Text;
                saladQuantityText.Focus();
            }
        }

        private void pastaSaladRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(pastaSaladRadioButton.Checked)
            {
                saladPriceText.Text = string.Format("{0:C2}", nickMenu.PricePastaSalad);
                saladLabel.Text = pastaSaladRadioButton.Text;
                saladQuantityText.Focus();
            }
        }


        private void smoothieRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(smoothieRadioButton.Checked)
            {
                drinkPriceText.Text = string.Format("{0:C2}", nickMenu.PriceSmoothie);
                drinksLabel.Text = smoothieRadioButton.Text;
                drinkNumberText.Focus();
            }
        }

        private void fruitJuiceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(fruitJuiceRadioButton.Checked)
            {
                drinkPriceText.Text = string.Format("{0:C2}", nickMenu.PriceFruitJuice);
                drinksLabel.Text = fruitJuiceRadioButton.Text;
                drinkNumberText.Focus();
            }
        }

        private void cupCakeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(cupCakeRadioButton.Checked)
            {
                dessertPriceText.Text = string.Format("{0:C2}", nickMenu.PriceCupCake);
                dessertsLabel.Text = cupCakeRadioButton.Text;
                dessertQtext.Focus();
            }
        }

        private void shortCakeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(shortCakeRadioButton.Checked)
            {
                dessertPriceText.Text = string.Format("{0:C2}", nickMenu.PriceShortCake);
                dessertsLabel.Text = shortCakeRadioButton.Text;
                dessertQtext.Focus();
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // passing selection
            if (pastaSaladRadioButton.Checked) nickMenu.SaladSelection = pastaSaladRadioButton.Text;
            if (fruitSaladRadioButton.Checked) nickMenu.SaladSelection = fruitSaladRadioButton.Text;
            if (cupCakeRadioButton.Checked) nickMenu.DessertSelection = cupCakeRadioButton.Text;
            if (shortCakeRadioButton.Checked) nickMenu.DessertSelection = shortCakeRadioButton.Text;
            if (fruitJuiceRadioButton.Checked) nickMenu.DrinkSelection = fruitJuiceRadioButton.Text;
            if (smoothieRadioButton.Checked) nickMenu.DrinkSelection = smoothieRadioButton.Text;
            //pasing quantity
            nickMenu.SaladQuantity = double.Parse(saladQuantityText.Text);
            nickMenu.DrinkQuantity = double.Parse(drinkNumberText.Text);
            nickMenu.DessertQuantity = double.Parse(dessertQtext.Text);
            //display
            messageLabel.Text = nickMenu.ToString();
        }

    }
}
       