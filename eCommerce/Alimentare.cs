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
    }
}
