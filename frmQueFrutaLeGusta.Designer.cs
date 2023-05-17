namespace pryLaboratorioTRES
{
    partial class frmQueFrutaLeGusta
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
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lstFrutas = new System.Windows.Forms.ListBox();
            this.cmbAlumno = new System.Windows.Forms.ComboBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(12, 18);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(152, 20);
            this.lblDNI.TabIndex = 12;
            this.lblDNI.Text = "Seleccionar alumno:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(159, 20);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Frutas que le gustan:";
            // 
            // lstFrutas
            // 
            this.lstFrutas.FormattingEnabled = true;
            this.lstFrutas.Location = new System.Drawing.Point(16, 94);
            this.lstFrutas.Name = "lstFrutas";
            this.lstFrutas.Size = new System.Drawing.Size(155, 225);
            this.lstFrutas.TabIndex = 15;
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.FormattingEnabled = true;
            this.cmbAlumno.Location = new System.Drawing.Point(16, 41);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(148, 21);
            this.cmbAlumno.TabIndex = 16;
            this.cmbAlumno.SelectedIndexChanged += new System.EventHandler(this.cmbAlumno_SelectedIndexChanged);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(16, 324);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 17;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // frmQueFrutaLeGusta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 359);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.cmbAlumno);
            this.Controls.Add(this.lstFrutas);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmQueFrutaLeGusta";
            this.Text = "frmQueFrutaLeGusta";
            this.Load += new System.EventHandler(this.frmQueFrutaLeGusta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ListBox lstFrutas;
        private System.Windows.Forms.ComboBox cmbAlumno;
        private System.Windows.Forms.Button btnVer;
    }
}