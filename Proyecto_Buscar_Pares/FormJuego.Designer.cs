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
            panel1 = new Panel();
            lbTiempo = new Label();
            label2 = new Label();
            label1 = new Label();
            lbAciertos = new Label();
            panel2 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(146, 119, 76);
            panel1.Location = new Point(45, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 426);
            panel1.TabIndex = 0;
            // 
            // lbTiempo
            // 
            lbTiempo.AutoSize = true;
            lbTiempo.BackColor = Color.FromArgb(146, 119, 76);
            lbTiempo.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbTiempo.ForeColor = SystemColors.Control;
            lbTiempo.Location = new Point(134, 22);
            lbTiempo.Name = "lbTiempo";
            lbTiempo.Size = new Size(20, 21);
            lbTiempo.TabIndex = 1;
            lbTiempo.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(146, 119, 76);
            label2.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(45, 22);
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
            label1.Location = new Point(45, 61);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 3;
            label1.Text = "Aciertos:";
            // 
            // lbAciertos
            // 
            lbAciertos.AutoSize = true;
            lbAciertos.BackColor = Color.FromArgb(146, 119, 76);
            lbAciertos.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbAciertos.ForeColor = SystemColors.Control;
            lbAciertos.Location = new Point(136, 61);
            lbAciertos.Name = "lbAciertos";
            lbAciertos.Size = new Size(20, 21);
            lbAciertos.TabIndex = 4;
            lbAciertos.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(146, 119, 76);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lbAciertos);
            panel2.Controls.Add(lbTiempo);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(483, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 105);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(146, 119, 76);
            button1.Location = new Point(528, 299);
            button1.Name = "button1";
            button1.Size = new Size(111, 33);
            button1.TabIndex = 6;
            button1.Text = "Reiniciar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.IMG_20230916_WA0003;
            ClientSize = new Size(735, 487);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormJuego";
            Text = "Juego de Pares";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbTiempo;
        private Label label2;
        private Label label1;
        private Label lbAciertos;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
    }
}