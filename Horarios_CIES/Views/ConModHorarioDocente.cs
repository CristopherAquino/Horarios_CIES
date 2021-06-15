using Horarios_CIES.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Horarios_CIES.Views
{
    public partial class ConModHorarioDocente : Form
    {
        public ConModHorarioDocente()
        {
            InitializeComponent();
        }

        int indiceInicio;
        string horainicio;
        int indiceFin;
        string horafin;
        int indiceDia;
        string dia;
        int indiceMateria;
        string materia;
        int indiceDocente;
        string docente;
        HorarioDocenteConsultaController horario = new HorarioDocenteConsultaController();

        private void ConModHorarioDocente_Load(object sender, EventArgs e)
        {
            try
            {
                Obtener();
                ObtenerCombos();
                txtCiclo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "BUSCAR POR NOMBRE DOCENTE")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "BUSCAR POR NOMBRE DOCENTE";
                txtBuscar.ForeColor = Color.FromArgb(113, 113, 113);
            }
        }
        private void Consultar(string s)
        {
            try
            {
                if (!txtBuscar.Text.Equals(""))
                {
                    TablaHorarioDocenteCon.DataSource = horario.Consulta(txtBuscar.Text);
                    TablaHorarioDocenteCon.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                else
                {
                    Obtener();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("SIN CONEXION A DATOS: " + a.Message);
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Consultar(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void Obtener()
        {
            try
            {
                TablaHorarioDocenteCon.DataSource = horario.obtenerHorariosDocentes();
                TablaHorarioDocenteCon.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TablaHorarioDocenteCon.ClearSelection();
            }
            catch (Exception a)
            {
                MessageBox.Show("SIN CONEXION A DATOS: " + a.Message);
            }
        }

        private void ObtenerCombos()
        {
            try
            {
                ComboDocente.DataSource = horario.comboDocente();
                ComboDocente.ValueMember = "Id_Docente";
                ComboDocente.DisplayMember = "Nombre_Docente";

                ComboMateria.DataSource = horario.comboMateria();
                ComboMateria.ValueMember = "Id_Materia";
                ComboMateria.DisplayMember = "Nombre_Materia";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void habilitar()
        {
            ComboMateria.Enabled = true;
            txtCiclo.Enabled = true;
            ComboDia.Enabled = true;
            ComboInicio.Enabled = true;
            ComboFin.Enabled = true;
        }

        private void inhabilitar()
        {
            ComboMateria.Enabled = false;
            txtCiclo.Enabled = false;
            ComboDia.Enabled = false;
            ComboInicio.Enabled = false;
            ComboFin.Enabled = false;
        }

        private void ComboInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceInicio = ComboInicio.SelectedIndex;
            horainicio = ComboInicio.Items[indiceInicio].ToString();
            ComboFin.Text = ComboFin.Items[indiceInicio].ToString();
        }

        private void ComboFin_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = ComboFin.SelectedIndex;
            indiceFin = indice;
            horafin = ComboFin.Items[indice].ToString();
            if (indiceFin < indiceInicio)
            {
                ComboFin.Text = ComboFin.Items[indiceInicio].ToString();
                MessageBox.Show("ELEGIR HORA POSTERIOR A LA DE INICIO");
            }
        }

        private void ComboDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceDia = ComboDia.SelectedIndex;
            dia = ComboDia.Items[indiceDia].ToString();
        }

        private void ComboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceMateria = ComboMateria.SelectedIndex;
            materia = ComboMateria.Items[indiceMateria].ToString();
        }

        private void ComboDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceDocente = ComboDocente.SelectedIndex;
            docente = ComboDocente.Items[indiceDocente].ToString();
        }
    }
}
