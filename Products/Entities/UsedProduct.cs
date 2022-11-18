using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Products.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime DateUsed { get; set; }

        public UsedProduct(string name, double price, DateTime dateUsed)
            : base(name, price)
        {
            DateUsed = dateUsed;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " (Manufacture date: " + DateUsed.ToString("dd/MM/yyyy") + ")";
        }
    }
}
