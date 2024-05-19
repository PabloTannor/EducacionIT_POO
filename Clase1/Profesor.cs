using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    internal class Profesor : Persona,IDeveloper,ICoordinador
    {
        public override void enviarMensaje(string texto)
        {
            Console.WriteLine($"Por SMS {texto}");//metodo abstracto heredaro
        }


        //metodos de interface
        string IDeveloper.AsignarNivel(string nivel)
        {
            throw new NotImplementedException();
        }

        string IDeveloper.LenguajeUsado(string lenguaje)
        {
            throw new NotImplementedException();
        }

        void IDeveloper.Programar()
        {
            throw new NotImplementedException();
        }

        //metodos de coordinador

        void ICoordinador.Coordinar()
        {
            throw new NotImplementedException();
        }
    }
}
