namespace PRACTICA_3_YEISON_BERIGUETE
{
    partial class Menuprincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonclientes = new System.Windows.Forms.Button();
            this.botoncategorias = new System.Windows.Forms.Button();
            this.botonproveedores = new System.Windows.Forms.Button();
            this.botonproductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonclientes
            // 
            this.botonclientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonclientes.Location = new System.Drawing.Point(31, 52);
            this.botonclientes.Name = "botonclientes";
            this.botonclientes.Size = new System.Drawing.Size(173, 62);
            this.botonclientes.TabIndex = 0;
            this.botonclientes.Text = "CLIENTES";
            this.botonclientes.UseVisualStyleBackColor = false;
            this.botonclientes.Click += new System.EventHandler(this.botonclientes_Click);
            // 
            // botoncategorias
            // 
            this.botoncategorias.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botoncategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoncategorias.Location = new System.Drawing.Point(31, 144);
            this.botoncategorias.Name = "botoncategorias";
            this.botoncategorias.Size = new System.Drawing.Size(173, 59);
            this.botoncategorias.TabIndex = 1;
            this.botoncategorias.Text = "CATEGORIAS";
            this.botoncategorias.UseVisualStyleBackColor = false;
            this.botoncategorias.Click += new System.EventHandler(this.botoncategorias_Click);
            // 
            // botonproveedores
            // 
            this.botonproveedores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonproveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonproveedores.Location = new System.Drawing.Point(31, 237);
            this.botonproveedores.Name = "botonproveedores";
            this.botonproveedores.Size = new System.Drawing.Size(173, 55);
            this.botonproveedores.TabIndex = 2;
            this.botonproveedores.Text = "PROVEEDORES";
            this.botonproveedores.UseVisualStyleBackColor = false;
            this.botonproveedores.Click += new System.EventHandler(this.botonproveedores_Click);
            // 
            // botonproductos
            // 
            this.botonproductos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonproductos.Location = new System.Drawing.Point(31, 333);
            this.botonproductos.Name = "botonproductos";
            this.botonproductos.Size = new System.Drawing.Size(173, 58);
            this.botonproductos.TabIndex = 3;
            this.botonproductos.Text = "PRODUCTOS";
            this.botonproductos.UseVisualStyleBackColor = false;
            this.botonproductos.Click += new System.EventHandler(this.botonproductos_Click);
            // 
            // Menuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonproductos);
            this.Controls.Add(this.botonproveedores);
            this.Controls.Add(this.botoncategorias);
            this.Controls.Add(this.botonclientes);
            this.Name = "Menuprincipal";
            this.Text = "MENÚ PRINCIPAL";
            this.Load += new System.EventHandler(this.Menuprincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonclientes;
        private System.Windows.Forms.Button botoncategorias;
        private System.Windows.Forms.Button botonproveedores;
        private System.Windows.Forms.Button botonproductos;
    }
}

