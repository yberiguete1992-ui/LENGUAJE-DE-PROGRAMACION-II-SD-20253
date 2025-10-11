namespace ACTIVIDAD_PRACTICA2_YEISON
{
    partial class Form3
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
            radioButtoneleccion1 = new RadioButton();
            radioButtoneleccion2 = new RadioButton();
            radioButtoneleccion3 = new RadioButton();
            botonaceptar = new Button();
            labeleleccionseleccionada = new Label();
            comboBoxloscores = new ComboBox();
            SuspendLayout();
            // 
            // radioButtoneleccion1
            // 
            radioButtoneleccion1.AutoSize = true;
            radioButtoneleccion1.Location = new Point(30, 29);
            radioButtoneleccion1.Name = "radioButtoneleccion1";
            radioButtoneleccion1.Size = new Size(93, 24);
            radioButtoneleccion1.TabIndex = 0;
            radioButtoneleccion1.TabStop = true;
            radioButtoneleccion1.Text = "Eleccion1";
            radioButtoneleccion1.UseVisualStyleBackColor = true;
            // 
            // radioButtoneleccion2
            // 
            radioButtoneleccion2.AutoSize = true;
            radioButtoneleccion2.Location = new Point(30, 88);
            radioButtoneleccion2.Name = "radioButtoneleccion2";
            radioButtoneleccion2.Size = new Size(97, 24);
            radioButtoneleccion2.TabIndex = 1;
            radioButtoneleccion2.TabStop = true;
            radioButtoneleccion2.Text = "Eleccion 2";
            radioButtoneleccion2.UseVisualStyleBackColor = true;
            // 
            // radioButtoneleccion3
            // 
            radioButtoneleccion3.AutoSize = true;
            radioButtoneleccion3.Location = new Point(30, 149);
            radioButtoneleccion3.Name = "radioButtoneleccion3";
            radioButtoneleccion3.Size = new Size(97, 24);
            radioButtoneleccion3.TabIndex = 2;
            radioButtoneleccion3.TabStop = true;
            radioButtoneleccion3.Text = "Eleccion 3";
            radioButtoneleccion3.UseVisualStyleBackColor = true;
            // 
            // botonaceptar
            // 
            botonaceptar.Location = new Point(30, 207);
            botonaceptar.Name = "botonaceptar";
            botonaceptar.Size = new Size(151, 41);
            botonaceptar.TabIndex = 3;
            botonaceptar.Text = "Aceptar Eleccion";
            botonaceptar.UseVisualStyleBackColor = true;
            botonaceptar.Click += botonaceptar_Click;
            // 
            // labeleleccionseleccionada
            // 
            labeleleccionseleccionada.AutoSize = true;
            labeleleccionseleccionada.Location = new Point(30, 271);
            labeleleccionseleccionada.Name = "labeleleccionseleccionada";
            labeleleccionseleccionada.Size = new Size(0, 20);
            labeleleccionseleccionada.TabIndex = 4;
            // 
            // comboBoxloscores
            // 
            comboBoxloscores.FormattingEnabled = true;
            comboBoxloscores.Items.AddRange(new object[] { "Rojo", "Azul", "Verde" });
            comboBoxloscores.Location = new Point(307, 57);
            comboBoxloscores.Name = "comboBoxloscores";
            comboBoxloscores.Size = new Size(151, 28);
            comboBoxloscores.TabIndex = 5;
            comboBoxloscores.SelectedIndexChanged += comboBoxloscores_SelectedIndexChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxloscores);
            Controls.Add(labeleleccionseleccionada);
            Controls.Add(botonaceptar);
            Controls.Add(radioButtoneleccion3);
            Controls.Add(radioButtoneleccion2);
            Controls.Add(radioButtoneleccion1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtoneleccion1;
        private RadioButton radioButtoneleccion2;
        private RadioButton radioButtoneleccion3;
        private Button botonaceptar;
        private Label labeleleccionseleccionada;
        private ComboBox comboBoxloscores;
    }
}