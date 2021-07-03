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
    public partial class ConModHorarioGrupo : Form
    {
        public ConModHorarioGrupo()
        {
            InitializeComponent();
        }

        HorarioGrupoConsultaController horario = new HorarioGrupoConsultaController();
        int? idM;
        int? idD;
        int? idC;
        int? idhorario = 0;
        string nombreciclo;
        string nombregrupo;
        string nombremateriavieja;
        bool flag = false;
        bool vacia = false;
        string nombredocente;
        int indiceInicio;
        string horainicio;
        int indiceFin;
        string horafin;

        private void ConModHorarioGrupo_Load(object sender, EventArgs e)
        {
            Horas();
            Obtener();
            ObtenerCombos();
        }

        private void Obtener()
        {
            try
            {
                TablaHorarioGrupoCon.DataSource = horario.obtenerHorariosGrupos();
                TablaHorarioGrupoCon.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception a)
            {
                MessageBox.Show("ERROR: " + a.Message);
            }
        }

        private void ObtenerCombos()
        {
            try
            {
                ComboGrupo.DataSource = horario.comboGrupo();
                ComboGrupo.ValueMember = "Id_Grupo";
                ComboGrupo.DisplayMember = "Nombre_Grupo";

                ComboCiclo.DataSource = horario.comboCiclo();
                ComboCiclo.ValueMember = "Id_Ciclo";
                ComboCiclo.DisplayMember = "Ciclo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void Horas()
        {
            try
            {
                TablaHorarioGrupoADD.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                for (int i = 7; i < 23; i++)
                {
                    TablaHorarioGrupoADD.Rows.Add(i + ":00");
                    TablaHorarioGrupoADD.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                TablaHorarioGrupoADD.AllowUserToAddRows = false;
            }
            catch (Exception a)
            {
                MessageBox.Show("ERROR: " + a.Message);
            }
        }

        private void limpiartabla()
        {
            TablaHorarioGrupoADD.Rows.Clear();
            TablaPrueba.Rows.Clear();
            Horas();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "BUSCAR POR GRUPO")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "BUSCAR POR GRUPO";
                txtBuscar.ForeColor = Color.FromArgb(113, 113, 113);
            }
        }

        private void ComboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idM = (int?)ComboMateria.SelectedValue;
                TablaMateriaDocente.DataSource = horario.ObtenerTablaMaterias(idC, idM, idD);
                vacia = horario.vacia(idC, idM, idD);

                ComboDocente.DataSource = horario.comboDocente(idM);
                ComboDocente.ValueMember = "Id_Docente";
                ComboDocente.DisplayMember = "Nombre_Docente";
                TablaMateriaDocente.ClearSelection();
            }
            catch (InvalidCastException) { }
        }

        private void ComboDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idD = (int?)ComboDocente.SelectedValue;
                TablaMateriaDocente.DataSource = horario.ObtenerTablaMaterias(idC, idM, idD);
                vacia = horario.vacia(idC, idM, idD);
                TablaMateriaDocente.ClearSelection();
            }
            catch (InvalidCastException) { }
        }

        private void ComboCiclo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idC = (int?)ComboCiclo.SelectedValue;
                TablaMateriaDocente.DataSource = horario.ObtenerTablaMaterias(idC, idM, idD);
                vacia = horario.vacia(idC, idM, idD);

                ComboMateria.DataSource = horario.comboMateria(idC);
                ComboMateria.ValueMember = "Id_Materia";
                ComboMateria.DisplayMember = "Nombre_Materia";
                TablaMateriaDocente.ClearSelection();
            }
            catch (InvalidCastException) { }
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

        private void TablaHorarioGrupoCon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string horariogrupo = TablaHorarioGrupoCon.CurrentRow.Cells[0].Value.ToString();
                idhorario = int.Parse(horariogrupo);
                nombreciclo = TablaHorarioGrupoCon.CurrentRow.Cells[1].Value.ToString();
                ComboCiclo.Text = nombreciclo;
                nombregrupo = TablaHorarioGrupoCon.CurrentRow.Cells[2].Value.ToString();
                ComboGrupo.Text = nombregrupo;
                nombremateriavieja = TablaHorarioGrupoCon.CurrentRow.Cells[3].Value.ToString();
                ComboMateria.Text = nombremateriavieja;
                nombredocente = TablaHorarioGrupoCon.CurrentRow.Cells[4].Value.ToString();
                ComboDocente.Text = nombredocente;
            }
            catch (InvalidCastException a) { }
        }

        private void Consultar(string s)
        {
            try
            {
                if (!txtBuscar.Text.Equals(""))
                {
                    TablaHorarioGrupoCon.DataSource = horario.Consulta(txtBuscar.Text);
                    TablaHorarioGrupoCon.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idhorario != null)
                {
                    int idmateriavieja = ComboMateria.FindStringExact(nombremateriavieja)+1;
                    int idgrupo = ComboGrupo.FindStringExact(nombregrupo);
                    TablaPrueba.DataSource = horario.obtenermenos(idmateriavieja, (int)idhorario);

                    string diametodo;
                    string iniciometodo;
                    string finmetodo;
                    bool valida = true;
                    if (vacia != false) 
                    {
                        foreach (DataGridViewRow fila1 in TablaMateriaDocente.Rows)
                        {
                            string dia = fila1.Cells[0].Value.ToString();
                            string inicio = fila1.Cells[1].Value.ToString();
                            int indexinicio = ComboInicio.FindStringExact(inicio);
                            string fin = fila1.Cells[2].Value.ToString();
                            int indexfin = ComboFin.FindStringExact(fin);

                            foreach (DataGridViewRow fila in TablaPrueba.Rows)
                            {
                                int compainicio = indexinicio;
                                int compafin = indexfin;
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
                                    }
                                    else if ((compafin >= inicioid) && (compafin <= finid))
                                    {
                                        MessageBox.Show("EL FIN DE LA HORA NO ESTA DISPONIBLE");
                                        valida = false;
                                    }
                                    else if ((compainicio >= inicioid) && (compafin <= finid))
                                    {
                                        MessageBox.Show("HORA OCUPADA POR OTRA MATERIA");
                                        valida = false;
                                        break;
                                    }
                                }
                                if (valida == true)
                                {
                                    horario.Modificar((int)idhorario, (int)ComboCiclo.SelectedValue,
                                        (int)ComboGrupo.SelectedValue, idmateriavieja,
                                        (int)ComboMateria.SelectedValue);
                                    Obtener();
                                }
                            }
                            if (valida == false)
                            { break; }
                        }
                    }
                    else { MessageBox.Show("MATERIA O DOCENTE INVALIDO"); }
                    TablaHorarioGrupoCon.ClearSelection();
                    idhorario = null;
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
                    int indice = ComboMateria.FindString(nombremateriavieja);
                    int idmateria = indice +1;
                    horario.Eliminar((int)idhorario, idmateria);
                    Obtener();
                    TablaHorarioGrupoCon.ClearSelection();
                    idhorario = null;
                }
                else
                {
                    MessageBox.Show("SELECCIONE LA MATERIA A ELIMINAR");
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
                    TablaPrueba.DataSource = horario.compararidentificador((int)idhorario);

                    foreach (DataGridViewRow fila in TablaPrueba.Rows)
                    {
                        string materiametodo = fila.Cells[2].Value.ToString();
                        string docentemetodo = fila.Cells[3].Value.ToString();
                        string diametodo = fila.Cells[4].Value.ToString();
                        string inicio = fila.Cells[5].Value.ToString();
                        int indexinicio = ComboInicio.FindStringExact(inicio) + 1;
                        string fin = fila.Cells[6].Value.ToString();
                        int indexfin = ComboFin.FindStringExact(fin) + 1;

                        CompararAdicion(indexinicio, indexfin, materiametodo, docentemetodo,
                            diametodo, inicio, fin);

                        TablaHorarioGrupoADD.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);

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
            catch (Exception a) { MessageBox.Show("ERROR: " + a.Message); }
        }

        private void CompararAdicion(int indexInicio, int indexFin, string materiametodo, string docentemetodo, string diametodo, string inicio, string fin)
        {
            try
            {
                string horainiciotabla;
                string diatabla;
                int indexhorainiciotabla;
                int indexdiatabla;
                int indexhorafintabla;
                string horafintabla;
                string m = materiametodo;
                string d = docentemetodo;
                string mostrar = m + Environment.NewLine + d;

                foreach (DataGridViewRow fila in TablaHorarioGrupoADD.Rows)
                {
                    horainiciotabla = fila.Cells["Hora"].Value.ToString();
                    if (inicio.Equals(horainiciotabla))
                    {
                        indexhorainiciotabla = fila.Index;
                        foreach (DataGridViewColumn columna in TablaHorarioGrupoADD.Columns)
                        {
                            diatabla = columna.HeaderText.ToString();
                            if (diametodo.Equals(diatabla))
                            {
                                indexdiatabla = columna.Index;
                                foreach (DataGridViewRow finde in TablaHorarioGrupoADD.Rows)
                                {
                                    horafintabla = finde.Cells["Hora"].Value.ToString();
                                    if (fin.Equals(horafintabla))
                                    {
                                        indexhorafintabla = finde.Index;
                                        if (indexInicio != indexFin)
                                        {
                                            var celda1 = TablaHorarioGrupoADD.Rows[indexhorainiciotabla].Cells[indexdiatabla].Value;
                                            if (celda1 == null)
                                            {
                                                var celda2 = TablaHorarioGrupoADD.Rows[indexhorafintabla - 1].Cells[indexdiatabla].Value;
                                                if (celda2 == null)
                                                {
                                                    int r = indexFin - indexInicio;
                                                    for (int i = 0; i <= r; i++)
                                                    {
                                                        TablaHorarioGrupoADD.Rows[indexhorainiciotabla + i].Cells[indexdiatabla].Value = mostrar;
                                                    }
                                                    flag = true;
                                                }
                                            }
                                        }
                                        else if (indexInicio == indexFin)
                                        {
                                            var vacio = TablaHorarioGrupoADD.Rows[indexhorainiciotabla].Cells[indexdiatabla].Value;
                                            if (vacio == null)
                                            {
                                                TablaHorarioGrupoADD.Rows[indexhorainiciotabla].Cells[indexdiatabla].Value = mostrar;
                                                flag = true;
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

        private void GenerarDocumento(Document document)
        {
            int i, j;
            PdfPTable datatable = new PdfPTable(TablaHorarioGrupoADD.ColumnCount);
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañoColumnas(TablaHorarioGrupoADD);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < TablaHorarioGrupoADD.ColumnCount; i++)
            {
                datatable.AddCell(TablaHorarioGrupoADD.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            for (i = 0; i < TablaHorarioGrupoADD.Rows.Count; i++)
            {
                for (j = 0; j < TablaHorarioGrupoADD.Columns.Count; j++)
                {
                    datatable.AddCell(new Phrase(Convert.ToString(TablaHorarioGrupoADD[j, i].Value)));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
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
                    doc.Add(new Paragraph("HORARIO GRUPO"));
                    doc.Add(new Paragraph("DOCENTE: " + nombregrupo));

                    PdfPTable tabla = new PdfPTable(TablaHorarioGrupoADD.Columns.Count);
                    tabla.DefaultCell.Padding = 2;
                    tabla.WidthPercentage = 100;
                    tabla.HorizontalAlignment = Element.ALIGN_LEFT;

                    foreach (DataGridViewColumn col in TablaHorarioGrupoADD.Columns)
                    {
                        PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                        tabla.AddCell(pCell);
                    }
                    foreach (DataGridViewRow row in TablaHorarioGrupoADD.Rows)
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
