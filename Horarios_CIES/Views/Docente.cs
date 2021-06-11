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
    public partial class Docente : Form
    {
        public Docente()
        {
            InitializeComponent();
        }

        DocenteController docente = new DocenteController();
        private void Docente_Load(object sender, EventArgs e)
        {
            try
            {
                Obtener();
                txtNombreDocente.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "BUSCAR POR NOMBRE DE DOCENTE")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "BUSCAR POR NOMBRE DE DOCENTE";
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
                    TablaDocente.DataSource = docente.Consulta(txtBuscar.Text);
                    TablaDocente.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
                TablaDocente.DataSource = docente.obtenerDocentes();
                TablaDocente.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TablaDocente.ClearSelection();
            }
            catch (Exception a)
            {
                MessageBox.Show("SIN CONEXION A DATOS: " + a.Message);
            }
        }

        public int? getid()
        {
            try
            {
                return int.Parse(TablaDocente.Rows
                    [TablaDocente.CurrentRow.Index].Cells[0].Value.ToString());
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
                if (!txtNombreDocente.Text.Equals(""))
                {
                    docente.añadir(txtNombreDocente.Text,
                        txtTelefonoCelular.Text,
                        txtTelefonoCasa.Text,
                        txtTelefonoOficina.Text,
                        txtCorreo.Text);
                    txtNombreDocente.Clear();
                    txtTelefonoCelular.Clear();
                    txtTelefonoCasa.Clear();
                    txtTelefonoOficina.Clear();
                    txtCorreo.Clear();
                    Obtener();
                }
                else
                {
                    MessageBox.Show("INGRESE NOMBRE DEL DOCENTE");
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
                if (!txtNombreDocente.Text.Equals(""))
                {
                    int? id = getid();
                    if (id != null)
                    {
                        docente.Modificar((int)id,
                            txtNombreDocente.Text,
                            txtTelefonoCelular.Text,
                            txtTelefonoCasa.Text,
                            txtTelefonoOficina.Text,
                            txtCorreo.Text);
                        txtNombreDocente.Clear();
                        txtTelefonoCelular.Clear();
                        txtTelefonoCasa.Clear();
                        txtTelefonoOficina.Clear();
                        txtCorreo.Clear();
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
                if (!txtNombreDocente.Text.Equals(""))
                {
                    int? id = getid();
                    if (id != null)
                    {
                        docente.Eliminar((int)id);
                        txtNombreDocente.Clear();
                        txtTelefonoCelular.Clear();
                        txtTelefonoCasa.Clear();
                        txtTelefonoOficina.Clear();
                        txtCorreo.Clear();
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

        private void TablaDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombreDocente.Text = TablaDocente.CurrentRow.Cells[1].Value.ToString();
                txtTelefonoCelular.Text = TablaDocente.CurrentRow.Cells[2].Value.ToString();
                txtTelefonoCasa.Text = TablaDocente.CurrentRow.Cells[3].Value.ToString();
                txtTelefonoOficina.Text = TablaDocente.CurrentRow.Cells[4].Value.ToString();
                txtCorreo.Text = TablaDocente.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR: " + x.Message);
            }
        }

        public static void Numeros(KeyPressEventArgs k)
        {
            if (Char.IsDigit(k.KeyChar))
            {
                k.Handled = false;
            }
            else if (Char.IsSeparator(k.KeyChar))
            {
                k.Handled = false;
            }
            else if (Char.IsControl(k.KeyChar))
            {
                k.Handled = false;
            }
            else
            {
                k.Handled = true;
            }
        }

        public static void Letra(KeyPressEventArgs k)
        {
            if (Char.IsLetter(k.KeyChar))
            {
                k.Handled = false;
            }
            else if (Char.IsSeparator(k.KeyChar))
            {
                k.Handled = false;
            }
            else if (Char.IsControl(k.KeyChar))
            {
                k.Handled = false;
            }
            else
            {
                k.Handled = true;
            }
        }

        private void txtNombreDocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Letra(e);
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Letra(e);
        }

        private void txtTelefonoCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeros(e);
        }

        private void txtTelefonoCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeros(e);
        }

        private void txtTelefonoOficina_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeros(e);
        }
    }
}
