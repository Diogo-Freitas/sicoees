using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace SICOEES
{
    public partial class Login : Form
    {
        public static string NivelAcesso;
        public static string UsuarioConectado;
        public static string Start;
        public Login()
        {
            if (Start == "Old")
            {
                InitializeComponent();
            }
            else
            {
                Thread t = new Thread(new ThreadStart(SplashScreen));
                t.Start();
                Thread.Sleep(3000);
                t.Abort();
                InitializeComponent();
            }
        }

        public void SplashScreen()
        {
            Application.Run(new Splash());
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                this.usuárioTableAdapter.Fill(this.banco_de_DadosDataSet.Usuário);
                this.AcceptButton = btnConectar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM [Usuário] WHERE Nome = '" + cmbUsuario.Text + "' AND Senha = '" + txtSenha.Text + "'";
            cmd.Connection = conn;
            SqlDataReader dr;

            conn.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                UsuarioConectado = cmbUsuario.Text;
                NivelAcesso = dr["Nível Acesso"].ToString();
                this.Hide();
                Agendamento form = new Agendamento();
                form.Show();
                
            }

            else
            {
                MessageBox.Show("Usuário e/ou senha incorretas", "Aviso de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Text = "";
            }
            conn.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
