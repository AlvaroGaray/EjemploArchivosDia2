using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploArchivo
{
    public partial class frmEjemploArchivo : Form
    {
        public frmEjemploArchivo()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //se invoca cuando el usuario oprime una tecla
        private void txtEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            //determina si el usuario oprimio la tecla Intro
            if (e.KeyCode== Keys.Enter)
            {
                string nombreArchivo;//nombre del archivo o directorio

                //se obtiene el archivo o directorio especificado por el usuario
                nombreArchivo= txtEntrada.Text;

                //determina si nombreArchivo es un archivo 
                if (File.Exists(nombreArchivo))
                {
                    //obtiene fecha de creacion del archivo,
                    //su fecha de modificacion,etc.
                    txtSalida.Text= ObtenerInformacion(nombreArchivo);

                    //muestra el contenido del archivo a traves de StreamReader
                    try
                    {

                        StreamReader sr = new StreamReader(nombreArchivo);
                        txtSalida.Text += sr.ReadToEnd();
                    }
                    //maneja excepcion si StreamReader no esta disponible
                    catch (IOException)
                    {

                        MessageBox.Show("Error al leer del archivo", "Error de archivo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(Directory.Exists(nombreArchivo))
                {
                    string[] listaDirrectorios;// arreglo para los directorios
                    txtSalida.Text = ObtenerInformacion(nombreArchivo);

                    //obtiene la lista de archivos/directorios del directorio especifico
                    listaDirrectorios= Directory.GetDirectories(nombreArchivo);

                }
                else
                {
                    //notifica al usuario que no existe directorio o archivo
                    MessageBox.Show(txtEntrada.Text + 
                        " no existe", "Error de archivo",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        //obtiene informacion sobre el archivo o directorio

        private string ObtenerInformacion(string nombreArchivo)
        {

            string informacion;
            //imprime mensaje indicando que existe el archivo o directorio
            informacion = nombreArchivo + " existe\r\n\r\n";

            //imprime en pantalla la fecha y hora de creacion del archivo o directorio

            informacion += "Creacion: " +
                File.GetLastWriteTime(nombreArchivo) + "\r\n";

            //imprime en pantalla la fecha de la ultima  modificacion del archivo o directorio

            informacion += "Ultima Modificacion: " +
                File.GetCreationTime(nombreArchivo) + "\r\n";

            //imprime en pantalla la fecha y hora del ultimo acceso del archivo o directorio

            informacion += "Ultimo Acceso: " +
                File.GetLastAccessTime(nombreArchivo) + "\r\n" + "\r\n";

            return informacion;
        }
    }
}
