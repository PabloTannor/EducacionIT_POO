using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    public class CuentaBancaria
    {

        public CuentaBancaria()
        {
            this.idCuenta = obtenerID();//objeto anonimo para id aleatoreo
            this._nroCuenta = "SIN NUMERO";
            this.Tipo = "CAJA DE AHORRO";
            this.Titular = "DESCONOCIDO";
            this.FechaApertura = DateTime.Now;
            this.Saldo = 100;
            this.Moneda = "Peso Argentino";
        }

        //Metodo constructor sobrecargado
        public CuentaBancaria(string nroCuenta,string tipo,string titular,double saldoApertura,string moneda,string tarjeta)
        {
            this.idCuenta = obtenerID();
            this._nroCuenta = nroCuenta;
            this.Tipo = tipo;
            this.Titular = titular;
            this.FechaApertura = DateTime.Now;
            this.Saldo = saldoApertura;
            this.Moneda = moneda;
            this.Tarjeta = tarjeta;
            this.ClavePrivada = GenerarClavePrivada();
        }

        public CuentaBancaria(string nroCuenta, string tipo, string titular, double saldoApertura, string moneda, string tarjeta, string seguro)
        {
            this.idCuenta = obtenerID();
            this._nroCuenta = nroCuenta;
            this.Tipo = tipo;
            this.Titular = titular;
            this.FechaApertura = DateTime.Now;
            this.Saldo = saldoApertura;
            this.Moneda = moneda;
            this.Tarjeta = tarjeta;
            this.Seguro = seguro;
            this.ClavePrivada = GenerarClavePrivada();
        }

        //ATRIBUTOS ENCAPSULADOS

        int idCuenta;
        string _nroCuenta;
        string Tipo;
        string Titular;
        DateTime FechaApertura;
        double Saldo;
        string Moneda;
        string Tarjeta;
        string Seguro;
        string ClavePrivada;

        //METODOS
        public void Depositar(double monto)
        {
            this.Saldo += monto;
        }

        public void Retirar ( double monto)
        {
            this.Saldo -= monto;
        }

        public double SaldoDisponible()
        {
            return this.Saldo;
        }

        private int obtenerID()
        {
            return new Random().Next();
        }

        public string MostrarDatos()
        {
            return $"Id Cuenta: {this.idCuenta}\nNro de cuenta: {this._nroCuenta}\nTipo:{this.Tipo}\nTitular: {this.Titular}\nMoneda: {this.Moneda}\nCuenta:{this.Saldo}\nSeguro {(this.Seguro != null ? this.Seguro : "sin seguro")}";
        }

        private string GenerarClavePrivada()
        {
            return new Guid().ToString();
        }

        //Metodos getters y setters forma java

        public int GetIdCuenta()
        {
            return this.idCuenta;
        }

        public string GetNumeroCta()
        {
            return this._nroCuenta;
        }

        public void setNroCuenta(string nro)
        {
            this._nroCuenta = nro;
        }

        // Propiedad en c#

        /*public string NroCuenta
        {
            get { return this._nroCuenta; }
            set { 
                if(value != null)
                 {
                  this._nroCuenta = value;
                 }                
                }
        } */

        public string nroCuenta { get; set; }

    }
}
