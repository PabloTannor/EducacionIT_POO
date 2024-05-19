using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    public class Empleado : Persona
    {
        public string nroLegajo { get; set; }

        public string categoria { get; set; }

        public override void enviarMensaje(string texto)
        {
            throw new NotImplementedException();
        }
    }
}
