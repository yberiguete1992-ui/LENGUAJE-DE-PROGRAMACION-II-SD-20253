namespace ACTIVIDAD_PRACTICA2_YEISON
{
    partial class Form6
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
            textBoxtemperatura = new TextBox();
            buttonconvertir = new Button();
            labelresultado = new Label();
            SuspendLayout();
            // 
            // textBoxtemperatura
            // 
            textBoxtemperatura.Location = new Point(23, 39);
            textBoxtemperatura.Name = "textBoxtemperatura";
            textBoxtemperatura.Size = new Size(175, 27);
            textBoxtemperatura.TabIndex = 0;
            // 
            // buttonconvertir
            // 
            buttonconvertir.Location = new Point(23, 110);
            buttonconvertir.Name = "buttonconvertir";
            buttonconvertir.Size = new Size(175, 49);
            buttonconvertir.TabIndex = 1;
            buttonconvertir.Text = "Convertidor °F";
            buttonconvertir.UseVisualStyleBackColor = true;
            buttonconvertir.Click += buttonconvertir_Click;
            // 
            // labelresultado
            // 
            labelresultado.AutoSize = true;
            labelresultado.Location = new Point(23, 204);
            labelresultado.Name = "labelresultado";
            labelresultado.Size = new Size(84, 20);
            labelresultado.TabIndex = 2;
            labelresultado.Text = "Resultado:-";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelresultado);
            Controls.Add(buttonconvertir);
            Controls.Add(textBoxtemperatura);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxtemperatura;
        private Button buttonconvertir;
        private Label labelresultado;
    }
}