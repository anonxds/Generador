using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador
{
    public partial class AcercaDe : MetroForm
    {
        private static AcercaDe instance;

        public AcercaDe()
        {
            InitializeComponent();
            bunifuCustomLabel1.Text = "Este software fue desarrollado por \n Sanchez de Santiago Orlando de la carrera Ing. Informatica \n" +
                "para contacta mandar correo a orlando.sanchez@tectijuana.edu.mx";
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
