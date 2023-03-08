using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaBanco
{
    public class Registro
    {
        private int cuenta;
        private string primerNombre;
        private string apellidoPaterno;
        private decimal saldo;

        //Constructor sin parametros establece los miembros a los valores predeterminados
        public Registro() : this(0, "", "", 0.0M)
        {

        }

        public Registro(int valorCuenta, String valorPrimerNombre, string valorApellidoPaterno, decimal valorSaldo)
        {
            Cuenta = valorCuenta;
            primerNombre = valorPrimerNombre;
            apellidoPaterno = valorApellidoPaterno;
            saldo = valorSaldo;

        }

        public int Cuenta { get => cuenta; set => cuenta = value; }
        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }
    }
}
