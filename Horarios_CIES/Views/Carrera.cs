using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Horarios_CIES.Controllers;

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
                TablaCarreras.DataSource = carrera.obtenerCarreras();
                TablaCarreras.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception a)
            {
                MessageBox.Show("Sin conexión a datos: "+a.Message);
            }
        }
    }
}
