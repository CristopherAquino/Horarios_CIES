﻿using Horarios_CIES.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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
        public static int c = 0;
        public string filename = "";
        int indiceFin;
        int indiceDocente;
        int indiceMateria;
        int indiceInicio;
        int indiceDia;
        int click = 0;
        int id=0;
        int unico = 0;

        private void Horas()
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
                MessageBox.Show("ERROR: " + a.Message);
            }
        }

        private void identifica()
        {
            int c = horario.identificador();
            if(c != 0)
            {
                id = c + 1;
            }
            else { id = 1; }
        }

        private void existe()
        {
            int c = horario.identificador();
            int iddocente = (int)ComboDocente.SelectedValue;
            int idciclo = (int)ComboCiclo.SelectedValue;
            if (c != 0)
            {
                bool a = horario.valida(iddocente, idciclo);
                if (a == true)
                {
                    unico = 1;
                }
                else { unico = 0; }
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

                ComboCiclo.DataSource = horario.comboCiclo();
                ComboCiclo.ValueMember = "Id_Ciclo";
                ComboCiclo.DisplayMember = "Ciclo";
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
                identifica();
                Horas();
                iniciodatos();
                ValidacionRegistros();
                TablaHorarioDocenteADD.ClearSelection();
            }
           catch(Exception ex) { MessageBox.Show("ERROR: "+ ex.Message); }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (click == 0)
                {
                    CompararAdicion();
                    TablaHorarioDocenteADD.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);
                    click = click + 1;
                    ComboDocente.Enabled = false;
                    ComboCiclo.Enabled = false;
                }
                else if (click != 0)
                {
                    string diametodo;
                    string iniciometodo;
                    string finmetodo;
                    bool valida = true;

                    foreach (DataGridViewRow fila in dtDatos.Rows)
                    {
                        int compainicio = indiceInicio;
                        int compafin = indiceFin;
                        diametodo = fila.Cells[3].Value.ToString();
                        iniciometodo = fila.Cells[4].Value.ToString();
                        finmetodo = fila.Cells[5].Value.ToString();
                        int inicioid = ComboInicio.FindString(iniciometodo);
                        int finid = ComboFin.FindString(finmetodo);

                        if (dia.Equals(diametodo))
                        {
                            if ((compainicio >= inicioid) && (compainicio <= finid))
                            {
                                MessageBox.Show("LA HORA DE INICIO NO ESTA DISPONIBLE");
                                valida = false;
                                break;
                            }
                            else if ((compafin >= inicioid) && (compafin <= finid))
                            {
                                MessageBox.Show("EL FIN DE LA HORA NO ESTA DISPONIBLE");
                                valida = false;
                                break;
                            }
                            else if ((inicioid >= compainicio) && (finid <= compafin))
                            {
                                MessageBox.Show("HORA OCUPADA POR OTRA MATERIA");
                                valida = false;
                                break;
                            }
                        }
                    }
                    if(valida == true)
                    {
                        CompararAdicion();
                        TablaHorarioDocenteADD.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);
                    }
                }
            }
            catch (Exception a) { MessageBox.Show("ERROR: " + a.Message); }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (click != 0)
                {
                    existe();
                    identifica();
                    if (unico == 0)
                    {
                        foreach (DataGridViewRow row in dtDatos.Rows)
                        {
                            int idmateria = int.Parse(row.Cells["idmateria"].Value.ToString());
                            int iddocente = int.Parse(row.Cells["iddocente"].Value.ToString());
                            int ciclo = int.Parse(row.Cells["idciclo"].Value.ToString());
                            string dias = row.Cells["dias"].Value.ToString();
                            string inicio = row.Cells["inicio"].Value.ToString();
                            string final = row.Cells["final"].Value.ToString();

                            horario.añadir(idmateria, iddocente, ciclo, dias, inicio, final, id);
                        }
                        aPDF();
                        Fin();
                    }
                    else { MessageBox.Show("EL DOCENTE YA TIENE HORARIO ESTABLECIDO EN ESTE MISMO CICLO"); }
                }
                else { MessageBox.Show("HORARIO VACIO"); }
            }
            catch (Exception ex)
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
                int indexhorafintabla;
                string horafintabla;
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
                                foreach (DataGridViewRow finde in TablaHorarioDocenteADD.Rows)
                                {
                                    horafintabla = finde.Cells["Hora"].Value.ToString();
                                    if (horafin.Equals(horafintabla))
                                    {
                                        indexhorafintabla = finde.Index;
                                        if (indiceInicio != indiceFin)
                                        {
                                            var celda1 = TablaHorarioDocenteADD.Rows[indexhorainiciotabla].Cells[indexdiatabla].Value;
                                            if (celda1 == null)
                                            {
                                                var celda2 = TablaHorarioDocenteADD.Rows[indexhorafintabla].Cells[indexdiatabla].Value;
                                                if (celda2 == null)
                                                {
                                                    int r = indiceFin - indiceInicio;
                                                    for (int i = 0; i <= r; i++)
                                                    {
                                                        TablaHorarioDocenteADD.Rows[indexhorainiciotabla + i].Cells[indexdiatabla].Value = mostrar;
                                                    }
                                                    Datos();
                                                    flag = true;
                                                }
                                            }
                                        }
                                        else if (indiceInicio == indiceFin)
                                        {
                                            var vacio = TablaHorarioDocenteADD.Rows[indexhorainiciotabla].Cells[indexdiatabla].Value;
                                            if (vacio == null)
                                            {
                                                TablaHorarioDocenteADD.Rows[indexhorainiciotabla].Cells[indexdiatabla].Value = mostrar;
                                                flag = true;
                                                Datos();
                                            }
                                        }
                                    }
                                }
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
            else if (ComboCiclo.Text.Equals(""))
            {
                MessageBox.Show("REGISTRE CICLOS ESCOLARES");
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
            indiceDocente = ComboDocente.SelectedIndex;
            docente = ComboDocente.Items[indiceDocente].ToString();
        }

        private void ComboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceMateria = ComboMateria.SelectedIndex;
            materia = ComboMateria.Items[indiceMateria].ToString();
        }

        private void Datos()
        {
            dtDatos.Rows.Add((int)ComboMateria.SelectedValue, (int)ComboDocente.SelectedValue,
                (int)ComboCiclo.SelectedValue, dia, horainicio, horafin);
        }

        private void Fin()
        {
            limpiartabla();
            iniciodatos();
            identifica();
        }

        private void iniciodatos()
        {
            ComboDia.Text = "LUNES";
            ComboInicio.Text = "7:00";
            ComboFin.Text = "8:00";
            ObtenerCombos();
        }

        private void limpiartabla()
        {
            TablaHorarioDocenteADD.Rows.Clear();
            dtDatos.Rows.Clear();
            Horas();
            click = 0;
            ComboDocente.Enabled = true;
            ComboCiclo.Enabled = true;
        }

        private void GenerarDocumento(Document document)
        {
            int i, j;
            PdfPTable datatable = new PdfPTable(TablaHorarioDocenteADD.ColumnCount);
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañoColumnas(TablaHorarioDocenteADD);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < TablaHorarioDocenteADD.ColumnCount; i++)
            {
                datatable.AddCell(TablaHorarioDocenteADD.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            for (i = 0; i < TablaHorarioDocenteADD.Rows.Count; i++)
            {
                for (j = 0; j < TablaHorarioDocenteADD.Columns.Count; j++)
                {
                        datatable.AddCell(new Phrase(Convert.ToString(TablaHorarioDocenteADD[j, i].Value)));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }

        private float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            limpiartabla();
        }

        private void aPDF()
        {
            try
            {
                Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
                SaveFileDialog save = new SaveFileDialog();
                save.InitialDirectory = @"C:";
                save.Title = "Guardar Horario";
                save.DefaultExt = "pdf";
                save.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
                save.FilterIndex = 2;
                save.RestoreDirectory = true;
                string filename = "";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    filename = save.FileName;
                }

                if (filename.Trim() != "")
                {
                    FileStream file = new FileStream(filename,
                    FileMode.OpenOrCreate,
                    FileAccess.ReadWrite,
                    FileShare.ReadWrite);
                    PdfWriter.GetInstance(doc, file);
                    doc.Open();

                    var fontcolour = new BaseColor(0, 122, 204);

                    doc.Add(new Paragraph("UNIVERSIDAD CIES", FontFactory.GetFont("ARIAL", 24, iTextSharp.text.Font.BOLD, fontcolour)));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Paragraph("HORARIO DOCENTE"));
                    doc.Add(new Paragraph("CICLO: "+ComboCiclo.Text));
                    doc.Add(new Paragraph("DOCENTE: " + ComboDocente.Text));

                    PdfPTable tabla = new PdfPTable(TablaHorarioDocenteADD.Columns.Count);
                    tabla.DefaultCell.Padding = 2;
                    tabla.WidthPercentage = 100;
                    tabla.HorizontalAlignment = Element.ALIGN_LEFT;

                    foreach (DataGridViewColumn col in TablaHorarioDocenteADD.Columns)
                    {
                        PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                        tabla.AddCell(pCell);
                    }
                    foreach (DataGridViewRow row in TablaHorarioDocenteADD.Rows)
                    {
                        foreach (DataGridViewCell dcell in row.Cells)
                        {
                            tabla.AddCell(Convert.ToString(dcell.Value));
                        }
                    }
                    doc.Add(Chunk.NEWLINE);
                    GenerarDocumento(doc);
                    doc.Close();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Error al Exportar PDF: " + s.Message);
            }
        }
    }
}