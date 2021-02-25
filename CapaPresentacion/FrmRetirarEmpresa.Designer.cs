namespace CapaPresentacion
{
    partial class FrmRetirarEmpresa
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
            this.btnRetirarEmpresa = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cboAlumnosCiclo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCiclos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRetirarEmpresa
            // 
            this.btnRetirarEmpresa.Location = new System.Drawing.Point(82, 158);
            this.btnRetirarEmpresa.Name = "btnRetirarEmpresa";
            this.btnRetirarEmpresa.Size = new System.Drawing.Size(145, 39);
            this.btnRetirarEmpresa.TabIndex = 26;
            this.btnRetirarEmpresa.Text = "&Retirar empresa";
            this.btnRetirarEmpresa.UseVisualStyleBackColor = true;
            this.btnRetirarEmpresa.Click += new System.EventHandler(this.btnRetirarEmpresa_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(256, 158);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(145, 39);
            this.btnVolver.TabIndex = 27;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cboAlumnosCiclo
            // 
            this.cboAlumnosCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlumnosCiclo.FormattingEnabled = true;
            this.cboAlumnosCiclo.Location = new System.Drawing.Point(203, 79);
            this.cboAlumnosCiclo.Name = "cboAlumnosCiclo";
            this.cboAlumnosCiclo.Size = new System.Drawing.Size(173, 21);
            this.cboAlumnosCiclo.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Alumnos/as del ciclo";
            // 
            // cboCiclos
            // 
            this.cboCiclos.BackColor = System.Drawing.Color.White;
            this.cboCiclos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiclos.FormattingEnabled = true;
            this.cboCiclos.Location = new System.Drawing.Point(162, 32);
            this.cboCiclos.Name = "cboCiclos";
            this.cboCiclos.Size = new System.Drawing.Size(117, 21);
            this.cboCiclos.TabIndex = 29;
            this.cboCiclos.SelectedIndexChanged += new System.EventHandler(this.cboCiclos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ciclo";
            // 
            // FrmRetirarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 238);
            this.Controls.Add(this.cboAlumnosCiclo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCiclos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRetirarEmpresa);
            this.Name = "FrmRetirarEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retirar empresa a alumno/a";
            this.Load += new System.EventHandler(this.FrmRetirarEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetirarEmpresa;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cboAlumnosCiclo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCiclos;
        private System.Windows.Forms.Label label1;
    }
}