using Horarios_CIES.Controllers;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Horarios_CIES.Views
{
    public partial class ConModHorarioDocente : Form
    {
        public ConModHorarioDocente()
        {
            InitializeComponent();
        }
        bool flag = false;
        int numerohorario;
        int? idhorario;
        int indiceInicio;
        string horainicio;
        int indiceFin;
        string horafin;
        int indiceDia;
        string dia;
        int indiceMateria;
        string materia;
        int indiceDocente;
        string docente;
        HorarioDocenteConsultaController horario = new HorarioDocenteConsultaController();

        private void ConModHorarioDocente_Load(object sender, EventArgs e)
        {
            try
            {
                Obtener();
                Horas();
                iniciodatos();
                TablaHorarioDocenteCon.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void limpiartabla()
        {
            TablaHorarioDocenteADD.Rows.Clear();
            TablaPrueba.Rows.Clear();
            Horas();
        }

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

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "BUSCAR POR NOMBRE DOCENTE")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "BUSCAR POR NOMBRE DOCENTE";
                txtBuscar.ForeColor = Color.FromArgb(113, 113, 113);
            }
        }
        
        private void Consultar(string s)
        {
            try
            {
                if (!txtBuscar.Text.Equals(""))
                {
                    TablaHorarioDocenteCon.DataSource = horario.Consulta(txtBuscar.Text);
                    TablaHorarioDocenteCon.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

        private void Obtener()
        {
            try
            {
                TablaHorarioDocenteCon.DataSource = horario.obtenerHorariosDocentes();
                TablaHorarioDocenteCon.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception a)
            {
                MessageBox.Show("ERROR: " + a.Message);
            }
        }

        private void iniciodatos()
        {
            ComboDia.Text = "LUNES";
            ComboInicio.Text = "7:00";
            ComboFin.Text = "8:00";
            ObtenerCombos();
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

        private void ComboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceMateria = ComboMateria.SelectedIndex;
            materia = ComboMateria.Items[indiceMateria].ToString();
        }

        private void ComboDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceDocente = ComboDocente.SelectedIndex;
            docente = ComboDocente.Items[indiceDocente].ToString();
        }

        private void TablaHorarioDocenteCon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idhorario = int.Parse(TablaHorarioDocenteCon.CurrentRow.Cells[0].Value.ToString());
                numerohorario = int.Parse(TablaHorarioDocenteCon.CurrentRow.Cells[1].Value.ToString());
                ComboCiclo.Text = TablaHorarioDocenteCon.CurrentRow.Cells[2].Value.ToString();
                ComboDocente.Text = TablaHorarioDocenteCon.CurrentRow.Cells[3].Value.ToString();
                ComboMateria.Text = TablaHorarioDocenteCon.CurrentRow.Cells[4].Value.ToString();
                ComboDia.Text = TablaHorarioDocenteCon.CurrentRow.Cells[5].Value.ToString();
                ComboInicio.Text = TablaHorarioDocenteCon.CurrentRow.Cells[6].Value.ToString();
                ComboFin.Text = TablaHorarioDocenteCon.CurrentRow.Cells[7].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR: " + x.Message);
            }
        }

        private void CompararAdicion(int indexInicio, int indexFin, string materia, string diametodo, string inicio, string fin)
        {
            try
            {
                string horainiciotabla;
                string diatabla;
                int indexhorainiciotabla;
                int indexdiatabla;
                int indexhorafintabla;
                string horafintabla;
                string m = materia;
                string d = ComboDocente.Text;
                string mostrar = m + Environment.NewLine + d;

                foreach (DataGridViewRow fila in TablaHorarioDocenteADD.Rows)
                {
                    horainiciotabla = fila.Cells["Hora"].Value.ToString();
                    if (inicio.Equals(horainiciotabla))
                    {
                        indexhorainiciotabla = fila.Index;
                        foreach (DataGridViewColumn columna in TablaHorarioDocenteADD.Columns)
                        {
                            diatabla = columna.HeaderText.ToString();
                            if (diametodo.Equals(diatabla))
                            {
                                indexdiatabla = columna.Index;
                                foreach (DataGridViewRow finde in TablaHorarioDocenteADD.Rows)
                                {
                                    horafintabla = finde.Cells["Hora"].Value.ToString();
                                    if (fin.Equals(horafintabla))
                                    {
                                        indexhorafintabla = finde.Index;
                                        if (indexInicio != indexFin)
                                        {
                                            var celda1 = TablaHorarioDocenteADD.Rows[indexhorainiciotabla].Cells[indexdiatabla].Value;
                                            if (celda1 == null)
                                            {
                                                var celda2 = TablaHorarioDocenteADD.Rows[indexhorafintabla-1].Cells[indexdiatabla].Value;
                                                if (celda2 == null)
                                                {
                                                    int r = indexFin - indexInicio;
                                                    for (int i = 0; i <= r; i++)
                                                    {
                                                        TablaHorarioDocenteADD.Rows[indexhorainiciotabla + i].Cells[indexdiatabla].Value = mostrar;
                                                    }
                                                    flag = true;
                                                }
                                                else { MessageBox.Show("CHOQUE DE HORARIO"+Environment.NewLine+"VERIFIQUE REGISTROS"); flag = false; }
                                            }
                                            else { MessageBox.Show("CHOQUE DE HORARIO" + Environment.NewLine + "VERIFIQUE REGISTROS"); flag = false; }
                                        }
                                        else if (indexInicio == indexFin)
                                        {
                                            var vacio = TablaHorarioDocenteADD.Rows[indexhorainiciotabla].Cells[indexdiatabla].Value;
                                            if (vacio == null)
                                            {
                                                TablaHorarioDocenteADD.Rows[indexhorainiciotabla].Cells[indexdiatabla].Value = mostrar;
                                                flag = true;
                                            }
                                            else { MessageBox.Show("CHOQUE DE MATERIAS" + Environment.NewLine + "VERIFIQUE REGISTROS"); flag = false; }
                                        }
                                        else { MessageBox.Show("CHOQUE DE MATERIAS" + Environment.NewLine + "VERIFIQUE REGISTROS"); flag = false; }
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idhorario != null)
                {
                    TablaPrueba.DataSource = horario.obtenermenos((int)idhorario, numerohorario);

                    string diametodo;
                    string iniciometodo;
                    string finmetodo;
                    bool valida=true;

                    foreach (DataGridViewRow fila in TablaPrueba.Rows)
                    {
                        int compainicio = indiceInicio;
                        int compafin = indiceFin;
                        diametodo = fila.Cells[2].Value.ToString();
                        iniciometodo = fila.Cells[3].Value.ToString();
                        finmetodo = fila.Cells[4].Value.ToString();
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
                        horario.Modificar((int)idhorario, (int)ComboMateria.SelectedValue,
                            ComboDia.Text, ComboInicio.Text, ComboFin.Text);
                        Obtener();
                    }
                        TablaHorarioDocenteCon.ClearSelection();
                }
                else
                {
                    MessageBox.Show("SELECCIONE LA FILA A MODIFICAR");
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
                if (idhorario != null)
                {
                    horario.Eliminar((int)idhorario);
                    Obtener();
                    TablaHorarioDocenteCon.ClearSelection();
                    idhorario = null;
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (idhorario != null)
                {
                    TablaPrueba.DataSource = horario.compararidentificador(numerohorario);

                    foreach (DataGridViewRow fila in TablaPrueba.Rows)
                    {
                        string inicio = fila.Cells[5].Value.ToString();
                        int indexinicio = ComboInicio.FindStringExact(inicio)+1;
                        string fin = fila.Cells[6].Value.ToString();
                        int indexfin = ComboFin.FindStringExact(fin)+1;
                        string diametodo = fila.Cells[4].Value.ToString();
                        string materiametodo = fila.Cells[3].Value.ToString();
                        CompararAdicion(indexinicio, indexfin, materiametodo, 
                            diametodo, inicio, fin);

                            TablaHorarioDocenteADD.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);
                        
                    }
                    if (flag == true)
                    {
                        aPDF();
                    }
                    TablaPrueba.DataSource = null;
                    limpiartabla();
                    idhorario = null;
                }
                else { MessageBox.Show("SELECCIONA UN REGISTRO DEL HORARIO A IMPRIMIR"); limpiartabla(); }
            }
            catch(Exception a) { MessageBox.Show("ERROR: "+ a.Message); }
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
                    doc.Add(new Paragraph("CICLO: " + ComboCiclo.Text));
                    doc.Add(new Paragraph("HORARIO DOCENTE"));
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
