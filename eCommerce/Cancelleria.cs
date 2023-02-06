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
        override public  float getScontato()
        {
            float prezzoScontato = 0;
            DateTime oggi = DateTime.Now;
            if (oggi.Day % 2 == 0)
            {
                prezzoScontato = (this.Prezzo * 3) / 100;
                prezzoScontato = this.Prezzo - prezzoScontato;
                return prezzoScontato;
            }
            return base.getScontato();
        }
    }
}
