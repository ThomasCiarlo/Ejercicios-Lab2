namespace FormulacioParcial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboTipoBotella = new System.Windows.Forms.ComboBox();
            this.numericCapacidad = new System.Windows.Forms.NumericUpDown();
            this.radioCerveza = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.numericContenido = new System.Windows.Forms.NumericUpDown();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioAgua = new System.Windows.Forms.RadioButton();
            this.BotTipo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barra1 = new ControlCantina.Barra();
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // comboTipoBotella
            // 
            this.comboTipoBotella.FormattingEnabled = true;
            this.comboTipoBotella.Items.AddRange(new object[] {
            "Vidrio",
            "Plastico"});
            this.comboTipoBotella.Location = new System.Drawing.Point(356, 333);
            this.comboTipoBotella.Name = "comboTipoBotella";
            this.comboTipoBotella.Size = new System.Drawing.Size(121, 21);
            this.comboTipoBotella.TabIndex = 0;
            // 
            // numericCapacidad
            // 
            this.numericCapacidad.Location = new System.Drawing.Point(158, 391);
            this.numericCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCapacidad.Name = "numericCapacidad";
            this.numericCapacidad.Size = new System.Drawing.Size(61, 20);
            this.numericCapacidad.TabIndex = 1;
            this.numericCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // radioCerveza
            // 
            this.radioCerveza.AutoSize = true;
            this.radioCerveza.Location = new System.Drawing.Point(31, 363);
            this.radioCerveza.Name = "radioCerveza";
            this.radioCerveza.Size = new System.Drawing.Size(64, 17);
            this.radioCerveza.TabIndex = 3;
            this.radioCerveza.TabStop = true;
            this.radioCerveza.Text = "Cerveza";
            this.radioCerveza.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(356, 367);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 44);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // numericContenido
            // 
            this.numericContenido.Location = new System.Drawing.Point(251, 391);
            this.numericContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericContenido.Name = "numericContenido";
            this.numericContenido.Size = new System.Drawing.Size(68, 20);
            this.numericContenido.TabIndex = 5;
            this.numericContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(158, 333);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(161, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Marca";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioAgua
            // 
            this.radioAgua.AutoSize = true;
            this.radioAgua.Location = new System.Drawing.Point(31, 391);
            this.radioAgua.Name = "radioAgua";
            this.radioAgua.Size = new System.Drawing.Size(50, 17);
            this.radioAgua.TabIndex = 8;
            this.radioAgua.TabStop = true;
            this.radioAgua.Text = "Agua";
            this.radioAgua.UseVisualStyleBackColor = true;
            // 
            // BotTipo
            // 
            this.BotTipo.AutoSize = true;
            this.BotTipo.Location = new System.Drawing.Point(353, 314);
            this.BotTipo.Name = "BotTipo";
            this.BotTipo.Size = new System.Drawing.Size(63, 13);
            this.BotTipo.TabIndex = 9;
            this.BotTipo.Text = "Botella Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Capacidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contenido";
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(12, 12);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(549, 299);
            this.barra1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 423);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BotTipo);
            this.Controls.Add(this.radioAgua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.numericContenido);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.radioCerveza);
            this.Controls.Add(this.numericCapacidad);
            this.Controls.Add(this.comboTipoBotella);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTipoBotella;
        private System.Windows.Forms.NumericUpDown numericCapacidad;
        private System.Windows.Forms.RadioButton radioCerveza;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown numericContenido;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioAgua;
        private System.Windows.Forms.Label BotTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ControlCantina.Barra barra1;
    }
}

