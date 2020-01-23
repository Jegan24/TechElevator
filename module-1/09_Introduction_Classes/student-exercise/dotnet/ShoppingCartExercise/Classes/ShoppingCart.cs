using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// A shopping cart class stores items in it.
    /// </summary>
    public class ShoppingCart
    {
        public int TotalNumberOfItems { get; private set; }

        public decimal TotalAmountOwed { get; private set; }

        public ShoppingCart()
        {
            TotalAmountOwed = 0;
            TotalNumberOfItems = 0;
        }
       
        public decimal GetAveragePricePerItem()
        {
            return TotalNumberOfItems != 0 ? TotalAmountOwed / TotalNumberOfItems : 0;
        }

        public void AddItems(int numberOfItems, decimal pricePerItem)
        {
            TotalNumberOfItems += numberOfItems;
            TotalAmountOwed += pricePerItem * numberOfItems;
        }

        public void Empty()
        {
            TotalAmountOwed = 0;
            TotalNumberOfItems = 0;
        }

    }
}
