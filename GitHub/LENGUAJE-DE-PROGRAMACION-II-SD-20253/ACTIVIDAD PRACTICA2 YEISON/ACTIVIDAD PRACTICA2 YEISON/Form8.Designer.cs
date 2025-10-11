namespace ACTIVIDAD_PRACTICA2_YEISON
{
    partial class Form8
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Label1 = new Label();
            tabPage2 = new TabPage();
            label2 = new Label();
            tabPage3 = new TabPage();
            label3 = new Label();
            textBoxcontenido = new TextBox();
            buttonabrir = new Button();
            buttonguardar = new Button();
            openFileabrir = new OpenFileDialog();
            saveFileguardar = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(56, 104);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(323, 200);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(315, 167);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Nombre";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(6, 3);
            Label1.Name = "Label1";
            Label1.Size = new Size(51, 20);
            Label1.TabIndex = 0;
            Label1.Text = "Yeison";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(315, 167);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Apellido";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 3);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "Beriguete";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(315, 167);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Dirección";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 2);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 0;
            label3.Text = "Santo Domingo Oeste";
            // 
            // textBoxcontenido
            // 
            textBoxcontenido.Location = new Point(527, 104);
            textBoxcontenido.Name = "textBoxcontenido";
            textBoxcontenido.Size = new Size(125, 27);
            textBoxcontenido.TabIndex = 1;
            // 
            // buttonabrir
            // 
            buttonabrir.Location = new Point(527, 165);
            buttonabrir.Name = "buttonabrir";
            buttonabrir.Size = new Size(125, 54);
            buttonabrir.TabIndex = 2;
            buttonabrir.Text = "Abrir archivo";
            buttonabrir.UseVisualStyleBackColor = true;
            buttonabrir.Click += buttonabrir_Click;
            // 
            // buttonguardar
            // 
            buttonguardar.Location = new Point(527, 248);
            buttonguardar.Name = "buttonguardar";
            buttonguardar.Size = new Size(125, 56);
            buttonguardar.TabIndex = 3;
            buttonguardar.Text = "Guardar archivo";
            buttonguardar.UseVisualStyleBackColor = true;
            buttonguardar.Click += buttonguardar_Click;
            // 
            // openFileabrir
            // 
            openFileabrir.FileName = "openFileDialog1";
            // 
            // saveFileguardar
            // 
            saveFileguardar.FileName = "openFileDialog1";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonguardar);
            Controls.Add(buttonabrir);
            Controls.Add(textBoxcontenido);
            Controls.Add(tabControl1);
            Name = "Form8";
            Text = "Form8";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label Label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxcontenido;
        private Button buttonabrir;
        private Button buttonguardar;
        private OpenFileDialog openFileabrir;
        private OpenFileDialog saveFileguardar;
    }
}