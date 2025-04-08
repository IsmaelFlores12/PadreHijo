namespace PadreHijo
{
    partial class Form1
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
            this.DGdatos = new System.Windows.Forms.DataGridView();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.labelEliminar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txbEliminar = new System.Windows.Forms.TextBox();
            this.LblGenero = new System.Windows.Forms.Label();
            this.txbGenero = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.lBLmODELO = new System.Windows.Forms.Label();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAlmacenamiento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbAño = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGdatos
            // 
            this.DGdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGdatos.Location = new System.Drawing.Point(44, 48);
            this.DGdatos.Name = "DGdatos";
            this.DGdatos.RowHeadersWidth = 51;
            this.DGdatos.RowTemplate.Height = 24;
            this.DGdatos.Size = new System.Drawing.Size(697, 336);
            this.DGdatos.TabIndex = 0;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(333, 390);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 1;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // labelEliminar
            // 
            this.labelEliminar.AutoSize = true;
            this.labelEliminar.Location = new System.Drawing.Point(892, 25);
            this.labelEliminar.Name = "labelEliminar";
            this.labelEliminar.Size = new System.Drawing.Size(141, 16);
            this.labelEliminar.TabIndex = 2;
            this.labelEliminar.Text = "AÑO PARA ELIMINAR";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(888, 76);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(145, 47);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txbEliminar
            // 
            this.txbEliminar.Location = new System.Drawing.Point(910, 48);
            this.txbEliminar.Name = "txbEliminar";
            this.txbEliminar.Size = new System.Drawing.Size(100, 22);
            this.txbEliminar.TabIndex = 4;
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.Location = new System.Drawing.Point(786, 161);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(65, 16);
            this.LblGenero.TabIndex = 5;
            this.LblGenero.Text = "GENERO";
            // 
            // txbGenero
            // 
            this.txbGenero.Location = new System.Drawing.Point(772, 180);
            this.txbGenero.Name = "txbGenero";
            this.txbGenero.Size = new System.Drawing.Size(100, 22);
            this.txbGenero.TabIndex = 6;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(794, 226);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(57, 16);
            this.LblPrecio.TabIndex = 7;
            this.LblPrecio.Text = "PRECIO";
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(772, 255);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(100, 22);
            this.txbPrecio.TabIndex = 8;
            // 
            // lBLmODELO
            // 
            this.lBLmODELO.AutoSize = true;
            this.lBLmODELO.Location = new System.Drawing.Point(794, 295);
            this.lBLmODELO.Name = "lBLmODELO";
            this.lBLmODELO.Size = new System.Drawing.Size(64, 16);
            this.lBLmODELO.TabIndex = 9;
            this.lBLmODELO.Text = "MODELO";
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(772, 326);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(100, 22);
            this.txbModelo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(760, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "ALMACENAMIENTO";
            // 
            // txbAlmacenamiento
            // 
            this.txbAlmacenamiento.Location = new System.Drawing.Point(772, 398);
            this.txbAlmacenamiento.Name = "txbAlmacenamiento";
            this.txbAlmacenamiento.Size = new System.Drawing.Size(100, 22);
            this.txbAlmacenamiento.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(805, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "AÑO";
            // 
            // txbAño
            // 
            this.txbAño.Location = new System.Drawing.Point(772, 468);
            this.txbAño.Name = "txbAño";
            this.txbAño.Size = new System.Drawing.Size(100, 22);
            this.txbAño.TabIndex = 14;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(939, 255);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(117, 48);
            this.BtnAgregar.TabIndex = 15;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(939, 346);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(117, 48);
            this.Actualizar.TabIndex = 16;
            this.Actualizar.Text = "Agregar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 506);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.txbAño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbAlmacenamiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbModelo);
            this.Controls.Add(this.lBLmODELO);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.txbGenero);
            this.Controls.Add(this.LblGenero);
            this.Controls.Add(this.txbEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.labelEliminar);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.DGdatos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGdatos;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Label labelEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txbEliminar;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.TextBox txbGenero;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.Label lBLmODELO;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAlmacenamiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbAño;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button Actualizar;
    }
}

