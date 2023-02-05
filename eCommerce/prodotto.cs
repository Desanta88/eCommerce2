namespace eCommerce
{
    public abstract class prodotto 
    {
        private string _id;
        private string _nome;
        private string _produttore;
        private string _descrizione;
        private float _prezzo;

        private int counter { get; set; }

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
        public void gestisciSconti(DateTime d,DateTime d2)
        {
            if (this is Elettronico)
                scontoElettronico(d);
            if (this is Alimentare)
                scontoAlimentare(d, d2);
            if (this is Cancelleria)
                scontoCancelleria(d);
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
            float prezzoScontato = 0;
            counter = 0;
            if (d.DayOfWeek == DayOfWeek.Monday && counter==0 )
            {
                prezzoScontato = (this.Prezzo * 5) / 100;
                this.Prezzo = this.Prezzo-prezzoScontato;
                counter++;
            }
            else
                this.Prezzo = this.Prezzo + prezzoScontato;
        }
        private void scontoAlimentare(DateTime d,DateTime d2)
        {
            counter = 0;
            float prezzoScontato = 0;
            var dif = d2.Subtract(d);
            if (dif.Days<=7 && counter==0)
            {
                prezzoScontato = (this.Prezzo * 50) / 100;
                this.Prezzo = this.Prezzo-prezzoScontato;
                counter++;
            }
            else
                this.Prezzo = this.Prezzo + prezzoScontato;
        }
        private void scontoCancelleria(DateTime d)
        {
            float prezzoScontato = 0;
            counter = 0;
            if (d.Day % 2 == 0)
            {
                prezzoScontato = (this.Prezzo * 3) / 100;
                this.Prezzo = this.Prezzo - prezzoScontato;
                counter++;
            }
            else
                this.Prezzo = this.Prezzo + prezzoScontato;
        }
    }
}
