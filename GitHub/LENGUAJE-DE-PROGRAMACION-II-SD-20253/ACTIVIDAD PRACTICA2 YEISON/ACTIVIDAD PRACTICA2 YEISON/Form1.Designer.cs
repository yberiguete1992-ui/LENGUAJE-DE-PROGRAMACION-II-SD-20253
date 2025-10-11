namespace ACTIVIDAD_PRACTICA2_YEISON
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            mensaje = new Label();
            labelresultadotexto = new Label();
            botonmostartexto = new Button();
            entrada = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(399, 20);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido al formulario de Yeison Beriguete SD-17-20813";
            // 
            // button1
            // 
            button1.Location = new Point(28, 83);
            button1.Name = "button1";
            button1.Size = new Size(158, 44);
            button1.TabIndex = 1;
            button1.Text = "Cambiar el texto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mensaje
            // 
            mensaje.AutoSize = true;
            mensaje.Location = new Point(204, 83);
            mensaje.Name = "mensaje";
            mensaje.Size = new Size(50, 20);
            mensaje.TabIndex = 2;
            mensaje.Text = "label2";
            // 
            // labelresultadotexto
            // 
            labelresultadotexto.AutoSize = true;
            labelresultadotexto.Location = new Point(31, 258);
            labelresultadotexto.Name = "labelresultadotexto";
            labelresultadotexto.Size = new Size(50, 20);
            labelresultadotexto.TabIndex = 3;
            labelresultadotexto.Text = "label2";
            // 
            // botonmostartexto
            // 
            botonmostartexto.Location = new Point(31, 202);
            botonmostartexto.Name = "botonmostartexto";
            botonmostartexto.Size = new Size(155, 41);
            botonmostartexto.TabIndex = 4;
            botonmostartexto.Text = "Ver texto";
            botonmostartexto.UseVisualStyleBackColor = true;
            botonmostartexto.Click += botonmostartexto_Click;
            // 
            // entrada
            // 
            entrada.Location = new Point(31, 154);
            entrada.Name = "entrada";
            entrada.Size = new Size(155, 27);
            entrada.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(entrada);
            Controls.Add(botonmostartexto);
            Controls.Add(labelresultadotexto);
            Controls.Add(mensaje);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label mensaje;
        private Label labelresultadotexto;
        private Button botonmostartexto;
        private TextBox entrada;
    }
}
