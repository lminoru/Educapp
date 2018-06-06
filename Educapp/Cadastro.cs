using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Educapp
{
    public partial class Cadastro : Form
    {
        String cs = Properties.Settings.Default.BDPRII17187ConnectionString;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("Usuário"))
                txtUsuario.Text = null;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(""))
                txtUsuario.Text = "Usuário";
        }

        private void txtApelido_Enter(object sender, EventArgs e)
        {
            if (txtApelido.Text.Equals("Apelido"))
                txtApelido.Text = null;
        }

        private void txtApelido_Leave(object sender, EventArgs e)
        {
            if (txtApelido.Text.Equals(""))
                txtApelido.Text = "Apelido";
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals("Senha"))
                txtSenha.Text = null;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals(""))
                txtSenha.Text = "Senha";
        }

        private void Cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection fc = Application.OpenForms; //fecha o formulario que ainda estiver aberto

            foreach (Form f in fc)
            {
                if (!f.Visible)
                    f.Close();
            }
        }

        private void btnCriar_Click(object sender, EventArgs e) 
        //salvar os dados dos textBox(s) no BD 
        {           
            if (txtUsuario.Text == "Usuário" || txtSenha.Text == "Senha" || txtApelido.Text == "Apelido")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            if(txtSenha.Text.Length < 8) // verifica se a senha digitada tem 8 ou mais caracteres
            {
                MessageBox.Show("Senha fraca." + "\n" + "Crie uma senha com mais caracteres para ter mais segurança. ");
                return;
            }

            int Resultado = 0;
            try
            {
                // cria conexao ao banco de dados
                SqlConnection con = new SqlConnection();
                cs = cs.Substring(cs.IndexOf("Data Source"));
                con.ConnectionString = cs;



                // cria comando de consulta ao SQL 
                string cmd_s = "INSERT INTO Jogador VALUES (@email, @apelido, @senha)";
                SqlCommand cmd = new SqlCommand(cmd_s, con);
                cmd.Parameters.AddWithValue("@email", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@apelido", txtApelido.Text);
                //codifica senha p/ verificar no banco          
                cmd.Parameters.AddWithValue("@senha", Criptografia.Codificar(txtSenha.Text));

                cmd.Connection = con;
                con.Open();
                Resultado = cmd.ExecuteNonQuery(); //Tudo que não dá retorno da tabela, usa-se este(ex: insert, delete, etc)
                con.Close();
                
            }
            catch (Exception erro)
            {
                //não mostrar erros ao usuário
            }
            finally
            {
                if (Resultado <= 0)
                {
                    MessageBox.Show("Email já cadastrado");
                }
                else
                {
                    //Cadastra e já loga no app
                    MessageBox.Show("Cadastro realizado com sucesso");
                    Principal prc = new Principal();
                    this.Hide();
                    prc.Show();
                }
            }

        }

        private void lblTitulo_MouseClick_1(object sender, MouseEventArgs e)
        {
            Logar log = new Logar();
            this.Hide();               // Se o usuario clicar no titulo ele sera levado para a pagína de login
            log.Show();

        }

        private void lblTitulo_MouseEnter_1(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = Color.MediumSlateBlue; // Altera a cor quando o mo  use esta em cima do título
        }

        private void lblTitulo_MouseLeave_1(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = Color.SlateBlue; // Altera a cor quando o mouse sai de cima do título
        }

        private void txtUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnCriar.PerformClick();
        }
    }
}
