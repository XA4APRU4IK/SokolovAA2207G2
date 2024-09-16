using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Market
{
    public abstract class Product
    {
        public virtual decimal Price { get; set; } 

        public abstract string GetInformation();
        public decimal GetDiscountedPrice(decimal discountPercentage)
        {
            return Price - (Price * discountPercentage / 100);
        }
    }
}
