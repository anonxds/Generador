using Generador.Fabrica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;
using MetroFramework.Forms;

namespace Generador
{
    public partial class Form1 : MetroForm
    {
        sql s = new sql();
        DeptFactory dept;
        DataTable dt = new DataTable();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "B3OW1lgPzkkyR8Vz1X7L2lfeTJwce9XLx3qO7TuW",
            BasePath = "https://formato-c8f84.firebaseio.com/"
        };
        IFirebaseClient client;
            
        public Form1()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
            if(client != null)
            {
                dt.Columns.Add("No. Control");
                dt.Columns.Add("Nombre Completo");
                dt.Columns.Add("Proyecto");
                dt.Columns.Add("Empresa");
                dt.Columns.Add("Asesor");
                dt.Columns.Add("Carrera");
                dt.Columns.Add("Correo");
                dt.Columns.Add("id");                
                dgvinfo.DataSource = dt;
                grid();

            }
        }
        private async void grid()
        {
            try
            {
                dt.Rows.Clear();
                int i = 0;

                FirebaseResponse response = await client.GetAsync("Counter/");
                counter obj = response.ResultAs<counter>();
                int cnt = Convert.ToInt32(obj.cnt);
                while (true)
                {
                    i++;
                    try
                    {
                        FirebaseResponse resp2 = await client.GetAsync("estudiante/" + i);
                        info obj2 = resp2.ResultAs<info>();
                        DataRow row = dt.NewRow();
                        row["No. Control"] = obj2.Control;
                        row["Nombre Completo"] = obj2.Nombre;
                        row["Proyecto"] = obj2.Proyecto;
                        row["Empresa"] = obj2.Empresa;
                        row["Asesor"] = obj2.Asesor;
                        row["Carrera"] = obj2.Carrera;
                        row["Correo"] = obj2.Correo;
                        row["id"] = obj2.Id;
                        dt.Rows.Add(row);
                    }
                    catch
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos ");
            }
        }

        private void dgvdatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
       

        }
        private void bngenerar_Click(object sender, EventArgs e)
        {
                }

        private void btngen_Click(object sender, EventArgs e)
        {
                int control = int.Parse(lblctl.Text);
              string nombre = lblnombreD.Text + " "+ lblapelldio.Text;
            string proyecto = lblproyecto.Text;
            string empresa = lblempresa.Text;
            string Asesor = lblasesor.Text;      
            string carrera = lblcarrera.Text;
            string correo = lblcorreo.Text;
            dept = new MetalMecanica();
                  dept.GetGenerarFormato(proyecto, Asesor, nombre, control, carrera, 3, correo, empresa);

        }

        private async void btneliminar_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = await client.DeleteAsync("estudiante/"+lblid.Text);
            FirebaseResponse res2 = await client.DeleteAsync("Control/"+lblctl.Text);
            grid();
          lblid.Text = lblctl.Text = lblnombreD.Text = lblproyecto.Text = lblempresa.Text = lblasesor.Text = lblasesor.Text = lblcarrera.Text = lblcorreo.Text = null;
            MessageBox.Show("Se borro de la base de datos");

        }

        private void btnrefresj_Click(object sender, EventArgs e)
        {
            grid();
        }

        private void dgvinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
      
        private void btnacercaDe_Click(object sender, EventArgs e)
        {
            AcercaDe d = new AcercaDe();
            d.Show();
           //SÍnGlaTÓN.getInstance;
        }

        private void txtbuscar_OnValueChanged(object sender, EventArgs e)
        {
            (dgvinfo.DataSource as DataTable).DefaultView.RowFilter = string.Format("[No. Control] LIKE '%{0}%'", txtbuscar.Text);

        }

        private void dgvinfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblctl.Text = dgvinfo.CurrentRow.Cells[0].Value.ToString();
            lblnombreD.Text = dgvinfo.CurrentRow.Cells[1].Value.ToString();
            //   lblapelldio.Text = dgvinfo.CurrentRow.Cells[2].Value.ToString();
            lblproyecto.Text = dgvinfo.CurrentRow.Cells[2].Value.ToString();
            lblempresa.Text = dgvinfo.CurrentRow.Cells[3].Value.ToString();
            lblasesor.Text = dgvinfo.CurrentRow.Cells[4].Value.ToString();
            //  lblempresaD.Text = dgvinfo.CurrentRow.Cells[5].Value.ToString();
            lblcarrera.Text = dgvinfo.CurrentRow.Cells[5].Value.ToString();
            lblcorreo.Text = dgvinfo.CurrentRow.Cells[6].Value.ToString();
            lblid.Text = dgvinfo.CurrentRow.Cells[7].Value.ToString();

        }
    }

    class counter
    {
        public double cnt { get; set; }
    }
    class info
    {
        private string numero;
        private string nombre;
        private string id;
        private string carrera;
        private string control;
        private string tel;
        private string empresa;
        private string asesor;
        private string proyecto;
        string correo;
        string apellido;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Control { get => control; set => control = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string Asesor { get => asesor; set => asesor = value; }
        public string Proyecto { get => proyecto; set => proyecto = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Id { get => id; set => id = value; }
    }
}
