namespace Proyecto_Buscar_Pares
{
    partial class FormJuego
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
            components = new System.ComponentModel.Container();
            lbTiempo = new Label();
            label2 = new Label();
            label1 = new Label();
            lbFallos = new Label();
            panel2 = new Panel();
            Tiempo = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            btnPista = new Button();
            temporizadorPista = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbTiempo
            // 
            lbTiempo.AutoSize = true;
            lbTiempo.BackColor = Color.FromArgb(146, 119, 76);
            lbTiempo.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbTiempo.ForeColor = SystemColors.Control;
            lbTiempo.Location = new Point(137, 22);
            lbTiempo.Name = "lbTiempo";
            lbTiempo.Size = new Size(56, 21);
            lbTiempo.TabIndex = 1;
            lbTiempo.Text = "00:00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(146, 119, 76);
            label2.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(37, 22);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 2;
            label2.Text = "Tiempo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(146, 119, 76);
            label1.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(37, 61);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 3;
            label1.Text = "Fallos:";
            // 
            // lbFallos
            // 
            lbFallos.AutoSize = true;
            lbFallos.BackColor = Color.FromArgb(146, 119, 76);
            lbFallos.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbFallos.ForeColor = SystemColors.Control;
            lbFallos.Location = new Point(137, 61);
            lbFallos.Name = "lbFallos";
            lbFallos.Size = new Size(20, 21);
            lbFallos.TabIndex = 4;
            lbFallos.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(146, 119, 76);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lbFallos);
            panel2.Controls.Add(lbTiempo);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(485, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 105);
            panel2.TabIndex = 5;
            // 
            // Tiempo
            // 
            Tiempo.Interval = 1000;
            Tiempo.Tick += TiempoEvent;
            // 
            // button1
            // 
            button1.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(146, 119, 76);
            button1.Location = new Point(545, 297);
            button1.Name = "button1";
            button1.Size = new Size(111, 33);
            button1.TabIndex = 6;
            button1.Text = "Reiniciar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ReinciarClick;
            // 
            // btnPista
            // 
            btnPista.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPista.ForeColor = Color.FromArgb(146, 119, 76);
            btnPista.Location = new Point(200, 420);
            btnPista.Name = "btnPista";
            btnPista.Size = new Size(89, 33);
            btnPista.TabIndex = 7;
            btnPista.Text = "Pista";
            btnPista.UseVisualStyleBackColor = true;
            btnPista.Click += btnPista_Click_1;
            // 
            // FormJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 209, 172);
            ClientSize = new Size(750, 487);
            Controls.Add(btnPista);
            Controls.Add(button1);
            Controls.Add(panel2);
            Name = "FormJuego";
            Text = "Memoria";
            Load += FormJuego_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbTiempo;
        private Label label2;
        private Label label1;
        private Label lbFallos;
        private Panel panel2;
        private System.Windows.Forms.Timer Tiempo;
        private Button button1;
        private Button btnPista;
        private System.Windows.Forms.Timer temporizadorPista;
    }
}