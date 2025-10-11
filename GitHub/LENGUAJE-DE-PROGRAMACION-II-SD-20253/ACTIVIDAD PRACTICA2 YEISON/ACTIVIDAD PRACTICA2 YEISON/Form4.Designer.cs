namespace ACTIVIDAD_PRACTICA2_YEISON
{
    partial class Form4
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
            textBoxelementonuevo = new TextBox();
            buttonagregar = new Button();
            listBoxelementos = new ListBox();
            buttoncontar = new Button();
            labelcontar = new Label();
            SuspendLayout();
            // 
            // textBoxelementonuevo
            // 
            textBoxelementonuevo.Location = new Point(21, 27);
            textBoxelementonuevo.Name = "textBoxelementonuevo";
            textBoxelementonuevo.Size = new Size(125, 27);
            textBoxelementonuevo.TabIndex = 0;
            // 
            // buttonagregar
            // 
            buttonagregar.Location = new Point(21, 90);
            buttonagregar.Name = "buttonagregar";
            buttonagregar.Size = new Size(168, 29);
            buttonagregar.TabIndex = 1;
            buttonagregar.Text = "Agregar al listado";
            buttonagregar.UseVisualStyleBackColor = true;
            buttonagregar.Click += buttonagregar_Click;
            // 
            // listBoxelementos
            // 
            listBoxelementos.FormattingEnabled = true;
            listBoxelementos.Location = new Point(21, 152);
            listBoxelementos.Name = "listBoxelementos";
            listBoxelementos.Size = new Size(280, 104);
            listBoxelementos.TabIndex = 2;
            // 
            // buttoncontar
            // 
            buttoncontar.Location = new Point(426, 47);
            buttoncontar.Name = "buttoncontar";
            buttoncontar.Size = new Size(124, 50);
            buttoncontar.TabIndex = 3;
            buttoncontar.Text = "Pulsar";
            buttoncontar.UseVisualStyleBackColor = true;
            // 
            // labelcontar
            // 
            labelcontar.AutoSize = true;
            labelcontar.Location = new Point(426, 129);
            labelcontar.Name = "labelcontar";
            labelcontar.Size = new Size(209, 20);
            labelcontar.TabIndex = 4;
            labelcontar.Text = "Cantidad de veces presionado";
            labelcontar.Click += label1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelcontar);
            Controls.Add(buttoncontar);
            Controls.Add(listBoxelementos);
            Controls.Add(buttonagregar);
            Controls.Add(textBoxelementonuevo);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxelementonuevo;
        private Button buttonagregar;
        private ListBox listBoxelementos;
        private Button buttoncontar;
        private Label labelcontar;
    }
}