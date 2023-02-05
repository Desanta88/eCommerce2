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
        public Penne(string pro, string name, string desc, int price, int s, string func) : base(pro, name, desc, price, s)
        {
            this.funzionamento = func;
        }
        public Penne()
        {

        }
    }
}
