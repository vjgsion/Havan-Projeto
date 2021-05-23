using Havan_Projeto.Modelos;
using Havan_Projeto.Serviços;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Havan_Projeto.Formularios
{
    public partial class NovoCambio : Form
    {
        public string pathMoedas;
        public string pathClientes;
        public List<Moeda> ListMoedas;
        public List<Cliente> ListClientes;

        public NovoCambio()
        {
            InitializeComponent();
        }

        public void SetCombos()
        {
            foreach(Moeda item in ListMoedas)
            {
                comboBox1.Items.Add(item.Nome);
                comboBox2.Items.Add(item.Nome);
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                float valor1 = ListMoedas.Find(x => x.Nome == comboBox1.Text).Valor;
                float valor2 = ListMoedas.Find(x => x.Nome == comboBox2.Text).Valor;

                var calc = Calculadora.Instance().ValorConvertido(valor1, valor2,
                    Convert.ToSingle(textBox1.Text));

                textBox2.Text = calc.ToString();
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != string.Empty)
            {
                float valor1 = ListMoedas.Find(x => x.Nome == comboBox1.Text).Valor;
                float valor2 = ListMoedas.Find(x => x.Nome == comboBox2.Text).Valor;

                var calc = Calculadora.Instance().ValorConvertido(valor1, valor2,
                    Convert.ToSingle(textBox1.Text));

                textBox2.Text = calc.ToString();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            float valor1 = ListMoedas.Find(x => x.Nome == comboBox1.Text).Valor;
            float valor2 = ListMoedas.Find(x => x.Nome == comboBox2.Text).Valor;

            var calc = Calculadora.Instance().ValorConvertido(valor1, valor2,
                Convert.ToSingle(textBox1.Text));

            textBox2.Text = calc.ToString();
        }

        private void BttSalvar_Click(object sender, EventArgs e)
        {
            double valorTaxa = 
                Calculadora.Instance().ValorTaxa(Convert.ToSingle(textBox2.Text));

            Cliente cliente = new Cliente
            {
                Nome = textBox3.Text,
                DataOperacao = DateTime.Now.ToString(),
                MoedaDestino = comboBox2.Text,
                MoedaOriginal = comboBox1.Text,
                TaxaCobrada = valorTaxa.ToString(),
                ValorOriginal = textBox1.Text,
                ValorConvertido = textBox2.Text
            };

            ListClientes.Add(cliente);

            using (StreamWriter sw = new StreamWriter(pathClientes))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(writer, ListClientes);
                }
            }

            DialogResult = DialogResult.OK;
        }
    }
}
