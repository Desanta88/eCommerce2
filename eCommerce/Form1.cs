namespace eCommerce
{
    public partial class Form1 : Form
    {
        public prodotto product1;
        public Elettronico product2;
        public prodotto product3;
        public prodotto[] prodottiPre = new prodotto[3];
        public prodotto[] Prodotti = new prodotto[100];
        public carrello car = new carrello("dfasij");
        public string prodottoSelect, sss;
        public int nP = 0, npC, index = 0;
        public string[] intes = new string[] { "ID", "NOME","PRODUTTORE","PREZZO","DESCRIZIONE" };
        public DateTime date = new DateTime(2023, 2, 6);
        public Form1()
        {
            InitializeComponent();
            product1 = new prodotto("AIA", "cotoletta");
            prodottiPre[0] = product1;
            product2 = new Elettronico("logitech", "mouse wireless","un bel mouse",15,"weaeawdx");
            prodottiPre[1] = product2;
            product3 = new prodotto("ya", "carne di maiale");
            prodottiPre[2] = product3;
            prodottoPredefiniti(prodottiPre);
            for (int i = 0; i < intes.Length; i++)
            {
                listViewCarrello.Columns.Add(intes[i]);
            }
        }

        public void prodottoPredefiniti(prodotto[] p)
        {
            for(int i = 0; i < 3; i++)
            {
                ListViewItem A = new ListViewItem(p[i].Nome);
                listViewProdotti.Items.Add(A);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (listViewCarrello.SelectedIndices.Count > 0)
                index = listViewCarrello.SelectedIndices[0];
            listViewCarrello.Items.RemoveAt(index);
            if (nP < 100)
            {
                prodottoSelect = listViewProdotti.SelectedItems[0].SubItems[0].Text;
                car.Rimuovi(prodottoSelect);
                nP--;
                car.SetNProdotti(nP);

            }
        }

        private void svuotaCarrelloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewCarrello.Items.Clear();
            car.Svuota();
            nP = 0;
            car.SetNProdotti(nP);
        }

        private void SvuotaCarrello_Click(object sender, EventArgs e)
        {
            listViewCarrello.Clear();
            car.Svuota();
        }

        public void MettiNelCarrello(string s,prodotto[] p)
        {
      
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            prodottoSelect = listViewProdotti.SelectedItems[0].Text;
            if (nP < 100)
            {
                for (int i = 0; i < prodottiPre.Length; i++)
                {
                    if (prodottoSelect == prodottiPre[i].Nome)
                    {
                        car.Aggiungi(prodottiPre[i],date);
                    }
                                 
                }
                nP++;
                car.SetNProdotti(nP);
            }
            for (int i = 0; i < prodottiPre.Length; i++)
            {
                if (prodottoSelect == prodottiPre[i].Nome)
                {
                    ListViewItem riga = new ListViewItem(prodottiPre[i].ToString().Split(';'));
                    listViewCarrello.Items.Add(riga);
                }

            }
        }
    }
}