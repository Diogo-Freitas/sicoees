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
    public partial class Agendamento : Form
    {
        public static string Tela, Data, Local, Hora, Nome, Horário, Aviso, Curso, Tipo;
        public static bool Disponivel, Feriado;
        public static int Resposta;

        public Agendamento()
        {
            InitializeComponent();
        }

        private void Agendamento_Load(object sender, EventArgs e)
        {
             Data = Calendario.SelectionStart.Date.ToShortDateString();
             CarregaEspacos();
             AtualizarForm();
        }

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            Data = Calendario.SelectionStart.Date.ToShortDateString();
            AtualizarForm();
        }

        private void CarregaEspacos()
        {
            try
            {
                Banco_de_DadosDataSetTableAdapters.EspaçoTableAdapter da = new Banco_de_DadosDataSetTableAdapters.EspaçoTableAdapter();
                cmbNome.DataSource = da.GetData();
                cmbNome.DisplayMember = "Nome";
                cmbNome.ValueMember = "idEspaço";
                cmbNome.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BuscaData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM [Datas] WHERE Data LIKE '" + Data + "'";
                cmd.Connection = conn;

                SqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                Feriado = false;
    
                if (dr.HasRows)
                {
                    dr.Read();
                    Feriado = true;
                    Aviso = dr["Nome"].ToString();
                    Tipo = dr["Tipo"].ToString();
                    labelAviso.ForeColor = Color.Green;
                    labelAviso.Text = "" + Aviso + "";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BuscaEspaço()
        {
            try
            {
                SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SELECT * FROM [Espaço] WHERE [idEspaço] = '" + Local + "'";
                cmd.Connection = conn;
                SqlDataReader dr;

                conn.Open();
                dr = cmd.ExecuteReader();
                Disponivel = true;
            
                if (dr.HasRows)
                {
                    dr.Read();
                    cmbNome.Text = dr["Nome"].ToString();
                    txtDescrição.Text = dr["Descrição"].ToString();
                    Disponivel = dr.GetBoolean(3);
                    if (Disponivel == false)
                    {
                        labelAviso.ForeColor = Color.Red;
                        labelAviso.Text = "Indisponível no Momento";
                    }
                }
                conn.Close();
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AtualizarForm()
        {
            labelAviso.Text = "";
            BuscaData();
            BuscaEspaço();
            textBox1.Text = BuscaNome("7");
            textBox2.Text = BuscaNome("8");
            textBox3.Text = BuscaNome("9");
            textBox4.Text = BuscaNome("10");
            textBox5.Text = BuscaNome("11");
            textBox6.Text = BuscaNome("12");
            textBox7.Text = BuscaNome("13");
            textBox8.Text = BuscaNome("14");
            textBox9.Text = BuscaNome("15");
            textBox10.Text = BuscaNome("16");
            textBox11.Text = BuscaNome("17");
            textBox12.Text = BuscaNome("18");
            textBox13.Text = BuscaNome("19");
            textBox14.Text = BuscaNome("20");
            textBox15.Text = BuscaNome("21");
        }

        private string BuscaNome(string Horário)
        {
                SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM [Agendamento] WHERE Data = '" + Data + "' AND Local = '" + Local + "' AND Horário = '" + Horário + "'";
                cmd.Connection = conn;

                SqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                Nome = "";
                if (dr.HasRows)
                {
                    dr.Read();
                    Tela = dr["Privilegiado"].ToString();
                    if (Tela == "Professor")
                    {
                        Aviso = dr["Nome"].ToString();
                        Curso = dr["Curso"].ToString();
                        Nome = "" + Aviso + " / " + Curso + "";
                    }
                    if (Tela == "Evento")
                    {
                        Nome = dr["Evento"].ToString();
                    }
                    if( Tela == "Pessoa")
                    {
                        Nome = dr["Nome"].ToString();
                    }
                }
                conn.Close();

                return Nome;
        }

        private void BuscaTela(string Horário)
        {
            try
            {
                SqlConnection conn = new SqlConnection(SICOEES.Properties.Settings.Default["Banco_de_DadosConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM [Agendamento] WHERE Data = '" + Data + "' AND Local = '" + Local + "' AND Horário = '" + Horário + "'";
                cmd.Connection = conn;

                SqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                Tela = "";
                if (dr.HasRows)
                {
                    dr.Read();
                    Tela = dr["Privilegiado"].ToString();
                    if (Tela == "Professor")
                    {
                        Prof form = new Prof();
                        form.ShowDialog();
                        AtualizarForm();
                    }
                    if (Tela == "Evento")
                    {
                        Event form = new Event();
                        form.ShowDialog();
                        AtualizarForm();
                    }
                    if(Tela == "Pessoa")
                    {
                        Simples form = new Simples();
                        form.ShowDialog();
                        AtualizarForm();
                    }
                }
            
                else
                {
                    if (Disponivel == true)
                    {
                        if (Feriado == false)
                        {
                            if (Calendario.SelectionStart < DateTime.Now.Date)
                            {
                                Resposta = Convert.ToInt32(MessageBox.Show("Esta data é anterior a atual.\nDeseja continuar? ", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                                if (Resposta == 6)
                                {
                                    Simples form = new Simples();
                                    form.ShowDialog();
                                    AtualizarForm();
                                }
                            }
                            else
                            {
                                Simples form = new Simples();
                                form.ShowDialog();
                                AtualizarForm();
                            }
                        }
                        else
                        {
                            Resposta = Convert.ToInt32(MessageBox.Show("Esta data está marcada como " + Tipo + ".\nDeseja continuar? ", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                            if (Resposta == 6)
                            {
                                Simples form = new Simples();
                                form.ShowDialog();
                                AtualizarForm();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("O Espaço está temporariamente indisponível para agendamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void textBox1_DoubleClick(object sender, EventArgs e)
        {  
            Hora = "7";
            BuscaTela(Hora);
        }
        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            Hora = "8";
            BuscaTela(Hora);
        }
        private void textBox3_DoubleClick(object sender, EventArgs e)
        {
            Hora = "9";
            BuscaTela(Hora);
        }
        private void textBox4_DoubleClick(object sender, EventArgs e)
        {
            Hora = "10";
            BuscaTela(Hora);
        }
        private void textBox5_DoubleClick(object sender, EventArgs e)
        {
            Hora = "11";
            BuscaTela(Hora);
        }
        private void textBox6_DoubleClick(object sender, EventArgs e)
        {
            Hora = "12";
            BuscaTela(Hora);
        }
        private void textBox7_DoubleClick(object sender, EventArgs e)
        {
            Hora = "13";
            BuscaTela(Hora);
        }
        private void textBox8_DoubleClick(object sender, EventArgs e)
        {
            Hora = "14";
            BuscaTela(Hora);
        }
        private void textBox9_DoubleClick(object sender, EventArgs e)
        {
            Hora = "15";
            BuscaTela(Hora);
        }
        private void textBox10_DoubleClick(object sender, EventArgs e)
        {
            Hora = "16";
            BuscaTela(Hora);
        }
        private void textBox11_DoubleClick(object sender, EventArgs e)
        {
            Hora = "17";
            BuscaTela(Hora);
        }
        private void textBox12_DoubleClick(object sender, EventArgs e)
        {
            Hora = "18";
            BuscaTela(Hora);
        }
        private void textBox13_DoubleClick(object sender, EventArgs e)
        {
            Hora = "19";
            BuscaTela(Hora);
        }
        private void textBox14_DoubleClick(object sender, EventArgs e)
        {
            Hora = "20";
            BuscaTela(Hora);
        }
        private void textBox15_DoubleClick(object sender, EventArgs e)
        {
            Hora = "21";
            BuscaTela(Hora);
        }

        private void Agendamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void trocarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.UsuarioConectado == "Admin")
            {
                Usuário form = new Usuário();
                form.ShowDialog();
                AtualizarForm();
            }
            else
            {
                MessageBox.Show("Acesso Negado!", "Aviso de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Agendamento_EnabledChanged(object sender, EventArgs e)
        {
            AtualizarForm();
        }

        private void adicionarOuRemoverEspaçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.UsuarioConectado == "Admin")
            {
                Espaco form = new Espaco();
                form.ShowDialog();
                CarregaEspacos();
            }
            else
            {
                MessageBox.Show("Acesso Negado!", "Aviso de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.NivelAcesso == "Administrador")
            {
                Professor form = new Professor();
                form.ShowDialog();
                AtualizarForm();
            }
            else
            {
                MessageBox.Show("Acesso Negado!", "Aviso de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void eventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.NivelAcesso == "Administrador")
            {
                Evento form = new Evento();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Acesso Negado!", "Aviso de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            Local = cmbNome.SelectedValue.ToString();
            BuscaEspaço();
            AtualizarForm();
        }

        private void datasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.NivelAcesso == "Administrador")
            {
                Datas form = new Datas();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Acesso Negado!", "Aviso de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void salvarBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login.NivelAcesso == "Administrador")
                {
                    SqlConnection.ClearAllPools();
                    saveFileDialog1.FileName = DateTime.Now.ToString("dd-MM-yyyy");
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (System.IO.File.Exists(saveFileDialog1.FileName + ".mdf"))
                        {
                            System.IO.File.Delete(saveFileDialog1.FileName + ".mdf");
                        }
                        if (System.IO.File.Exists(saveFileDialog1.FileName + "_log.ldf"))
                        {
                            System.IO.File.Delete(saveFileDialog1.FileName + "_log.ldf");
                        }
                        System.IO.File.Copy(Application.StartupPath.ToString() + "\\Banco de Dados.mdf", saveFileDialog1.FileName + ".mdf");
                        System.IO.File.Copy(Application.StartupPath.ToString() + "\\Banco de Dados_log.ldf", saveFileDialog1.FileName + "_log.ldf");

                        MessageBox.Show("Backup realizado com sucesso!!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Acesso Negado!", "Aviso de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void carregarBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login.UsuarioConectado == "Admin")
                {
                    SqlConnection.ClearAllPools();
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (System.IO.File.Exists(Application.StartupPath.ToString() + "\\Banco de Dados.mdf"))
                        {
                            System.IO.File.Delete(Application.StartupPath.ToString() + "\\Banco de Dados.mdf");
                        }
                        System.IO.File.Copy(openFileDialog1.FileName, Application.StartupPath.ToString() + "\\Banco de Dados.mdf");
                        if (openFileDialog2.ShowDialog() == DialogResult.OK)
                        {
                            if (System.IO.File.Exists(Application.StartupPath.ToString() + "\\Banco de Dados_log.ldf"))
                            {
                                System.IO.File.Delete(Application.StartupPath.ToString() + "\\Banco de Dados_log.ldf");
                            }
                            System.IO.File.Copy(openFileDialog2.FileName, Application.StartupPath.ToString() + "\\Banco de Dados_log.ldf");
                        }
                        MessageBox.Show("Backup restaurado com sucesso!!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Login.Start = "Old";
                        this.Hide();
                        Login form = new Login();
                        form.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Acesso Negado!", "Aviso de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trocarDeUsuárioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.Start = "Old";
            Login form = new Login();
            form.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info form = new Info();
            form.ShowDialog();
        }
    }
}
