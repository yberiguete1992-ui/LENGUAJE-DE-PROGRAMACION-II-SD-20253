namespace ACTIVIDAD_PRACTICA2_YEISON
{
    partial class Form2
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
            textBoxNumero1 = new TextBox();
            textBoxNumero2 = new TextBox();
            botonsumar = new Button();
            labelResultadoSuma = new Label();
            SuspendLayout();
            // 
            // textBoxNumero1
            // 
            textBoxNumero1.Location = new Point(27, 39);
            textBoxNumero1.Name = "textBoxNumero1";
            textBoxNumero1.Size = new Size(125, 27);
            textBoxNumero1.TabIndex = 0;
            // 
            // textBoxNumero2
            // 
            textBoxNumero2.Location = new Point(27, 94);
            textBoxNumero2.Name = "textBoxNumero2";
            textBoxNumero2.Size = new Size(125, 27);
            textBoxNumero2.TabIndex = 1;
            // 
            // botonsumar
            // 
            botonsumar.Location = new Point(27, 138);
            botonsumar.Name = "botonsumar";
            botonsumar.Size = new Size(142, 29);
            botonsumar.TabIndex = 2;
            botonsumar.Text = "Calcular Suma";
            botonsumar.UseVisualStyleBackColor = true;
            botonsumar.Click += botonsumar_Click;
            // 
            // labelResultadoSuma
            // 
            labelResultadoSuma.AutoSize = true;
            labelResultadoSuma.Location = new Point(27, 189);
            labelResultadoSuma.Name = "labelResultadoSuma";
            labelResultadoSuma.Size = new Size(75, 20);
            labelResultadoSuma.TabIndex = 3;
            labelResultadoSuma.Text = "Resultado";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResultadoSuma);
            Controls.Add(botonsumar);
            Controls.Add(textBoxNumero2);
            Controls.Add(textBoxNumero1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNumero1;
        private TextBox textBoxNumero2;
        private Button botonsumar;
        private Label labelResultadoSuma;
    }
}