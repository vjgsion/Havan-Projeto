
namespace Havan_Projeto.Formularios
{
    partial class NovaMoeda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttSalvar = new System.Windows.Forms.Button();
            this.txtBoxNomeMoeda = new System.Windows.Forms.TextBox();
            this.txtBoxValorMoeda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da Moeda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor da Moeda";
            // 
            // bttSalvar
            // 
            this.bttSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttSalvar.Location = new System.Drawing.Point(226, 154);
            this.bttSalvar.Name = "bttSalvar";
            this.bttSalvar.Size = new System.Drawing.Size(75, 23);
            this.bttSalvar.TabIndex = 5;
            this.bttSalvar.Text = "Salvar";
            this.bttSalvar.UseVisualStyleBackColor = true;
            this.bttSalvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // txtBoxNomeMoeda
            // 
            this.txtBoxNomeMoeda.Location = new System.Drawing.Point(12, 35);
            this.txtBoxNomeMoeda.Name = "txtBoxNomeMoeda";
            this.txtBoxNomeMoeda.Size = new System.Drawing.Size(289, 23);
            this.txtBoxNomeMoeda.TabIndex = 6;
            this.txtBoxNomeMoeda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxValorMoeda
            // 
            this.txtBoxValorMoeda.Location = new System.Drawing.Point(12, 98);
            this.txtBoxValorMoeda.Name = "txtBoxValorMoeda";
            this.txtBoxValorMoeda.Size = new System.Drawing.Size(289, 23);
            this.txtBoxValorMoeda.TabIndex = 7;
            this.txtBoxValorMoeda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NovaMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 189);
            this.Controls.Add(this.txtBoxValorMoeda);
            this.Controls.Add(this.txtBoxNomeMoeda);
            this.Controls.Add(this.bttSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "NovaMoeda";
            this.Text = "Nova Moeda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttSalvar;
        private System.Windows.Forms.TextBox txtBoxNomeMoeda;
        private System.Windows.Forms.TextBox txtBoxValorMoeda;
    }
}