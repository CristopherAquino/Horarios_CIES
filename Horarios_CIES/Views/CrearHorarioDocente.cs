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
    }
}
