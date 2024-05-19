using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    public class Cliente : Persona
    {
        public int idCliente { get; set; }
        public string CUIT { get; set; }
        
        public DateTime fechaDeAlta { get; set; }

        public double saldoCredito { get; set; }

        public override void enviarMensaje(string texto)
        {
            Console.WriteLine($"Enviando mensaje por Email {texto}");
        }
    }
}
