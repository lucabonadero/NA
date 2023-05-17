namespace pryLaboratorioTRES
{
    partial class frmConsultarPorNombre
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gbDNI = new System.Windows.Forms.GroupBox();
            this.txtSexoRO = new System.Windows.Forms.TextBox();
            this.txtBarrioRO = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.txtDNIRO = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbDNI.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(12, 226);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(285, 23);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // gbDNI
            // 
            this.gbDNI.Controls.Add(this.txtSexoRO);
            this.gbDNI.Controls.Add(this.txtBarrioRO);
            this.gbDNI.Controls.Add(this.lblSexo);
            this.gbDNI.Controls.Add(this.txtNombre);
            this.gbDNI.Controls.Add(this.lblBarrio);
            this.gbDNI.Controls.Add(this.txtDNIRO);
            this.gbDNI.Controls.Add(this.lblDNI);
            this.gbDNI.Controls.Add(this.lblNombre);
            this.gbDNI.Location = new System.Drawing.Point(12, 12);
            this.gbDNI.Name = "gbDNI";
            this.gbDNI.Size = new System.Drawing.Size(285, 208);
            this.gbDNI.TabIndex = 15;
            this.gbDNI.TabStop = false;
            this.gbDNI.Text = "Consultar alumno por DNI";
            // 
            // txtSexoRO
            // 
            this.txtSexoRO.Location = new System.Drawing.Point(6, 167);
            this.txtSexoRO.Name = "txtSexoRO";
            this.txtSexoRO.ReadOnly = true;
            this.txtSexoRO.Size = new System.Drawing.Size(140, 20);
            this.txtSexoRO.TabIndex = 13;
            // 
            // txtBarrioRO
            // 
            this.txtBarrioRO.Location = new System.Drawing.Point(6, 120);
            this.txtBarrioRO.Name = "txtBarrioRO";
            this.txtBarrioRO.ReadOnly = true;
            this.txtBarrioRO.Size = new System.Drawing.Size(140, 20);
            this.txtBarrioRO.TabIndex = 12;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(6, 144);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(49, 20);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(144, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(136, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(6, 97);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(55, 20);
            this.lblBarrio.TabIndex = 10;
            this.lblBarrio.Text = "Barrio:";
            // 
            // txtDNIRO
            // 
            this.txtDNIRO.Location = new System.Drawing.Point(6, 74);
            this.txtDNIRO.Name = "txtDNIRO";
            this.txtDNIRO.ReadOnly = true;
            this.txtDNIRO.Size = new System.Drawing.Size(140, 20);
            this.txtDNIRO.TabIndex = 11;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(6, 27);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(140, 20);
            this.lblDNI.TabIndex = 6;
            this.lblDNI.Text = "Apellido y Nombre:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(41, 20);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "DNI:";
            // 
            // frmConsultarPorNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 257);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gbDNI);
            this.Name = "frmConsultarPorNombre";
            this.Text = "frmConsultarPorNombre";
            this.gbDNI.ResumeLayout(false);
            this.gbDNI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox gbDNI;
        private System.Windows.Forms.TextBox txtSexoRO;
        private System.Windows.Forms.TextBox txtBarrioRO;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.TextBox txtDNIRO;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
    }
}