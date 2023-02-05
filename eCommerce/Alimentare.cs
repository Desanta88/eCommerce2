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

        private int sconto { get; set; }

        public Alimentare(string pro, string name, string desc, int price,string[] ing, DateTime expireD, int s):base(pro,name, desc,price)
        {
            this.ingredienti = ing;
            this.dataScadenza = expireD;
            this.sconto = s;
        }
        public Alimentare()
        {

        }
    }
}
