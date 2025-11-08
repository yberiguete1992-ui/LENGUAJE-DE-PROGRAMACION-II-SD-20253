namespace PRACTICA_3_YEISON_BERIGUETE
{
    partial class FormProductos
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
            this.textidproducto = new System.Windows.Forms.TextBox();
            this.textnombreprod = new System.Windows.Forms.TextBox();
            this.textdescripcioprod = new System.Windows.Forms.TextBox();
            this.textprecioprod = new System.Windows.Forms.TextBox();
            this.textstockprod = new System.Windows.Forms.TextBox();
            this.cboxcategoria = new System.Windows.Forms.ComboBox();
            this.cboxproveedor = new System.Windows.Forms.ComboBox();
            this.botonguardarprod = new System.Windows.Forms.Button();
            this.botonactualizarprod = new System.Windows.Forms.Button();
            this.botoneliminarprod = new System.Windows.Forms.Button();
            this.botonlimpiarprod = new System.Windows.Forms.Button();
            this.datagridviewproductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // textidproducto
            // 
            this.textidproducto.Location = new System.Drawing.Point(13, 26);
            this.textidproducto.Name = "textidproducto";
            this.textidproducto.Size = new System.Drawing.Size(100, 22);
            this.textidproducto.TabIndex = 0;
            this.textidproducto.Visible = false;
            // 
            // textnombreprod
            // 
            this.textnombreprod.Location = new System.Drawing.Point(13, 68);
            this.textnombreprod.Name = "textnombreprod";
            this.textnombreprod.Size = new System.Drawing.Size(100, 22);
            this.textnombreprod.TabIndex = 1;
            // 
            // textdescripcioprod
            // 
            this.textdescripcioprod.Location = new System.Drawing.Point(13, 112);
            this.textdescripcioprod.Name = "textdescripcioprod";
            this.textdescripcioprod.Size = new System.Drawing.Size(100, 22);
            this.textdescripcioprod.TabIndex = 2;
            // 
            // textprecioprod
            // 
            this.textprecioprod.Location = new System.Drawing.Point(13, 157);
            this.textprecioprod.Name = "textprecioprod";
            this.textprecioprod.Size = new System.Drawing.Size(100, 22);
            this.textprecioprod.TabIndex = 3;
            // 
            // textstockprod
            // 
            this.textstockprod.Location = new System.Drawing.Point(13, 196);
            this.textstockprod.Name = "textstockprod";
            this.textstockprod.Size = new System.Drawing.Size(100, 22);
            this.textstockprod.TabIndex = 4;
            // 
            // cboxcategoria
            // 
            this.cboxcategoria.FormattingEnabled = true;
            this.cboxcategoria.Location = new System.Drawing.Point(13, 247);
            this.cboxcategoria.Name = "cboxcategoria";
            this.cboxcategoria.Size = new System.Drawing.Size(121, 24);
            this.cboxcategoria.TabIndex = 5;
            // 
            // cboxproveedor
            // 
            this.cboxproveedor.FormattingEnabled = true;
            this.cboxproveedor.Location = new System.Drawing.Point(13, 291);
            this.cboxproveedor.Name = "cboxproveedor";
            this.cboxproveedor.Size = new System.Drawing.Size(121, 24);
            this.cboxproveedor.TabIndex = 6;
            // 
            // botonguardarprod
            // 
            this.botonguardarprod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonguardarprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonguardarprod.Location = new System.Drawing.Point(13, 344);
            this.botonguardarprod.Name = "botonguardarprod";
            this.botonguardarprod.Size = new System.Drawing.Size(121, 43);
            this.botonguardarprod.TabIndex = 7;
            this.botonguardarprod.Text = "GUARDAR";
            this.botonguardarprod.UseVisualStyleBackColor = false;
            // 
            // botonactualizarprod
            // 
            this.botonactualizarprod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonactualizarprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonactualizarprod.Location = new System.Drawing.Point(13, 403);
            this.botonactualizarprod.Name = "botonactualizarprod";
            this.botonactualizarprod.Size = new System.Drawing.Size(121, 42);
            this.botonactualizarprod.TabIndex = 8;
            this.botonactualizarprod.Text = "ACTUALIZAR";
            this.botonactualizarprod.UseVisualStyleBackColor = false;
            // 
            // botoneliminarprod
            // 
            this.botoneliminarprod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botoneliminarprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoneliminarprod.Location = new System.Drawing.Point(255, 344);
            this.botoneliminarprod.Name = "botoneliminarprod";
            this.botoneliminarprod.Size = new System.Drawing.Size(139, 43);
            this.botoneliminarprod.TabIndex = 9;
            this.botoneliminarprod.Text = "ELIMINAR";
            this.botoneliminarprod.UseVisualStyleBackColor = false;
            // 
            // botonlimpiarprod
            // 
            this.botonlimpiarprod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonlimpiarprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonlimpiarprod.Location = new System.Drawing.Point(255, 403);
            this.botonlimpiarprod.Name = "botonlimpiarprod";
            this.botonlimpiarprod.Size = new System.Drawing.Size(139, 42);
            this.botonlimpiarprod.TabIndex = 10;
            this.botonlimpiarprod.Text = "LIMPIAR";
            this.botonlimpiarprod.UseVisualStyleBackColor = false;
            // 
            // datagridviewproductos
            // 
            this.datagridviewproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewproductos.Location = new System.Drawing.Point(313, 13);
            this.datagridviewproductos.Name = "datagridviewproductos";
            this.datagridviewproductos.RowHeadersWidth = 51;
            this.datagridviewproductos.RowTemplate.Height = 24;
            this.datagridviewproductos.Size = new System.Drawing.Size(475, 314);
            this.datagridviewproductos.TabIndex = 11;
   
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagridviewproductos);
            this.Controls.Add(this.botonlimpiarprod);
            this.Controls.Add(this.botoneliminarprod);
            this.Controls.Add(this.botonactualizarprod);
            this.Controls.Add(this.botonguardarprod);
            this.Controls.Add(this.cboxproveedor);
            this.Controls.Add(this.cboxcategoria);
            this.Controls.Add(this.textstockprod);
            this.Controls.Add(this.textprecioprod);
            this.Controls.Add(this.textdescripcioprod);
            this.Controls.Add(this.textnombreprod);
            this.Controls.Add(this.textidproducto);
            this.Name = "FormProductos";
            this.Text = "Formproductos";
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textidproducto;
        private System.Windows.Forms.TextBox textnombreprod;
        private System.Windows.Forms.TextBox textdescripcioprod;
        private System.Windows.Forms.TextBox textprecioprod;
        private System.Windows.Forms.TextBox textstockprod;
        private System.Windows.Forms.ComboBox cboxcategoria;
        private System.Windows.Forms.ComboBox cboxproveedor;
        private System.Windows.Forms.Button botonguardarprod;
        private System.Windows.Forms.Button botonactualizarprod;
        private System.Windows.Forms.Button botoneliminarprod;
        private System.Windows.Forms.Button botonlimpiarprod;
        private System.Windows.Forms.DataGridView datagridviewproductos;
    }
}