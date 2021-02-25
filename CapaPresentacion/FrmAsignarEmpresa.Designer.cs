namespace CapaPresentacion
{
    partial class FrmAsignarEmpresa
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
            this.cboCiclos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAlumnosFcts = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEmpresasCiclo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAlumnosCiclo = new System.Windows.Forms.ComboBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProfes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTutorEmpresa = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboCiclos
            // 
            this.cboCiclos.BackColor = System.Drawing.Color.White;
            this.cboCiclos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiclos.FormattingEnabled = true;
            this.cboCiclos.Location = new System.Drawing.Point(116, 45);
            this.cboCiclos.Name = "cboCiclos";
            this.cboCiclos.Size = new System.Drawing.Size(117, 21);
            this.cboCiclos.TabIndex = 3;
            this.cboCiclos.SelectedIndexChanged += new System.EventHandler(this.cboCiclos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ciclo";
            // 
            // cboAlumnosFcts
            // 
            this.cboAlumnosFcts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlumnosFcts.FormattingEnabled = true;
            this.cboAlumnosFcts.Location = new System.Drawing.Point(325, 368);
            this.cboAlumnosFcts.Name = "cboAlumnosFcts";
            this.cboAlumnosFcts.Size = new System.Drawing.Size(117, 21);
            this.cboAlumnosFcts.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Alumnos/as que aún no se les ha asignado empresa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, -51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Empresas para el ciclo (ordenadas alfabétícamente)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Empresas para el ciclo (ordenadas alfabétícamente)";
            // 
            // cboEmpresasCiclo
            // 
            this.cboEmpresasCiclo.BackColor = System.Drawing.Color.White;
            this.cboEmpresasCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresasCiclo.FormattingEnabled = true;
            this.cboEmpresasCiclo.Location = new System.Drawing.Point(333, 85);
            this.cboEmpresasCiclo.Name = "cboEmpresasCiclo";
            this.cboEmpresasCiclo.Size = new System.Drawing.Size(270, 21);
            this.cboEmpresasCiclo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Alumnos/as del ciclo";
            // 
            // cboAlumnosCiclo
            // 
            this.cboAlumnosCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlumnosCiclo.FormattingEnabled = true;
            this.cboAlumnosCiclo.Location = new System.Drawing.Point(430, 43);
            this.cboAlumnosCiclo.Name = "cboAlumnosCiclo";
            this.cboAlumnosCiclo.Size = new System.Drawing.Size(173, 21);
            this.cboAlumnosCiclo.TabIndex = 19;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(180, 201);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(145, 39);
            this.btnAsignar.TabIndex = 20;
            this.btnAsignar.Text = "&Asignar empresa";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tutor/a del instituto";
            // 
            // cboProfes
            // 
            this.cboProfes.BackColor = System.Drawing.Color.White;
            this.cboProfes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfes.FormattingEnabled = true;
            this.cboProfes.Location = new System.Drawing.Point(157, 128);
            this.cboProfes.Name = "cboProfes";
            this.cboProfes.Size = new System.Drawing.Size(117, 21);
            this.cboProfes.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tutor/a de la empresa";
            // 
            // txtTutorEmpresa
            // 
            this.txtTutorEmpresa.Location = new System.Drawing.Point(469, 129);
            this.txtTutorEmpresa.Name = "txtTutorEmpresa";
            this.txtTutorEmpresa.Size = new System.Drawing.Size(210, 20);
            this.txtTutorEmpresa.TabIndex = 24;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(393, 201);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(145, 39);
            this.btnVolver.TabIndex = 25;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmAsignarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 433);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtTutorEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboProfes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.cboAlumnosCiclo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboEmpresasCiclo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboAlumnosFcts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboCiclos);
            this.Controls.Add(this.label1);
            this.Name = "FrmAsignarEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar empresas a alumnado";
            this.Load += new System.EventHandler(this.FrmAsignarEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCiclos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAlumnosFcts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboEmpresasCiclo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAlumnosCiclo;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboProfes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTutorEmpresa;
        private System.Windows.Forms.Button btnVolver;
    }
}