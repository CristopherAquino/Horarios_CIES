
namespace Horarios_CIES.Views
{
    partial class Grupo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ComboCarrera = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuatrimestre = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new AltoControls.AltoButton();
            this.btnModificar = new AltoControls.AltoButton();
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new AltoControls.AltoButton();
            this.TablaGrupos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TablaGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboCarrera
            // 
            this.ComboCarrera.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ComboCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCarrera.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboCarrera.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.ComboCarrera.FormattingEnabled = true;
            this.ComboCarrera.Location = new System.Drawing.Point(504, 79);
            this.ComboCarrera.Name = "ComboCarrera";
            this.ComboCarrera.Size = new System.Drawing.Size(245, 25);
            this.ComboCarrera.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label3.Location = new System.Drawing.Point(504, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "CARRERA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label2.Location = new System.Drawing.Point(94, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "CUATRIMESTRE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCuatrimestre
            // 
            this.txtCuatrimestre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCuatrimestre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuatrimestre.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.txtCuatrimestre.Location = new System.Drawing.Point(94, 142);
            this.txtCuatrimestre.MaxLength = 60;
            this.txtCuatrimestre.Name = "txtCuatrimestre";
            this.txtCuatrimestre.Size = new System.Drawing.Size(245, 25);
            this.txtCuatrimestre.TabIndex = 27;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.txtBuscar.Location = new System.Drawing.Point(94, 214);
            this.txtBuscar.MaxLength = 60;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(404, 29);
            this.txtBuscar.TabIndex = 26;
            this.txtBuscar.Text = "BUSCAR POR NOMBRE DE GRUPO";
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(94, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "NOMBRE DEL GRUPO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnEliminar.Location = new System.Drawing.Point(598, 560);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Radius = 5;
            this.btnEliminar.Size = new System.Drawing.Size(88, 30);
            this.btnEliminar.Stroke = false;
            this.btnEliminar.StrokeColor = System.Drawing.Color.Gray;
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.Transparency = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(504, 560);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Radius = 5;
            this.btnModificar.Size = new System.Drawing.Size(88, 30);
            this.btnModificar.Stroke = false;
            this.btnModificar.StrokeColor = System.Drawing.Color.Gray;
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.Transparency = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombreGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreGrupo.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.txtNombreGrupo.Location = new System.Drawing.Point(94, 79);
            this.txtNombreGrupo.MaxLength = 60;
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.Size = new System.Drawing.Size(245, 25);
            this.txtNombreGrupo.TabIndex = 21;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(179)))), ((int)(((byte)(244)))));
            this.btnAgregar.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(179)))), ((int)(((byte)(244)))));
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(179)))), ((int)(((byte)(180)))));
            this.btnAgregar.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(179)))), ((int)(((byte)(180)))));
            this.btnAgregar.Location = new System.Drawing.Point(410, 560);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Radius = 5;
            this.btnAgregar.Size = new System.Drawing.Size(88, 30);
            this.btnAgregar.Stroke = false;
            this.btnAgregar.StrokeColor = System.Drawing.Color.Gray;
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.Transparency = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // TablaGrupos
            // 
            this.TablaGrupos.AllowUserToAddRows = false;
            this.TablaGrupos.AllowUserToDeleteRows = false;
            this.TablaGrupos.AllowUserToResizeColumns = false;
            this.TablaGrupos.AllowUserToResizeRows = false;
            this.TablaGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaGrupos.BackgroundColor = System.Drawing.Color.White;
            this.TablaGrupos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaGrupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Nirmala UI", 11F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.TablaGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Nirmala UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaGrupos.DefaultCellStyle = dataGridViewCellStyle8;
            this.TablaGrupos.EnableHeadersVisualStyles = false;
            this.TablaGrupos.GridColor = System.Drawing.Color.Navy;
            this.TablaGrupos.Location = new System.Drawing.Point(94, 249);
            this.TablaGrupos.MultiSelect = false;
            this.TablaGrupos.Name = "TablaGrupos";
            this.TablaGrupos.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Nirmala UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaGrupos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.TablaGrupos.RowHeadersVisible = false;
            this.TablaGrupos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TablaGrupos.RowTemplate.Height = 25;
            this.TablaGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaGrupos.Size = new System.Drawing.Size(824, 265);
            this.TablaGrupos.TabIndex = 31;
            this.TablaGrupos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaGrupos_CellClick);
            // 
            // Grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 621);
            this.Controls.Add(this.TablaGrupos);
            this.Controls.Add(this.ComboCarrera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCuatrimestre);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtNombreGrupo);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grupo";
            this.Text = "Grupo";
            this.Load += new System.EventHandler(this.Grupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboCarrera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCuatrimestre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private AltoControls.AltoButton btnEliminar;
        private AltoControls.AltoButton btnModificar;
        private System.Windows.Forms.TextBox txtNombreGrupo;
        private AltoControls.AltoButton btnAgregar;
        private System.Windows.Forms.DataGridView TablaGrupos;
    }
}