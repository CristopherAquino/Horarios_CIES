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
    public partial class Materia : Form
    {
        public Materia()
        {
            InitializeComponent();
        }

        MateriaController materia = new MateriaController();
        private void Materia_Load(object sender, EventArgs e)
        {
            try
            {
                Obtener();
                ObtenerCombo();
                txtCodigoMateria.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "BUSCAR POR NOMBRE DE MATERIA")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "BUSCAR POR NOMBRE DE MATERIA";
                txtBuscar.ForeColor = Color.FromArgb(113, 113, 113);
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

        private void Consultar(string s)
        {
            try
            {
                if (!txtBuscar.Text.Equals(""))
                {
                    TablaMaterias.DataSource = materia.Consulta(txtBuscar.Text);
                    TablaMaterias.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

        private void Obtener()
        {
            try
            {
                TablaMaterias.DataSource = materia.obtenerMaterias();
                TablaMaterias.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TablaMaterias.ClearSelection();
            }
            catch (Exception a)
            {
                MessageBox.Show("SIN CONEXION A DATOS: " + a.Message);
            }
        }

        private void ObtenerCombo()
        {
            try
            {
                ComboGrupo.DataSource = materia.combo();
                ComboGrupo.ValueMember = "Id_Grupo";
                ComboGrupo.DisplayMember = "Nombre_Grupo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

        }

        public int? getid()
        {
            try
            {
                return int.Parse(TablaMaterias.Rows
                    [TablaMaterias.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNombreMateria.Text.Equals("") &&
                    !txtCodigoMateria.Text.Equals(""))
                {
                    materia.añadir(txtNombreMateria.Text,
                        txtCodigoMateria.Text,
                        (int)ComboGrupo.SelectedValue);
                    txtNombreMateria.Clear();
                    txtCodigoMateria.Clear();
                    Obtener();
                }
                else
                {
                    MessageBox.Show("CAMPOS VACIOS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNombreMateria.Text.Equals("") &&
                    !txtCodigoMateria.Text.Equals(""))
                {
                    int? id = getid();
                    if (id != null)
                    {
                        materia.Modificar((int)id,
                            txtNombreMateria.Text,
                            txtCodigoMateria.Text,
                            (int)ComboGrupo.SelectedValue);
                        txtNombreMateria.Clear();
                        txtCodigoMateria.Clear();
                        Obtener();
                    }
                    else
                    {
                        MessageBox.Show("SELECCIONE LA FILA A MODIFICAR");
                    }
                }
                else
                {
                    MessageBox.Show("SIN MODIFICACIONES");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNombreMateria.Text.Equals(""))
                {
                    int? id = getid();
                    if (id != null)
                    {
                        materia.Eliminar((int)id);
                        txtCodigoMateria.Clear();
                        txtNombreMateria.Clear();
                        Obtener();
                    }
                    else
                    {
                        MessageBox.Show("SELECCIONE LA FILA A ELIMINAR");
                    }
                }
                else
                {
                    MessageBox.Show("SELECCIONE LA FILA A ELIMINAR");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void TablaMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombreMateria.Text = TablaMaterias.CurrentRow.Cells[2].Value.ToString();
                txtCodigoMateria.Text = TablaMaterias.CurrentRow.Cells[1].Value.ToString();
                ComboGrupo.Text = TablaMaterias.CurrentRow.Cells[3].Value.ToString();

            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR: " + x.Message);
            }
        }
    }
}
