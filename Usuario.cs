using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SICOEES
{
    public partial class Usuário : Form
    {
        string Nivel,id;
        int resposta;
        bool ok;
        public Usuário()
        {
            InitializeComponent();
        }

        private void Usuário_Load(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            CarregaUsuário();
            BuscaUsuário();
        }
        private void CarregaUsuário()
        {
            Banco_de_DadosDataSetTableAdapters.UsuárioTableAdapter da = new Banco_de_DadosDataSetTableAdapters.UsuárioTableAdapter();
            cmbNome.DataSource = da.GetData();
            cmbNome.DisplayMember = "Nome";
            cmbNome.ValueMember = "idUsuário";
            cmbNome.Refresh();
            btnExcluir.Text = "Excluir";
        }
       
        private void BuscaUsuário()
        {
            SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM [Usuário] WHERE [idUsuário] = '" + id + "'";
            cmd.Connection = conn;
            SqlDataReader dr;

            conn.Open();
            dr = cmd.ExecuteReader();
            btnExcluir.Enabled = true;
            cmbNivel.Enabled = true;
            if (dr.HasRows)
            {
                dr.Read();
                cmbNome.Text = dr["Nome"].ToString();
                Nivel = dr["Nível Acesso"].ToString();
                if (Nivel == "Administrador")
                {
                    cmbNivel.SelectedIndex = 0;
                }
                if (Nivel == "Usuário")
                {
                    cmbNivel.SelectedIndex = 1;
                }
                txtSenha.Text = dr["Senha"].ToString();
                txtRepita.Text = dr["Senha"].ToString();
                btnSalvar.Text = "Atualizar";
                if (cmbNome.Text == "Admin")
                {
                    btnExcluir.Enabled = false;
                    cmbNivel.Enabled = false;
                }
            }
            conn.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox3.Visible = true;
            btnNovo.Enabled = false;
            txtNome.Text = "";
            cmbNivel.SelectedIndex = 1;
            txtSenha.Text = "";
            txtRepita.Text = "";
            btnSalvar.Text = "Salvar";
            btnExcluir.Enabled = true;
            btnExcluir.Text = "Cancelar";
            cmbNivel.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnExcluir.Text == "Excluir")
                {
                    resposta = Convert.ToInt32(MessageBox.Show("Deseja excluir usuário?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                    if (resposta == 6)
                    {
                        SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
                        SqlCommand cmd = new SqlCommand("DELETE FROM Usuário WHERE idUsuário = " + id, conn);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Usuário excluido com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnExcluir.Text = "Excluir";
                    }
                }
                groupBox1.Visible = true;
                groupBox3.Visible = false;
                btnNovo.Enabled = true;
                btnExcluir.Text = "Excluir";
                CarregaUsuário();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNome.Text = txtNome.Text.TrimStart();
                txtNome.Text = txtNome.Text.TrimEnd();

                if (txtSenha.Text == txtRepita.Text && txtSenha.Text != "")
                {
                    String cmdSql;
                    if (btnSalvar.Text == "Salvar")
                    {
                        BuscaNome();
                        if (ok == true)
                        {
                            if (txtNome.Text == "")
                            {
                                MessageBox.Show("Nome em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                cmdSql = "INSERT INTO Usuário (Nome, [Nível Acesso], Senha) VALUES ('" + txtNome.Text + "', '" + cmbNivel.Text + "', '" + txtSenha.Text + "')";
                                SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
                                SqlCommand cmd = new SqlCommand(cmdSql, conn);

                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("Usuário salvo com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                groupBox1.Visible = true;
                                groupBox3.Visible = false;
                                btnNovo.Enabled = true;
                                btnSalvar.Text = "Salvar";
                                CarregaUsuário();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário já cadastrado!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        cmdSql = "UPDATE Usuário SET [Nível Acesso] = '" + cmbNivel.Text + "', Senha = '" + txtSenha.Text + "' WHERE [idUsuário] LIKE '" + id + "'";

                        SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
                        SqlCommand cmd = new SqlCommand(cmdSql, conn);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Usuário atualizado com sucesso!!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        groupBox1.Visible = true;
                        groupBox3.Visible = false;
                        btnNovo.Enabled = true;
                        btnSalvar.Text = "Salvar";
                        CarregaUsuário();
                    }
                }
                else
                {
                    if (txtSenha.Text == "")
                    {
                        MessageBox.Show("Senha em branco!", "Aviso de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Senha e Repita senha estão diferentes!", "Aviso de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BuscaNome()
        {
            SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Usuário WHERE Nome LIKE '" + txtNome.Text + "'";
            cmd.Connection = conn;
            SqlDataReader dr;
            ok = true;
            conn.Open();
            dr = cmd.ExecuteReader();
            btnExcluir.Enabled = true;
            if (dr.HasRows)
            {
                dr.Read();
                ok = false;
            }
            conn.Close();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                id = cmbNome.SelectedValue.ToString();
                BuscaUsuário();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
