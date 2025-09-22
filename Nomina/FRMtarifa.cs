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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nomina
{
    public partial class FRMtarifa : Form
    {
        public String ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"ValoresTarifa.json");
        public FRMtarifa()
        {
            InitializeComponent();
            if (File.Exists(ruta))
            {
                string json = File.ReadAllText(ruta);
                Datos datos = JsonConvert.DeserializeObject<Datos>(json);

                txtRG.Text = datos.Campo1;
                txtOT.Text = datos.Campo2;
                txtDT.Text = datos.Campo3;
            }
        }

        private void BTNguardar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos()
            {
                Campo1 = txtRG.Text,
                Campo2 = txtOT.Text,
                Campo3 = txtDT.Text,
            };

            String json = JsonConvert.SerializeObject(datos, Formatting.Indented);
            String ruta = Path.Combine(Application.StartupPath, "ValoresTarifa.json");
            File.WriteAllText(ruta, json);

            MessageBox.Show("Tarifas Guardadas", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void BTNcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
