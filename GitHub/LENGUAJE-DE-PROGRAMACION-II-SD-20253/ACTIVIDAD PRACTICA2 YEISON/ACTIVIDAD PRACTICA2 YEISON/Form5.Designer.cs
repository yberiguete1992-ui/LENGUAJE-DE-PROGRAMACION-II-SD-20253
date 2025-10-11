namespace ACTIVIDAD_PRACTICA2_YEISON
{
    partial class Form5
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
            textBoxverificarnumero = new TextBox();
            buttonverificar = new Button();
            labelestado = new Label();
            buttonsaludar = new Button();
            dateTimePickerfecha = new DateTimePicker();
            buttonverfecha = new Button();
            labelfechaelegida = new Label();
            SuspendLayout();
            // 
            // textBoxverificarnumero
            // 
            textBoxverificarnumero.Location = new Point(33, 54);
            textBoxverificarnumero.Name = "textBoxverificarnumero";
            textBoxverificarnumero.Size = new Size(125, 27);
            textBoxverificarnumero.TabIndex = 0;
            // 
            // buttonverificar
            // 
            buttonverificar.Location = new Point(33, 119);
            buttonverificar.Name = "buttonverificar";
            buttonverificar.Size = new Size(201, 61);
            buttonverificar.TabIndex = 1;
            buttonverificar.Text = "Verificar Numero";
            buttonverificar.UseVisualStyleBackColor = true;
            buttonverificar.Click += buttonverificar_Click;
            // 
            // labelestado
            // 
            labelestado.AutoSize = true;
            labelestado.Location = new Point(33, 209);
            labelestado.Name = "labelestado";
            labelestado.Size = new Size(184, 20);
            labelestado.TabIndex = 2;
            labelestado.Text = "A la espera de verificacion";
            labelestado.Click += labelestado_Click;
            // 
            // buttonsaludar
            // 
            buttonsaludar.Location = new Point(33, 277);
            buttonsaludar.Name = "buttonsaludar";
            buttonsaludar.Size = new Size(184, 57);
            buttonsaludar.TabIndex = 3;
            buttonsaludar.Text = "\"Hola, soy Yeison SD-17-20813\"";
            buttonsaludar.UseVisualStyleBackColor = true;
            buttonsaludar.Click += buttonsaludar_Click;
            // 
            // dateTimePickerfecha
            // 
            dateTimePickerfecha.Location = new Point(383, 52);
            dateTimePickerfecha.Name = "dateTimePickerfecha";
            dateTimePickerfecha.Size = new Size(305, 27);
            dateTimePickerfecha.TabIndex = 4;
            // 
            // buttonverfecha
            // 
            buttonverfecha.Location = new Point(477, 119);
            buttonverfecha.Name = "buttonverfecha";
            buttonverfecha.Size = new Size(130, 61);
            buttonverfecha.TabIndex = 5;
            buttonverfecha.Text = "Ver Fecha";
            buttonverfecha.UseVisualStyleBackColor = true;
            buttonverfecha.Click += buttonverfecha_Click;
            // 
            // labelfechaelegida
            // 
            labelfechaelegida.AutoSize = true;
            labelfechaelegida.Location = new Point(496, 209);
            labelfechaelegida.Name = "labelfechaelegida";
            labelfechaelegida.Size = new Size(56, 20);
            labelfechaelegida.TabIndex = 6;
            labelfechaelegida.Text = "Fecha:-";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelfechaelegida);
            Controls.Add(buttonverfecha);
            Controls.Add(dateTimePickerfecha);
            Controls.Add(buttonsaludar);
            Controls.Add(labelestado);
            Controls.Add(buttonverificar);
            Controls.Add(textBoxverificarnumero);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxverificarnumero;
        private Button buttonverificar;
        private Label labelestado;
        private Button buttonsaludar;
        private DateTimePicker dateTimePickerfecha;
        private Button buttonverfecha;
        private Label labelfechaelegida;
    }
}