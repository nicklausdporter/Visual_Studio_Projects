using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingMortyApp
{
    public class OrderingMorty
    {
        public string[] getOccasion
        {
            get; set;
        }
        public int numberEvents
        {
            get; set;
        }

        public OrderingMorty ()
        {
            this.getOccasion = new string[100];
            numberEvents = 0;
        }

        public void AddOccasion(string getOccasion)
        {
            this.getOccasion[this.numberEvents] = getOccasion;
        }

    }
}
