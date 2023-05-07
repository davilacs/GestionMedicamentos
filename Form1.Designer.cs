namespace GestionMedicamentos
{
    partial class frmgmedicamentos
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
            this.grpingreso = new System.Windows.Forms.GroupBox();
            this.txtprecioUnitario = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblpreciounit = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.dgvdatos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnordenar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preciounit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpingreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpingreso
            // 
            this.grpingreso.Controls.Add(this.txtprecioUnitario);
            this.grpingreso.Controls.Add(this.txtcantidad);
            this.grpingreso.Controls.Add(this.txtnombre);
            this.grpingreso.Controls.Add(this.txtcodigo);
            this.grpingreso.Controls.Add(this.lblpreciounit);
            this.grpingreso.Controls.Add(this.lblcantidad);
            this.grpingreso.Controls.Add(this.lblnombre);
            this.grpingreso.Controls.Add(this.lblcodigo);
            this.grpingreso.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpingreso.Location = new System.Drawing.Point(20, 24);
            this.grpingreso.Margin = new System.Windows.Forms.Padding(2);
            this.grpingreso.Name = "grpingreso";
            this.grpingreso.Padding = new System.Windows.Forms.Padding(2);
            this.grpingreso.Size = new System.Drawing.Size(487, 185);
            this.grpingreso.TabIndex = 0;
            this.grpingreso.TabStop = false;
            this.grpingreso.Text = "DATOS";
            // 
            // txtprecioUnitario
            // 
            this.txtprecioUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprecioUnitario.Location = new System.Drawing.Point(189, 139);
            this.txtprecioUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.txtprecioUnitario.Multiline = true;
            this.txtprecioUnitario.Name = "txtprecioUnitario";
            this.txtprecioUnitario.Size = new System.Drawing.Size(42, 21);
            this.txtprecioUnitario.TabIndex = 4;
            // 
            // txtcantidad
            // 
            this.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcantidad.Location = new System.Drawing.Point(189, 105);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtcantidad.Multiline = true;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(42, 21);
            this.txtcantidad.TabIndex = 3;
            // 
            // txtnombre
            // 
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre.Location = new System.Drawing.Point(189, 71);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(250, 21);
            this.txtnombre.TabIndex = 2;
            // 
            // txtcodigo
            // 
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigo.Location = new System.Drawing.Point(189, 38);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodigo.Multiline = true;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(62, 21);
            this.txtcodigo.TabIndex = 1;
            // 
            // lblpreciounit
            // 
            this.lblpreciounit.AutoSize = true;
            this.lblpreciounit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreciounit.Location = new System.Drawing.Point(40, 139);
            this.lblpreciounit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpreciounit.Name = "lblpreciounit";
            this.lblpreciounit.Size = new System.Drawing.Size(126, 13);
            this.lblpreciounit.TabIndex = 3;
            this.lblpreciounit.Text = "PRECIO UNITARIO:";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.Location = new System.Drawing.Point(40, 105);
            this.lblcantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(78, 13);
            this.lblcantidad.TabIndex = 2;
            this.lblcantidad.Text = "CANTIDAD:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(40, 71);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(63, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "NOMBRE:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(40, 38);
            this.lblcodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(61, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "CODIGO:";
            // 
            // dgvdatos
            // 
            this.dgvdatos.AllowUserToAddRows = false;
            this.dgvdatos.AllowUserToDeleteRows = false;
            this.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.Preciounit,
            this.Monto});
            this.dgvdatos.Location = new System.Drawing.Point(20, 254);
            this.dgvdatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvdatos.MultiSelect = false;
            this.dgvdatos.Name = "dgvdatos";
            this.dgvdatos.ReadOnly = true;
            this.dgvdatos.RowHeadersVisible = false;
            this.dgvdatos.RowHeadersWidth = 51;
            this.dgvdatos.RowTemplate.Height = 24;
            this.dgvdatos.Size = new System.Drawing.Size(622, 226);
            this.dgvdatos.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "LISTADO";
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::GestionMedicamentos.Properties.Resources.DeleteTableRow;
            this.btneliminar.Location = new System.Drawing.Point(565, 163);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(49, 35);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnordenar
            // 
            this.btnordenar.Image = global::GestionMedicamentos.Properties.Resources.SortDescending;
            this.btnordenar.Location = new System.Drawing.Point(565, 124);
            this.btnordenar.Margin = new System.Windows.Forms.Padding(2);
            this.btnordenar.Name = "btnordenar";
            this.btnordenar.Size = new System.Drawing.Size(49, 35);
            this.btnordenar.TabIndex = 7;
            this.btnordenar.UseVisualStyleBackColor = true;
            this.btnordenar.Click += new System.EventHandler(this.btnordenar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::GestionMedicamentos.Properties.Resources.SearchProperty;
            this.btnbuscar.Location = new System.Drawing.Point(565, 85);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(49, 35);
            this.btnbuscar.TabIndex = 6;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Image = global::GestionMedicamentos.Properties.Resources.Add;
            this.btnagregar.Location = new System.Drawing.Point(565, 46);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(49, 35);
            this.btnagregar.TabIndex = 5;
            this.btnagregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cantidad.Width = 125;
            // 
            // Preciounit
            // 
            this.Preciounit.HeaderText = "Precio Unitario";
            this.Preciounit.MinimumWidth = 6;
            this.Preciounit.Name = "Preciounit";
            this.Preciounit.ReadOnly = true;
            this.Preciounit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Preciounit.Width = 125;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto Invertido";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Monto.Width = 125;
            // 
            // frmgmedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 490);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnordenar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvdatos);
            this.Controls.Add(this.grpingreso);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmgmedicamentos";
            this.Text = "GESTION DE MEDICAMENTOS";
            this.Load += new System.EventHandler(this.frmgmedicamentos_Load);
            this.grpingreso.ResumeLayout(false);
            this.grpingreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpingreso;
        private System.Windows.Forms.Label lblpreciounit;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.DataGridView dgvdatos;
        private System.Windows.Forms.TextBox txtprecioUnitario;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnordenar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preciounit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
    }
}

