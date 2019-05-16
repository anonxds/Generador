using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generador.Fabrica
{
 abstract class GenerarFormato
    {       
        public abstract string Dept { get; set; }
        public abstract string Lugar { get; set; }
        public abstract string Num { get; set; }
    }
}
