using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using capadatos;
using capaentidad;
using System.Data;

namespace capanegocio
{
    public class CNcita
    {
        CDcita objdato = new CDcita();

        public DataTable N_listado()
        {
            return objdato.D_listado();
        }
    }
}
