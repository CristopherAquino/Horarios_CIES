﻿
namespace Horarios_CIES.Views
{
    partial class ConModHorarioGrupo
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new AltoControls.AltoButton();
            this.btnModificar = new AltoControls.AltoButton();
            this.TablaHorarioGrupoCon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TablaHorarioGrupoCon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtBuscar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.txtBuscar.Location = new System.Drawing.Point(94, 79);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(404, 29);
            this.txtBuscar.TabIndex = 42;
            this.txtBuscar.Text = "Buscar Por Horario De Grupo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Active1 = System.Drawing.Color.OrangeRed;
            this.btnEliminar.Active2 = System.Drawing.Color.OrangeRed;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEliminar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Inactive1 = System.Drawing.Color.Red;
            this.btnEliminar.Inactive2 = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(598, 560);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Radius = 5;
            this.btnEliminar.Size = new System.Drawing.Size(88, 30);
            this.btnEliminar.Stroke = false;
            this.btnEliminar.StrokeColor = System.Drawing.Color.Gray;
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Transparency = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Active1 = System.Drawing.Color.Yellow;
            this.btnModificar.Active2 = System.Drawing.Color.Yellow;
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnModificar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Inactive1 = System.Drawing.Color.Gold;
            this.btnModificar.Inactive2 = System.Drawing.Color.Gold;
            this.btnModificar.Location = new System.Drawing.Point(504, 560);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Radius = 5;
            this.btnModificar.Size = new System.Drawing.Size(88, 30);
            this.btnModificar.Stroke = false;
            this.btnModificar.StrokeColor = System.Drawing.Color.Gray;
            this.btnModificar.TabIndex = 40;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Transparency = false;
            // 
            // TablaHorarioGrupoCon
            // 
            this.TablaHorarioGrupoCon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaHorarioGrupoCon.BackgroundColor = System.Drawing.Color.White;
            this.TablaHorarioGrupoCon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TablaHorarioGrupoCon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaHorarioGrupoCon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.TablaHorarioGrupoCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaHorarioGrupoCon.DefaultCellStyle = dataGridViewCellStyle8;
            this.TablaHorarioGrupoCon.EnableHeadersVisualStyles = false;
            this.TablaHorarioGrupoCon.GridColor = System.Drawing.Color.Navy;
            this.TablaHorarioGrupoCon.Location = new System.Drawing.Point(94, 148);
            this.TablaHorarioGrupoCon.MultiSelect = false;
            this.TablaHorarioGrupoCon.Name = "TablaHorarioGrupoCon";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaHorarioGrupoCon.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.TablaHorarioGrupoCon.RowHeadersVisible = false;
            this.TablaHorarioGrupoCon.RowTemplate.Height = 25;
            this.TablaHorarioGrupoCon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaHorarioGrupoCon.Size = new System.Drawing.Size(824, 350);
            this.TablaHorarioGrupoCon.TabIndex = 39;
            // 
            // ConModHorarioGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 621);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.TablaHorarioGrupoCon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConModHorarioGrupo";
            this.Text = "ConModHorarioGrupo";
            ((System.ComponentModel.ISupportInitialize)(this.TablaHorarioGrupoCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private AltoControls.AltoButton btnEliminar;
        private AltoControls.AltoButton btnModificar;
        private System.Windows.Forms.DataGridView TablaHorarioGrupoCon;
    }
}