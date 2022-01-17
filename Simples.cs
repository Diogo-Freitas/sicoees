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
    public partial class Simples : Form
    {
        string id;
        int resposta;
       
        public Simples()
        {
            InitializeComponent();
        }

        private void Simples_Load(object sender, EventArgs e)
        {
            gpPagamento.Visible = false;
            btnExcluir.Enabled = false;
            BuscaAgendamento();
        }

        private void BuscaAgendamento()
        {
            SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM [Agendamento] WHERE Data LIKE '" + Agendamento.Data + "' AND Local LIKE '" + Agendamento.Local + "' AND Horário LIKE '" + Agendamento.Hora + "'";
            cmd.Connection = conn;
            SqlDataReader dr;

            conn.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                id = dr["idAgendamento"].ToString();
                txtNome.Text = dr["Nome"].ToString();
                txtDocumento.Text = dr["Documento"].ToString();
                ckMemorando.Checked = dr.GetBoolean(6);
                ckAluguel.Checked = dr.GetBoolean(7);
                txtValor.Text = dr["Valor"].ToString();
                btnSalvar.Text = "Atualizar";
                btnExcluir.Enabled = true;
                professorToolStripMenuItem.Enabled = false;
                eventoToolStripMenuItem.Enabled = false;

            }
            conn.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNome.Text = txtNome.Text.TrimStart();
                txtNome.Text = txtNome.Text.TrimEnd();
                txtDocumento.Text = txtDocumento.Text.TrimStart();
                txtDocumento.Text = txtDocumento.Text.TrimEnd();

                if(txtNome.Text == "" && txtDocumento.Text == "")
                {
                    MessageBox.Show("Nome e Documento em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (txtNome.Text == "")
                {
                    MessageBox.Show("Nome em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (txtDocumento.Text == "")
                {
                    MessageBox.Show("Documento em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    String cmdSql, strMensagem;

                    if (btnSalvar.Text == "Salvar")
                    {
                        cmdSql = "INSERT INTO Agendamento (Data, Local, Horário, Nome, Documento, Memorando, Aluguel, Valor, Privilegiado) VALUES ('" + Agendamento.Data + "', '" + Agendamento.Local + "', '" + Agendamento.Hora + "', '" + txtNome.Text + "', '" + txtDocumento.Text + "', '" + ckMemorando.Checked + "', '" + ckAluguel.Checked + "', '" + txtValor.Text + "', 'Pessoa')";
                        strMensagem = "Agendamento salvo com sucesso!";
                    }

                    else
                    {
                        cmdSql = "UPDATE Agendamento SET Nome = '" + txtNome.Text + "', Documento = '" + txtDocumento.Text + "', Memorando = '" + ckMemorando.Checked + "', Aluguel = '" + ckAluguel.Checked + "', Valor = '" + txtValor.Text + "' WHERE idAgendamento = " + id;
                        strMensagem = "Agendamento atualizado com sucesso!";
                    }

                    SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
                    SqlCommand cmd = new SqlCommand(cmdSql, conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show(strMensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSalvar.Text = "Salvar";
                    this.Close();
                }
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
                resposta = Convert.ToInt32(MessageBox.Show("Pretende excluir agendamento?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (resposta == 6)
                {
                    SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
                    SqlCommand cmd = new SqlCommand("DELETE FROM Agendamento WHERE idAgendamento = " + id, conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Agendamento excluido com sucesso!", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void ckAluguel_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAluguel.Checked == true)
            {
                gpPagamento.Visible = true;
            }
            else
            {
                gpPagamento.Visible = false;
                txtValor.Text = "";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtDocumento.Text = "";
            ckMemorando.Checked = false;
            ckAluguel.Checked = false;
            txtValor.Text = "";
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.NivelAcesso == "Administrador")
            {
                Prof form = new Prof(); 
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Acesso Negado!", "Aviso de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void eventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Event form = new Event();
            form.ShowDialog ();
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
