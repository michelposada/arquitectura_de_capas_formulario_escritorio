using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaentidad
{
    public class CEcita
    {
        public string cod_cita { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
        public string id_paciente { get; set; }
        public string id_medico { get; set; }
        public int valor { get; set; }
        public string diagnostico { get; set; }
        public string nom_acompañante { get; set; }
        public byte activo { get; set; }
    }
}
