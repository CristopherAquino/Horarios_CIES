﻿
namespace Horarios_CIES.Views
{
    partial class Carrera
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
            this.btnAgregar = new AltoControls.AltoButton();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.TablaCarreras = new System.Windows.Forms.DataGridView();
            this.btnModificar = new AltoControls.AltoButton();
            this.btnEliminar = new AltoControls.AltoButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCarreras)).BeginInit();
            this.SuspendLayout();
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
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.Transparency = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombreCarrera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreCarrera.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.txtNombreCarrera.Location = new System.Drawing.Point(94, 81);
            this.txtNombreCarrera.MaxLength = 60;
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Size = new System.Drawing.Size(245, 25);
            this.txtNombreCarrera.TabIndex = 1;
            // 
            // TablaCarreras
            // 
            this.TablaCarreras.AllowUserToAddRows = false;
            this.TablaCarreras.AllowUserToDeleteRows = false;
            this.TablaCarreras.AllowUserToResizeColumns = false;
            this.TablaCarreras.AllowUserToResizeRows = false;
            this.TablaCarreras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaCarreras.BackgroundColor = System.Drawing.Color.White;
            this.TablaCarreras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaCarreras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaCarreras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaCarreras.DefaultCellStyle = dataGridViewCellStyle2;
            this.TablaCarreras.EnableHeadersVisualStyles = false;
            this.TablaCarreras.GridColor = System.Drawing.Color.Navy;
            this.TablaCarreras.Location = new System.Drawing.Point(94, 253);
            this.TablaCarreras.MultiSelect = false;
            this.TablaCarreras.Name = "TablaCarreras";
            this.TablaCarreras.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaCarreras.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaCarreras.RowHeadersVisible = false;
            this.TablaCarreras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TablaCarreras.RowTemplate.Height = 25;
            this.TablaCarreras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaCarreras.Size = new System.Drawing.Size(824, 265);
            this.TablaCarreras.TabIndex = 3;
            this.TablaCarreras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaCarreras_CellClick);
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
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.Transparency = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.Transparency = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(94, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "NOMBRE DE CARRERA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.txtBuscar.Location = new System.Drawing.Point(94, 218);
            this.txtBuscar.MaxLength = 60;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(404, 29);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.Text = "BUSCAR POR NOMBRE DE CARRERA";
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 621);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.TablaCarreras);
            this.Controls.Add(this.txtNombreCarrera);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Carrera";
            this.Text = "Carrera";
            this.Load += new System.EventHandler(this.Carrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaCarreras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AltoControls.AltoButton btnAgregar;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.DataGridView TablaCarreras;
        private AltoControls.AltoButton btnModificar;
        private AltoControls.AltoButton btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}