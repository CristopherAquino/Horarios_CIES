
namespace Horarios_CIES.Views
{
    partial class Materia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new AltoControls.AltoButton();
            this.btnModificar = new AltoControls.AltoButton();
            this.txtCodigoMateria = new System.Windows.Forms.TextBox();
            this.btnAgregar = new AltoControls.AltoButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboGrupo = new System.Windows.Forms.ComboBox();
            this.TablaMaterias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.txtBuscar.Location = new System.Drawing.Point(94, 214);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(404, 29);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.Text = "BUSCAR POR NOMBRE DE MATERIA";
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
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "CODIGO DE MATERIA";
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
            this.btnEliminar.TabIndex = 12;
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
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.Transparency = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtCodigoMateria
            // 
            this.txtCodigoMateria.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCodigoMateria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoMateria.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.txtCodigoMateria.Location = new System.Drawing.Point(94, 79);
            this.txtCodigoMateria.MaxLength = 30;
            this.txtCodigoMateria.Name = "txtCodigoMateria";
            this.txtCodigoMateria.Size = new System.Drawing.Size(245, 25);
            this.txtCodigoMateria.TabIndex = 9;
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
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.Transparency = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label2.Location = new System.Drawing.Point(94, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "NOMBRE DE LA MATERIA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombreMateria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreMateria.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.txtNombreMateria.Location = new System.Drawing.Point(94, 142);
            this.txtNombreMateria.MaxLength = 50;
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(245, 25);
            this.txtNombreMateria.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label3.Location = new System.Drawing.Point(504, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "GRUPO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboGrupo
            // 
            this.ComboGrupo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ComboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboGrupo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboGrupo.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.ComboGrupo.FormattingEnabled = true;
            this.ComboGrupo.Location = new System.Drawing.Point(504, 79);
            this.ComboGrupo.Name = "ComboGrupo";
            this.ComboGrupo.Size = new System.Drawing.Size(245, 25);
            this.ComboGrupo.TabIndex = 19;
            // 
            // TablaMaterias
            // 
            this.TablaMaterias.AllowUserToAddRows = false;
            this.TablaMaterias.AllowUserToDeleteRows = false;
            this.TablaMaterias.AllowUserToResizeColumns = false;
            this.TablaMaterias.AllowUserToResizeRows = false;
            this.TablaMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaMaterias.BackgroundColor = System.Drawing.Color.White;
            this.TablaMaterias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaMaterias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaMaterias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaMaterias.DefaultCellStyle = dataGridViewCellStyle2;
            this.TablaMaterias.EnableHeadersVisualStyles = false;
            this.TablaMaterias.GridColor = System.Drawing.Color.Navy;
            this.TablaMaterias.Location = new System.Drawing.Point(94, 249);
            this.TablaMaterias.MultiSelect = false;
            this.TablaMaterias.Name = "TablaMaterias";
            this.TablaMaterias.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaMaterias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaMaterias.RowHeadersVisible = false;
            this.TablaMaterias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TablaMaterias.RowTemplate.Height = 25;
            this.TablaMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaMaterias.Size = new System.Drawing.Size(824, 265);
            this.TablaMaterias.TabIndex = 32;
            this.TablaMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaMaterias_CellClick);
            // 
            // Materia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 621);
            this.Controls.Add(this.TablaMaterias);
            this.Controls.Add(this.ComboGrupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreMateria);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtCodigoMateria);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Materia";
            this.Text = "Materia";
            this.Load += new System.EventHandler(this.Materia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private AltoControls.AltoButton btnEliminar;
        private AltoControls.AltoButton btnModificar;
        private System.Windows.Forms.TextBox txtCodigoMateria;
        private AltoControls.AltoButton btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboGrupo;
        private System.Windows.Forms.DataGridView TablaMaterias;
    }
}