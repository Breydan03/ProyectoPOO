using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_19
{
    internal class Limpieza
    {
        public void limpiarControles(Control control) //Recibe un control por parámetro
        {
            foreach (var c in control.Controls) //Ingresa a los controles del control asignado
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = ""; //castea la variable c para convertirla en un textbox y le asigna un texto vacío.
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1; //castea la variable c para convertirla en un comboBox y selecciona el índice -1
                }
                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false; //castea la variable c para convertirla en un RadioButton y desmarca cualquier opción seleccionada
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false; //castea la variable c para convertirla en un checkBox y desmarca cualquier opción seleccionada
                }
                if(c is DateTimePicker)
                {
                   ((DateTimePicker)c).Value = DateTime.Now; //castea la variable c para convertirla en un DateTimePiker y restablece a la fecha actual
                }

            }

        } //Final función limpiarControles(Control control);
    }

}
