using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_WPF
{
    public enum ProductTypes
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int Priority { get; set; }
        public ProductTypes ProductType { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}