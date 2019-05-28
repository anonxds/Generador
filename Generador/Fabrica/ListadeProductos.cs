using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generador.Fabrica
{
    class Residencia : GenerarFormato
    {
        public override string Dept { get => "Metal-Mecanica"; set => Dept = value; }
        public override string Lugar { get => "Tijuana B.C"; set => Lugar = value; }
        public override string Num { get => "1"; set => Num = value; }
        public override string tipoP { get => "Informe Tecnico de Residencia profesional"; set => tipoP = value; }
    }
}
