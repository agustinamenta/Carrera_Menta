namespace Carreras_Menta
{
    partial class frmNuevoPlan
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoPlan));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnioCurs = new System.Windows.Forms.TextBox();
            this.cboAsign = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtPrimerC = new System.Windows.Forms.RadioButton();
            this.rbtSegundoC = new System.Windows.Forms.RadioButton();
            this.dgvDetalleCar = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(216, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUEVO PLAN DE ESTUDIO";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(172, 476);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(132, 24);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(339, 476);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 24);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Carrera:";
            // 
            // txtNombreC
            // 
            this.txtNombreC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreC.Location = new System.Drawing.Point(259, 70);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(240, 20);
            this.txtNombreC.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(283, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "ASIGNATURA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rubik", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre Asignatura:";
            // 
            // txtAnioCurs
            // 
            this.txtAnioCurs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnioCurs.Location = new System.Drawing.Point(260, 186);
            this.txtAnioCurs.Name = "txtAnioCurs";
            this.txtAnioCurs.Size = new System.Drawing.Size(240, 20);
            this.txtAnioCurs.TabIndex = 7;
            // 
            // cboAsign
            // 
            this.cboAsign.FormattingEnabled = true;
            this.cboAsign.Location = new System.Drawing.Point(260, 142);
            this.cboAsign.Name = "cboAsign";
            this.cboAsign.Size = new System.Drawing.Size(240, 21);
            this.cboAsign.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rubik", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Año de cursado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rubik", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cuatrimestre:";
            // 
            // rbtPrimerC
            // 
            this.rbtPrimerC.AutoSize = true;
            this.rbtPrimerC.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPrimerC.Location = new System.Drawing.Point(239, 232);
            this.rbtPrimerC.Name = "rbtPrimerC";
            this.rbtPrimerC.Size = new System.Drawing.Size(128, 17);
            this.rbtPrimerC.TabIndex = 11;
            this.rbtPrimerC.TabStop = true;
            this.rbtPrimerC.Text = "Primer cuatrimestre";
            this.rbtPrimerC.UseVisualStyleBackColor = true;
            // 
            // rbtSegundoC
            // 
            this.rbtSegundoC.AutoSize = true;
            this.rbtSegundoC.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSegundoC.Location = new System.Drawing.Point(373, 233);
            this.rbtSegundoC.Name = "rbtSegundoC";
            this.rbtSegundoC.Size = new System.Drawing.Size(141, 17);
            this.rbtSegundoC.TabIndex = 12;
            this.rbtSegundoC.TabStop = true;
            this.rbtSegundoC.Text = "Segundo cuatrimestre";
            this.rbtSegundoC.UseVisualStyleBackColor = true;
            // 
            // dgvDetalleCar
            // 
            this.dgvDetalleCar.AllowUserToAddRows = false;
            this.dgvDetalleCar.AllowUserToDeleteRows = false;
            this.dgvDetalleCar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDetalleCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.Anio,
            this.Cuatrimestre,
            this.Acciones});
            this.dgvDetalleCar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDetalleCar.Location = new System.Drawing.Point(54, 307);
            this.dgvDetalleCar.Name = "dgvDetalleCar";
            this.dgvDetalleCar.ReadOnly = true;
            this.dgvDetalleCar.Size = new System.Drawing.Size(544, 153);
            this.dgvDetalleCar.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(260, 265);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 24);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Asignatura";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Anio
            // 
            this.Anio.HeaderText = "Año de cursado";
            this.Anio.Name = "Anio";
            this.Anio.ReadOnly = true;
            // 
            // Cuatrimestre
            // 
            this.Cuatrimestre.HeaderText = "Cuatrimestre";
            this.Cuatrimestre.Name = "Cuatrimestre";
            this.Cuatrimestre.ReadOnly = true;
            // 
            // Acciones
            // 
            this.Acciones.HeaderText = "Acciones";
            this.Acciones.Name = "Acciones";
            this.Acciones.ReadOnly = true;
            // 
            // frmNuevoPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 512);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvDetalleCar);
            this.Controls.Add(this.rbtSegundoC);
            this.Controls.Add(this.rbtPrimerC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboAsign);
            this.Controls.Add(this.txtAnioCurs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevoPlan";
            this.Text = "Agregar nuevo plan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnioCurs;
        private System.Windows.Forms.ComboBox cboAsign;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtPrimerC;
        private System.Windows.Forms.RadioButton rbtSegundoC;
        private System.Windows.Forms.DataGridView dgvDetalleCar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuatrimestre;
        private System.Windows.Forms.DataGridViewButtonColumn Acciones;
    }
}

