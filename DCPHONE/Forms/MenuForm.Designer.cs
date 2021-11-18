namespace DCPHONE.Forms
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.DtgvMostrarProductos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgg = new System.Windows.Forms.Button();
            this.panelBajo = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvMostrarProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtgvMostrarProductos
            // 
            this.DtgvMostrarProductos.AllowUserToDeleteRows = false;
            this.DtgvMostrarProductos.AllowUserToResizeColumns = false;
            this.DtgvMostrarProductos.AllowUserToResizeRows = false;
            this.DtgvMostrarProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DtgvMostrarProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.DtgvMostrarProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgvMostrarProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgvMostrarProductos.ColumnHeadersHeight = 30;
            this.DtgvMostrarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtgvMostrarProductos.EnableHeadersVisualStyles = false;
            this.DtgvMostrarProductos.GridColor = System.Drawing.Color.SteelBlue;
            this.DtgvMostrarProductos.Location = new System.Drawing.Point(0, 157);
            this.DtgvMostrarProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtgvMostrarProductos.MultiSelect = false;
            this.DtgvMostrarProductos.Name = "DtgvMostrarProductos";
            this.DtgvMostrarProductos.ReadOnly = true;
            this.DtgvMostrarProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgvMostrarProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgvMostrarProductos.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DtgvMostrarProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DtgvMostrarProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgvMostrarProductos.Size = new System.Drawing.Size(1470, 348);
            this.DtgvMostrarProductos.TabIndex = 1;
            this.DtgvMostrarProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtgvMostrarProductos_CellFormatting);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1370, 157);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(6)))), ((int)(((byte)(132)))));
            this.panelBotones.Controls.Add(this.btnRegresar);
            this.panelBotones.Controls.Add(this.btnDelete);
            this.panelBotones.Controls.Add(this.btnModificar);
            this.panelBotones.Controls.Add(this.btnAgg);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBotones.Location = new System.Drawing.Point(1140, 157);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(230, 535);
            this.panelBotones.TabIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Navy;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(0, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(230, 78);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Navy;
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(0, 78);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnModificar.Size = new System.Drawing.Size(230, 78);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgg
            // 
            this.btnAgg.BackColor = System.Drawing.Color.Navy;
            this.btnAgg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgg.FlatAppearance.BorderSize = 0;
            this.btnAgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgg.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgg.Image = ((System.Drawing.Image)(resources.GetObject("btnAgg.Image")));
            this.btnAgg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgg.Location = new System.Drawing.Point(0, 0);
            this.btnAgg.Name = "btnAgg";
            this.btnAgg.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAgg.Size = new System.Drawing.Size(230, 78);
            this.btnAgg.TabIndex = 6;
            this.btnAgg.Text = "Agregar";
            this.btnAgg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgg.UseVisualStyleBackColor = false;
            this.btnAgg.Click += new System.EventHandler(this.btnAgg_Click);
            // 
            // panelBajo
            // 
            this.panelBajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(6)))), ((int)(((byte)(132)))));
            this.panelBajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBajo.Location = new System.Drawing.Point(0, 543);
            this.panelBajo.Name = "panelBajo";
            this.panelBajo.Size = new System.Drawing.Size(1140, 149);
            this.panelBajo.TabIndex = 17;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Navy;
            this.btnRegresar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(0, 234);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRegresar.Size = new System.Drawing.Size(230, 78);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 692);
            this.Controls.Add(this.panelBajo);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DtgvMostrarProductos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuForm";
            this.Text = "MENU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvMostrarProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DtgvMostrarProductos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgg;
        private System.Windows.Forms.Panel panelBajo;
        private System.Windows.Forms.Button btnRegresar;
    }
}