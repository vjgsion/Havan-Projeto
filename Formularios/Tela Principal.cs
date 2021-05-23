using Havan_Projeto.Formularios;
using Havan_Projeto.Modelos;
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

namespace Havan_Projeto
{
    public partial class Form1 : Form
    {
        private readonly string pathMoedas = $"{Application.StartupPath}//Moedas.json";
        private readonly string pathClientes = $"{Application.StartupPath}//Clientes.json";
        private ColumnHeader SortingColumn = null;

        public List<Moeda> ListMoedas = new List<Moeda>();
        public List<Cliente> ListClientes = new List<Cliente>();

        public Form1()
        {
            string listaMoedas = File.ReadAllText(pathMoedas);
            string listaClientes = File.ReadAllText(pathClientes);

            ListMoedas = JsonConvert.DeserializeObject<List<Moeda>>(listaMoedas);
            ListClientes = JsonConvert.DeserializeObject<List<Cliente>>(listaClientes);

            InitializeComponent(); 
            PopulateListView();
        }

        private void PopulateListView()
        {
            float valorOriginal = 0;
            float valorTaxas = 0;

            listView1.Items.Clear();

            foreach (var cliente in ListClientes)
            {
                var itemNome = listView1.Items.Add(cliente.Nome);
                itemNome.SubItems.Add(cliente.MoedaOriginal);
                itemNome.SubItems.Add(cliente.MoedaDestino);
                itemNome.SubItems.Add(cliente.DataOperacao);
                itemNome.SubItems.Add(cliente.ValorOriginal);
                itemNome.SubItems.Add(cliente.ValorConvertido);
                itemNome.SubItems.Add(cliente.TaxaCobrada);

                valorOriginal +=
                    Convert.ToSingle(cliente.ValorOriginal) *
                    ListMoedas.Find(x => x.Nome == cliente.MoedaOriginal).Valor;

                valorTaxas +=
                    Convert.ToSingle(cliente.TaxaCobrada) *
                    ListMoedas.Find(x => x.Nome == cliente.MoedaOriginal).Valor;
            }

            textBox1.Text = $"R$ {Math.Round(valorTaxas, 2)}";
            textBox2.Text = $"R$ {Math.Round(valorOriginal, 2)}";
        }

        private void Moeda_Click(object sender, EventArgs e)
        {
            NovaMoeda novaMoeda = new NovaMoeda
            {
                ListMoedas = ListMoedas,
                pathMoedas = pathMoedas
            };

            novaMoeda.ShowDialog();

            PopulateListView();
        }

        private void Cambio_Click(object sender, EventArgs e)
        {
            NovoCambio novoCambio = new NovoCambio
            {
                ListMoedas = ListMoedas,
                ListClientes = ListClientes,
                pathMoedas = pathMoedas,
                pathClientes = pathClientes
            };

            novoCambio.SetCombos();
            novoCambio.ShowDialog();

            PopulateListView();
        }

        private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ColumnHeader new_sorting_column = listView1.Columns[e.Column];

            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn == null)
            {
                sort_order = SortOrder.Ascending;
            }
            else
            {
                if (new_sorting_column == SortingColumn)
                {
                    if (SortingColumn.Text.StartsWith("> "))
                    {
                        sort_order = SortOrder.Descending;
                    }
                    else
                    {
                        sort_order = SortOrder.Ascending;
                    }
                }
                else
                {
                    sort_order = SortOrder.Ascending;
                }

                SortingColumn.Text = SortingColumn.Text.Substring(2);
            }

            SortingColumn = new_sorting_column;

            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn.Text = "> " + SortingColumn.Text;
            }
            else
            {
                SortingColumn.Text = "< " + SortingColumn.Text;
            }

            listView1.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            listView1.Sort();
        }
    }
}
