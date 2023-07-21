using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregar
using System.Windows.Forms;
using System.Text.RegularExpressions; //Validaciones


namespace Diseño.Validaciones
{
    class Validar
    {
        public static bool SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)) //con esto capturamos cada tecla que se presiona 
            {                            //en este caso se valida si preciona un numero
                e.Handled = false;
                return true;    // si es numero retorna  verdadero
            }
            else if (char.IsControl(e.KeyChar))//se valida si la tecla precionada es un control ya sea borrar o otro
            {
                e.Handled = false;
                return true;// si es control retorna  verdadero
            }
            else  //en caso de que no sea numero retorna falso
            {
                e.Handled = true;
                return false;// no permitira que se ingrese la informacion
            }
        }

        public static bool SoloLetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) //con esto capturamos cada tecla que se presiona 
            {                            //en este caso se valida si preciona letras
                e.Handled = false;
                return true;    // si son letras retorna  verdadero
            }
            else if (char.IsControl(e.KeyChar))//se valida si la tecla precionada es un control ya sea borrar o otro
            {
                e.Handled = false;
                return true;// si es control retorna  verdadero
            }
            else  //en caso de que no sea letras retorna falso
            {
                e.Handled = true;
                return false;// no permitira que se ingrese la informacion
            }
        }

        public static bool Vacios(TextBox ptxt) //pasamos un parametro de tipo texbox
        {
            if (ptxt.Text == string.Empty)//Validamos is el texbox esta vacio
            {
                ptxt.Focus();//que no nos permita ir a otro sin llenar ese
                return true; // retorna verdadero si esta vacio
            }
            else
            {
                return false;//si tiene informacion sea falso
            }
        }

        public static bool ValidarCedula(string cedula)
        {
            return cedula != null && Regex.IsMatch(cedula, "^[0-9]{3}[-][0-9]{6}[-][0-9]{4}[A-Z]{1}$");
        }

        public static bool ValidarFecha(string fecha)
        {
            return fecha != null && Regex.IsMatch(fecha, "^[0-9]{2}[-][0-9]{2}[-][0-9]{4}$");
        }
    }
}
