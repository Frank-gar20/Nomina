using Newtonsoft.Json;
using OfficeOpenXml;
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
using System.Windows.Forms.VisualStyles;


namespace Nomina
{
    public partial class Form1 : Form
    {
        List<string> columnas;
        public String ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ValoresTarifa.json");
        public Form1()
        {
            InitializeComponent();
            columnas = new List<string>();
            columnas.Add("EE");
            columnas.Add("Nombre");
            columnas.Add("Apellido");
            columnas.Add("Rg. Hrs");
            columnas.Add("OT. Hrs.");
            columnas.Add("D Hrs.");
        }

        private void importarExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ofdExcel.ShowDialog() == DialogResult.OK)
            {
                string archivo = ofdExcel.FileName;
                //MessageBox.Show("Archivo seleccionado: " + archivo);
                CargarExcel(archivo);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            ttsHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void CargarExcel(string path)
        {
            ExcelPackage.License.SetNonCommercialPersonal("Jose Luis Mota Espeleta");

            using (var package = new ExcelPackage(new System.IO.FileInfo(path)))
            {
                if (package.Workbook.Worksheets.Count == 0)
                {
                    MessageBox.Show("El archivo de Excel no contiene hojas de trabajo.");
                    return; //En caso que no haya hojas
                }

                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                DataTable dt = new DataTable();

                // Leer los encabezados de columna
                foreach (var col in columnas)
                {
                    dt.Columns.Add(col);
                }

                // Leer las filas de datos
                int rowCount = worksheet.Dimension.End.Row;
                dgvInformacion.Rows.Clear(); //limpiar antes de mostrar

                //traemos las tarifas a la pantalla principal
                try
                {
                    decimal rgTarifa, otTarifa, dtTarifa;
                    string json = File.ReadAllText(ruta);
                    Datos datos = JsonConvert.DeserializeObject<Datos>(json);
                    rgTarifa = decimal.Parse(datos.Campo1);
                    otTarifa = decimal.Parse(datos.Campo2);
                    dtTarifa = decimal.Parse(datos.Campo3);

                    for (int i = 3; i < rowCount; i++)
                    {
                        String ee = worksheet.Cells[i, 2].Text;
                        if (!String.IsNullOrWhiteSpace(ee))
                        {
                            DataRow row = dt.NewRow();

                            ee = worksheet.Cells[i, 1].Text;

                            string nombreCompleto = worksheet.Cells[i, 2].Text;
                            string[] partes = SepararNombre(nombreCompleto);

                            string apellido = partes[0];
                            string nombre = partes.Length >= 2 ? partes[1] : "";

                            string rgH = worksheet.Cells[i, 3].Text;
                            string otH = worksheet.Cells[i, 4].Text;
                            string dH = worksheet.Cells[i, 5].Text;

                            rgTarifa *= decimal.Parse(rgH);
                            otTarifa *= decimal.Parse(otH);
                            dtTarifa *= decimal.Parse(dH);

                            dt.Rows.Add(row);
                            //ponemos los datos en el DGV
                            dgvInformacion.Rows.Add(ee, nombre, apellido, rgH, otH, dH, rgTarifa.ToString(), otTarifa.ToString(), dtTarifa.ToString());
                        }
                        //volvemos a darle el valor que tiene la tarifa
                        rgTarifa = decimal.Parse(datos.Campo1);
                        otTarifa = decimal.Parse(datos.Campo2);
                        dtTarifa = decimal.Parse(datos.Campo3);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ingresa los valores de las Tarifas", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FRMtarifa fRMtarifa = new FRMtarifa();
                    fRMtarifa.Show();
                }                
            }
        }

        private string [] SepararNombre(string nombreCompleto)
        { 
            
            string[] partes = nombreCompleto.Split(',');
            if (partes.Length >= 2)
            {
                string apellido = partes[0];
                string nombre = partes[1]; 
                partes[1] = nombre.Trim();               
            }
            return partes;
        }

        private void tarifaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMtarifa fRMtarifa = new FRMtarifa();
            fRMtarifa.Show();
        }
    }
}