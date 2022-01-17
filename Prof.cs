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
    public partial class Prof : Form
    {
        string id;
        int resposta;

        public Prof()
        {
            InitializeComponent();
        }

        private void Prof_Load(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
            BuscaAgendamento();
            if (Login.NivelAcesso == "Usuário")
            {
                btnSalvar.Enabled = false;
                btnExcluir.Enabled = false;
                btnLimpar.Enabled = false;
            }
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
                txtCurso.Text = dr["Curso"].ToString();
                txtDisciplina.Text = dr["Disciplina"].ToString();
                btnSalvar.Text = "Atualizar";
                btnExcluir.Enabled = true;
                pessoaToolStripMenuItem.Enabled = false;
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
                txtCurso.Text = txtCurso.Text.TrimStart();
                txtCurso.Text = txtCurso.Text.TrimEnd();
                txtDisciplina.Text = txtDisciplina.Text.TrimStart();
                txtDisciplina.Text = txtDisciplina.Text.TrimEnd();

                if (txtNome.Text == "" && txtCurso.Text == "" && txtDisciplina.Text == "")
                {
                    MessageBox.Show("Nome, Curso e Disciplina em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (txtNome.Text == "" && txtCurso.Text == "")
                {
                    MessageBox.Show("Nome e Curso em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (txtNome.Text == "" && txtDisciplina.Text == "")
                {
                    MessageBox.Show("Nome e Disciplina em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (txtCurso.Text == "" && txtDisciplina.Text == "")
                {
                    MessageBox.Show("Curso e Disciplina em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (txtNome.Text == "")
                {
                    MessageBox.Show("Nome em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (txtCurso.Text == "")
                {
                    MessageBox.Show("Disciplina em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (txtDisciplina.Text == "")
                {
                    MessageBox.Show("Disciplina em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    String cmdSql, strMensagem;

                    if (btnSalvar.Text == "Salvar")
                    {
                        cmdSql = "INSERT INTO Agendamento (Data, Local, Horário, Nome, Curso, Disciplina, Privilegiado) VALUES ('" + Agendamento.Data + "', '" + Agendamento.Local + "', '" + Agendamento.Hora + "', '" + txtNome.Text + "', '" + txtCurso.Text + "', '" + txtDisciplina.Text + "', 'Professor')";
                        strMensagem = "Agendamento salvo com sucesso!";
                    }

                    else
                    {
                        cmdSql = "UPDATE Agendamento SET Nome = '" + txtNome.Text + "', Curso = '" + txtCurso.Text + "', Disciplina = '" + txtDisciplina.Text + "' WHERE idAgendamento = " + id;
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
                resposta = Convert.ToInt32(MessageBox.Show("Pretende excluir agendamento?", "Mensagem", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));
                if (resposta == 6)
                {
                    SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
                    SqlCommand cmd = new SqlCommand("DELETE FROM Agendamento WHERE idAgendamento = " + id, conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Agendamento excluido com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtCurso.Text = "";
            txtDisciplina.Text = "";
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Simples form = new Simples();
            form.ShowDialog();
            this.Close();
        }

        private void eventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Event form = new Event();
            form.ShowDialog();
            this.Close();
        }

        private void simplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
