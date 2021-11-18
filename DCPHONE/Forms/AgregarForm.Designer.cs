namespace DCPHONE
{
    partial class AgregarForm
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
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.gpboxDatosprod = new System.Windows.Forms.GroupBox();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpEntradaInv = new System.Windows.Forms.DateTimePicker();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.nudExistencia = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.panelBoton = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpboxDatosprod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).BeginInit();
            this.panelBoton.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Location = new System.Drawing.Point(257, 261);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(241, 21);
            this.cmbUnidadMedida.TabIndex = 0;
            this.cmbUnidadMedida.SelectedIndexChanged += new System.EventHandler(this.cmbModelos_SelectedIndexChanged);
            // 
            // gpboxDatosprod
            // 
            this.gpboxDatosprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.gpboxDatosprod.Controls.Add(this.dtpVencimiento);
            this.gpboxDatosprod.Controls.Add(this.lblVencimiento);
            this.gpboxDatosprod.Controls.Add(this.label6);
            this.gpboxDatosprod.Controls.Add(this.cmbUnidadMedida);
            this.gpboxDatosprod.Controls.Add(this.lblFecha);
            this.gpboxDatosprod.Controls.Add(this.lblDescripción);
            this.gpboxDatosprod.Controls.Add(this.lblPrecio);
            this.gpboxDatosprod.Controls.Add(this.lblCantidad);
            this.gpboxDatosprod.Controls.Add(this.lblNombre);
            this.gpboxDatosprod.Controls.Add(this.dtpEntradaInv);
            this.gpboxDatosprod.Controls.Add(this.nudPrecio);
            this.gpboxDatosprod.Controls.Add(this.nudExistencia);
            this.gpboxDatosprod.Controls.Add(this.txtDescripcion);
            this.gpboxDatosprod.Controls.Add(this.txtnombre);
            this.gpboxDatosprod.Location = new System.Drawing.Point(-2, 2);
            this.gpboxDatosprod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpboxDatosprod.Name = "gpboxDatosprod";
            this.gpboxDatosprod.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpboxDatosprod.Size = new System.Drawing.Size(505, 289);
            this.gpboxDatosprod.TabIndex = 1;
            this.gpboxDatosprod.TabStop = false;
            this.gpboxDatosprod.Text = "Datos de Producto";
            this.gpboxDatosprod.Enter += new System.EventHandler(this.gpboxDatosprod_Enter);
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Location = new System.Drawing.Point(256, 229);
            this.dtpVencimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(241, 20);
            this.dtpVencimiento.TabIndex = 22;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVencimiento.Location = new System.Drawing.Point(4, 225);
            this.lblVencimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(228, 24);
            this.lblVencimiento.TabIndex = 21;
            this.lblVencimiento.Text = "Fecha de Vencimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(4, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Unidad de Medida:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFecha.Location = new System.Drawing.Point(4, 195);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(221, 24);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "Fecha de Adquisición:";
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripción.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDescripción.Location = new System.Drawing.Point(4, 56);
            this.lblDescripción.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(127, 24);
            this.lblDescripción.TabIndex = 19;
            this.lblDescripción.Text = "Descripción:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrecio.Location = new System.Drawing.Point(4, 156);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(201, 24);
            this.lblPrecio.TabIndex = 16;
            this.lblPrecio.Text = "Precio del Producto:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantidad.Location = new System.Drawing.Point(3, 120);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(112, 24);
            this.lblCantidad.TabIndex = 17;
            this.lblCantidad.Text = "Existencia:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(4, 20);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(216, 24);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre del Producto:";
            // 
            // dtpEntradaInv
            // 
            this.dtpEntradaInv.Location = new System.Drawing.Point(256, 195);
            this.dtpEntradaInv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpEntradaInv.Name = "dtpEntradaInv";
            this.dtpEntradaInv.Size = new System.Drawing.Size(241, 20);
            this.dtpEntradaInv.TabIndex = 4;
            // 
            // nudPrecio
            // 
            this.nudPrecio.BackColor = System.Drawing.Color.White;
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(256, 158);
            this.nudPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudPrecio.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(240, 20);
            this.nudPrecio.TabIndex = 3;
            this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudExistencia
            // 
            this.nudExistencia.BackColor = System.Drawing.Color.White;
            this.nudExistencia.Location = new System.Drawing.Point(256, 122);
            this.nudExistencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudExistencia.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudExistencia.Name = "nudExistencia";
            this.nudExistencia.Size = new System.Drawing.Size(240, 20);
            this.nudExistencia.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(256, 53);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(241, 51);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.White;
            this.txtnombre.Location = new System.Drawing.Point(256, 17);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(241, 20);
            this.txtnombre.TabIndex = 0;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            this.btnAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.LightGray;
            this.btnAgregarProducto.Location = new System.Drawing.Point(0, 3);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(145, 32);
            this.btnAgregarProducto.TabIndex = 2;
            this.btnAgregarProducto.Text = "Guardar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // panelBoton
            // 
            this.panelBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            this.panelBoton.Controls.Add(this.btnCancelar);
            this.panelBoton.Controls.Add(this.btnAgregarProducto);
            this.panelBoton.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBoton.Location = new System.Drawing.Point(504, 0);
            this.panelBoton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBoton.Name = "panelBoton";
            this.panelBoton.Size = new System.Drawing.Size(142, 289);
            this.panelBoton.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Location = new System.Drawing.Point(0, 34);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 32);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AgregarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(46)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(646, 289);
            this.Controls.Add(this.panelBoton);
            this.Controls.Add(this.gpboxDatosprod);
            this.Name = "AgregarForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpboxDatosprod.ResumeLayout(false);
            this.gpboxDatosprod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).EndInit();
            this.panelBoton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpboxDatosprod;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Panel panelBoton;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.ComboBox cmbUnidadMedida;
        public System.Windows.Forms.DateTimePicker dtpEntradaInv;
        public System.Windows.Forms.NumericUpDown nudPrecio;
        public System.Windows.Forms.NumericUpDown nudExistencia;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtnombre;
        public System.Windows.Forms.DateTimePicker dtpVencimiento;
    }
}

