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
    public partial class CrearHorarioDocente : Form
    {
        public CrearHorarioDocente()
        {
            InitializeComponent();
        }

        HorarioDocenteCrearController horario = new HorarioDocenteCrearController();
        bool flag=false;
        string horainicio;
        string horafin;
        string dia;
        string docente;
        string materia;
        int indiceFin;
        int indiceInicio;
        int indiceDia;
        int click = 0;

        public void Horas()
        {
            try
            {
                TablaHorarioDocenteADD.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                for (int i = 7; i < 23; i++)
                {
                    TablaHorarioDocenteADD.Rows.Add(i + ":00");
                }
                TablaHorarioDocenteADD.AllowUserToAddRows = false;
            }
            catch (Exception a)
            {
                MessageBox.Show("Sin conexión a datos");
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

        private void CrearHorarioDocente_Load(object sender, EventArgs e)
        {
            try
            {
                Horas();
                ObtenerCombos();
                txtCiclo.Focus();
                TablaHorarioDocenteADD.ClearSelection();
                ValidacionRegistros();
            }
            catch(Exception ex) { MessageBox.Show("ERROR: "+ ex.Message); }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ComboDia.Text.Equals("") &&
            !ComboInicio.Text.Equals("") &&
            !ComboFin.Text.Equals(""))
            {
                CompararAdicion();
                if (flag == true)
                {
                    click = click + 1;
                    Datos();
                }
            }
            else { MessageBox.Show("AGREGUE DIA Y HORAS"); }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (click != 0)
                {
                    if (!txtCiclo.Text.Equals(""))
                    {
                        foreach(DataGridViewRow row in dtDatos.Rows)
                        {
                            int idmateria = int.Parse(row.Cells["idmateria"].Value.ToString());
                            int iddocente = int.Parse(row.Cells["iddocente"].Value.ToString());
                            string ciclo = txtCiclo.Text;
                            string dias = row.Cells["dias"].Value.ToString();
                            string inicio = row.Cells["inicio"].Value.ToString();
                            string final = row.Cells["final"].Value.ToString();

                            horario.añadir(idmateria, iddocente, ciclo, dias, inicio, final);
                        }
                    }
                    else { MessageBox.Show("AGREGUE EL CICLO"); }
                }
                else
                {
                    MessageBox.Show("HORARIO VACIO");
                }
            }
            catch(Exception ex)
            { MessageBox.Show("ERROR: " + ex.Message); }
        }

        private void CompararAdicion()
        {
            try
            {
                string horainiciotabla;
                string diatabla;
                int indexhorainiciotabla;
                int indexdiatabla;
                string m = ComboMateria.Text;
                string d = ComboDocente.Text;
                string mostrar = m + Environment.NewLine + d;

                foreach (DataGridViewRow fila in TablaHorarioDocenteADD.Rows)
                {
                    horainiciotabla = fila.Cells["Hora"].Value.ToString();
                    if (horainicio.Equals(horainiciotabla))
                    {
                        indexhorainiciotabla = fila.Index;
                        foreach (DataGridViewColumn columna in TablaHorarioDocenteADD.Columns)
                        {
                            diatabla = columna.HeaderText.ToString();
                            if (dia.Equals(diatabla))
                            {
                                indexdiatabla = columna.Index;
                                var vacio = TablaHorarioDocenteADD.Rows[indexhorainiciotabla].Cells[indexdiatabla].Value;
                                if (vacio == null)
                                {
                                    TablaHorarioDocenteADD.Rows[indexhorainiciotabla].Cells[indexdiatabla].Value = mostrar;
                                    flag = true;
                                    if (indiceInicio != indiceFin)
                                    {
                                        int r = indiceFin - indiceInicio;
                                        for (int i = 1; i <= r; i++)
                                        {
                                            TablaHorarioDocenteADD.Rows[indexhorainiciotabla + i].Cells[indexdiatabla].Value = mostrar;
                                        }
                                    }
                                }
                                else { MessageBox.Show("DIA Y HORA OCUPADO"); }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void ValidacionRegistros()
        {
            if (ComboDocente.Text.Equals(""))
            {
                MessageBox.Show("REGISTRE DOCENTES");
                btnAgregar.Enabled = false;
                btnGuardar.Enabled = false;
            }
            else if (ComboMateria.Text.Equals(""))
            {
                MessageBox.Show("REGISTRE MATERIAS");
                btnAgregar.Enabled = false;
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
                btnAgregar.Enabled = true;
            }
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

        private void ComboDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceDocente = ComboDocente.SelectedIndex;
            docente = ComboDocente.Items[indiceDocente].ToString();
        }

        private void ComboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceMateria = ComboMateria.SelectedIndex;
            materia = ComboMateria.Items[indiceMateria].ToString();
        }

        private void Datos()
        {
            dtDatos.Rows.Add((int)ComboMateria.SelectedValue, (int)ComboDocente.SelectedValue,
                dia, horainicio, horafin);
        }
    }
}
