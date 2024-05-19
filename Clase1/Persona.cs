using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NroDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Edad { get; set; }

        public string CorreoElectronico { get; set; }

        public string saludar() //metodo con codigo
        {
            return $"hola,{Nombre} {Apellido}, Bienvendino";
        }

        public abstract void enviarMensaje(string texto);//no implementada

    }
}
