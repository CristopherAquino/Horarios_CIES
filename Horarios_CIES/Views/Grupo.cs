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
    public partial class Grupo : Form
    {
        public Grupo()
        {
            InitializeComponent();
        }
        GrupoController grupo = new GrupoController();

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "BUSCAR POR NOMBRE DE GRUPO")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "BUSCAR POR NOMBRE DE GRUPO";
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
                    TablaGrupos.DataSource = grupo.Consulta(txtBuscar.Text);
                    TablaGrupos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

        private void Grupo_Load(object sender, EventArgs e)
        {
            try
            {
                Obtener();
                ObtenerCombo();
                txtNombreGrupo.Focus();
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
                TablaGrupos.DataSource = grupo.obtenerGrupos();
                TablaGrupos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TablaGrupos.ClearSelection();
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
                ComboCarrera.DataSource = grupo.combo();
                ComboCarrera.ValueMember = "IdCarrera";
                ComboCarrera.DisplayMember = "Nombre_Carrera";
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: "+ex.Message);
            }
        }

        public int? getid()
        {
            try
            {
                return int.Parse(TablaGrupos.Rows
                    [TablaGrupos.CurrentRow.Index].Cells[0].Value.ToString());
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
                if (!txtNombreGrupo.Text.Equals("") && 
                    !txtCuatrimestre.Text.Equals(""))
                {
                    grupo.añadir(txtNombreGrupo.Text, 
                        txtCuatrimestre.Text,
                        (int)ComboCarrera.SelectedValue);
                    txtNombreGrupo.Clear();
                    txtCuatrimestre.Clear();
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
                if (!txtNombreGrupo.Text.Equals("") &&
                    !txtCuatrimestre.Text.Equals(""))
                {
                    int? id = getid();
                    if (id != null)
                    {
                        grupo.Modificar((int)id, 
                            txtNombreGrupo.Text,
                            txtCuatrimestre.Text,
                            (int)ComboCarrera.SelectedValue);
                        txtNombreGrupo.Clear();
                        txtCuatrimestre.Clear();
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
                if (!txtNombreGrupo.Text.Equals(""))
                {
                    int? id = getid();
                    if (id != null)
                    {
                        grupo.Eliminar((int)id);
                        txtCuatrimestre.Clear();
                        txtNombreGrupo.Clear();
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

        private void TablaGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombreGrupo.Text = TablaGrupos.CurrentRow.Cells[1].Value.ToString();
                txtCuatrimestre.Text = TablaGrupos.CurrentRow.Cells[2].Value.ToString();
                ComboCarrera.Text = TablaGrupos.CurrentRow.Cells[3].Value.ToString();
                
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR: " + x.Message);
            }
        }
    }
}
