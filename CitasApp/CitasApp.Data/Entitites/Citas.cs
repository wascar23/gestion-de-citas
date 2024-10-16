using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasApp.Data.Entitites
{
    public class Citas
    {
        public int ID { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaCita { get; set; }
        public string DescripcionCita { get; set; }
    }
}
