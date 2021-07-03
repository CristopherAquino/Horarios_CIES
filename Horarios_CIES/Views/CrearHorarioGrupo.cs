using Horarios_CIES.Controllers;
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
    public partial class CrearHorarioGrupo : Form
    {
        public CrearHorarioGrupo()
        {
            InitializeComponent();
        }

        HorarioGrupoCrearController horario = new HorarioGrupoCrearController();
        int click = 0;
        int id = 0;
        int unico = 0;
        int? idC;
        int? idM;
        int? idD;
        string nombreMateria;
        string nombredocente;
        string dia;
        int indiceInicio;
        string horainicio;
        int indiceFin;
        string horafin;
        bool flag = false;
        bool vacia = false;

        private void CrearHorarioGrupo_Load(object sender, EventArgs e)
        {
            try
            {
                identifica();
                Horas();
                ObtenerCombos();
                ValidacionRegistros();
                TablaHorarioGrupoADD.ClearSelection();
                TablaMateriaDocente.ClearSelection();
            }
            catch (Exception ex) { MessageBox.Show("ERROR: " + ex.Message); }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (vacia != false)
                {
                    if (click == 0)
                    {
                        foreach (DataGridViewRow fila in TablaMateriaDocente.Rows)
                        {
                            string inicio = fila.Cells[1].Value.ToString();
                            int indexinicio = ComboInicio.FindStringExact(inicio) + 1;
                            string fin = fila.Cells[2].Value.ToString();
                            int indexfin = ComboFin.FindStringExact(fin) + 1;
                            string diametodo = fila.Cells[0].Value.ToString();
                            CompararAdicion(indexinicio, indexfin, diametodo, inicio, fin);
                            TablaHorarioGrupoADD.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);
                        }
                        click = click + 1;
                        ComboCiclo.Enabled = false;
                        ComboGrupo.Enabled = false;
                    }
                    else if (click != 0)
                    {
                        string diametodoexistente;
                        string iniciometodoexistente;
                        string finmetodoexistente;
                        bool valida = true;

                        foreach (DataGridViewRow fila in TablaPrueba.Rows)
                        {
                            diametodoexistente = fila.Cells[1].Value.ToString();
                            iniciometodoexistente = fila.Cells[2].Value.ToString();
                            finmetodoexistente = fila.Cells[3].Value.ToString();
                            int inicioidexistente = ComboInicio.FindString(iniciometodoexistente);
                            int finidexistente = ComboFin.FindString(finmetodoexistente);

                            foreach (DataGridViewRow fila2 in TablaMateriaDocente.Rows)
                            {
                                string diaagregar = fila2.Cells[0].Value.ToString();
                                string inicioagregar = fila2.Cells[1].Value.ToString();
                                string finagregar = fila2.Cells[2].Value.ToString();
                                int inicioidagregar = ComboInicio.FindString(inicioagregar);
                                int finidagregar = ComboFin.FindString(finagregar);

                                if (diaagregar.Equals(diametodoexistente))
                                {
                                    if ((inicioidagregar >= inicioidexistente) && (inicioidagregar <= finidexistente))
                                    {
                                        MessageBox.Show("LA HORA DE INICIO NO ESTA DISPONIBLE");
                                        valida = false;
                                        break;
                                    }
                                    else if ((finidagregar >= inicioidexistente) && (finidagregar <= inicioidexistente))
                                    {
                                        MessageBox.Show("EL FIN DE LA HORA NO ESTA DISPONIBLE");
                                        valida = false;
                                        break;
                                    }
                                    else if ((inicioidexistente >= inicioidagregar) && (finidexistente <= finidagregar))
                                    {
                                        MessageBox.Show("HORA OCUPADA POR OTRA MATERIA");
                                        valida = false;
                                        break;
                                    }
                                }
                            }
                            if(valida == false)
                            {
                                break;
                            }
                        }
                        if (valida == true)
                        {
                            foreach (DataGridViewRow fila in TablaMateriaDocente.Rows)
                            {
                                string inicio = fila.Cells[1].Value.ToString();
                                int indexinicio = ComboInicio.FindStringExact(inicio) + 1;
                                string fin = fila.Cells[2].Value.ToString();
                                int indexfin = ComboFin.FindStringExact(fin) + 1;
                                string diametodo1 = fila.Cells[0].Value.ToString();
                                CompararAdicion(indexinicio, indexfin, diametodo1, inicio, fin);
                                TablaHorarioGrupoADD.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);
                            }
                        }
                    }
                }
                else { MessageBox.Show("MATERIA/DOCENTE/CICLO SIN HORARIO ESTABLECIDO"); }
            }
            catch (Exception a) { MessageBox.Show("ERROR: " + a.Message); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiartabla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (click != 0)
                {
                    existe();
                    if (unico == 0)
                    {
                        foreach (DataGridViewRow row in dtDatos.Rows)
                        {
                            int idgrupo = int.Parse(row.Cells[0].Value.ToString());
                            int idmateria = int.Parse(row.Cells[1].Value.ToString());
                            int idciclo = int.Parse(row.Cells[2].Value.ToString());

                            horario.añadir(idmateria, idgrupo, idciclo, id);
                        }
                        aPDF();
                        limpiartabla();
                    }
                    else { MessageBox.Show("EL GRUPO YA TIENE HORARIO ESTABLECIDO EN ESTE MISMO CICLO"); }
                }
                else { MessageBox.Show("HORARIO VACIO"); }
            }
            catch (Exception ex)
            { MessageBox.Show("ERROR: " + ex.InnerException.Message); }
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

        private void Horas()
        {
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
                MessageBox.Show("ERROR: " + a.Message);
            }
        }

        private void identifica()
        {
            int c = horario.identificador();
            if (c != 0)
            {
                id = c + 1;
            }
            else { id = 1; }
        }

        private void existe()
        {
            int c = horario.identificador();
            int idgrupo = (int)ComboGrupo.SelectedValue;
            int idCiclo = (int)ComboCiclo.SelectedValue;
            if (c != 0)
            {
                bool a = horario.valida(idgrupo, idCiclo);
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

        private void ValidacionRegistros()
        {
            if (ComboGrupo.Text.Equals(""))
            {
                MessageBox.Show("REGISTRE GRUPOS");
                btnAgregar.Enabled = false;
                btnGuardar.Enabled = false;
            }
            else if (ComboCiclo.Text.Equals(""))
            {
                MessageBox.Show("REGISTRE CICLOS");
                btnAgregar.Enabled = false;
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
                btnAgregar.Enabled = true;
            }
        }

        private void TablaMateriaDocente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dia = TablaMateriaDocente.CurrentRow.Cells[0].Value.ToString();
            horainicio = TablaMateriaDocente.CurrentRow.Cells[1].Value.ToString();
            horafin = TablaMateriaDocente.CurrentRow.Cells[2].Value.ToString();
        }

        private void ComboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idM = (int?)ComboMateria.SelectedValue;
                TablaMateriaDocente.DataSource = horario.ObtenerTablaMaterias(idC, idM, idD);
                vacia = horario.vacia(idC,idM,idD);

                ComboDocente.DataSource = horario.comboDocente(idM);
                ComboDocente.ValueMember = "Id_Docente";
                ComboDocente.DisplayMember = "Nombre_Docente";
                TablaMateriaDocente.ClearSelection();
            }
            catch (InvalidCastException) { }
        }

        private void CompararAdicion(int indexInicio, int indexFin, string diametodo, string inicio, string fin)
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
                                                    Datos();
                                                    flag = true;
                                                }
                                                else { MessageBox.Show("CHOQUE DE HORARIO" + Environment.NewLine + "VERIFIQUE REGISTROS"); flag = false; }
                                            }
                                            else { MessageBox.Show("CHOQUE DE HORARIO" + Environment.NewLine + "VERIFIQUE REGISTROS"); flag = false; }
                                        }
                                        else if (indexInicio == indexFin)
                                        {
                                            var vacio = TablaHorarioGrupoADD.Rows[indexhorainiciotabla].Cells[indexdiatabla].Value;
                                            if (vacio == null)
                                            {
                                                TablaHorarioGrupoADD.Rows[indexhorainiciotabla].Cells[indexdiatabla].Value = mostrar;
                                                flag = true;
                                                Datos();
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
                    doc.Add(new Paragraph("GRUPO: " + ComboGrupo.Text));

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

        private void limpiartabla()
        {
            TablaHorarioGrupoADD.Rows.Clear();
            dtDatos.Rows.Clear();
            TablaPrueba.Rows.Clear();
            Horas();
            click = 0;
            ComboCiclo.Enabled = true;
            ComboGrupo.Enabled = true;
        }

        private void Datos()
        {
            dtDatos.Rows.Add((int)ComboGrupo.SelectedValue, (int)ComboMateria.SelectedValue,
                (int)ComboCiclo.SelectedValue);
            foreach(DataGridViewRow fila in TablaMateriaDocente.Rows)
            {
                string a = fila.Cells[0].Value.ToString();
                string b = fila.Cells[1].Value.ToString();
                string c = fila.Cells[2].Value.ToString();
 
                TablaPrueba.Rows.Add(ComboMateria.Text, a, b, c);
            }
        }

        private void ComboInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceInicio = ComboInicio.SelectedIndex;
            horainicio = ComboInicio.Items[indiceInicio].ToString();
        }

        private void ComboFin_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = ComboFin.SelectedIndex;
            indiceFin = indice;
            horafin = ComboFin.Items[indice].ToString();
        }
    }
}
