using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    public abstract class Cancelleria:prodotto
    {
        public Cancelleria(string pro, string name, string desc, int price) : base(pro, name, desc, price)
        {
            
        }
        public Cancelleria()
        {

        }
    }
}
