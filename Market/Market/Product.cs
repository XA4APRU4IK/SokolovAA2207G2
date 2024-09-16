using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    public class Toy : Product
    {
        public string Material { get; set; }  

        public Toy(string material, decimal price)
        {
            Material = material;
            Price = price;
        }

        public override string GetInformation()
        {
            return $"Toy: Material = {Material}, Price = {Price:C}";
        }
    }

    public class Meat : Product
    {
        public DateTime ExpiryDate { get; set; } 

        public Meat(DateTime expiryDate, decimal price)
        {
            ExpiryDate = expiryDate;
            Price = price;
        }

        public override string GetInformation()
        {
            return $"Meat: Expiry Date = {ExpiryDate.ToShortDateString()}, Price = {Price:C}";
        }
    }

    public class Drink : Product
    {
        public int Volume { get; set; } 

        public Drink(int volume, decimal price)
        {
            Volume = volume;
            Price = price;
        }

        public override string GetInformation()
        {
            return $"Drink: Volume = {Volume}ml, Price = {Price:C}";
        }
    }

    public class Snack : Product
    {
        public int Calories { get; set; } 

        public Snack(int calories, decimal price)
        {
            Calories = calories;
            Price = price;
        }

        public override string GetInformation()
        {
            return $"Snack: Calories = {Calories}, Price = {Price:C}";
        }
    }

    public class Electronics : Product
    {
        public int WarrantyPeriod { get; set; } 

        public Electronics(int warrantyPeriod, decimal price)
        {
            WarrantyPeriod = warrantyPeriod;
            Price = price;
        }

        public override string GetInformation()
        {
            return $"Electronics: Warranty = {WarrantyPeriod} months, Price = {Price:C}";
        }
    }

}
