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
    public partial class Logar : Form
    {
        String cs = Properties.Settings.Default.BDPRII17187ConnectionString;
        public Logar()
        {
            InitializeComponent();
        }

        private void linkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro cds = new Cadastro();
            this.Hide();
            cds.Show();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "Usuário" || txtSenha.Text == "Senha")
            {
                MessageBox.Show("Digite a senha ou o usuário");
                return;
            }

            try
            {
                // cria conexao ao banco de dados
                SqlConnection con = new SqlConnection();
                cs = cs.Substring(cs.IndexOf("Data Source"));
                con.ConnectionString = cs;



                // cria comando de consulta ao SQL 
                string cmd_s = "Select * from Jogador where email=@email and senha=@senha";
                SqlCommand cmd = new SqlCommand(cmd_s, con);
                cmd.Parameters.AddWithValue("@email", txtUsuario.Text);
                //codifica senha p/ verificar no banco          
                cmd.Parameters.AddWithValue("@senha", Criptografia.Codificar(txtSenha.Text));

                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adapt.Fill(ds);
                con.Close();

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //Loga no app
                    MessageBox.Show("Usuário autorizado!");
                    Principal prc = new Principal();
                    this.Hide();
                    prc.Show();
                }
                else
                    MessageBox.Show("Usuário não autorizado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void Logar_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection fc = Application.OpenForms; //fecha o formulario que ainda estiver aberto

            foreach (Form f in fc)
            {
                if (!f.Visible)
                    f.Close();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogar.PerformClick();
        }
    }
}
