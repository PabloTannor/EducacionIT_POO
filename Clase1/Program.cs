namespace Clase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.Nombre = "Pepe";

            CuentaBancaria cuenta = new CuentaBancaria(); //objeto que invoca sin parametros

            CuentaBancaria cuenta2 = new CuentaBancaria("4578712", "CORRIENTE", "PEDRO PICAPIEDRA", 50000, "PESO ARGENTINO", "5875-4852-4521-4578");

            Console.WriteLine(cuenta2.MostrarDatos()); //muestra datos cta constructor 2;            

            CuentaBancaria cuenta3 = new CuentaBancaria("5207895","AHORRO","PABLO PICAPIEDRA",60000,"PESO ARGENTINO","5487-8520-4587-8521","123456789");

            Console.WriteLine(cuenta3.MostrarDatos());

        }
    }
}
