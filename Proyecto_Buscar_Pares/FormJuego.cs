namespace Proyecto_Buscar_Pares
{
    public partial class FormJuego : Form
    {
        List<int> numero = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        string seleccion1;
        string seleccion2;
        int intentos;
        List<PictureBox> imagenes = new List<PictureBox>();
        PictureBox imgA;
        PictureBox imgB;
        int tries;
        int tiempoTotal = 30;
        int cuentaRegresiva;
        bool gameOver = false;
        public FormJuego()
        {
            InitializeComponent();
            CargarImagenes();
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
                imgA = sender as PictureBox;
                if (imgA.Tag != null && imgA.Image == null)
                {
                    imgA.Image = Image.FromFile("gatos/" + (string)imgA.Tag + ".png");
                    seleccion1 = (string)imgA.Tag;
                }
            }
            else if (seleccion2 == null)
            {
                imgB = sender as PictureBox;
                if (imgB.Tag != null && imgB.Image == null)
                {
                    imgB.Image = Image.FromFile("gatos/" + (string)imgB.Tag + ".png");
                    seleccion2 = (string)imgB.Tag;
                }
            }
            else
            {
                CheckPictures(imgA, imgB);
            }
        }
        private void ReiniciarJuego()
        {
            var randomList = numero.OrderBy(x => Guid.NewGuid()).ToList();
            // assign the random list to the original
            numero = randomList;
            for (int i = 0; i < imagenes.Count; i++)
            {
                imagenes[i].Image = null;
                imagenes[i].Tag = numero[i].ToString();
            }
            intentos = 0;
            //lblStatus.Text = "Mismatched: " + tries + " times.";
            lbAciertos.Text = "0" + intentos;
            lbTiempo.Text = "0" + tiempoTotal;
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
                tries++;
                lbAciertos.Text = "0" + tries;
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

            if (imagenes.All(o => o.Tag == imagenes[0].Tag))
            {
                GameOver("Buen trabajo, has ganado!!!!");
            }
        }
        private void GameOver(string msg)
        {
            Tiempo.Stop();
            gameOver = true;
            MessageBox.Show(msg + " Haga click para comenzar denuevo :) ", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TiempoEvent(object sender, EventArgs e)
        {
            cuentaRegresiva--;
            lbTiempo.Text = "00:" + cuentaRegresiva;
            if (cuentaRegresiva < 1)
            {
                GameOver("Tiempo fuera, has perdido. ");
                foreach (PictureBox x in imagenes)
                {
                    if (x.Tag != null)
                    {
                        x.Image = Image.FromFile("gatos/" + (string)x.Tag + ".png");
                    }
                }
            }
        }

        private void ReinciarEvent(object sender, EventArgs e)
        {
            var randomList = numero.OrderBy(x => Guid.NewGuid()).ToList();
            numero = randomList;
            for (int i = 0; i < imagenes.Count; i++)
            {
                imagenes[i].Image = null;
                imagenes[i].Tag = imagenes[i].ToString();
            }
            intentos = 0;
            lbAciertos.Text = "0" + intentos;
            lbTiempo.Text = "00:" + tiempoTotal;
            gameOver = false;
            Tiempo.Start();
            cuentaRegresiva = tiempoTotal;
        }


    }
}

