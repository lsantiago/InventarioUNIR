namespace InventarioUNIR
{
    partial class FormInventario
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.gbDatosMedicamento = new System.Windows.Forms.GroupBox();
            this.tbCantidadMedicamento = new System.Windows.Forms.TextBox();
            this.tbNombreMedicamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDistribuidor = new System.Windows.Forms.GroupBox();
            this.gbDestinos = new System.Windows.Forms.GroupBox();
            this.cbTipoMedicamento = new System.Windows.Forms.ComboBox();
            this.rbCofarma = new System.Windows.Forms.RadioButton();
            this.rbEmpsephar = new System.Windows.Forms.RadioButton();
            this.rbCemefar = new System.Windows.Forms.RadioButton();
            this.cbSucursalPrincipal = new System.Windows.Forms.CheckBox();
            this.cbSucursalSecundaria = new System.Windows.Forms.CheckBox();
            this.gbDatosMedicamento.SuspendLayout();
            this.gbDistribuidor.SuspendLayout();
            this.gbDestinos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(284, 406);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(203, 406);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // gbDatosMedicamento
            // 
            this.gbDatosMedicamento.Controls.Add(this.cbTipoMedicamento);
            this.gbDatosMedicamento.Controls.Add(this.tbCantidadMedicamento);
            this.gbDatosMedicamento.Controls.Add(this.tbNombreMedicamento);
            this.gbDatosMedicamento.Controls.Add(this.label3);
            this.gbDatosMedicamento.Controls.Add(this.label2);
            this.gbDatosMedicamento.Controls.Add(this.label1);
            this.gbDatosMedicamento.Location = new System.Drawing.Point(12, 24);
            this.gbDatosMedicamento.Name = "gbDatosMedicamento";
            this.gbDatosMedicamento.Size = new System.Drawing.Size(356, 114);
            this.gbDatosMedicamento.TabIndex = 2;
            this.gbDatosMedicamento.TabStop = false;
            this.gbDatosMedicamento.Text = "Datos del medicamento";
            // 
            // tbCantidadMedicamento
            // 
            this.tbCantidadMedicamento.Location = new System.Drawing.Point(77, 87);
            this.tbCantidadMedicamento.Name = "tbCantidadMedicamento";
            this.tbCantidadMedicamento.Size = new System.Drawing.Size(270, 20);
            this.tbCantidadMedicamento.TabIndex = 4;
            // 
            // tbNombreMedicamento
            // 
            this.tbNombreMedicamento.Location = new System.Drawing.Point(77, 32);
            this.tbNombreMedicamento.Name = "tbNombreMedicamento";
            this.tbNombreMedicamento.Size = new System.Drawing.Size(270, 20);
            this.tbNombreMedicamento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // gbDistribuidor
            // 
            this.gbDistribuidor.Controls.Add(this.rbCemefar);
            this.gbDistribuidor.Controls.Add(this.rbEmpsephar);
            this.gbDistribuidor.Controls.Add(this.rbCofarma);
            this.gbDistribuidor.Location = new System.Drawing.Point(17, 168);
            this.gbDistribuidor.Name = "gbDistribuidor";
            this.gbDistribuidor.Size = new System.Drawing.Size(350, 101);
            this.gbDistribuidor.TabIndex = 3;
            this.gbDistribuidor.TabStop = false;
            this.gbDistribuidor.Text = "Distribuidor  Farmacéutico";
            // 
            // gbDestinos
            // 
            this.gbDestinos.Controls.Add(this.cbSucursalSecundaria);
            this.gbDestinos.Controls.Add(this.cbSucursalPrincipal);
            this.gbDestinos.Location = new System.Drawing.Point(17, 296);
            this.gbDestinos.Name = "gbDestinos";
            this.gbDestinos.Size = new System.Drawing.Size(350, 100);
            this.gbDestinos.TabIndex = 4;
            this.gbDestinos.TabStop = false;
            this.gbDestinos.Text = "Recibir en";
            // 
            // cbTipoMedicamento
            // 
            this.cbTipoMedicamento.FormattingEnabled = true;
            this.cbTipoMedicamento.Items.AddRange(new object[] {
            "",
            "Analgésico",
            "Analéptico",
            "Anestésico",
            "Antiácido",
            "Antidepresivo",
            "Antibióticos"});
            this.cbTipoMedicamento.Location = new System.Drawing.Point(77, 60);
            this.cbTipoMedicamento.Name = "cbTipoMedicamento";
            this.cbTipoMedicamento.Size = new System.Drawing.Size(270, 21);
            this.cbTipoMedicamento.TabIndex = 0;
            // 
            // rbCofarma
            // 
            this.rbCofarma.AutoSize = true;
            this.rbCofarma.Location = new System.Drawing.Point(23, 45);
            this.rbCofarma.Name = "rbCofarma";
            this.rbCofarma.Size = new System.Drawing.Size(64, 17);
            this.rbCofarma.TabIndex = 0;
            this.rbCofarma.TabStop = true;
            this.rbCofarma.Text = "Cofarma";
            this.rbCofarma.UseVisualStyleBackColor = true;
            // 
            // rbEmpsephar
            // 
            this.rbEmpsephar.AutoSize = true;
            this.rbEmpsephar.Location = new System.Drawing.Point(125, 45);
            this.rbEmpsephar.Name = "rbEmpsephar";
            this.rbEmpsephar.Size = new System.Drawing.Size(78, 17);
            this.rbEmpsephar.TabIndex = 1;
            this.rbEmpsephar.TabStop = true;
            this.rbEmpsephar.Text = "Empsephar";
            this.rbEmpsephar.UseVisualStyleBackColor = true;
            // 
            // rbCemefar
            // 
            this.rbCemefar.AutoSize = true;
            this.rbCemefar.Location = new System.Drawing.Point(257, 45);
            this.rbCemefar.Name = "rbCemefar";
            this.rbCemefar.Size = new System.Drawing.Size(64, 17);
            this.rbCemefar.TabIndex = 2;
            this.rbCemefar.TabStop = true;
            this.rbCemefar.Text = "Cemefar";
            this.rbCemefar.UseVisualStyleBackColor = true;
            // 
            // cbSucursalPrincipal
            // 
            this.cbSucursalPrincipal.AutoSize = true;
            this.cbSucursalPrincipal.Location = new System.Drawing.Point(11, 32);
            this.cbSucursalPrincipal.Name = "cbSucursalPrincipal";
            this.cbSucursalPrincipal.Size = new System.Drawing.Size(110, 17);
            this.cbSucursalPrincipal.TabIndex = 0;
            this.cbSucursalPrincipal.Text = "Sucursal Principal";
            this.cbSucursalPrincipal.UseVisualStyleBackColor = true;
            // 
            // cbSucursalSecundaria
            // 
            this.cbSucursalSecundaria.AutoSize = true;
            this.cbSucursalSecundaria.Location = new System.Drawing.Point(11, 56);
            this.cbSucursalSecundaria.Name = "cbSucursalSecundaria";
            this.cbSucursalSecundaria.Size = new System.Drawing.Size(124, 17);
            this.cbSucursalSecundaria.TabIndex = 1;
            this.cbSucursalSecundaria.Text = "Sucursal Secundaria";
            this.cbSucursalSecundaria.UseVisualStyleBackColor = true;
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 441);
            this.Controls.Add(this.gbDestinos);
            this.Controls.Add(this.gbDistribuidor);
            this.Controls.Add(this.gbDatosMedicamento);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEnviar);
            this.Name = "FormInventario";
            this.Text = "INVENTARIO UNIR";
            this.gbDatosMedicamento.ResumeLayout(false);
            this.gbDatosMedicamento.PerformLayout();
            this.gbDistribuidor.ResumeLayout(false);
            this.gbDistribuidor.PerformLayout();
            this.gbDestinos.ResumeLayout(false);
            this.gbDestinos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox gbDatosMedicamento;
        private System.Windows.Forms.GroupBox gbDistribuidor;
        private System.Windows.Forms.GroupBox gbDestinos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCantidadMedicamento;
        private System.Windows.Forms.TextBox tbNombreMedicamento;
        private System.Windows.Forms.ComboBox cbTipoMedicamento;
        private System.Windows.Forms.RadioButton rbCemefar;
        private System.Windows.Forms.RadioButton rbEmpsephar;
        private System.Windows.Forms.RadioButton rbCofarma;
        private System.Windows.Forms.CheckBox cbSucursalSecundaria;
        private System.Windows.Forms.CheckBox cbSucursalPrincipal;
    }
}

