using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices; //Drag and Drop
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp; //FontAwesome

namespace Diseño
{
    public partial class Dashboard : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm; //Para almacenar formulario hijo actual

        //Constructor
        public Dashboard()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //Deshacernos de la barra de titulo del form
            this.Text = string.Empty; //Texto del form cadena vacia
            this.ControlBox = false; //Quitamos caja de control
            this.DoubleBuffered = true; //Ativamos doble buffer para reducir parpadeo en lo graficos del formulario
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //Establecer limites en el maximizado del formulario para que no cubra la barra de tareas
        }

        //Estructura para activar colores RGB
        //structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 113);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null) //Verificar que el boton no sea nulo
            {
                //Invocamos metodo antes de resaltar el boteon, asi desactivar el boton aterior
                DisableButton();

                //Personalizacion del boton y borde izquierdo del boton
                currentBtn = (IconButton)senderBtn; //Asignar boton actual con boton remitente, convertir objeto al mismo tipo de boton
                currentBtn.BackColor = Color.FromArgb(37, 36, 81); //Cambiamos color fondo del boton
                currentBtn.ForeColor = color; //Cambiamos color de texto
                currentBtn.TextAlign = ContentAlignment.MiddleCenter; //Alineamos texto hacia el centro
                currentBtn.IconColor = color; //Cambiamos color de icono a parametro color
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage; //Texto antes de imagen
                currentBtn.ImageAlign = ContentAlignment.MiddleRight; //Icono hacia la derecha

                //Left border button
                leftBorderBtn.BackColor = color; //Cambiamos color de fondo a parametro boton
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y); //Asiganr nueva ubicacion
                leftBorderBtn.Visible = true; //Aplicamos visibilidad
                leftBorderBtn.BringToFront(); //Lo traemos al frente

                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;//icono del formulario hijo actual igual al icono del boton actual
                iconCurrentChildForm.IconColor = color; //Cambiamos color del icono al parametro color
            }
        }
        //Desactivar el resaltado del boton
        private void DisableButton()
        {
            if(currentBtn != null)  //Verificamos que el boton no sea nulo
            {
                //Las mismas propiedades del boton
                currentBtn.BackColor = Color.FromArgb(31, 30, 68); //Aplicamos color original del boton
                currentBtn.ForeColor = Color.Gainsboro; //Aplicamos color original del texto
                currentBtn.TextAlign = ContentAlignment.MiddleCenter; //Alineamos texto hacia la izquierda
                currentBtn.IconColor = Color.Gainsboro; //Aplicamos color original del icono
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText; //Icono antes del texto
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft; //Alinear icono hacia la izquierda
            }
        }

        //Abrir formularios Hijos
        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //Open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false; //Indicamos que el formulario hijo no es de nivel superior
            childForm.FormBorderStyle = FormBorderStyle.None; //Quitamos el borde del formulario
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm); //Agregamos el form hijo a los controles del panel escritorio
            panelDesktop.Tag = childForm; //Asociamos los datos del formulario al panel
            childForm.BringToFront(); //Traemos los formularios hacia el frente
            childForm.Show(); //Los mostramos
            lblTitleChildForm.Text = childForm.Text; //Finalmente mostromos el texto del formulario en la etiqueta titulo
        }

        //Efecto botones
        #region
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmMostrarViajes());
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new frmVehiculo());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Choferes());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            
        }
        #endregion


        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        //Resetear Todo
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        //Drag and Drop Form
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wparam, int lparam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconBtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Control para manejar el tamaño maximizar
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconBtnMasOpciones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            frmMas frm = new frmMas();
            frm.ShowDialog();
        }

        private void iconBtnProveedores_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            frmProveedor frm = new frmProveedor();
            frm.ShowDialog();
        }
    }
}
