using Horarios_CIES.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Horarios_CIES.Controllers;

namespace Horarios_CIES
{
    public partial class Menu : Form
    {
        //Movimiento de ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Variables de posicion
        int lx, ly;

        //Contador de clicks
        int clickD = 1;
        int clickG = 1;

        CarreraController carrera = new CarreraController();

        public Menu()
        {
            InitializeComponent();
            carrera.obtenerCarreras();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Inicio());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1300, 650);
            this.Location = new Point(lx, ly);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void PanelControlador_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnHorarioDocente_Click(object sender, EventArgs e)
        {

            if (clickD == 1)
            {
                OcultarGrupo();
                MostrarHorarioDocente();
            }
            else if (clickD == 2)
            {
                OcultarDoc();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            OcultarDoc();
            OcultarGrupo();
            AbrirFormEnPanel(new Inicio());
            lblTitulo.Text = "INICIO";
        }

        private void btnCarrera_Click(object sender, EventArgs e)
        {
            OcultarDoc();
            OcultarGrupo();
            AbrirFormEnPanel(new Carrera());
            lblTitulo.Text = "CARRERA";
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            OcultarDoc();
            OcultarGrupo();
            AbrirFormEnPanel(new Grupo());
            lblTitulo.Text = "GRUPO";
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            OcultarDoc();
            OcultarGrupo();
            AbrirFormEnPanel(new Materia());
            lblTitulo.Text = "MATERIA";
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            OcultarDoc();
            OcultarGrupo();
            AbrirFormEnPanel(new Docente());
            lblTitulo.Text = "DOCENTE";
        }

        private void btnHorarioGrupo_Click(object sender, EventArgs e)
        {
            if (clickG == 1)
            {
                OcultarDoc();
                MostrarHorarioGrupo();
            }
            else if (clickG == 2)
            {
                OcultarGrupo();
            }
        }

        private void btnHorarioGruCrear_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CrearHorarioGrupo());
            lblTitulo.Text = "CREAR HORARIO DE GRUPO";
        }

        private void btnHorarioGruConsulta_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ConModHorarioGrupo());
            lblTitulo.Text = "CONSULTA/MODIFICAR HORARIO DE GRUPO";
        }

        private void btnHorarioDocCrear_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CrearHorarioDocente());
            lblTitulo.Text = "CREAR HORARIO DE DOCENTE";
        }

        private void btnHorarioDocConsulta_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ConModHorarioDocente());
            lblTitulo.Text = "CONSULTA/MODIFICAR HORARIO DE DOCENTE";
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void MostrarHorarioGrupo()
        {
            btnHorarioGruCrear.Enabled = true;
            btnHorarioGruCrear.Visible = true;
            btnHorarioGruConsulta.Enabled = true;
            btnHorarioGruConsulta.Visible = true;
            clickG = 2;
        }

        private void OcultarDoc()
        {
            btnHorarioDocCrear.Enabled = false;
            btnHorarioDocConsulta.Enabled = false;
            btnHorarioDocConsulta.Visible = false;
            btnHorarioDocCrear.Visible = false;
            btnHorarioGrupo.Location = new Point(0, 425);
            clickD = 1;
        }

        private void OcultarGrupo()
        {
            btnHorarioGruCrear.Enabled = false;
            btnHorarioGruCrear.Visible = false;
            btnHorarioGruConsulta.Enabled = false;
            btnHorarioGruConsulta.Visible = false;
            clickG = 1;
        }

        private void btnCiclo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Ciclos());
            lblTitulo.Text = "CICLO";
        }

        private void MostrarHorarioDocente()
        {
            btnHorarioDocCrear.Enabled = true;
            btnHorarioDocCrear.Visible = true;
            btnHorarioDocConsulta.Enabled = true;
            btnHorarioDocConsulta.Visible = true;
            btnHorarioGrupo.Location = new Point(0, 505);
            clickD = 2;
        }
    }
}