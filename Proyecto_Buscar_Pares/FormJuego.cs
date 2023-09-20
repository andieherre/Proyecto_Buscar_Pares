using System;
using System.Windows.Forms;

namespace Proyecto_Buscar_Pares
{
    public partial class FormJuego : Form
    {
        //Declaracion de Variables//
        List<int> numeros = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        string seleccion1;
        string seleccion2;
        int intentos;
        List<PictureBox> imagenes = new List<PictureBox>();
        PictureBox imagenA;
        PictureBox imagenB;
        int tiempoTotal = 50;
        int cuentaRegresiva;
        bool gameOver = false;
        bool ganar = true;

        public FormJuego()
        {
            InitializeComponent();
            CargarImagenes();
        }
        private void FormJuego_Load(object sender, EventArgs e)
        {

        }

        private void NewPic_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                return;
            }
            if (seleccion1 == null)
            {
                imagenA = sender as PictureBox;
                if (imagenA.Tag != null && imagenA.Image == null)
                {
                    imagenA.Image = Image.FromFile("gatos/" + (string)imagenA.Tag + ".png");
                    seleccion1 = (string)imagenA.Tag;
                }
            }
            else if (seleccion2 == null)
            {
                imagenB = sender as PictureBox;
                if (imagenB.Tag != null && imagenB.Image == null)
                {
                    imagenB.Image = Image.FromFile("gatos/" + (string)imagenB.Tag + ".png");
                    seleccion2 = (string)imagenB.Tag;
                }
            }
            else
            {
                CheckPictures(imagenA, imagenB);
            }
        }

        private void TiempoEvent(object sender, EventArgs e)
        {
            cuentaRegresiva--;
            lbTiempo.Text = "00:" + cuentaRegresiva;
            if (cuentaRegresiva <= 0)
            {
                ganar = false;
                GameOver();
                foreach (PictureBox x in imagenes)
                {
                    if (x.Tag != null)
                    {
                        x.Image = Image.FromFile("gatos/" + (string)x.Tag + ".png");
                    }
                }
            }
        }
        private void ReinciarClick(object sender, EventArgs e)
        {
            ReiniciarJuego();
        }


        private void CargarImagenes()
        {
            int leftPos = 40;
            int topPos = 87;
            int rows = 0;
            for (int i = 0; i < 12; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = 90;
                newPic.Width = 90;
                newPic.BackgroundImage = Image.FromFile("gatos/atras.png");
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += NewPic_Click;
                imagenes.Add(newPic);

                if (rows < 4)
                {
                    rows++;
                    newPic.Left = leftPos;
                    newPic.Top = topPos;
                    this.Controls.Add(newPic);
                    leftPos = leftPos + 110;
                }
                if (rows == 4)
                {
                    leftPos = 40;
                    topPos += 110;
                    rows = 0;
                }
            }

            ReiniciarJuego();
        }
        private void ReiniciarJuego()
        {
            var randomList = numeros.OrderBy(x => Guid.NewGuid()).ToList();
            numeros = randomList;
            for (int i = 0; i < imagenes.Count; i++)
            {
                imagenes[i].Image = null;
                imagenes[i].Tag = numeros[i].ToString();
            }
            intentos = 0;
            lbFallos.Text = "0" + intentos;
            lbTiempo.Text = "00:" + tiempoTotal;
            gameOver = false;
            Tiempo.Start();
            cuentaRegresiva = tiempoTotal;
        }
        private void CheckPictures(PictureBox A, PictureBox B)
        {
            if (seleccion1 == seleccion2)
            {
                A.Tag = null;
                B.Tag = null;
            }
            else
            {
                intentos++;
                lbFallos.Text = "0" + intentos;
            }

            seleccion1 = null;
            seleccion2 = null;

            foreach (PictureBox imagen in imagenes.ToList())
            {
                if (imagen.Tag != null)
                {
                    imagen.Image = null;
                }
            }

            if ((imagenes.All(o => o.Tag == imagenes[0].Tag)) && cuentaRegresiva > 0)
            {
                ganar = true;
                GameOver();
            }
        }
        private void GameOver()
        {
            Tiempo.Stop();
            gameOver = true;

            if (ganar)
                    {
                MessageBox.Show("¡Has ganado!", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
            else if (ganar == false)
            {
                MessageBox.Show("Has perdido :(", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnPista_Click_1(object sender, EventArgs e)
        {

    }
}
}