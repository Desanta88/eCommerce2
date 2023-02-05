using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    public class carrello
    {
        private string _id;
        private prodotto[] Prodotti;
        private int i = 0, pos = 0;


        public carrello(string iden)
        {
            _id = iden;
            Prodotti = new prodotto[100];
        }
        public string Id
        {
            get { return _id; }
            private set { _id = value; }
        }
        public void Aggiungi(prodotto p,DateTime d)
        {
            if (i < 100 && p != null)
            {
                p.Id = "p" + i;
                Prodotti[i] = p;
                i++;
                p.gestisciSconti(d);    
            }
        }
        private int ricerca(string id)
        {
            int m = 0, pos = 0;
            for (int x = 0; x < i; x++)
            {
                if (id == Prodotti[x].Id)
                {
                    return pos;
                }
                else
                {
                    m++;
                }
                pos = m;
            }
            return -1;
        }
        private void Ricompatta(int posi)
        {
            for (int i = posi; i <= (i) - 1; i++)
            {
                Prodotti[i] = Prodotti[i + 1];
            }
            i--;
        }
        public void Rimuovi(string id)
        {
            pos = ricerca(id);
            Ricompatta(pos);
        }
        public void Svuota()
        {
            for (int i = 0; i < Prodotti.Length; i++)
            {
                Prodotti[i] = null;
            }
        }
        public prodotto[] GetProdotti()
        {
            return Prodotti;
        }
        public int GetNProdotti()
        {
            return i;
        }
        public void SetNProdotti(int p)
        {
            i = p;
        }
    }
}
