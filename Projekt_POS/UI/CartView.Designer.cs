namespace Projekt_POS.UI
{
    partial class CartView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartView));
            this.sell = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typeofDoc = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sell
            // 
            this.sell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sell.Location = new System.Drawing.Point(10, 360);
            this.sell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sell.Name = "sell";
            this.sell.Size = new System.Drawing.Size(368, 24);
            this.sell.TabIndex = 0;
            this.sell.Text = "Dokonaj sprzedaży";
            this.sell.UseVisualStyleBackColor = true;
            this.sell.Click += new System.EventHandler(this.SellClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(368, 259);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista zakupów";
            // 
            // paymentList
            // 
            this.paymentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paymentList.FormattingEnabled = true;
            this.paymentList.ItemHeight = 15;
            this.paymentList.Items.AddRange(new object[] {
            "Gotówka",
            "Karta płatnicza",
            "Przelew"});
            this.paymentList.Location = new System.Drawing.Point(12, 306);
            this.paymentList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentList.Name = "paymentList";
            this.paymentList.Size = new System.Drawing.Size(181, 49);
            this.paymentList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wybierz metodę płatności";
            // 
            // typeofDoc
            // 
            this.typeofDoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeofDoc.FormattingEnabled = true;
            this.typeofDoc.ItemHeight = 15;
            this.typeofDoc.Items.AddRange(new object[] {
            "Paragon",
            "Faktura"});
            this.typeofDoc.Location = new System.Drawing.Point(198, 306);
            this.typeofDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeofDoc.Name = "typeofDoc";
            this.typeofDoc.Size = new System.Drawing.Size(182, 49);
            this.typeofDoc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wybierz rodzaj dokumentu";
            // 
            // CartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 393);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeofDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paymentList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sell);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CartView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koszyk";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button sell;
        private DataGridView dataGridView1;
        private Label label1;
        private ListBox paymentList;
        private Label label2;
        private ListBox typeofDoc;
        private Label label3;
    }
}