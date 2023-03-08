using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaBanco
{
    public partial class frmBancoUI : Form
    {
        protected int CuentaTextBox = 4; //Numero de TextBox en el Formulario

        //Las Constantes de la enumearcion especifican los indice de los controles TextBox
        public enum IndicesTextBox
        {
            CUENTA,
            NOMBRE,
            APELLIDO,
            SALDO
        }

        public frmBancoUI()
        {
            InitializeComponent();
        }

        //Limpia todos los controles TextBox
        public void LimpiarControlesTextBox()
        {

            //Itera a traves de cada control en el formulario
            for(int i =0; i < Controls.Count; i++)
            {
                Control miControl = Controls[i]; //Obtiene el Control

                //determina si el Control es TextBox
                if(miControl is TextBox)
                {
                    //Limpia la Propiedad Text (La establece una cadena vacia)
                    miControl.Text = "";
                }
            }
        }

        //Establece los valores de los controles TextBox con el arreglo string valores

        public void EstablecerValoresControlesTextBox(string[] valores)
        {
            //Determina si el arreglo string tiene la longitud correcta
            if(valores.Length != CuentaTextBox)
            {
                //Lanza la excepcion si no tiene la longitud correcta
                throw new ArgumentException("Debe haber" + (CuentaTextBox+1) + " Objetos string en el arreglo");
            } 
            //Establece valores si el arreglo tiene la longitud correcta
            else
            {
                txtCuenta.Text = valores[(int)IndicesTextBox.CUENTA];
                txtprimerNom.Text = valores[(int)IndicesTextBox.NOMBRE];
                txtApellidoPaterno.Text = valores[(int)IndicesTextBox.APELLIDO];
                txtSaldo.Text = valores[(int)IndicesTextBox.SALDO];
            }
        }

        //Devuelve los valores de los controles TextBox como un arreglo string
        public string[] ObtenerValoresControlesTextBox()
        {
            string[] valores = new string[CuentaTextBox];

            //copia los campos de los controles TextBox al arreglo string
            valores[(int)IndicesTextBox.CUENTA] = txtCuenta.Text;
            valores[(int)IndicesTextBox.NOMBRE] = txtprimerNom.Text;
            valores[(int)IndicesTextBox.APELLIDO]=txtApellidoPaterno.Text;
            valores[(int)IndicesTextBox.SALDO]=txtSaldo.Text;

            return valores;
        }

    }
}
