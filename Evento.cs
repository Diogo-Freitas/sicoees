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
    public partial class Evento : Form
    {
        string Data, Local, Hora;
        bool Status;
        int Resposta, Cont;
        public Evento()
        {
            InitializeComponent();
        }

        private void Evento_Load(object sender, EventArgs e)
        {
            CarregaEspacos();
            Data = Calendario.SelectionStart.Date.ToShortDateString();
            Local = "1";
            BuscaEspaço();
        }

        private void CarregaEspacos()
        {
            Banco_de_DadosDataSetTableAdapters.EspaçoTableAdapter da = new Banco_de_DadosDataSetTableAdapters.EspaçoTableAdapter();
            cmbNome.DataSource = da.GetData();
            cmbNome.DisplayMember = "Nome";
            cmbNome.ValueMember = "idEspaço";
            cmbNome.Refresh();
        }

        private void BuscaEspaço()
        {
            SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM [Espaço] WHERE [idEspaço] = '" + Local + "'";
            cmd.Connection = conn;
            SqlDataReader dr;

            conn.Open();
            dr = cmd.ExecuteReader();
            Status = true;
            txtDescrição.BackColor = Color.White;
            if (dr.HasRows)
            {
                dr.Read();
                cmbNome.Text = dr["Nome"].ToString();
                txtDescriçãoLocal.Text = dr["Descrição"].ToString();
                Status = dr.GetBoolean(3);
            }
            conn.Close();
        }

        private void cmbNome_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Local = cmbNome.SelectedValue.ToString();
            BuscaEspaço();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNome.Text = txtNome.Text.TrimStart();
                txtNome.Text = txtNome.Text.TrimEnd();
                txtEvento.Text = txtEvento.Text.TrimStart();
                txtEvento.Text = txtEvento.Text.TrimEnd();

                if (txtNome.Text == "" && txtEvento.Text == "")
                {
                    MessageBox.Show("Nome e Evento em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (txtNome.Text == "")
                {
                    MessageBox.Show("Nome em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (txtEvento.Text == "")
                {
                    MessageBox.Show("Evento em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Cont = 0;
                    if (Calendario.SelectionStart < DateTime.Now.Date)
                    {
                        Resposta = Convert.ToInt32(MessageBox.Show("A data selecionada é anterior a data atual.\nDeseja continuar? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                        if (Resposta == 6)
                        {
                            SelecionaHoras();
                            if (Cont == 0)
                            {
                                MessageBox.Show("Nenhum agendamento foi salvo.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Agendamentos salvo com sucesso!\nTotal de agendamentos " + Cont + "", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                    else
                    {
                        SelecionaHoras();
                        if (Cont == 0)
                        {
                            MessageBox.Show("Nenhum agendamento foi salvo.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Agendamentos salvo com sucesso!\nTotal de agendamentos " + Cont + "", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Salvar()
        {
                String cmdSql;
                cmdSql = "INSERT INTO Agendamento (Data, Local, Horário, Nome, Evento,Descrição, Privilegiado) VALUES ('" + Data + "', '" + Local + "', '" + Hora + "', '" + txtNome.Text + "', '" + txtEvento.Text + "', '" + txtDescrição.Text + "', 'Evento')";

                SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand(cmdSql, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                Cont++;
                btnSalvar.Text = "Salvar";
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

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            Data = Calendario.SelectionStart.Date.ToShortDateString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEvento.Text = "";
            txtDescrição.Text = "";
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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
