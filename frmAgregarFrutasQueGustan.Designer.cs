namespace pryLaboratorioTRES
{
    partial class frmAgregarFrutasQueGustan
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbDNI = new System.Windows.Forms.ComboBox();
            this.cmbCodFruta = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(12, 72);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 38);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(12, 37);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(122, 20);
            this.lblDNI.TabIndex = 20;
            this.lblDNI.Text = "Codigo de fruta:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(124, 20);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "DNI del Alumno:";
            // 
            // cmbDNI
            // 
            this.cmbDNI.FormattingEnabled = true;
            this.cmbDNI.Location = new System.Drawing.Point(162, 9);
            this.cmbDNI.Name = "cmbDNI";
            this.cmbDNI.Size = new System.Drawing.Size(130, 21);
            this.cmbDNI.TabIndex = 24;
            // 
            // cmbCodFruta
            // 
            this.cmbCodFruta.FormattingEnabled = true;
            this.cmbCodFruta.Location = new System.Drawing.Point(162, 39);
            this.cmbCodFruta.Name = "cmbCodFruta";
            this.cmbCodFruta.Size = new System.Drawing.Size(130, 21);
            this.cmbCodFruta.TabIndex = 25;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(155, 72);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 38);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmAgregarFrutasQueGustan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 125);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cmbCodFruta);
            this.Controls.Add(this.cmbDNI);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmAgregarFrutasQueGustan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarFrutasQueGustan";
            this.Load += new System.EventHandler(this.frmAgregarFrutasQueGustan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbDNI;
        private System.Windows.Forms.ComboBox cmbCodFruta;
        private System.Windows.Forms.Button btnEliminar;
    }
}