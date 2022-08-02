namespace Semaforo
{
    public partial class Form1 : Form
    {
        private string Coratual;
        public Form1()
        {
            // Inicia com o semaforo em vermelho.
            Coratual = "Vermelho";
            InitializeComponent();
        }
        // Inicia o semaforo
        private void btnLigar_Click(object sender, EventArgs e)
        {
            // Mostrar as cores
            timer.Start();
            timer.Enabled = true;
        }

        // Verificar em que cor o semaforo está.
        private void Mudarcor()
        {
            if (Coratual == "Vermelho")
            {
                pictureBox.Load("../../../Properties/vermelho.png");
                timer.Interval = 5000;
                Coratual = "verde";
            }
            else if (Coratual == "verde")
            {
                timer.Interval = 10000;
                pictureBox.Load("../../../Properties/verde.png");
                Coratual = "amarelo";
            }
            else
            {
                pictureBox.Load("../../../Properties/amarelo.png");
                timer.Interval = 3000;
                Coratual = "Vermelho";
            }
        }

        // Fecha o programa
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Vai para o semaforo
        private void btnDesligar_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Mudarcor();
        }
    }
}