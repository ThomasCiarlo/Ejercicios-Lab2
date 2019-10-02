namespace Formularios
{
    partial class frmPrincipal
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
            this.richListProductos = new System.Windows.Forms.RichTextBox();
            this.richListVentas = new System.Windows.Forms.RichTextBox();
            this.richListDescripcion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupAcciones = new System.Windows.Forms.GroupBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // richListProductos
            // 
            this.richListProductos.Location = new System.Drawing.Point(12, 38);
            this.richListProductos.Name = "richListProductos";
            this.richListProductos.Size = new System.Drawing.Size(418, 239);
            this.richListProductos.TabIndex = 0;
            this.richListProductos.Text = "";
            // 
            // richListVentas
            // 
            this.richListVentas.Location = new System.Drawing.Point(12, 305);
            this.richListVentas.Name = "richListVentas";
            this.richListVentas.Size = new System.Drawing.Size(733, 124);
            this.richListVentas.TabIndex = 1;
            this.richListVentas.Text = "";
            this.richListVentas.TextChanged += new System.EventHandler(this.RichListVentas_TextChanged);
            // 
            // richListDescripcion
            // 
            this.richListDescripcion.Location = new System.Drawing.Point(439, 153);
            this.richListDescripcion.Name = "richListDescripcion";
            this.richListDescripcion.Size = new System.Drawing.Size(306, 124);
            this.richListDescripcion.TabIndex = 2;
            this.richListDescripcion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de productos";
            // 
            // groupAcciones
            // 
            this.groupAcciones.Controls.Add(this.btnVender);
            this.groupAcciones.Location = new System.Drawing.Point(439, 38);
            this.groupAcciones.Name = "groupAcciones";
            this.groupAcciones.Size = new System.Drawing.Size(306, 109);
            this.groupAcciones.TabIndex = 4;
            this.groupAcciones.TabStop = false;
            this.groupAcciones.Text = "Acciones";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(6, 41);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(90, 30);
            this.btnVender.TabIndex = 0;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista de ventas";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupAcciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richListDescripcion);
            this.Controls.Add(this.richListVentas);
            this.Controls.Add(this.richListProductos);
            this.Name = "frmPrincipal";
            this.Text = "La comiqueria";
            this.groupAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richListProductos;
        private System.Windows.Forms.RichTextBox richListVentas;
        private System.Windows.Forms.RichTextBox richListDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupAcciones;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label label2;
    }
}

