using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Horarios_CIES.Views
{
    public partial class CrearHorarioGrupo : Form
    {
        public CrearHorarioGrupo()
        {
            InitializeComponent();
            try
            {
                TablaHorarioGrupoADD.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                for (int i = 7; i < 23; i++)
                {
                    TablaHorarioGrupoADD.Rows.Add(i + ":00");
                }
                TablaHorarioGrupoADD.AllowUserToAddRows = false;
            }
            catch (Exception a)
            {
                MessageBox.Show("Sin conexión a datos" + a.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }
    }
}
