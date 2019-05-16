using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generador
{
 public  class SÍnGlaTÓN
    {
        private static AcercaDe instance;

        public static AcercaDe getInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new AcercaDe();
                }
                return instance;
            }
        }
    }
}
