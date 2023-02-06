namespace eCommerce
{
    public partial class Form1 : Form
    {
        public Alimentare product1;
        public Elettronico product2;
        public Penne product3;
        public FogliDiCartaPerLaStampa product4;
        public prodotto[] prodottiPre = new prodotto[4];
        public prodotto[] Prodotti = new prodotto[100];
        public carrello car = new carrello("dfasij");
        public string prodottoSelect, sss;
        public int nP = 0, npC, index = 0;
        public string[] intes = new string[] { "ID", "NOME","PRODUTTORE","PREZZO","DESCRIZIONE" };
        public string[] ingredienti = new string[] { "pollo" };
        public DateTime date = new DateTime(2023, 2, 6);
        public DateTime scadenza = new DateTime(2023, 2, 14);
        public Form1()
        {
            InitializeComponent();
            product1 = new Alimentare("AIA", "cotoletta","una buonissima coto",6,ingredienti,scadenza);
            prodottiPre[0] = product1;
            product2 = new Elettronico("logitech", "mouse wireless","un bel mouse",15,"weaeawdx");
            prodottiPre[1] = product2;
            product3 = new Penne("bic", "penna blu","una penna",3,"scrivere");
            prodottiPre[2] = product3;
            product4 = new FogliDiCartaPerLaStampa("yolo", "foglio bianco", "una foglio", 4, 7);
            prodottiPre[3] = product4;
            prodottoPredefiniti(prodottiPre);
            for (int i = 0; i < intes.Length; i++)
            {
                listViewCarrello.Columns.Add(intes[i]);
            }
        }

        public void prodottoPredefiniti(prodotto[] p)
        {
            for(int i = 0; i < 4; i++)
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

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            
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
                          car.Aggiungi(prodottiPre[i],date,scadenza);                          
                    }
                                 
                }
                nP++;
                car.SetNProdotti(nP);
            }
            for (int i = 0; i < prodottiPre.Length; i++)
            {
                if (prodottoSelect == prodottiPre[i].Nome)
                {
                    if (date == scadenza || date > scadenza)
                    {
                        MessageBox.Show("il prodotto è scaduto,esso verrà eliminato");
                        if (listViewProdotti.SelectedIndices.Count > 0)
                            index = listViewProdotti.SelectedIndices[0];
                        listViewProdotti.Items.RemoveAt(index);
                    }
                    else
                    {
                        ListViewItem riga = new ListViewItem(prodottiPre[i].ToString().Split(';'));
                        listViewCarrello.Items.Add(riga);
                    }    
                }

            }
        }
    }
}