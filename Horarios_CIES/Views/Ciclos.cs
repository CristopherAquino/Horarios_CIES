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
    public partial class Ciclos : Form
    {
        public Ciclos()
        {
            InitializeComponent();
        }

        CicloController ciclos = new CicloController();

        private void Carrera_Load(object sender, EventArgs e)
        {
            try
            {
                Obtener();
                txtCiclo.Focus();
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
                TablaCiclos.DataSource = ciclos.obtenerCiclos();
                TablaCiclos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TablaCiclos.ClearSelection();
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
                    TablaCiclos.DataSource = ciclos.Consulta(txtBuscar.Text);
                    TablaCiclos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            if (txtBuscar.Text == "BUSCAR POR CICLO")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "BUSCAR POR CICLO";
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
                if (!txtCiclo.Text.Equals(""))
                {
                    ciclos.añadir(txtCiclo.Text);
                    txtCiclo.Clear();
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
                return int.Parse(TablaCiclos.Rows
                    [TablaCiclos.CurrentRow.Index].Cells[0].Value.ToString());
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
                if (!txtCiclo.Text.Equals(""))
                {
                    int? id = getid();
                    if (id != null)
                    {
                        ciclos.Modificar((int)id, txtCiclo.Text);
                        txtCiclo.Clear();
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
                if (!txtCiclo.Text.Equals(""))
                {
                    int? id = getid();
                    if (id != null)
                    {
                        ciclos.Eliminar((int)id);
                        txtCiclo.Clear();
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
                txtCiclo.Text = TablaCiclos.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR", "SELECCIÓN" + x.ToString());
            }
        }
    }
}
