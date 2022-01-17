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
    public partial class Professor : Form
    {
        string Hora, Data, Local, Semana, SemanaAtual;
        int i, n, Resposta,Cont;

        public Professor()
        {
            InitializeComponent();
            
        }

        private void Professor_Load(object sender, EventArgs e)
        {
            this.espaçoTableAdapter.Fill(this.banco_de_DadosDataSet.Espaço);
            radSegunda.Checked = true;
            Local = "1";          
        }

        private void cmbLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Local = cmbLocal.SelectedValue.ToString();
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
                    MessageBox.Show("Curso em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (txtDisciplina.Text == "")
                {
                    MessageBox.Show("Disciplina em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DateTime Inicio = DateTimeInicio.Value.Date;
                    DateTime Fim = DateTimeFim.Value.Date;
                    TimeSpan ts = Fim.Subtract(Inicio);

                    n = ts.Days;
                    Cont = 0;

                    if (Inicio == Fim)
                    {
                        MessageBox.Show("A data de início e término do período são iguais.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Inicio > Fim)
                    {
                        MessageBox.Show("A data de término do período é anterior a de Início.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (Inicio < DateTime.Now.Date)
                        {
                            Resposta = Convert.ToInt32(MessageBox.Show("A data de início do período é anterior a data atual.\nDeseja continuar? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                            if (Resposta == 6)
                            {
                                SelecionaSemana();
                                FazAgendamento();
                            }
                        }
                        else
                        {
                            SelecionaSemana();
                            FazAgendamento();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
               
        private void FazAgendamento()
        {
            
            for (i = 0; i <= n; i++)
            {
                DateTime Inicio = DateTimeInicio.Value.Date;
                Inicio = Inicio.AddDays(i);
                Data = Inicio.Date.ToString("d/M/yyyy");
                SemanaAtual = Inicio.DayOfWeek.ToString();
                if (SemanaAtual == Semana)
                {
                    SelecionaHoras();
                }
            }
            if (Cont == 0)
            {
                MessageBox.Show("Nenhum agendamento foi feito!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Agendamentos feitos com sucesso!!!\nTotal de Agendamentos: " + Cont + "", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Salvar()
        {
            String cmdSql;

            cmdSql = "INSERT INTO Agendamento (Data, Local, Horário, Nome, Curso, Disciplina, Privilegiado) VALUES ('" + Data + "', '" + Local + "', '" + Hora + "', '" + txtNome.Text + "', '" + txtCurso.Text + "', '" + txtDisciplina.Text + "', 'Professor')";

            SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
            SqlCommand cmd = new SqlCommand(cmdSql, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Cont++;
        }
        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            radSegunda.Checked = true;
            DateTimeInicio.Value = DateTime.Today;
            DateTimeFim.Value = DateTime.Today;
            txtNome.Text = "";
            txtCurso.Text = "";
            txtDisciplina.Text = "";
            Local = "1";
            ck7.Checked = false;
            ck8.Checked = false;
            ck9.Checked = false;
            ck10.Checked = false;
            ck11.Checked = false;
            ck12.Checked = false;
            ck13.Checked = false;
            ck14.Checked = false;
            ck15.Checked = false;
            ck16.Checked = false;
            ck17.Checked = false;
            ck18.Checked = false;
            ck19.Checked = false;
            ck20.Checked = false;
            ck21.Checked = false;

        }

        private void SelecionaSemana()
        {
            if (radSegunda.Checked == true)
            {
                Semana = DayOfWeek.Monday.ToString();
            }
            if (radTerça.Checked == true)
            {
                Semana = DayOfWeek.Tuesday.ToString();
            }
            if (radQuarta.Checked == true)
            {
                Semana = DayOfWeek.Wednesday.ToString();
            }
            if (radQuinta.Checked == true)
            {
                Semana = DayOfWeek.Thursday.ToString();
            }
            if (radSexta.Checked == true)
            {
                Semana = DayOfWeek.Friday.ToString();
            }
            if (radSábado.Checked == true)
            {
                Semana = DayOfWeek.Saturday.ToString();
            }
        }

        private void SelecionaHoras()
        {
            if (ck7.Checked == true)
            {
                Hora = "7";
                Salvar();  
            }
            if (ck8.Checked == true)
            {
                Hora = "8";
                Salvar();  
            }
            if (ck9.Checked == true)
            {
                Hora = "9";
                Salvar();  
            }
            if (ck10.Checked == true)
            {
                Hora = "10";
                Salvar();  
            }
            if (ck11.Checked == true)
            {
                Hora = "11";
                Salvar();  
            }
            if (ck12.Checked == true)
            {
                Hora = "12";
                Salvar();  
            }
            if (ck13.Checked == true)
            {
                Hora = "13";
                Salvar();
            }
            if (ck14.Checked == true)
            {
                Hora = "14";
                Salvar();
            }
            if (ck15.Checked == true)
            {
                Hora = "15";
                Salvar();
            }
            if (ck16.Checked == true)
            {
                Hora = "16";
                Salvar();
            }
            if (ck17.Checked == true)
            {
                Hora = "17";
                Salvar();
            }
            if (ck18.Checked == true)
            {
                Hora = "18";
                Salvar();
            }
            if (ck19.Checked == true)
            {
                Hora = "19";
                Salvar();
            }
            if (ck20.Checked == true)
            {
                Hora = "20";
                Salvar();
            }
            if (ck21.Checked == true)
            {
                Hora = "21";
                Salvar();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
