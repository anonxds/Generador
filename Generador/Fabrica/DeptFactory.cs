using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador.Fabrica
{
   abstract class DeptFactory
    {
        public abstract GenerarFormato GetGenerarFormato(string proyecto, string asesor, string nombre, int control, string carrera, int tel, string correo, string empresa);
    }
}
