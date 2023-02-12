using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    public class Elettronico :prodotto
    {
        private string modello { get; set; }

        public Elettronico(string pro, string name, string desc, int price,string model) : base(pro, name, desc, price)
        {
            this.modello = model;
        }
        public Elettronico()
        {

        }
        override public float getScontato()
        {
            float prezzoScontato = 0;
            DateTime oggi=DateTime.Now;
            if (oggi.DayOfWeek == DayOfWeek.Monday)
            {
                prezzoScontato = (this.Prezzo * 5) / 100;
                prezzoScontato = this.Prezzo - prezzoScontato;
                return prezzoScontato;
            }
            return base.getScontato();
        }
        override public string ToString()
        {
            return Id + ";" + Nome + ";" + Produttore + ";" + Prezzo + ";" + getScontato().ToString() + ";" + Descrizione + ";" + modello;
        }
        override public prodotto Clone(prodotto p)
        {
            Elettronico a = new Elettronico();
            a.Id = p.Id;
            a.Prezzo = p.Prezzo;
            a.Descrizione = p.Descrizione;
            a.Nome = p.Nome;
            a.Produttore = p.Produttore;
            a.modello = this.modello;
            return a;
        }
    }
}
