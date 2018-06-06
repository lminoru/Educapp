using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis; //sintetizador de voz

namespace Educapp
{
    public partial class Principal : Form
    {
        private Boolean respondendo = false;
        private static SpeechSynthesizer synthesizer;
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection fc = Application.OpenForms; //fecha o formulario que ainda estiver aberto

            foreach (Form f in fc)
            {
                if (!f.Visible)
                    f.Close();
            }
        }

        private void Principal_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Muda posição do personagem através do teclado (tecla a para esquerda e tecla d para direita)
            if ((e.KeyChar.ToString().Equals("a") || (Keys)e.KeyChar == Keys.Right) && pbPersonagem.Location.X != 9)
                pbPersonagem.Location = new Point(pbPersonagem.Location.X - 85, pbPersonagem.Location.Y);
            
            if (e.KeyChar.ToString().Equals("d") && pbPersonagem.Location.X != 179)
                pbPersonagem.Location = new Point(pbPersonagem.Location.X + 85, pbPersonagem.Location.Y);

            //Posições possiveis do personagem:   9; 14 RAIA A
                                             //  94; 14 RAIA B
                                             // 179; 15 RAIA C


            if ( (Keys)e.KeyChar == Keys.Space && pnRaia.Visible)//Enter da pause no jogo
            {
                //parar de falar
                synthesizer.Pause();

                timer.Stop();
                timer2.Stop();
                MessageBox.Show("PRESS [ENTER] TO RESUME", "PAUSED");
                timer.Start();
                timer2.Start();

                //Retorna a falar
                synthesizer.Resume();
            }

        }


        private void timer_Tick(object sender, EventArgs e)
        {
            //distancia de metade da raia entre um obstaculo e outro
            if (pbObstaculo.Location.Y == 230)
            {
                timer2.Enabled = true;
                timer2.Start();
            }

            //perdeu
            if (pbObstaculo.Location.Y < pbPersonagem.Location.Y + 65 && pbObstaculo.Location.X == pbPersonagem.Location.X)
            {
                if (respondendo)
                {
                    respondendo = false;

                    synthesizer.SpeakAsync("Correto");


                    pbObstaculo.BackgroundImage = Educapp.Properties.Resources.obstaculo;
                    pbObstaculo2.BackgroundImage = Educapp.Properties.Resources.obstaculo;

                    pbObstaculo.Location = new Point(94, 460);
                    pbObstaculo2.Location = new Point(9, 460);
                    

                    i += 10;

                    timer.Stop();
                    pnRaia.BackgroundImage = Educapp.Properties.Resources.raiaCerto;
                    
                }
                else
                {
                    timer.Stop();
                    timer2.Stop();

                    perdeu();
                }


            }
            else 
                if (pbObstaculo.Location.Y == -40)//obstaculo não encostou no personagem
                {
                    pbObstaculo.Location = new Point(pbPersonagem.Location.X, 460);
                }
            this.pbObstaculo.Location = new Point(pbObstaculo.Location.X, pbObstaculo.Location.Y - 5);
            //obstaculo movimento


            
        }
    

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pbObstaculo2.Location.Y < pbPersonagem.Location.Y + 65 && pbObstaculo2.Location.X == pbPersonagem.Location.X)
            {
                if (respondendo /*&& alternativaCerta()*/)
                {
                    respondendo = false;

                    synthesizer.SpeakAsync("Correto");


                    pbObstaculo.BackgroundImage  = Educapp.Properties.Resources.obstaculo;
                    pbObstaculo2.BackgroundImage = Educapp.Properties.Resources.obstaculo;

                    pbObstaculo.Location = new Point(94, 460);
                    pbObstaculo2.Location = new Point(9, 460);

                    

                    //ponto por responder certo
                    i += 10;

                    timer.Stop();
                    pnRaia.BackgroundImage = Educapp.Properties.Resources.raiaCerto;
                }
                else
                {
                    timer.Stop();
                    timer2.Stop();

                    perdeu();
                }
   
            }
            else
                if (pbObstaculo2.Location.Y == -40)
                {
                    Random rad = new Random();

                    int[] i = new int[2]; // vetor com as posições X das raias

                    if (pbObstaculo.Location.X == 9)
                    {
                        i[0] = 94;
                        i[1] = 179;
                    }
                    else
                        if (pbObstaculo.Location.X == 94)
                        {
                            i[0] = 9;
                            i[1] = 179;
                        }
                        else
                        {
                            i[0] = 9;
                            i[1] = 94;
                        }
                        
                     pbObstaculo2.Location = new Point(i[rad.Next(0, 2)], 460);
                }

            this.pbObstaculo2.Location = new Point(pbObstaculo2.Location.X, pbObstaculo2.Location.Y - 5);
        }

        private void perdeu ()
        {
            pnRaia.Visible = false;

            lbLose.Visible = true;
            timer1.Start();
            btnReiniciar.Visible = true;
            btnVoltar.Visible = true;

            //parar de falar
            synthesizer.Pause();


            //parar e mostrar pontuação
            tmPontuacao.Stop();
            lblPontuacao.Visible = false;
            lblConsolacao.Text = i + " pontos";
            if (i >= 15 && i<30)
                lblConsolacao.ForeColor = Color.Gold;
            if (i >= 30)
                lblConsolacao.ForeColor = Color.Lime;
            lblConsolacao.Visible = true;

            pbObstaculo.Location = new Point(94, 460);
            pbObstaculo2.Location = new Point(9, 460);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            /*
            Random cor = new Random();
            lbLose.ForeColor = Color.FromArgb(cor.Next(0,255), cor.Next(0, 255), cor.Next(0, 255));
            */
            if (lbLose.ForeColor == Color.Black)
            {
                lbLose.ForeColor = Color.Red;
            }
            else
                lbLose.ForeColor = Color.Black;

        }

        private int i = 0;
        private void tmPontuacao_Tick(object sender, EventArgs e)
        {
            i++;
            lblPontuacao.Text = i.ToString("000000");

            if (i == 2) 
            {
                String pergunta = "Qual é a capital da Austrália?";
                String[] alternativa = { "Camberra", "Sidney", "Adelaide" };
                synthesizer.SpeakAsync(pergunta);


                //pnRaia.BackgroundImage = Educapp.Properties.Resources.raiaA;
                synthesizer.SpeakAsync("Alternativa a ... ... ...");
                synthesizer.SpeakAsync(alternativa[0]);



                //pnRaia.BackgroundImage = Educapp.Properties.Resources.raiaB;
                synthesizer.SpeakAsync("Alternativa b ... ... ...");
                synthesizer.SpeakAsync(alternativa[1]); 




                //pnRaia.BackgroundImage = Educapp.Properties.Resources.raiaC;
                synthesizer.SpeakAsync("Alternativa c ... ... ...");
                synthesizer.SpeakAsync(alternativa[2]);


                //pnRaia.BackgroundImage = Educapp.Properties.Resources.raia;
                //tmPontuacao.Stop();
            }

            if (i == 14)
            {
                respondendo = true;
                pbObstaculo.BackgroundImage  = Educapp.Properties.Resources.A;
                pbObstaculo2.BackgroundImage = Educapp.Properties.Resources.B;
            }

            if (i == 19 && respondendo)
            {
                perdeu();
            }

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lbLose.Visible = false;
            btnReiniciar.Visible = false;
            btnVoltar.Visible = false;
            lblPontuacao.Visible = true;
            lblConsolacao.Visible = false;
            

            pnRaia.Visible = true;
            

            //objetos voltam a se mexer
            timer.Start();


            //reinicia contador de pontos e starta pontuação
            i = 0;
            tmPontuacao.Start();

            //starta posição do personagem no meio da raia
            pbPersonagem.Location = new Point(94, 15);

            //retorna o foco
            this.Focus();


        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Leo Minoru\Music\SAMAHTA - graffiti (feat. Melody Federer).wav");
            simpleSound.Play();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //playSimpleSound();  //play na trilha sonora

            synthesizer = new SpeechSynthesizer(); //instancia o leitor de perguntas
            
           // while (!synthesizer.State.ToString().Equals("Ready")) { } //espera carregar 
        }  
    }
}
