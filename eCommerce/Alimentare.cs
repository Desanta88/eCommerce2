using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    public class Alimentare:prodotto
    {
        private string[] ingredienti=new string[10];
        private DateTime dataScadenza { get; set; }


        public Alimentare(string pro, string name, string desc, int price,string[] ing, DateTime expireD):base(pro,name, desc,price)
        {
            this.ingredienti = ing;
            this.dataScadenza = expireD;
        }
        public Alimentare()
        {

        }
        override public float getScontato()
        {
            DateTime oggi = DateTime.Now;
            float prezzoScontato = 0;
            var dif = dataScadenza.Subtract(oggi);
            if (dif.Days <= 7)
            {
                prezzoScontato = (this.Prezzo * 50) / 100;
                prezzoScontato = this.Prezzo - prezzoScontato;
                return prezzoScontato;
            }
            return base.getScontato();
        }
    }
}
