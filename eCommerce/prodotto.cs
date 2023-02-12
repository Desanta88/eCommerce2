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
        public virtual float getScontato()
        {
            return Prezzo;
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Produttore
        {
            get { return _produttore; }
            set { _produttore = value; }
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
            return Id + ";" + Nome + ";"+Produttore + ";"+Prezzo +";"+getScontato().ToString()+ ";"+Descrizione;
        }
        public virtual prodotto Clone(prodotto p)
        {
            return p;
        }
    }
}
