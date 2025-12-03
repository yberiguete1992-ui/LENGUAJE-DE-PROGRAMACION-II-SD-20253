namespace ProyectofinalYeisonberiguete
{
    partial class FormCalificaciones
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
            this.dgvCalificaciones = new System.Windows.Forms.DataGridView();
            this.btnAgregarCalificacion = new System.Windows.Forms.Button();
            this.btnExportarCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCalificaciones
            // 
            this.dgvCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalificaciones.Location = new System.Drawing.Point(15, 29);
            this.dgvCalificaciones.Name = "dgvCalificaciones";
            this.dgvCalificaciones.ReadOnly = true;
            this.dgvCalificaciones.RowHeadersWidth = 51;
            this.dgvCalificaciones.RowTemplate.Height = 24;
            this.dgvCalificaciones.Size = new System.Drawing.Size(872, 359);
            this.dgvCalificaciones.TabIndex = 0;
            this.dgvCalificaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalificaciones_CellDoubleClick);
            // 
            // btnAgregarCalificacion
            // 
            this.btnAgregarCalificacion.Location = new System.Drawing.Point(94, 412);
            this.btnAgregarCalificacion.Name = "btnAgregarCalificacion";
            this.btnAgregarCalificacion.Size = new System.Drawing.Size(252, 64);
            this.btnAgregarCalificacion.TabIndex = 1;
            this.btnAgregarCalificacion.Text = "Agregar Calificación";
            this.btnAgregarCalificacion.UseVisualStyleBackColor = true;
            this.btnAgregarCalificacion.Click += new System.EventHandler(this.btnAgregarCalificacion_Click);
            // 
            // btnExportarCSV
            // 
            this.btnExportarCSV.Location = new System.Drawing.Point(474, 412);
            this.btnExportarCSV.Name = "btnExportarCSV";
            this.btnExportarCSV.Size = new System.Drawing.Size(302, 64);
            this.btnExportarCSV.TabIndex = 2;
            this.btnExportarCSV.Text = "Exportar a CSV";
            this.btnExportarCSV.UseVisualStyleBackColor = true;
            this.btnExportarCSV.Click += new System.EventHandler(this.btnExportarCSV_Click);
            // 
            // FormCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.btnExportarCSV);
            this.Controls.Add(this.btnAgregarCalificacion);
            this.Controls.Add(this.dgvCalificaciones);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormCalificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCalificaciones";
            this.Load += new System.EventHandler(this.FormCalificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCalificaciones;
        private System.Windows.Forms.Button btnAgregarCalificacion;
        private System.Windows.Forms.Button btnExportarCSV;
    }
}