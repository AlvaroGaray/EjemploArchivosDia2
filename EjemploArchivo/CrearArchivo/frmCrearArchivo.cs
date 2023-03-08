using BibliotecaBanco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrearArchivo
{
    public partial class frmCrearArchivo : frmBancoUI
    {
        private StreamWriter archivoWriter; //Escribe datos ene archivo de texto
        private FileStream salida; //Mantiene la conexion con el archivo
        
        
        public frmCrearArchivo()
        {
            InitializeComponent();
        }

        //Manejador de eventos con el boton Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Crea un cuadro de Dialogo que permite al Usuario Guardar el Archivo
            SaveFileDialog SelectorArchivo = new SaveFileDialog();
            DialogResult result = SelectorArchivo.ShowDialog();
            string nombreArchivo; // Nombre del archivo en el que se van a guardar los datos

            SelectorArchivo.CheckFileExists = false; // permite al usuario crear el archivo

            //Sale del manejador de eventos si el usuario hace click en "Cancelar"
            if(result == DialogResult.Cancel)
            {
                return;

                nombreArchivo = SelectorArchivo.FileName; //Obtiene el Nombre del aechivo especificado

                //Muestra error sinel usuario especificó un archivo invalido
                if(nombreArchivo == "" || nombreArchivo == null)
                {
                    MessageBox.Show("Nombre del Archivo Invalido ", "ERROR" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
