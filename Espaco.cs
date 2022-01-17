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
    public partial class Espaco : Form
    {
        string id;
        int resposta;
        public Espaco()
        {
            InitializeComponent();
        }

        private void Espaco_Load(object sender, EventArgs e)
        {
            txtNome.Visible = false;
            CarregaEspaco();
            id = "1";
            BuscaEspaço();
            
        }

        private void CarregaEspaco()
        {
            Banco_de_DadosDataSetTableAdapters.EspaçoTableAdapter da = new Banco_de_DadosDataSetTableAdapters.EspaçoTableAdapter();
            cmbNome.DataSource = da.GetData();
            cmbNome.DisplayMember = "Nome";
            cmbNome.ValueMember = "idEspaço";
            cmbNome.Refresh();
            btnExcluir.Text = "Excluir";
        }

        private void BuscaEspaço()
        {
            SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM [Espaço] WHERE [idEspaço] = '" + id + "'";
            cmd.Connection = conn;
            SqlDataReader dr;

            conn.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                cmbNome.Text = dr["Nome"].ToString();
                txtDescrição.Text = dr["Descrição"].ToString();
                ckDisponivel.Checked = dr.GetBoolean(3);
                btnSalvar.Text = "Atualizar";
            }
            conn.Close();
        }

        private void cmbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                id = cmbNome.SelectedValue.ToString();
                BuscaEspaço();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cmbNome.Visible = false;
            txtNome.Visible = true;
            btnNovo.Enabled = false;
            txtNome.Text = "";
            txtDescrição.Text = "";
            btnSalvar.Text = "Salvar";
            btnExcluir.Text = "Cancelar";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                String cmdSql, strMensagem;
                if (btnSalvar.Text == "Salvar")
                {
                    cmdSql = "INSERT INTO Espaço (Nome, Descrição, Status) VALUES ('" + txtNome.Text + "', '" + txtDescrição.Text + "', '" + ckDisponivel.Checked + "')";
                    strMensagem = "Espaço salvo com sucesso!";
                }

                else
                {
                    cmdSql = "UPDATE Espaço SET Descrição = '" + txtDescrição.Text + "', Status = '" + ckDisponivel.Checked + "' WHERE [idEspaço] LIKE '" + id + "'";
                    strMensagem = "Espaço atualizado com sucesso!";
                }
                SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand(cmdSql, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show(strMensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbNome.Visible = true;
                txtNome.Visible = false;
                btnNovo.Enabled = true;
                btnSalvar.Text = "Salvar";
                CarregaEspaco();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnExcluir.Text == "Excluir")
                {
                    resposta = Convert.ToInt32(MessageBox.Show("Pretende excluir Espaço?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                    if (resposta == 6)
                    {
                        resposta = Convert.ToInt32(MessageBox.Show("AVISO: Todos os agendamentos desse espaço serão excluidos permanentemente.\nDeseja continuar?", "Excluir Espaço e Agendamentos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
                        if (resposta == 6)
                        {
                            ExcluirAgendamentos();
                            SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
                            SqlCommand cmd = new SqlCommand("DELETE FROM Espaço WHERE idEspaço = " + id, conn);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Espaço excluido com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnExcluir.Text = "Excluir";
                        }
                    }
                }
                cmbNome.Visible = true;
                txtNome.Visible = false;
                btnNovo.Enabled = true;
                btnExcluir.Text = "Excluir";
                CarregaEspaco();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExcluirAgendamentos()
        {
            try
            {
                SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand("DELETE FROM Agendamento WHERE Local = " + id, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
