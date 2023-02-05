using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    public class Cancelleria:prodotto
    {
        private int sconto{set;get;}
        public Cancelleria(string pro, string name, string desc, int price,int s) : base(pro, name, desc, price)
        {
            this.sconto = s;
        }
        public Cancelleria()
        {

        }
    }
}
