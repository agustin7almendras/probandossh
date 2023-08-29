namespace practica_planilla_de_pagos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtempleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxempleado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpfechaingreso = new System.Windows.Forms.DateTimePicker();
            this.lblfechaactual = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmesconsultado = new System.Windows.Forms.TextBox();
            this.txtañosdeservicio = new System.Windows.Forms.TextBox();
            this.btnprocesar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblcomision = new System.Windows.Forms.Label();
            this.lblgratificacion = new System.Windows.Forms.Label();
            this.lblsueldobasico = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblcooperativa = new System.Windows.Forms.Label();
            this.lblafp = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblsegurosocial = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbltotalingresos = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lbltotaldescuentos = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lbltotalaportaciones = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lbltotalneto = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAñosServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotalNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLANILLA DE PAGOS DE EMPLEADOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "INFORMACION GENERAL DEL EMPLEADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Empleado";
            // 
            // txtempleado
            // 
            this.txtempleado.Location = new System.Drawing.Point(28, 109);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.Size = new System.Drawing.Size(125, 27);
            this.txtempleado.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cargo";
            // 
            // cbxempleado
            // 
            this.cbxempleado.FormattingEnabled = true;
            this.cbxempleado.Items.AddRange(new object[] {
            "Coordinador",
            "Jefe",
            "Capacitador",
            "Asistente"});
            this.cbxempleado.Location = new System.Drawing.Point(28, 162);
            this.cbxempleado.Name = "cbxempleado";
            this.cbxempleado.Size = new System.Drawing.Size(151, 28);
            this.cbxempleado.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(860, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha de consulta";
            // 
            // dtpfechaingreso
            // 
            this.dtpfechaingreso.Location = new System.Drawing.Point(589, 109);
            this.dtpfechaingreso.Name = "dtpfechaingreso";
            this.dtpfechaingreso.Size = new System.Drawing.Size(250, 27);
            this.dtpfechaingreso.TabIndex = 8;
            this.dtpfechaingreso.ValueChanged += new System.EventHandler(this.dtpfechaingreso_ValueChanged);
            // 
            // lblfechaactual
            // 
            this.lblfechaactual.AutoSize = true;
            this.lblfechaactual.Location = new System.Drawing.Point(860, 116);
            this.lblfechaactual.Name = "lblfechaactual";
            this.lblfechaactual.Size = new System.Drawing.Size(12, 20);
            this.lblfechaactual.TabIndex = 9;
            this.lblfechaactual.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(589, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mes consultado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(860, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Años de servicio";
            // 
            // txtmesconsultado
            // 
            this.txtmesconsultado.Enabled = false;
            this.txtmesconsultado.Location = new System.Drawing.Point(589, 177);
            this.txtmesconsultado.Name = "txtmesconsultado";
            this.txtmesconsultado.Size = new System.Drawing.Size(125, 27);
            this.txtmesconsultado.TabIndex = 12;
            // 
            // txtañosdeservicio
            // 
            this.txtañosdeservicio.Enabled = false;
            this.txtañosdeservicio.Location = new System.Drawing.Point(860, 177);
            this.txtañosdeservicio.Name = "txtañosdeservicio";
            this.txtañosdeservicio.Size = new System.Drawing.Size(125, 27);
            this.txtañosdeservicio.TabIndex = 13;
            // 
            // btnprocesar
            // 
            this.btnprocesar.Location = new System.Drawing.Point(28, 210);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(94, 29);
            this.btnprocesar.TabIndex = 14;
            this.btnprocesar.Text = "PROCESAR";
            this.btnprocesar.UseVisualStyleBackColor = true;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblcomision);
            this.groupBox1.Controls.Add(this.lblgratificacion);
            this.groupBox1.Controls.Add(this.lblsueldobasico);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(28, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESOS";
            // 
            // lblcomision
            // 
            this.lblcomision.AutoSize = true;
            this.lblcomision.Location = new System.Drawing.Point(130, 102);
            this.lblcomision.Name = "lblcomision";
            this.lblcomision.Size = new System.Drawing.Size(12, 20);
            this.lblcomision.TabIndex = 22;
            this.lblcomision.Text = ".";
            // 
            // lblgratificacion
            // 
            this.lblgratificacion.AutoSize = true;
            this.lblgratificacion.Location = new System.Drawing.Point(127, 67);
            this.lblgratificacion.Name = "lblgratificacion";
            this.lblgratificacion.Size = new System.Drawing.Size(12, 20);
            this.lblgratificacion.TabIndex = 21;
            this.lblgratificacion.Text = ".";
            // 
            // lblsueldobasico
            // 
            this.lblsueldobasico.AutoSize = true;
            this.lblsueldobasico.Location = new System.Drawing.Point(127, 35);
            this.lblsueldobasico.Name = "lblsueldobasico";
            this.lblsueldobasico.Size = new System.Drawing.Size(12, 20);
            this.lblsueldobasico.TabIndex = 20;
            this.lblsueldobasico.Text = ".";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Comision";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Gratificacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Sueldo basico";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblcooperativa);
            this.groupBox2.Controls.Add(this.lblafp);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(327, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 125);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DESCUENTOS";
            // 
            // lblcooperativa
            // 
            this.lblcooperativa.AutoSize = true;
            this.lblcooperativa.Location = new System.Drawing.Point(104, 67);
            this.lblcooperativa.Name = "lblcooperativa";
            this.lblcooperativa.Size = new System.Drawing.Size(12, 20);
            this.lblcooperativa.TabIndex = 21;
            this.lblcooperativa.Text = ".";
            // 
            // lblafp
            // 
            this.lblafp.AutoSize = true;
            this.lblafp.Location = new System.Drawing.Point(104, 35);
            this.lblafp.Name = "lblafp";
            this.lblafp.Size = new System.Drawing.Size(12, 20);
            this.lblafp.TabIndex = 20;
            this.lblafp.Text = ".";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 20);
            this.label17.TabIndex = 19;
            this.label17.Text = "Cooperativa";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 20);
            this.label16.TabIndex = 18;
            this.label16.Text = "AFP";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblsegurosocial);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Location = new System.Drawing.Point(605, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 125);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "APORTACIONES";
            // 
            // lblsegurosocial
            // 
            this.lblsegurosocial.AutoSize = true;
            this.lblsegurosocial.Location = new System.Drawing.Point(134, 35);
            this.lblsegurosocial.Name = "lblsegurosocial";
            this.lblsegurosocial.Size = new System.Drawing.Size(12, 20);
            this.lblsegurosocial.TabIndex = 19;
            this.lblsegurosocial.Text = ".";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 20);
            this.label20.TabIndex = 18;
            this.label20.Text = "Seguro social";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(28, 387);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(123, 20);
            this.label22.TabIndex = 18;
            this.label22.Text = "TOTAL INGRESOS";
            // 
            // lbltotalingresos
            // 
            this.lbltotalingresos.AutoSize = true;
            this.lbltotalingresos.Location = new System.Drawing.Point(174, 387);
            this.lbltotalingresos.Name = "lbltotalingresos";
            this.lbltotalingresos.Size = new System.Drawing.Size(12, 20);
            this.lbltotalingresos.TabIndex = 19;
            this.lbltotalingresos.Text = ".";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(327, 387);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(145, 20);
            this.label24.TabIndex = 20;
            this.label24.Text = "TOTAL DESCUENTOS";
            // 
            // lbltotaldescuentos
            // 
            this.lbltotaldescuentos.AutoSize = true;
            this.lbltotaldescuentos.Location = new System.Drawing.Point(494, 387);
            this.lbltotaldescuentos.Name = "lbltotaldescuentos";
            this.lbltotaldescuentos.Size = new System.Drawing.Size(12, 20);
            this.lbltotaldescuentos.TabIndex = 21;
            this.lbltotaldescuentos.Text = ".";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(624, 387);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(132, 20);
            this.label26.TabIndex = 22;
            this.label26.Text = "Total aportaciones";
            // 
            // lbltotalaportaciones
            // 
            this.lbltotalaportaciones.AutoSize = true;
            this.lbltotalaportaciones.Location = new System.Drawing.Point(781, 387);
            this.lbltotalaportaciones.Name = "lbltotalaportaciones";
            this.lbltotalaportaciones.Size = new System.Drawing.Size(12, 20);
            this.lbltotalaportaciones.TabIndex = 23;
            this.lbltotalaportaciones.Text = ".";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(624, 432);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(91, 20);
            this.label28.TabIndex = 24;
            this.label28.Text = "TOTAL NETO";
            // 
            // lbltotalneto
            // 
            this.lbltotalneto.AutoSize = true;
            this.lbltotalneto.Location = new System.Drawing.Point(736, 432);
            this.lbltotalneto.Name = "lbltotalneto";
            this.lbltotalneto.Size = new System.Drawing.Size(12, 20);
            this.lbltotalneto.TabIndex = 25;
            this.lbltotalneto.Text = ".";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(28, 432);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(94, 29);
            this.btnsalir.TabIndex = 26;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(142, 432);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(94, 29);
            this.btncancelar.TabIndex = 27;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 6;
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 125;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNombre,
            this.cCargo,
            this.cAñosServicio,
            this.cTotalNeto});
            this.dgvEmpleados.Location = new System.Drawing.Point(28, 525);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 29;
            this.dgvEmpleados.Size = new System.Drawing.Size(885, 188);
            this.dgvEmpleados.TabIndex = 28;
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.MinimumWidth = 6;
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Width = 125;
            // 
            // cCargo
            // 
            this.cCargo.HeaderText = "Cargo";
            this.cCargo.MinimumWidth = 6;
            this.cCargo.Name = "cCargo";
            this.cCargo.ReadOnly = true;
            this.cCargo.Width = 125;
            // 
            // cAñosServicio
            // 
            this.cAñosServicio.HeaderText = "Años de Servicio";
            this.cAñosServicio.MinimumWidth = 6;
            this.cAñosServicio.Name = "cAñosServicio";
            this.cAñosServicio.ReadOnly = true;
            this.cAñosServicio.Width = 125;
            // 
            // cTotalNeto
            // 
            this.cTotalNeto.HeaderText = "Total Neto";
            this.cTotalNeto.MinimumWidth = 6;
            this.cTotalNeto.Name = "cTotalNeto";
            this.cTotalNeto.ReadOnly = true;
            this.cTotalNeto.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 744);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lbltotalneto);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.lbltotalaportaciones);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lbltotaldescuentos);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.lbltotalingresos);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnprocesar);
            this.Controls.Add(this.txtañosdeservicio);
            this.Controls.Add(this.txtmesconsultado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblfechaactual);
            this.Controls.Add(this.dtpfechaingreso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxempleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtempleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "l";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtempleado;
        private Label label4;
        private ComboBox cbxempleado;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpfechaingreso;
        private Label lblfechaactual;
        private Label label8;
        private Label label9;
        private TextBox txtmesconsultado;
        private TextBox txtañosdeservicio;
        private Button btnprocesar;
        private GroupBox groupBox1;
        private Label lblcomision;
        private Label lblgratificacion;
        private Label lblsueldobasico;
        private Label label12;
        private Label label11;
        private Label label10;
        private GroupBox groupBox2;
        private Label lblcooperativa;
        private Label lblafp;
        private Label label17;
        private Label label16;
        private GroupBox groupBox3;
        private Label lblsegurosocial;
        private Label label20;
        private Label label22;
        private Label lbltotalingresos;
        private Label label24;
        private Label lbltotaldescuentos;
        private Label label26;
        private Label lbltotalaportaciones;
        private Label label28;
        private Label lbltotalneto;
        private Button btnsalir;
        private Button btncancelar;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridView dgvEmpleados;
        private DataGridViewTextBoxColumn cNombre;
        private DataGridViewTextBoxColumn cCargo;
        private DataGridViewTextBoxColumn cAñosServicio;
        private DataGridViewTextBoxColumn cTotalNeto;
    }
}