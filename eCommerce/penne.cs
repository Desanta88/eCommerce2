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
        override public string ToString()
        {
            return Id + ";" + Nome + ";" + Produttore + ";" + Prezzo + ";" + getScontato().ToString() + ";" + Descrizione + ";" + funzionamento;
        }
        override public prodotto Clone(prodotto p)
        {
            Penne a = new Penne();
            a.Id = p.Id;
            a.Prezzo = p.Prezzo;
            a.Descrizione = p.Descrizione;
            a.Nome = p.Nome;
            a.Produttore = p.Produttore;
            a.funzionamento = this.funzionamento;
            return a;
        }
    }
}
