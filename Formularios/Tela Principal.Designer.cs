
namespace Havan_Projeto
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.MoedaOriginal = new System.Windows.Forms.ColumnHeader();
            this.MoedaDestino = new System.Windows.Forms.ColumnHeader();
            this.DataOperacao = new System.Windows.Forms.ColumnHeader();
            this.ValorOriginal = new System.Windows.Forms.ColumnHeader();
            this.ValorConvertido = new System.Windows.Forms.ColumnHeader();
            this.TaxaCobrada = new System.Windows.Forms.ColumnHeader();
            this.bttCambio = new System.Windows.Forms.Button();
            this.bttMoeda = new System.Windows.Forms.Button();
            this.lblValorTotalOperacoes = new System.Windows.Forms.Label();
            this.lblValorTotalTaxas = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.MoedaOriginal,
            this.MoedaDestino,
            this.DataOperacao,
            this.ValorOriginal,
            this.ValorConvertido,
            this.TaxaCobrada});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(689, 300);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView1_ColumnClick);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 100;
            // 
            // MoedaOriginal
            // 
            this.MoedaOriginal.Text = "Moeda Original";
            this.MoedaOriginal.Width = 90;
            // 
            // MoedaDestino
            // 
            this.MoedaDestino.Text = "Moeda Destino";
            this.MoedaDestino.Width = 90;
            // 
            // DataOperacao
            // 
            this.DataOperacao.DisplayIndex = 5;
            this.DataOperacao.Text = "Data de Operação";
            this.DataOperacao.Width = 120;
            // 
            // ValorOriginal
            // 
            this.ValorOriginal.DisplayIndex = 3;
            this.ValorOriginal.Text = "Valor Original";
            this.ValorOriginal.Width = 90;
            // 
            // ValorConvertido
            // 
            this.ValorConvertido.DisplayIndex = 4;
            this.ValorConvertido.Text = "Valor Convertido";
            this.ValorConvertido.Width = 90;
            // 
            // TaxaCobrada
            // 
            this.TaxaCobrada.Text = "Taxa Cobrada";
            this.TaxaCobrada.Width = 90;
            // 
            // bttCambio
            // 
            this.bttCambio.Location = new System.Drawing.Point(12, 12);
            this.bttCambio.Name = "bttCambio";
            this.bttCambio.Size = new System.Drawing.Size(92, 23);
            this.bttCambio.TabIndex = 2;
            this.bttCambio.Text = "Novo cambio";
            this.bttCambio.UseVisualStyleBackColor = true;
            this.bttCambio.Click += new System.EventHandler(this.Cambio_Click);
            // 
            // bttMoeda
            // 
            this.bttMoeda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttMoeda.Location = new System.Drawing.Point(609, 12);
            this.bttMoeda.Name = "bttMoeda";
            this.bttMoeda.Size = new System.Drawing.Size(92, 23);
            this.bttMoeda.TabIndex = 3;
            this.bttMoeda.Text = "Nova Moeda";
            this.bttMoeda.UseVisualStyleBackColor = true;
            this.bttMoeda.Click += new System.EventHandler(this.Moeda_Click);
            // 
            // lblValorTotalOperacoes
            // 
            this.lblValorTotalOperacoes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValorTotalOperacoes.AutoSize = true;
            this.lblValorTotalOperacoes.Location = new System.Drawing.Point(723, 60);
            this.lblValorTotalOperacoes.Name = "lblValorTotalOperacoes";
            this.lblValorTotalOperacoes.Size = new System.Drawing.Size(82, 30);
            this.lblValorTotalOperacoes.TabIndex = 4;
            this.lblValorTotalOperacoes.Text = "Valor total \r\ndas operações";
            this.lblValorTotalOperacoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorTotalTaxas
            // 
            this.lblValorTotalTaxas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValorTotalTaxas.AutoSize = true;
            this.lblValorTotalTaxas.Location = new System.Drawing.Point(709, 133);
            this.lblValorTotalTaxas.Name = "lblValorTotalTaxas";
            this.lblValorTotalTaxas.Size = new System.Drawing.Size(111, 15);
            this.lblValorTotalTaxas.TabIndex = 6;
            this.lblValorTotalTaxas.Text = "Valor total das taxas";
            this.lblValorTotalTaxas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(709, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(111, 23);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(709, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(111, 23);
            this.textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 353);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblValorTotalTaxas);
            this.Controls.Add(this.lblValorTotalOperacoes);
            this.Controls.Add(this.bttMoeda);
            this.Controls.Add(this.bttCambio);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tela Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button bttCambio;
        private System.Windows.Forms.Button bttMoeda;
        private System.Windows.Forms.Label lblValorTotalOperacoes;
        private System.Windows.Forms.Label lblValorTotalTaxas;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader MoedaOriginal;
        private System.Windows.Forms.ColumnHeader MoedaDestino;
        private System.Windows.Forms.ColumnHeader DataOperacao;
        private System.Windows.Forms.ColumnHeader ValorOriginal;
        private System.Windows.Forms.ColumnHeader ValorConvertido;
        private System.Windows.Forms.ColumnHeader TaxaCobrada;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

