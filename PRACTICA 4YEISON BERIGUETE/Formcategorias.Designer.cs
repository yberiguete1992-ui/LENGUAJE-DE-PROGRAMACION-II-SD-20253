namespace PRACTICA_3_YEISONYBD
{
    partial class FormCategorias
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
            this.textidcategoria = new System.Windows.Forms.TextBox();
            this.textnombrecategoria = new System.Windows.Forms.TextBox();
            this.botonguardarcat = new System.Windows.Forms.Button();
            this.botonactualizarcat = new System.Windows.Forms.Button();
            this.botoneliminarcat = new System.Windows.Forms.Button();
            this.botonlimpiarcat = new System.Windows.Forms.Button();
            this.datagridviewcategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewcategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // textidcategoria
            // 
            this.textidcategoria.Location = new System.Drawing.Point(53, 42);
            this.textidcategoria.Name = "textidcategoria";
            this.textidcategoria.Size = new System.Drawing.Size(100, 22);
            this.textidcategoria.TabIndex = 0;
            this.textidcategoria.Visible = false;
            // 
            // textnombrecategoria
            // 
            this.textnombrecategoria.Location = new System.Drawing.Point(53, 108);
            this.textnombrecategoria.Name = "textnombrecategoria";
            this.textnombrecategoria.Size = new System.Drawing.Size(100, 22);
            this.textnombrecategoria.TabIndex = 1;
            // 
            // botonguardarcat
            // 
            this.botonguardarcat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonguardarcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonguardarcat.Location = new System.Drawing.Point(64, 193);
            this.botonguardarcat.Name = "botonguardarcat";
            this.botonguardarcat.Size = new System.Drawing.Size(127, 54);
            this.botonguardarcat.TabIndex = 2;
            this.botonguardarcat.Text = "GUARDAR";
            this.botonguardarcat.UseVisualStyleBackColor = false;
            // 
            // botonactualizarcat
            // 
            this.botonactualizarcat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonactualizarcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonactualizarcat.Location = new System.Drawing.Point(64, 289);
            this.botonactualizarcat.Name = "botonactualizarcat";
            this.botonactualizarcat.Size = new System.Drawing.Size(127, 44);
            this.botonactualizarcat.TabIndex = 3;
            this.botonactualizarcat.Text = "ACTUALIZAR";
            this.botonactualizarcat.UseVisualStyleBackColor = false;
            // 
            // botoneliminarcat
            // 
            this.botoneliminarcat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botoneliminarcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoneliminarcat.Location = new System.Drawing.Point(273, 369);
            this.botoneliminarcat.Name = "botoneliminarcat";
            this.botoneliminarcat.Size = new System.Drawing.Size(127, 44);
            this.botoneliminarcat.TabIndex = 4;
            this.botoneliminarcat.Text = "ELIMINAR";
            this.botoneliminarcat.UseVisualStyleBackColor = false;
            // 
            // botonlimpiarcat
            // 
            this.botonlimpiarcat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonlimpiarcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonlimpiarcat.Location = new System.Drawing.Point(610, 366);
            this.botonlimpiarcat.Name = "botonlimpiarcat";
            this.botonlimpiarcat.Size = new System.Drawing.Size(127, 51);
            this.botonlimpiarcat.TabIndex = 5;
            this.botonlimpiarcat.Text = "LIMPIAR";
            this.botonlimpiarcat.UseVisualStyleBackColor = false;
            // 
            // datagridviewcategorias
            // 
            this.datagridviewcategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewcategorias.Location = new System.Drawing.Point(247, 25);
            this.datagridviewcategorias.Name = "datagridviewcategorias";
            this.datagridviewcategorias.RowHeadersWidth = 51;
            this.datagridviewcategorias.RowTemplate.Height = 24;
            this.datagridviewcategorias.Size = new System.Drawing.Size(541, 322);
            this.datagridviewcategorias.TabIndex = 6;
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagridviewcategorias);
            this.Controls.Add(this.botonlimpiarcat);
            this.Controls.Add(this.botoneliminarcat);
            this.Controls.Add(this.botonactualizarcat);
            this.Controls.Add(this.botonguardarcat);
            this.Controls.Add(this.textnombrecategoria);
            this.Controls.Add(this.textidcategoria);
            this.Name = "FormCategorias";
            this.Text = "Formcategorias";
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewcategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textidcategoria;
        private System.Windows.Forms.TextBox textnombrecategoria;
        private System.Windows.Forms.Button botonguardarcat;
        private System.Windows.Forms.Button botonactualizarcat;
        private System.Windows.Forms.Button botoneliminarcat;
        private System.Windows.Forms.Button botonlimpiarcat;
        private System.Windows.Forms.DataGridView datagridviewcategorias;
    }
}