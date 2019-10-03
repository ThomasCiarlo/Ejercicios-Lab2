namespace Formularios
{
  partial class frmLlamador
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
            this.txtNroDestino = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAsterisco = new System.Windows.Forms.Button();
            this.btnNumeral = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNroOrigen = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNroDestino
            // 
            this.txtNroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDestino.Location = new System.Drawing.Point(12, 12);
            this.txtNroDestino.Multiline = true;
            this.txtNroDestino.Name = "txtNroDestino";
            this.txtNroDestino.Size = new System.Drawing.Size(368, 32);
            this.txtNroDestino.TabIndex = 0;
            this.txtNroDestino.Text = "Numero Destino";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAsterisco);
            this.groupBox1.Controls.Add(this.btnNumeral);
            this.groupBox1.Controls.Add(this.btn0);
            this.groupBox1.Controls.Add(this.btn7);
            this.groupBox1.Controls.Add(this.btn8);
            this.groupBox1.Controls.Add(this.btn9);
            this.groupBox1.Controls.Add(this.btn6);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Controls.Add(this.btn5);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 275);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // btnAsterisco
            // 
            this.btnAsterisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsterisco.Location = new System.Drawing.Point(108, 198);
            this.btnAsterisco.Name = "btnAsterisco";
            this.btnAsterisco.Size = new System.Drawing.Size(45, 47);
            this.btnAsterisco.TabIndex = 20;
            this.btnAsterisco.Text = "*";
            this.btnAsterisco.UseVisualStyleBackColor = true;
            this.btnAsterisco.Click += new System.EventHandler(this.btnAsterisco_Click);
            // 
            // btnNumeral
            // 
            this.btnNumeral.Location = new System.Drawing.Point(6, 198);
            this.btnNumeral.Name = "btnNumeral";
            this.btnNumeral.Size = new System.Drawing.Size(45, 47);
            this.btnNumeral.TabIndex = 19;
            this.btnNumeral.Text = "#";
            this.btnNumeral.UseVisualStyleBackColor = true;
            this.btnNumeral.Click += new System.EventHandler(this.btnNumeral_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(57, 198);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(45, 47);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(6, 145);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 47);
            this.btn7.TabIndex = 16;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(57, 145);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 47);
            this.btn8.TabIndex = 15;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(108, 145);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 47);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(108, 92);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 47);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(6, 92);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 47);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(57, 92);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 47);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(6, 39);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 47);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(57, 39);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 47);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(108, 39);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 47);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(176, 116);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(204, 47);
            this.btnLlamar.TabIndex = 2;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(176, 169);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(204, 47);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtNroOrigen
            // 
            this.txtNroOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroOrigen.Location = new System.Drawing.Point(177, 243);
            this.txtNroOrigen.Name = "txtNroOrigen";
            this.txtNroOrigen.Size = new System.Drawing.Size(203, 26);
            this.txtNroOrigen.TabIndex = 4;
            this.txtNroOrigen.Text = "Numero de origen";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(176, 278);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(204, 47);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbFranja
            // 
            this.cmbFranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFranja.FormattingEnabled = true;
            this.cmbFranja.Items.AddRange(new object[] {
            "Franja 1",
            "Franja 2",
            "Franja 3"});
            this.cmbFranja.Location = new System.Drawing.Point(12, 343);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(374, 28);
            this.cmbFranja.TabIndex = 6;
            this.cmbFranja.Text = "Franja";
            // 
            // frmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 378);
            this.Controls.Add(this.cmbFranja);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNroOrigen);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNroDestino);
            this.Name = "frmLlamador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Llamador";
            this.Load += new System.EventHandler(this.Llamador_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtNroDestino;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnAsterisco;
    private System.Windows.Forms.Button btnNumeral;
    private System.Windows.Forms.Button btn0;
    private System.Windows.Forms.Button btn7;
    private System.Windows.Forms.Button btn8;
    private System.Windows.Forms.Button btn9;
    private System.Windows.Forms.Button btn6;
    private System.Windows.Forms.Button btn4;
    private System.Windows.Forms.Button btn5;
    private System.Windows.Forms.Button btn1;
    private System.Windows.Forms.Button btn2;
    private System.Windows.Forms.Button btn3;
    private System.Windows.Forms.Button btnLlamar;
    private System.Windows.Forms.Button btnLimpiar;
    private System.Windows.Forms.TextBox txtNroOrigen;
    private System.Windows.Forms.Button btnSalir;
    private System.Windows.Forms.ComboBox cmbFranja;
  }
}
