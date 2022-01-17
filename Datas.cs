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
    public partial class Datas : Form
    {
        string ID, Data,Tipo;
        int resposta;

        public Datas()
        {
            InitializeComponent();
            LimpaForm();
        }

        private void Datas_Load(object sender, EventArgs e)
        {
            Data = Calendario.SelectionStart.Date.ToShortDateString();
            CarregaDatas(); 
        }

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            Data = Calendario.SelectionStart.Date.ToShortDateString();
        }

        private void LimpaForm()
        {
            CarregaDatas();
            txtNome.Text = "";
            cmbTipo.SelectedIndex = 0;
            Calendario.SelectionStart = DateTime.Now.Date;
            Calendario.SelectionEnd = DateTime.Now.Date;
            btnSalvar.Text = "Salvar";
        }

        private void BuscaData()
        {
            SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM [Datas] WHERE idData = '" + ID + "'";
            cmd.Connection = conn;

            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                txtNome.Text = dr["Nome"].ToString();
                Tipo = dr["Tipo"].ToString();
                if (Tipo == "Feriado")
                {
                    cmbTipo.SelectedIndex = 0;
                }
                else if (Tipo == "Recesso")
                {
                    cmbTipo.SelectedIndex = 1;
                }
                else if (Tipo == "Paralisação")
                {
                    cmbTipo.SelectedIndex = 2;
                }
                else
                {
                    cmbTipo.SelectedIndex = 3;
                }
                Data = dr["Data"].ToString();
                DateTime data = DateTime.Parse(Data);
                Data = data.ToShortDateString();
                Calendario.SelectionStart = Convert.ToDateTime(Data);
                Calendario.SelectionEnd = Convert.ToDateTime(Data);
                btnSalvar.Text = "Novo";
            }
            conn.Close();
        }

        private void CarregaDatas()
        {
            Banco_de_DadosDataSetTableAdapters.DatasTableAdapter da = new Banco_de_DadosDataSetTableAdapters.DatasTableAdapter();
            listFixo.DataSource = da.GetData();
            listFixo.DisplayMember = "Nome";
            listFixo.ValueMember = "idData";
            listFixo.Refresh();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSalvar.Text == "Salvar")
                {
                    txtNome.Text = txtNome.Text.TrimStart();
                    txtNome.Text = txtNome.Text.TrimEnd();
                    if (txtNome.Text == "")
                    {
                        MessageBox.Show("Nome da Data em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        String cmdSql;
                        cmdSql = "INSERT INTO Datas (Nome, Data, Tipo) VALUES ('" + txtNome.Text + "', '" + Data + "', '" + cmbTipo.Text + "')";

                        SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
                        SqlCommand cmd = new SqlCommand(cmdSql, conn);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Data salva com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpaForm();
                    }
                }
                else
                {
                    LimpaForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listFixo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = listFixo.SelectedValue.ToString();
            BuscaData();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                resposta = Convert.ToInt32(MessageBox.Show("Pretende excluir data?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (resposta == 6)
                {
                    SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
                    SqlCommand cmd = new SqlCommand("DELETE FROM Datas WHERE idData = " + ID, conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Data excluída com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaForm();
                }
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
