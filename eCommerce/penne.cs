using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    public class Penne:Cancelleria
    {
        private string funzionamento { set; get; }
        public Penne(string pro, string name, string desc, int price,string func) : base(pro, name, desc, price)
        {
            this.funzionamento = func;
        }
        public Penne()
        {

        }
    }
}
