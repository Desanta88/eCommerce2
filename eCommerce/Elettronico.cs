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
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
