using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickMenu
{
    public class NickMenu
    {
        //properties
        public String CustomerName
        {
            get; set;
        }

        public double PriceFruitSalad
        {
            get; set;
        }
        public double PricePastaSalad
        {
            get; set;
        }
        public double PriceSmoothie
        {
            get; set;
        }

        public double PriceFruitJuice
        {
            get; set;
        }
        public double PriceCupCake
        {
            get; set;
        }
        public double PriceShortCake
        {
            get; set;
        }

        public double DessertQuantity
        {
            get; set;
        }
        public double SaladQuantity
        {
            get; set;
        }
        public double DrinkQuantity
        {
            get; set;
        }

        public string DrinkSelection
        {
            get; set;
        }
        public string DessertSelection
        {
            get; set;
        }
        public string SaladSelection
        {
            get; set;
        }
        public NickMenu()
        {

            this.PriceFruitSalad = 9.95;
            this.PricePastaSalad = 12.0;
            this.PriceSmoothie = 4.95;
            this.PriceFruitJuice = 3.95;
            this.PriceCupCake = 3.0;
            this.PriceShortCake = 6.0;
            this.DrinkSelection = "";
            this.SaladSelection = "";
            this.DessertSelection = "";

        }
        //methods
        public double AssessMenu()
        {
            double totalDrinkCost = 0.0;
            double totalSaladCost = 0.0;
            double totalDessertCost = 0.0;

            switch (this.SaladSelection.ToUpper())
            {
                case "FRUIT SALAD":
                    totalSaladCost = this.PriceFruitSalad * this.SaladQuantity;
                    break;
                case "PASTA SALAD":
                    totalSaladCost = this.PricePastaSalad * this.SaladQuantity;
                    break;
                default:
                    totalSaladCost = 0.0 * this.SaladQuantity;
                    break;
            }

            switch (this.DrinkSelection.ToUpper())
            {
                case "SMOOTHIE":
                    totalDrinkCost = this.PriceSmoothie * this.DrinkQuantity;
                    break;
                case "FRUIT JUICE":
                    totalDrinkCost = this.PriceFruitJuice * this.DrinkQuantity;
                    break;
                default:
                    totalDrinkCost = 0.0 * this.DrinkQuantity;
                    break;
            }

            switch (this.DessertSelection.ToUpper())
            {
                case "CUP CAKE":
                    totalDessertCost = this.PriceCupCake * this.DessertQuantity;
                    break;
                case "SHORT CAKE":
                    totalDessertCost = this.PriceShortCake * this.DessertQuantity;
                    break;
                default:
                    totalDessertCost = 0.0 * this.DessertQuantity;
                    break;
            }
            return totalDrinkCost + totalDessertCost + totalSaladCost;
        }

        public override string ToString()
        {
            double menuFoodCosts = AssessMenu();
            return this.CustomerName + " The total costs of your food has been assessed. Thank you for your payment of  " + string.Format("{0:C2}", menuFoodCosts);

        }
    }

}
