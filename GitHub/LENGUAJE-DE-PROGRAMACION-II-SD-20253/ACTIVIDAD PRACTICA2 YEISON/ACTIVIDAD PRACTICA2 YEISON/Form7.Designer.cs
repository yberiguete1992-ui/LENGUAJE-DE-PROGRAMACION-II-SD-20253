namespace ACTIVIDAD_PRACTICA2_YEISON
{
    partial class Form7
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
            components = new System.ComponentModel.Container();
            progreso = new ProgressBar();
            buttoniniciar = new Button();
            buttondetener = new Button();
            timerprogreso = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progreso
            // 
            progreso.Location = new Point(42, 60);
            progreso.Name = "progreso";
            progreso.Size = new Size(157, 54);
            progreso.TabIndex = 0;
            // 
            // buttoniniciar
            // 
            buttoniniciar.Location = new Point(42, 155);
            buttoniniciar.Name = "buttoniniciar";
            buttoniniciar.Size = new Size(232, 77);
            buttoniniciar.TabIndex = 1;
            buttoniniciar.Text = "Iniciar el progreso";
            buttoniniciar.UseVisualStyleBackColor = true;
            buttoniniciar.Click += buttoniniciar_Click;
            // 
            // buttondetener
            // 
            buttondetener.Location = new Point(42, 265);
            buttondetener.Name = "buttondetener";
            buttondetener.Size = new Size(232, 74);
            buttondetener.TabIndex = 2;
            buttondetener.Text = "Detener el progreso";
            buttondetener.UseVisualStyleBackColor = true;
            buttondetener.Click += buttondetener_Click;
            // 
            // timerprogreso
            // 
            timerprogreso.Tick += timerprogreso_Tick;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttondetener);
            Controls.Add(buttoniniciar);
            Controls.Add(progreso);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progreso;
        private Button buttoniniciar;
        private Button buttondetener;
        private System.Windows.Forms.Timer timerprogreso;
    }
}