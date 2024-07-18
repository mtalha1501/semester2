using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{   
    internal class Card
    {
        protected int theValue;
        protected int theSuit;
        public Card(int value,int suit)
        {
            this.theValue = value;
            this.theSuit = suit;
        }
        public string GetSuitAsString()
        {
            return this.theSuit.ToString();
        }
        public string GetValueAsString()
        {
            return this.theValue.ToString();
        }
        public string ToString()
        {
            return "[Card value is "+this.theValue+"]\n[Card Suit is "+this.theSuit+"]";
        }
    }
}
