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
                dt.Columns.Add("status");
                dt.Columns.Add("No. Control");
                dt.Columns.Add("Nombre Completo");
                dt.Columns.Add("Proyecto");
                dt.Columns.Add("Empresa");
                dt.Columns.Add("Asesor");
                dt.Columns.Add("Carrera");
                dt.Columns.Add("Correo");
                dt.Columns.Add("Telefono");
                dt.Columns.Add("id");                
                dgvinfo.DataSource = dt;
                grid();
                this.dgvinfo.Columns["No. Control"].ReadOnly = true;
                this.dgvinfo.Columns["status"].ReadOnly = true;
                this.dgvinfo.Columns["id"].ReadOnly = true;

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
                        row["status"] = obj2.status;
                        row["No. Control"] = obj2.control;
                        row["Nombre Completo"] = obj2.nombre;
                        row["Proyecto"] = obj2.proyecto;
                        row["Empresa"] = obj2.empresa;
                        row["Asesor"] = obj2.asesor;
                        row["Carrera"] = obj2.carrera;
                        row["Correo"] = obj2.correo;
                        row["Telefono"] = obj2.tel;
                        row["id"] = obj2.id;
                        dt.Rows.Add(row);
                    }
                    catch
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos " + ex);
            }
        }
       

        private void btngen_Click(object sender, EventArgs e)
        {
            if (lblid.Text == " ")
            {
                MessageBox.Show("Seleccione un estudiante");

            }
            else
            {
                int control = int.Parse(lblctl.Text);
                string nombre = lblnombreD.Text;
                string proyecto = lblproyecto.Text;
                string empresa = lblempresa.Text;
                string Asesor = lblasesor.Text;
                string carrera = lblcarrera.Text;
                string correo = lblcorreo.Text;
                string tel = lblcorreoD.Text;
                dept = new MetalMecanica();

                dept.GetGenerarFormato(proyecto, Asesor, nombre, control, carrera, tel, correo, empresa);
            }
        }

        private async void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblid.Text == " ")
                {
                    MessageBox.Show("Seleccione un estudiante");

                }
                else
                {
                    var count = dgvinfo.Rows
         .Cast<DataGridViewRow>()
         .Select(row => row.Cells["No. Control"].Value.ToString())
         .Count(s => s == lblctl.Text);

                  
                    if(count == 1)
                    {
                        FirebaseResponse res = await client.DeleteAsync("estudiante/" + lblid.Text);
                        FirebaseResponse res2 = await client.DeleteAsync("Control/" + lblctl.Text);
                    }
                    else
                    {
                        FirebaseResponse res = await client.DeleteAsync("estudiante/" + lblid.Text);
                    }


                    grid();
                    lblcorreoD.Text = lblid.Text = lblctl.Text = lblnombreD.Text = lblproyecto.Text = lblempresa.Text = lblasesor.Text = lblasesor.Text = lblcarrera.Text = lblcorreo.Text = null;
                    MessageBox.Show("Se borro de la base de datos");
                }
                }
            catch
            {
                MessageBox.Show("Checar la conexion de internet");
            }
        }

        private void btnrefresj_Click(object sender, EventArgs e)
        {
         
            grid();
        }
      
      
        private void btnacercaDe_Click(object sender, EventArgs e)
        {
            AcercaDe d = new AcercaDe();
            d.Show();
        }

        private void txtbuscar_OnValueChanged(object sender, EventArgs e)
        {
            (dgvinfo.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Nombre completo] like '%{0}%' or [No. Control] like '%{1}%'", txtbuscar.Text,txtbuscar.Text);

        }

      

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void dgvinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbstatus.Text = dgvinfo.CurrentRow.Cells[0].Value.ToString();
            lblctl.Text = dgvinfo.CurrentRow.Cells[1].Value.ToString();
            lblnombreD.Text = dgvinfo.CurrentRow.Cells[2].Value.ToString();
            lblproyecto.Text = dgvinfo.CurrentRow.Cells[3].Value.ToString();
            lblempresa.Text = dgvinfo.CurrentRow.Cells[4].Value.ToString();
            lblasesor.Text = dgvinfo.CurrentRow.Cells[5].Value.ToString();
            lblcarrera.Text = dgvinfo.CurrentRow.Cells[6].Value.ToString();
            lblcorreo.Text = dgvinfo.CurrentRow.Cells[7].Value.ToString();
            lblid.Text = dgvinfo.CurrentRow.Cells[9].Value.ToString();
            lblcorreoD.Text = dgvinfo.CurrentRow.Cells[8].Value.ToString();

        }

        private void bunifuImageButton1_MouseHover(object sender, EventArgs e)
        {
            metroToolTip1.SetToolTip(bunifuImageButton1, "Cerrar");

        }

        private async void btncambiar_Click(object sender, EventArgs e)
        {
            var data = new info
            {
                id = lblid.Text,
                control = lblctl.Text,
                nombre = lblnombreD.Text,
                empresa = lblempresa.Text,
                asesor = lblasesor.Text,
                proyecto = lblproyecto.Text,
                carrera = lblcarrera.Text,
                correo = lblcorreo.Text,
                tel = lblcorreoD.Text,
                status = cbstatus.Text,
            };
            var s = new info
            {
                status = cbstatus.Text,

            };
            if (lblid.Text == " ")
            {
                MessageBox.Show("Seleccione un estudiante");

            }
            else
            {

                FirebaseResponse res = await client.UpdateAsync("estudiante/" + lblid.Text, data);
                FirebaseResponse res2 = await client.UpdateAsync("Control/" + lblctl.Text, s);
                info resu = res.ResultAs<info>();
                MessageBox.Show("Datos actualizados");
                grid();
            }
        }
        public void buscar()
        {
            switch (metroComboBox1.Text)
            {
                case "Todos":
                        (dgvinfo.DataSource as DataTable).DefaultView.RowFilter = string.Format("[status] like '%{0}%' or [status] like '%{1}%' or [status] like '%{2}%'", "Pendiente","Aceptado","Rechazado");
                        break;
                case "Pendientes":
                    (dgvinfo.DataSource as DataTable).DefaultView.RowFilter = string.Format("[status] like '%{0}%'", "Pendiente");
                    break;
                case "Aceptados":
                        (dgvinfo.DataSource as DataTable).DefaultView.RowFilter = string.Format("[status] like '%{0}%'", "Aceptado");
                        break;                    
                case "Rechazados":
                    (dgvinfo.DataSource as DataTable).DefaultView.RowFilter = string.Format("[status] like '%{0}%'", "Rechazado");
                    break;
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buscar();
        }

      
    }

    class counter
    {
        public double cnt { get; set; }
    }
    class info
    {
        private string _numero;
        private string _nombre;
        private string _id;
        private string _carrera;
        private string _control;
        private string _tel;
        private string _empresa;
        private string _asesor;
        private string _proyecto;
   private     string _correo;
      private  string _status;
        public string nombre { get => _nombre; set => _nombre = value; }
        public string carrera { get => _carrera; set => _carrera = value; }
        public string control { get => _control; set => _control = value; }
        public string tel { get => _tel; set => _tel = value; }
        public string empresa { get => _empresa; set => _empresa = value; }
        public string asesor { get => _asesor; set => _asesor = value; }
        public string proyecto { get => _proyecto; set => _proyecto = value; }
        public string numero { get => _numero; set => _numero = value; }
        public string correo { get => _correo; set => _correo = value; }
        public string status { get => _status; set => _status = value; }
        public string id { get => _id; set => _id = value; }
    }
}
