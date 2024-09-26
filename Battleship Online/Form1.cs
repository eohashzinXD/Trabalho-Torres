using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship_Online
{
    public partial class Form1 : Form
    {

        private Button[,] botoesJogador = new Button[10, 10];
        private Button[,] botoesOponente = new Button[10, 10];
        private List<Point> naviosJogador = new List<Point>();
        private Adversario form2;
        private bool jogoIniciado = false;
        private int maxNavios = 5;
        private bool turnoJogador1 = true;

        public Form1()
        {
            InitializeComponent();
            CriarTabuleiro(panelJogador, botoesJogador, Jogador_Click); // Tabuleiro do jogador
            CriarTabuleiro(panelOponente, botoesOponente, Oponente_Click); // Tabuleiro do oponente
            form2 = new Adversario(this); // Passa o Form1 como parâmetro para o Form2
            form2.Show();

            // Adiciona o botão "Iniciar Jogo"
            Button iniciarJogoButton = new Button();
            iniciarJogoButton.Text = "Iniciar Jogo";
            iniciarJogoButton.Location = new Point(410, 150);
            iniciarJogoButton.Click += IniciarJogo_Click;
            this.Controls.Add(iniciarJogoButton);


        }

        private void CriarTabuleiro(Panel panel, Button[,] botoes, EventHandler eventoClick)
        {
            panel.Controls.Clear();
            int tamanhoBotao = 30;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    botoes[i, j] = new Button();
                    botoes[i, j].Size = new Size(tamanhoBotao, tamanhoBotao);
                    botoes[i, j].Location = new Point(i * tamanhoBotao, j * tamanhoBotao);
                    botoes[i, j].Tag = new Point(i, j); // Armazenar a coordenada no Tag do botão
                    botoes[i, j].Click += eventoClick;
                    panel.Controls.Add(botoes[i, j]);
                }
            }
        }

        // Evento quando o jogador clica em seu próprio tabuleiro (Jogador 1)
        private void Jogador_Click(object sender, EventArgs e)
        {
            if (jogoIniciado) return; // Se o jogo já começou, o jogador não pode posicionar navios

            Button botao = (Button)sender;
            Point coordenada = (Point)botao.Tag;

            if (naviosJogador.Count < maxNavios)
            {
                if (!naviosJogador.Contains(coordenada))
                {
                    naviosJogador.Add(coordenada);
                    botao.BackColor = Color.Blue; // Indica que um navio foi posicionado
                    MessageBox.Show($"Navio posicionado na célula {coordenada.X}, {coordenada.Y}");
                }
                else
                {
                    MessageBox.Show("Já existe um navio nessa posição!");
                }

                if (naviosJogador.Count == maxNavios)
                {
                    MessageBox.Show("Todos os navios foram posicionados. Aguarde o início do jogo.");
                }
            }
            else
            {
                MessageBox.Show("Você já posicionou todos os seus navios.");
            }
        }

        // Evento para o botão "Iniciar Jogo"
        private void IniciarJogo_Click(object sender, EventArgs e)
        {
            if (naviosJogador.Count == maxNavios && form2.NaviosPosicionados())
            {
                jogoIniciado = true;
                MessageBox.Show("O jogo começou! Agora você pode atacar o oponente.");
                form2.IniciarJogo(); // Notifica o Form2 que o jogo foi iniciado
            }
            else
            {
                MessageBox.Show("Aguarde ambos os jogadores posicionarem todos os navios.");
            }
        }

        // Evento quando o Jogador 1 clica no tabuleiro do oponente (Jogador 2)
        private void Oponente_Click(object sender, EventArgs e)
        {
            if (!jogoIniciado)
            {
                MessageBox.Show("O jogo ainda não começou!");
                return;
            }

            if (!turnoJogador1)
            {
                MessageBox.Show("Turno do jogador 2!");
                return;
            }

            Button botao = (Button)sender;
            Point coordenada = (Point)botao.Tag;

            // Notifica o Form2 (Jogador 2) do ataque
            form2.ReceberAtaque(coordenada);

            if (botao.BackColor == SystemColors.Control)
            {
                botao.BackColor = Color.Gray;
            }

            // Muda o turno para o Jogador 2
            turnoJogador1 = false;
            form2.TrocarTurno();
        }

        // Método chamado pelo Form2 para notificar um ataque recebido no Form1
        public void ReceberAtaque(Point coordenada)
        {
            if (naviosJogador.Contains(coordenada))
            {
                botoesJogador[coordenada.X, coordenada.Y].BackColor = Color.Red;
                MessageBox.Show($"Jogador 2 acertou um navio na célula {coordenada.X}, {coordenada.Y}!");
                naviosJogador.Remove(coordenada); // Remove o navio que foi atingido
            }
            else
            {
                MessageBox.Show($"Jogador 2 errou na célula {coordenada.X}, {coordenada.Y}!");
            }

            // Verificar se todos os navios foram destruídos
            if (naviosJogador.Count == 0)
            {
                MessageBox.Show("Todos os seus navios foram destruídos! Você perdeu.");
            }

            // Muda o turno para o Jogador 1
            turnoJogador1 = true;
        }

        // Método para iniciar o jogo (chamado pelo Form2)
        public void IniciarJogo()
        {
            jogoIniciado = true;
        }

        // Método chamado pelo Form2 para trocar o turno
        public void TrocarTurno()
        {
            turnoJogador1 = true;
        }

        // Retorna se todos os navios foram posicionados
        public bool NaviosPosicionados()
        {
            return naviosJogador.Count == maxNavios;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form2 = new Adversario(this);
            form2.Show();
        }
    }
}
