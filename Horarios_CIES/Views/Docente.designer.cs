
namespace Horarios_CIES.Views
{
    partial class Docente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefonoCelular = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new AltoControls.AltoButton();
            this.btnModificar = new AltoControls.AltoButton();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.btnAgregar = new AltoControls.AltoButton();
            this.txtTelefonoOficina = new System.Windows.Forms.TextBox();
            this.txtTelefonoCasa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TablaDocente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDocente)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label3.Location = new System.Drawing.Point(504, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "TELEFONO OFICINA";
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
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "TELEFONO CELULAR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTelefonoCelular
            // 
            this.txtTelefonoCelular.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTelefonoCelular.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.txtTelefonoCelular.Location = new System.Drawing.Point(94, 142);
            this.txtTelefonoCelular.MaxLength = 20;
            this.txtTelefonoCelular.Name = "txtTelefonoCelular";
            this.txtTelefonoCelular.Size = new System.Drawing.Size(245, 25);
            this.txtTelefonoCelular.TabIndex = 2;
            this.txtTelefonoCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoCelular_KeyPress);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.txtBuscar.Location = new System.Drawing.Point(94, 259);
            this.txtBuscar.MaxLength = 2;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(404, 29);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.Text = "BUSCAR POR NOMBRE DE DOCENTE";
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
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
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "NOMBRE DEL DOCENTE";
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
            this.btnEliminar.Location = new System.Drawing.Point(598, 580);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Radius = 5;
            this.btnEliminar.Size = new System.Drawing.Size(88, 30);
            this.btnEliminar.Stroke = false;
            this.btnEliminar.StrokeColor = System.Drawing.Color.Gray;
            this.btnEliminar.TabIndex = 10;
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
            this.btnModificar.Location = new System.Drawing.Point(504, 580);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Radius = 5;
            this.btnModificar.Size = new System.Drawing.Size(88, 30);
            this.btnModificar.Stroke = false;
            this.btnModificar.StrokeColor = System.Drawing.Color.Gray;
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.Transparency = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombreDocente.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.txtNombreDocente.Location = new System.Drawing.Point(94, 79);
            this.txtNombreDocente.MaxLength = 100;
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(245, 25);
            this.txtNombreDocente.TabIndex = 1;
            this.txtNombreDocente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreDocente_KeyPress);
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
            this.btnAgregar.Location = new System.Drawing.Point(410, 580);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Radius = 5;
            this.btnAgregar.Size = new System.Drawing.Size(88, 30);
            this.btnAgregar.Stroke = false;
            this.btnAgregar.StrokeColor = System.Drawing.Color.Gray;
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.Transparency = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTelefonoOficina
            // 
            this.txtTelefonoOficina.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTelefonoOficina.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.txtTelefonoOficina.Location = new System.Drawing.Point(508, 79);
            this.txtTelefonoOficina.MaxLength = 20;
            this.txtTelefonoOficina.Name = "txtTelefonoOficina";
            this.txtTelefonoOficina.Size = new System.Drawing.Size(245, 25);
            this.txtTelefonoOficina.TabIndex = 4;
            this.txtTelefonoOficina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoOficina_KeyPress);
            // 
            // txtTelefonoCasa
            // 
            this.txtTelefonoCasa.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTelefonoCasa.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.txtTelefonoCasa.Location = new System.Drawing.Point(94, 205);
            this.txtTelefonoCasa.MaxLength = 20;
            this.txtTelefonoCasa.Name = "txtTelefonoCasa";
            this.txtTelefonoCasa.Size = new System.Drawing.Size(245, 25);
            this.txtTelefonoCasa.TabIndex = 3;
            this.txtTelefonoCasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoCasa_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label4.Location = new System.Drawing.Point(504, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 21);
            this.label4.TabIndex = 44;
            this.label4.Text = "CORREO ELECTRONICO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCorreo.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.txtCorreo.Location = new System.Drawing.Point(508, 142);
            this.txtCorreo.MaxLength = 100;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(245, 25);
            this.txtCorreo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label5.Location = new System.Drawing.Point(94, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "TELEFONO CASA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TablaDocente
            // 
            this.TablaDocente.AllowUserToAddRows = false;
            this.TablaDocente.AllowUserToDeleteRows = false;
            this.TablaDocente.AllowUserToResizeColumns = false;
            this.TablaDocente.AllowUserToResizeRows = false;
            this.TablaDocente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaDocente.BackgroundColor = System.Drawing.Color.White;
            this.TablaDocente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaDocente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaDocente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaDocente.DefaultCellStyle = dataGridViewCellStyle2;
            this.TablaDocente.EnableHeadersVisualStyles = false;
            this.TablaDocente.GridColor = System.Drawing.Color.Navy;
            this.TablaDocente.Location = new System.Drawing.Point(94, 294);
            this.TablaDocente.MultiSelect = false;
            this.TablaDocente.Name = "TablaDocente";
            this.TablaDocente.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaDocente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaDocente.RowHeadersVisible = false;
            this.TablaDocente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TablaDocente.RowTemplate.Height = 25;
            this.TablaDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaDocente.Size = new System.Drawing.Size(824, 265);
            this.TablaDocente.TabIndex = 8;
            this.TablaDocente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDocentes_CellClick);
            // 
            // Docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 621);
            this.Controls.Add(this.TablaDocente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefonoCasa);
            this.Controls.Add(this.txtTelefonoOficina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelefonoCelular);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtNombreDocente);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Docente";
            this.Text = "Docente";
            this.Load += new System.EventHandler(this.Docente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaDocente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefonoCelular;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private AltoControls.AltoButton btnEliminar;
        private AltoControls.AltoButton btnModificar;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private AltoControls.AltoButton btnAgregar;
        private System.Windows.Forms.TextBox txtTelefonoOficina;
        private System.Windows.Forms.TextBox txtTelefonoCasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView TablaDocente;
    }
}