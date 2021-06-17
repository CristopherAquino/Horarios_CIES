
namespace Horarios_CIES.Views
{
    partial class ConModHorarioDocente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new AltoControls.AltoButton();
            this.btnModificar = new AltoControls.AltoButton();
            this.TablaHorarioDocenteCon = new System.Windows.Forms.DataGridView();
            this.ComboDia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboFin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboInicio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCiclo = new System.Windows.Forms.TextBox();
            this.ComboDocente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboMateria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaHorarioDocenteCon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.txtBuscar.Location = new System.Drawing.Point(94, 259);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(404, 29);
            this.txtBuscar.TabIndex = 46;
            this.txtBuscar.Text = "BUSCAR POR NOMBRE DOCENTE";
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Active1 = System.Drawing.Color.OrangeRed;
            this.btnEliminar.Active2 = System.Drawing.Color.OrangeRed;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEliminar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Inactive1 = System.Drawing.Color.Red;
            this.btnEliminar.Inactive2 = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(549, 579);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Radius = 5;
            this.btnEliminar.Size = new System.Drawing.Size(88, 30);
            this.btnEliminar.Stroke = false;
            this.btnEliminar.StrokeColor = System.Drawing.Color.Gray;
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.Transparency = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Active1 = System.Drawing.Color.Yellow;
            this.btnModificar.Active2 = System.Drawing.Color.Yellow;
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnModificar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Inactive1 = System.Drawing.Color.Gold;
            this.btnModificar.Inactive2 = System.Drawing.Color.Gold;
            this.btnModificar.Location = new System.Drawing.Point(455, 579);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Radius = 5;
            this.btnModificar.Size = new System.Drawing.Size(88, 30);
            this.btnModificar.Stroke = false;
            this.btnModificar.StrokeColor = System.Drawing.Color.Gray;
            this.btnModificar.TabIndex = 44;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.Transparency = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // TablaHorarioDocenteCon
            // 
            this.TablaHorarioDocenteCon.AllowUserToAddRows = false;
            this.TablaHorarioDocenteCon.AllowUserToDeleteRows = false;
            this.TablaHorarioDocenteCon.AllowUserToResizeColumns = false;
            this.TablaHorarioDocenteCon.AllowUserToResizeRows = false;
            this.TablaHorarioDocenteCon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaHorarioDocenteCon.BackgroundColor = System.Drawing.Color.White;
            this.TablaHorarioDocenteCon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaHorarioDocenteCon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Nirmala UI", 11F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaHorarioDocenteCon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.TablaHorarioDocenteCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Nirmala UI", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaHorarioDocenteCon.DefaultCellStyle = dataGridViewCellStyle11;
            this.TablaHorarioDocenteCon.EnableHeadersVisualStyles = false;
            this.TablaHorarioDocenteCon.GridColor = System.Drawing.Color.Navy;
            this.TablaHorarioDocenteCon.Location = new System.Drawing.Point(94, 294);
            this.TablaHorarioDocenteCon.MultiSelect = false;
            this.TablaHorarioDocenteCon.Name = "TablaHorarioDocenteCon";
            this.TablaHorarioDocenteCon.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Nirmala UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaHorarioDocenteCon.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.TablaHorarioDocenteCon.RowHeadersVisible = false;
            this.TablaHorarioDocenteCon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TablaHorarioDocenteCon.RowTemplate.Height = 25;
            this.TablaHorarioDocenteCon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaHorarioDocenteCon.Size = new System.Drawing.Size(911, 265);
            this.TablaHorarioDocenteCon.TabIndex = 47;
            this.TablaHorarioDocenteCon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaHorarioDocenteCon_CellClick);
            // 
            // ComboDia
            // 
            this.ComboDia.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ComboDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboDia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboDia.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.ComboDia.FormattingEnabled = true;
            this.ComboDia.Items.AddRange(new object[] {
            "LUNES",
            "MARTES",
            "MIERCOLES",
            "JUEVES",
            "VIERNES",
            "SABADO",
            "DOMINGO"});
            this.ComboDia.Location = new System.Drawing.Point(508, 79);
            this.ComboDia.Name = "ComboDia";
            this.ComboDia.Size = new System.Drawing.Size(245, 25);
            this.ComboDia.TabIndex = 65;
            this.ComboDia.SelectedIndexChanged += new System.EventHandler(this.ComboDia_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label6.Location = new System.Drawing.Point(508, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 21);
            this.label6.TabIndex = 64;
            this.label6.Text = "DIA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboFin
            // 
            this.ComboFin.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ComboFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboFin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboFin.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.ComboFin.FormattingEnabled = true;
            this.ComboFin.Items.AddRange(new object[] {
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00"});
            this.ComboFin.Location = new System.Drawing.Point(509, 205);
            this.ComboFin.Name = "ComboFin";
            this.ComboFin.Size = new System.Drawing.Size(245, 25);
            this.ComboFin.TabIndex = 63;
            this.ComboFin.SelectedIndexChanged += new System.EventHandler(this.ComboFin_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label4.Location = new System.Drawing.Point(508, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 62;
            this.label4.Text = "HORA FIN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboInicio
            // 
            this.ComboInicio.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ComboInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboInicio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboInicio.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.ComboInicio.FormattingEnabled = true;
            this.ComboInicio.Items.AddRange(new object[] {
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.ComboInicio.Location = new System.Drawing.Point(508, 142);
            this.ComboInicio.Name = "ComboInicio";
            this.ComboInicio.Size = new System.Drawing.Size(245, 25);
            this.ComboInicio.TabIndex = 61;
            this.ComboInicio.SelectedIndexChanged += new System.EventHandler(this.ComboInicio_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label5.Location = new System.Drawing.Point(508, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 60;
            this.label5.Text = "HORA INICIO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label2.Location = new System.Drawing.Point(94, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 59;
            this.label2.Text = "CICLO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCiclo
            // 
            this.txtCiclo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCiclo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCiclo.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.txtCiclo.Location = new System.Drawing.Point(94, 205);
            this.txtCiclo.MaxLength = 60;
            this.txtCiclo.Name = "txtCiclo";
            this.txtCiclo.Size = new System.Drawing.Size(245, 25);
            this.txtCiclo.TabIndex = 58;
            // 
            // ComboDocente
            // 
            this.ComboDocente.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ComboDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboDocente.Enabled = false;
            this.ComboDocente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboDocente.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.ComboDocente.FormattingEnabled = true;
            this.ComboDocente.Location = new System.Drawing.Point(94, 79);
            this.ComboDocente.Name = "ComboDocente";
            this.ComboDocente.Size = new System.Drawing.Size(245, 25);
            this.ComboDocente.TabIndex = 57;
            this.ComboDocente.SelectedIndexChanged += new System.EventHandler(this.ComboDocente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(94, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 56;
            this.label1.Text = "DOCENTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboMateria
            // 
            this.ComboMateria.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ComboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMateria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboMateria.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.ComboMateria.FormattingEnabled = true;
            this.ComboMateria.Location = new System.Drawing.Point(94, 142);
            this.ComboMateria.Name = "ComboMateria";
            this.ComboMateria.Size = new System.Drawing.Size(245, 25);
            this.ComboMateria.TabIndex = 55;
            this.ComboMateria.SelectedIndexChanged += new System.EventHandler(this.ComboMateria_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label3.Location = new System.Drawing.Point(94, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 54;
            this.label3.Text = "MATERIA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConModHorarioDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 621);
            this.Controls.Add(this.ComboDia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComboFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCiclo);
            this.Controls.Add(this.ComboDocente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboMateria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TablaHorarioDocenteCon);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConModHorarioDocente";
            this.Text = "ConModHorarioDocente";
            this.Load += new System.EventHandler(this.ConModHorarioDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaHorarioDocenteCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private AltoControls.AltoButton btnEliminar;
        private AltoControls.AltoButton btnModificar;
        private System.Windows.Forms.DataGridView TablaHorarioDocenteCon;
        private System.Windows.Forms.ComboBox ComboDia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCiclo;
        private System.Windows.Forms.ComboBox ComboDocente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboMateria;
        private System.Windows.Forms.Label label3;
    }
}