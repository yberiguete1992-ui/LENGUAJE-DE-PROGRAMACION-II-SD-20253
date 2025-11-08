namespace PRACTICA_3_YEISON_BERIGUETE
{
    partial class FormClientes
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
            this.datagridviewclientes = new System.Windows.Forms.DataGridView();
            this.textidcliente = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.textcorreo = new System.Windows.Forms.TextBox();
            this.texttelefono = new System.Windows.Forms.TextBox();
            this.textdireccion = new System.Windows.Forms.TextBox();
            this.botonguardar = new System.Windows.Forms.Button();
            this.botonactualizar = new System.Windows.Forms.Button();
            this.botonlimpiar = new System.Windows.Forms.Button();
            this.botoneliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridviewclientes
            // 
            this.datagridviewclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewclientes.Location = new System.Drawing.Point(333, 52);
            this.datagridviewclientes.Name = "datagridviewclientes";
            this.datagridviewclientes.RowHeadersWidth = 51;
            this.datagridviewclientes.RowTemplate.Height = 24;
            this.datagridviewclientes.Size = new System.Drawing.Size(455, 259);
            this.datagridviewclientes.TabIndex = 0;
            // 
            // textidcliente
            // 
            this.textidcliente.Location = new System.Drawing.Point(29, 52);
            this.textidcliente.Name = "textidcliente";
            this.textidcliente.Size = new System.Drawing.Size(251, 22);
            this.textidcliente.TabIndex = 1;
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(29, 103);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(251, 22);
            this.textnombre.TabIndex = 2;
            // 
            // textcorreo
            // 
            this.textcorreo.Location = new System.Drawing.Point(29, 155);
            this.textcorreo.Name = "textcorreo";
            this.textcorreo.Size = new System.Drawing.Size(251, 22);
            this.textcorreo.TabIndex = 3;
            // 
            // texttelefono
            // 
            this.texttelefono.Location = new System.Drawing.Point(29, 212);
            this.texttelefono.Name = "texttelefono";
            this.texttelefono.Size = new System.Drawing.Size(251, 22);
            this.texttelefono.TabIndex = 4;
            // 
            // textdireccion
            // 
            this.textdireccion.Location = new System.Drawing.Point(29, 269);
            this.textdireccion.Name = "textdireccion";
            this.textdireccion.Size = new System.Drawing.Size(251, 22);
            this.textdireccion.TabIndex = 5;
            // 
            // botonguardar
            // 
            this.botonguardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonguardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonguardar.Location = new System.Drawing.Point(29, 317);
            this.botonguardar.Name = "botonguardar";
            this.botonguardar.Size = new System.Drawing.Size(115, 48);
            this.botonguardar.TabIndex = 6;
            this.botonguardar.Text = "GUARDAR";
            this.botonguardar.UseVisualStyleBackColor = false;
            // 
            // botonactualizar
            // 
            this.botonactualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonactualizar.Location = new System.Drawing.Point(29, 371);
            this.botonactualizar.Name = "botonactualizar";
            this.botonactualizar.Size = new System.Drawing.Size(115, 43);
            this.botonactualizar.TabIndex = 7;
            this.botonactualizar.Text = "ACTUALIZAR";
            this.botonactualizar.UseVisualStyleBackColor = false;
            // 
            // botonlimpiar
            // 
            this.botonlimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonlimpiar.Location = new System.Drawing.Point(333, 335);
            this.botonlimpiar.Name = "botonlimpiar";
            this.botonlimpiar.Size = new System.Drawing.Size(105, 48);
            this.botonlimpiar.TabIndex = 8;
            this.botonlimpiar.Text = "LIMPIAR";
            this.botonlimpiar.UseVisualStyleBackColor = false;
            this.botonlimpiar.Click += new System.EventHandler(this.botonlimpiar_Click);
            // 
            // botoneliminar
            // 
            this.botoneliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botoneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoneliminar.Location = new System.Drawing.Point(605, 338);
            this.botoneliminar.Name = "botoneliminar";
            this.botoneliminar.Size = new System.Drawing.Size(105, 43);
            this.botoneliminar.TabIndex = 9;
            this.botoneliminar.Text = "ELIMINAR";
            this.botoneliminar.UseVisualStyleBackColor = false;
            this.botoneliminar.Click += new System.EventHandler(this.botoneliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Direccion";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botoneliminar);
            this.Controls.Add(this.botonlimpiar);
            this.Controls.Add(this.botonactualizar);
            this.Controls.Add(this.botonguardar);
            this.Controls.Add(this.textdireccion);
            this.Controls.Add(this.texttelefono);
            this.Controls.Add(this.textcorreo);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.textidcliente);
            this.Controls.Add(this.datagridviewclientes);
            this.Name = "FormClientes";
            this.Text = "Formclientes";
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridviewclientes;
        private System.Windows.Forms.TextBox textidcliente;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.TextBox textcorreo;
        private System.Windows.Forms.TextBox texttelefono;
        private System.Windows.Forms.TextBox textdireccion;
        private System.Windows.Forms.Button botonguardar;
        private System.Windows.Forms.Button botonactualizar;
        private System.Windows.Forms.Button botonlimpiar;
        private System.Windows.Forms.Button botoneliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}