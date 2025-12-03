namespace ProyectofinalYeisonberiguete
{
    partial class FormMaterias
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
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(26, 30);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersWidth = 51;
            this.dgvMaterias.RowTemplate.Height = 24;
            this.dgvMaterias.Size = new System.Drawing.Size(845, 367);
            this.dgvMaterias.TabIndex = 0;
            this.dgvMaterias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterias_CellDoubleClick);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(272, 435);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(280, 88);
            this.btnAgregarMateria.TabIndex = 1;
            this.btnAgregarMateria.Text = "Agrerar Materia";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // FormMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(906, 573);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.dgvMaterias);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMaterias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Button btnAgregarMateria;
    }
}