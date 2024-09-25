using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace ShaolinMatadorDePorco
{
    public partial class HorarioLOL : Form
    {

        int TimeLeft;

        int InitialTime;

        public HorarioLOL()
        {
            InitializeComponent();
        }

        private void HorarioLOL_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            TimeLeft = Convert.ToInt32(nudTime.Value); // Define o tempo com o valor escolhido pelo usuário

            InitialTime = TimeLeft;

            if (TimeLeft == 0)
            {
                return;
            }
            else
            {
                lblTempo.Text = TimeLeft.ToString(); // Atualiza o rótulo com o tempo inicial
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TimeLeft > 0)
            {
                TimeLeft = TimeLeft - 1;
                lblTempo.Text = TimeLeft + "";
            }
            if (lblTempo.Text == "0")
            {
                TimeLeft = InitialTime + 1;
                Form2 popUp = new Form2();
                popUp.Show();
                TocarMusica("C:\\Users\\Usuario\\Downloads\\Sininho.wav");
            }
        }

        public static void TocarMusica(string filepath)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = filepath;
            player.Play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
    }
