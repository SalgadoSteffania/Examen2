
namespace ExamenDos
{
    partial class FrmEstudiante
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RegistrarAsignatura = new System.Windows.Forms.Button();
            this.nudSiste = new System.Windows.Forms.NumericUpDown();
            this.nudPrimerP = new System.Windows.Forms.NumericUpDown();
            this.nudSegundoP = new System.Windows.Forms.NumericUpDown();
            this.lblClase = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlDatosEstudiante = new System.Windows.Forms.Panel();
            this.pnlAsignatura = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudSiste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrimerP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegundoP)).BeginInit();
            this.pnlDatosEstudiante.SuspendLayout();
            this.pnlAsignatura.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(269, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(109, 125);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(269, 20);
            this.txtApellidos.TabIndex = 1;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(109, 166);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(269, 20);
            this.txtCarnet.TabIndex = 2;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(109, 205);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(269, 20);
            this.txtMunicipio.TabIndex = 3;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(109, 253);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(269, 20);
            this.txtDepartamento.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(222, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(34, 77);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 15);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 8;
            this.label2.Tag = "Canet";
            this.label2.Text = "Carnet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 9;
            this.label3.Tag = "";
            this.label3.Text = "Municipio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 10;
            this.label4.Tag = "";
            this.label4.Text = "Ciudad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(144, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Asignatura de ";
            // 
            // RegistrarAsignatura
            // 
            this.RegistrarAsignatura.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegistrarAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarAsignatura.Location = new System.Drawing.Point(222, 216);
            this.RegistrarAsignatura.Name = "RegistrarAsignatura";
            this.RegistrarAsignatura.Size = new System.Drawing.Size(155, 32);
            this.RegistrarAsignatura.TabIndex = 14;
            this.RegistrarAsignatura.Text = "Registrar asignatura";
            this.RegistrarAsignatura.UseVisualStyleBackColor = false;
            this.RegistrarAsignatura.Click += new System.EventHandler(this.RegistrarAsignatura_Click);
            // 
            // nudSiste
            // 
            this.nudSiste.Location = new System.Drawing.Point(147, 76);
            this.nudSiste.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudSiste.Name = "nudSiste";
            this.nudSiste.Size = new System.Drawing.Size(221, 20);
            this.nudSiste.TabIndex = 15;
            // 
            // nudPrimerP
            // 
            this.nudPrimerP.Location = new System.Drawing.Point(147, 126);
            this.nudPrimerP.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.nudPrimerP.Name = "nudPrimerP";
            this.nudPrimerP.Size = new System.Drawing.Size(221, 20);
            this.nudPrimerP.TabIndex = 16;
            // 
            // nudSegundoP
            // 
            this.nudSegundoP.Location = new System.Drawing.Point(147, 171);
            this.nudSegundoP.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.nudSegundoP.Name = "nudSegundoP";
            this.nudSegundoP.Size = new System.Drawing.Size(221, 20);
            this.nudSegundoP.TabIndex = 17;
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClase.Location = new System.Drawing.Point(249, 27);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(42, 14);
            this.lblClase.TabIndex = 18;
            this.lblClase.Text = "Clase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sistemáticos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Parcial I";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Parcial II";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(165, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 14);
            this.label9.TabIndex = 22;
            this.label9.Text = "Datos del estudiante";
            // 
            // pnlDatosEstudiante
            // 
            this.pnlDatosEstudiante.Controls.Add(this.label9);
            this.pnlDatosEstudiante.Controls.Add(this.label4);
            this.pnlDatosEstudiante.Controls.Add(this.label3);
            this.pnlDatosEstudiante.Controls.Add(this.label2);
            this.pnlDatosEstudiante.Controls.Add(this.label1);
            this.pnlDatosEstudiante.Controls.Add(this.lblNombre);
            this.pnlDatosEstudiante.Controls.Add(this.txtDepartamento);
            this.pnlDatosEstudiante.Controls.Add(this.txtMunicipio);
            this.pnlDatosEstudiante.Controls.Add(this.txtCarnet);
            this.pnlDatosEstudiante.Controls.Add(this.txtApellidos);
            this.pnlDatosEstudiante.Controls.Add(this.txtNombre);
            this.pnlDatosEstudiante.Location = new System.Drawing.Point(16, 32);
            this.pnlDatosEstudiante.Name = "pnlDatosEstudiante";
            this.pnlDatosEstudiante.Size = new System.Drawing.Size(395, 318);
            this.pnlDatosEstudiante.TabIndex = 23;
            // 
            // pnlAsignatura
            // 
            this.pnlAsignatura.Controls.Add(this.label8);
            this.pnlAsignatura.Controls.Add(this.label7);
            this.pnlAsignatura.Controls.Add(this.label5);
            this.pnlAsignatura.Controls.Add(this.lblClase);
            this.pnlAsignatura.Controls.Add(this.nudSegundoP);
            this.pnlAsignatura.Controls.Add(this.nudPrimerP);
            this.pnlAsignatura.Controls.Add(this.nudSiste);
            this.pnlAsignatura.Controls.Add(this.RegistrarAsignatura);
            this.pnlAsignatura.Controls.Add(this.label6);
            this.pnlAsignatura.Controls.Add(this.button1);
            this.pnlAsignatura.Location = new System.Drawing.Point(451, 32);
            this.pnlAsignatura.Name = "pnlAsignatura";
            this.pnlAsignatura.Size = new System.Drawing.Size(437, 317);
            this.pnlAsignatura.TabIndex = 24;
            // 
            // FrmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.pnlAsignatura);
            this.Controls.Add(this.pnlDatosEstudiante);
            this.Name = "FrmEstudiante";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.FrmEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSiste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrimerP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegundoP)).EndInit();
            this.pnlDatosEstudiante.ResumeLayout(false);
            this.pnlDatosEstudiante.PerformLayout();
            this.pnlAsignatura.ResumeLayout(false);
            this.pnlAsignatura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RegistrarAsignatura;
        private System.Windows.Forms.NumericUpDown nudSiste;
        private System.Windows.Forms.NumericUpDown nudPrimerP;
        private System.Windows.Forms.NumericUpDown nudSegundoP;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlDatosEstudiante;
        private System.Windows.Forms.Panel pnlAsignatura;
    }
}