namespace Proyecto_Buscar_Pares
{
    partial class FormInicio
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
            label1 = new Label();
            btnInicioJuego = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(175, 103);
            label1.Name = "label1";
            label1.Size = new Size(144, 31);
            label1.TabIndex = 0;
            label1.Text = "MEMORIA";
            // 
            // btnInicioJuego
            // 
            btnInicioJuego.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInicioJuego.Location = new Point(158, 197);
            btnInicioJuego.Name = "btnInicioJuego";
            btnInicioJuego.Size = new Size(179, 50);
            btnInicioJuego.TabIndex = 1;
            btnInicioJuego.Text = "Iniciar Juego";
            btnInicioJuego.UseVisualStyleBackColor = true;
            btnInicioJuego.Click += button1_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(171, 138, 84);
            ClientSize = new Size(495, 350);
            Controls.Add(btnInicioJuego);
            Controls.Add(label1);
            Name = "FormInicio";
            Text = "FormInicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnInicioJuego;
    }
}