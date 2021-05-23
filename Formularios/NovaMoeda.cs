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

namespace Havan_Projeto.Formularios
{
    public partial class NovaMoeda : Form
    {
        public string pathMoedas;
        public List<Moeda> ListMoedas;

        public NovaMoeda()
        {
            InitializeComponent();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Moeda novaMoeda = new Moeda
            {
                Nome = txtBoxNomeMoeda.Text,
                Valor = Convert.ToSingle(txtBoxValorMoeda.Text)
            };
            
            ListMoedas.Add(novaMoeda);

            using (StreamWriter sw = new StreamWriter(pathMoedas))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(writer, ListMoedas);
                }
            }

            DialogResult = DialogResult.OK;
        }
    }
}
