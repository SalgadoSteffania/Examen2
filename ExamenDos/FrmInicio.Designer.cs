
namespace ExamenDos
{
    partial class FrmInicio
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAñadirEst = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnMejorProm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlInicio = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pnlInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnAñadirEst
            // 
            this.btnAñadirEst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAñadirEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirEst.Location = new System.Drawing.Point(20, 8);
            this.btnAñadirEst.Name = "btnAñadirEst";
            this.btnAñadirEst.Size = new System.Drawing.Size(150, 29);
            this.btnAñadirEst.TabIndex = 1;
            this.btnAñadirEst.Text = "Añadir estudiante";
            this.btnAñadirEst.UseVisualStyleBackColor = false;
            this.btnAñadirEst.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(20, 271);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(736, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // btnMejorProm
            // 
            this.btnMejorProm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMejorProm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMejorProm.Location = new System.Drawing.Point(176, 8);
            this.btnMejorProm.Name = "btnMejorProm";
            this.btnMejorProm.Size = new System.Drawing.Size(157, 29);
            this.btnMejorProm.TabIndex = 3;
            this.btnMejorProm.Text = "Ver mejor promedio";
            this.btnMejorProm.UseVisualStyleBackColor = false;
            this.btnMejorProm.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estudiantes registrados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mejor rendimiento académico";
            // 
            // pnlInicio
            // 
            this.pnlInicio.Controls.Add(this.label2);
            this.pnlInicio.Controls.Add(this.label1);
            this.pnlInicio.Controls.Add(this.btnMejorProm);
            this.pnlInicio.Controls.Add(this.dataGridView2);
            this.pnlInicio.Controls.Add(this.btnAñadirEst);
            this.pnlInicio.Controls.Add(this.dataGridView1);
            this.pnlInicio.Location = new System.Drawing.Point(12, 17);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(776, 442);
            this.pnlInicio.TabIndex = 6;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.pnlInicio);
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pnlInicio.ResumeLayout(false);
            this.pnlInicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAñadirEst;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnMejorProm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlInicio;
    }
}