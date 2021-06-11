using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Horarios_CIES.Controllers;
using System.Linq;
using System.Data.SqlClient;

namespace Horarios_CIES.Views
{
    public partial class Carrera : Form
    {
        public Carrera()
        {
            InitializeComponent();
        }

        CarreraController carrera = new CarreraController();

        private void Carrera_Load(object sender, EventArgs e)
        {
            try
            {
                Obtener();
                txtNombreCarrera.Focus();
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
                TablaCarreras.DataSource = carrera.obtenerCarreras();
                TablaCarreras.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TablaCarreras.ClearSelection();
            }
            catch (Exception a)
            {
                MessageBox.Show("SIN CONEXION A DATOS: " + a.Message);
            }
        }

        private void Consultar(string s)
        {
            try
            {
                if (!txtBuscar.Text.Equals(""))
                {
                    TablaCarreras.DataSource = carrera.Consulta(txtBuscar.Text);
                    TablaCarreras.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "BUSCAR POR NOMBRE DE CARRERA")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "BUSCAR POR NOMBRE DE CARRERA";
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNombreCarrera.Text.Equals(""))
                {
                    carrera.añadir(txtNombreCarrera.Text);
                    txtNombreCarrera.Clear();
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

        public int? getid()
        {
            try
            {
                return int.Parse(TablaCarreras.Rows
                    [TablaCarreras.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNombreCarrera.Text.Equals(""))
                {
                    int? id = getid();
                    if (id != null)
                    {
                        carrera.Modificar((int)id, txtNombreCarrera.Text);
                        txtNombreCarrera.Clear();
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
                if (!txtNombreCarrera.Text.Equals(""))
                {
                    int? id = getid();
                    if (id != null)
                    {
                        carrera.Eliminar((int)id);
                        txtNombreCarrera.Clear();
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

        private void TablaCarreras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombreCarrera.Text = TablaCarreras.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR", "SELECCIÓN" + x.ToString());
            }
        }
    }
}
