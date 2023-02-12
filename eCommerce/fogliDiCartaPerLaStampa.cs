using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    public class FogliDiCartaPerLaStampa:Cancelleria
    {
        private float grammatura { get; set; }
        public FogliDiCartaPerLaStampa(string pro, string name, string desc, int price,float gramm) : base(pro, name, desc, price)
        {
            this.grammatura = gramm;
        }
        public FogliDiCartaPerLaStampa()
        {

        }
        override public string ToString()
        {
            return Id + ";" + Nome + ";" + Produttore + ";" + Prezzo + ";" + getScontato().ToString() + ";" + Descrizione + ";" + grammatura;
        }
        override public prodotto Clone(prodotto p)
        {
            FogliDiCartaPerLaStampa a = new FogliDiCartaPerLaStampa();
            a.Id = p.Id;
            a.Prezzo = p.Prezzo;
            a.Descrizione = p.Descrizione;
            a.Nome = p.Nome;
            a.Produttore = p.Produttore;
            a.grammatura = this.grammatura;
            return a;
        }
    }
}
