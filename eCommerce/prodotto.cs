using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    public class prodotto //ricordati di fare abstract
    {
        private string _id;
        private string _nome;
        private string _produttore;
        private string _descrizione;
        private float _prezzo;

        public prodotto(string pro, string name,string desc,int price)
        {
            _produttore = pro;
            _nome = name;
            _descrizione = desc;
            _prezzo = price;
        }
        public prodotto(string pro, string name)
        {
            _produttore = pro;
            _nome = name;
        }
        public prodotto()
        {

        }
        public void gestisciSconti(DateTime d)
        {
            if (this is Elettronico)
                scontoElettronico(d);
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Produttore
        {
            get { return _produttore; }
            private set { _produttore = value; }
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }
        public float Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }
        public virtual string ToString()
        {
            return Id + ";" + Nome + ";"+Produttore + ";"+Prezzo + ";"+Descrizione;
        }
        private void scontoElettronico(DateTime d)
        {
            if (d.DayOfWeek == DayOfWeek.Monday)
            {
                float prezzoScontato = 0;
                prezzoScontato = (this.Prezzo * 5) / 100;
                this.Prezzo = this.Prezzo - prezzoScontato;
            }
        }
    }
}
