using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador.Fabrica
{
    class MetalMecanica : DeptFactory
    {
     
        public override GenerarFormato GetGenerarFormato(string proyecto,string asesor,string nombre, int control,string carrera,int tel,string correo,string empresa)
        {    
            var res = new Residencia();
            Formato f = new Formato();
            f.pdf("test", res.Dept, res.Lugar, "Informe Tecnico de Residencia profecional",proyecto,asesor,int.Parse(res.Num),nombre,control,carrera,tel,correo,empresa);
            return null;
        }
    }
}
