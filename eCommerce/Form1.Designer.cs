namespace eCommerce
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewProdotti = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.svuotaCarrelloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewCarrello = new System.Windows.Forms.ListView();
            this.labelPrezzoToT = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewProdotti
            // 
            this.listViewProdotti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewProdotti.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewProdotti.Location = new System.Drawing.Point(28, 12);
            this.listViewProdotti.MultiSelect = false;
            this.listViewProdotti.Name = "listViewProdotti";
            this.listViewProdotti.Size = new System.Drawing.Size(263, 426);
            this.listViewProdotti.TabIndex = 0;
            this.listViewProdotti.UseCompatibleStateImageBehavior = false;
            this.listViewProdotti.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Prodotti";
            this.columnHeader1.Width = 120;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem1.Text = "Metti nel carrello";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.svuotaCarrelloToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(153, 48);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Rimuovi";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // svuotaCarrelloToolStripMenuItem
            // 
            this.svuotaCarrelloToolStripMenuItem.Name = "svuotaCarrelloToolStripMenuItem";
            this.svuotaCarrelloToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.svuotaCarrelloToolStripMenuItem.Text = "Svuota carrello";
            this.svuotaCarrelloToolStripMenuItem.Click += new System.EventHandler(this.svuotaCarrelloToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(610, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "il tuo carrello";
            // 
            // listViewCarrello
            // 
            this.listViewCarrello.Location = new System.Drawing.Point(308, 25);
            this.listViewCarrello.Name = "listViewCarrello";
            this.listViewCarrello.Size = new System.Drawing.Size(480, 413);
            this.listViewCarrello.TabIndex = 4;
            this.listViewCarrello.UseCompatibleStateImageBehavior = false;
            this.listViewCarrello.View = System.Windows.Forms.View.Details;
            // 
            // labelPrezzoToT
            // 
            this.labelPrezzoToT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrezzoToT.Location = new System.Drawing.Point(477, 450);
            this.labelPrezzoToT.Name = "labelPrezzoToT";
            this.labelPrezzoToT.Size = new System.Drawing.Size(186, 23);
            this.labelPrezzoToT.TabIndex = 5;
            this.labelPrezzoToT.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.labelPrezzoToT);
            this.Controls.Add(this.listViewCarrello);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewProdotti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listViewProdotti;
        private Label label1;
        private ColumnHeader columnHeader1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem toolStripMenuItem2;
        private ListView listViewCarrello;
        private ToolStripMenuItem svuotaCarrelloToolStripMenuItem;
        private Label labelPrezzoToT;
    }
}