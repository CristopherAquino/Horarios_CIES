﻿using System;
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
            try
            {
                TablaHorarioDocenteCon.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception a)
            {
                MessageBox.Show("Sin conexión a datos");
            }
        }
    }
}