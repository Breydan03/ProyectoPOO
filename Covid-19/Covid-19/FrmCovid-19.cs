using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_19
{
    public partial class FrmCovid19 : Form
    {
        public FrmCovid19()
        {
            InitializeComponent();
        }

        //Variables globales
        string vTos = "";
        string vFiebre = "";
        string vCansancio = "";
        string vIncapacidad = "";
        string vRespiración = "";
        string vDolor = "";

        string tipoSexo = "";
        string nivelAcademico = "";
        string provincia = "";

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtFechaActual.Text = DateTime.Now.ToShortDateString(); //Mostrar fecha corta
            //txtHoraActual.Text = DateTime.Now.ToShortTimeString();
            txtHoraActual.Text = DateTime.Now.ToString("h:mm:ss"); //Muestra la hora personalizada
        }

        public void FrmCovid19_Load(object sender, EventArgs e) //Formulario covid
        {
            //Doble click sobre el formulario
        }

        private void chkFiebre_CheckedChanged(object sender, EventArgs e) //Hacer check sobre una casilla
        {
            if (chkFiebre.Checked == true) //Si se hizo check en Fiebre como síntoma:
            {
                vFiebre = "Fiebre"; //Asigna "Fiebre" a la variable global vFiebre
            }
            else //De los contrario lo deja en blanco:
            {
                vFiebre = ""; 
            }

        }

        private void chkTos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTos.Checked == true)
            {
                vTos = "Tos";
            }
            else
            {
                vTos = "";
            }
        }

        private void chkCansancio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCansancio.Checked == true)
            {
                vCansancio = "Cansancio";
            }
            else
            {
                vCansancio = "";
            }
        }

        private void chkRespiracion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRespiracion.Checked == true)
            {
                vRespiración = "Dificultad para respirar o sensación de falta de aire";
            }
            else
            {
                vRespiración = "";
            }
        }

        private void chkDolorPecho_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDolorPecho.Checked == true)
            {
                vDolor = "Dolor o presión en el pecho";
            }
            else
            {
                vDolor = "";
            }
        }

        private void chkIncapacidad_CheckedChanged(object sender, EventArgs e)
        {
            if( chkIncapacidad.Checked == true)
            {
                vIncapacidad = "Incapacidad para hablar o moverse";
            }
            else
            {
                vIncapacidad = "";
            }
        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMasculino.Checked == true)
            {
                tipoSexo = "Masculino";
            }   
        }

        private void rbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemenino.Checked == true)
            {
                tipoSexo = "Femenino";
            }
        }

        private void cbNivelAcademico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNivelAcademico.SelectedIndex != -1) //Si el elemento seleccionado es distinto de -1
            {
                nivelAcademico = cbNivelAcademico.Text; //Almacena en la variable nivelAcademico el texto seleccionado en el combo
            }
        }

        private void cbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvincias.SelectedIndex != -1)
            {
                provincia = cbProvincias.Text;
            }
        }

        private void btnResumir_Click(object sender, EventArgs e)
        {
            string mensaje0 = "Información - Diagnóstico CORONAVIRUS - COVID-19";
            string mensaje1 = "Nombre: " + txtNombre.Text + " " + txtPrimerApellido.Text + " " + txtSegundoApellido.Text;
            string mensaje2 = "Fecha: " + txtFechaActual.Text + " Dirección: " + txtDireccion.Text;
            string mensaje3 = "Sexo: " + tipoSexo + " Correo electrónico: " + txtCorreo.Text;
            string mensaje4 = "Síntomas Básicos: " + vFiebre + " " + vTos + " " + vCansancio + " ";
            string mensaje5 = "Síntomas Graves: " + vRespiración + " " + vDolor + " " + vIncapacidad + " ";

            DialogResult resultado = new DialogResult(); //Creación de un objeto de tipo DialogResult

            resultado = MessageBox.Show(mensaje0 + mensaje1 + mensaje2 + mensaje3 + mensaje4 + mensaje5 + " ",
                "Información General - Resumen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCerrarA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea abandonar la aplicación?", "Registro de pacientes", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDianostico_Click(object sender, EventArgs e)
        {
            Limpieza l = new Limpieza(); //Creación del objeto l de la clase Limpieza
            l.limpiarControles(gbInformacionPacientes); //Se le envía el groupbox por parámetro
            l.limpiarControles(gbSintomas);
        }

        private void ckDespertarse_CheckedChanged(object sender, EventArgs e)
        {
            //Código añadido de prueba
            //Código de prueba #2
        }
    }
}
