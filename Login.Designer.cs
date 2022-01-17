namespace SICOEES
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.usuárioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco_de_DadosDataSet = new SICOEES.Banco_de_DadosDataSet();
            this.bannerTelaLogin = new System.Windows.Forms.PictureBox();
            this.usuárioTableAdapter = new SICOEES.Banco_de_DadosDataSetTableAdapters.UsuárioTableAdapter();
            senhaLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuárioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_de_DadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerTelaLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(92, 65);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 4;
            senhaLabel.Text = "Senha:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(87, 32);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 0;
            usuarioLabel.Text = "Usuário:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(senhaLabel);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(usuarioLabel);
            this.groupBox1.Controls.Add(this.cmbUsuario);
            this.groupBox1.Location = new System.Drawing.Point(35, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 145);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insira o Login:";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(205, 105);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(105, 105);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(145, 65);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(120, 20);
            this.txtSenha.TabIndex = 0;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUsuario.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuárioBindingSource, "idUsuário", true));
            this.cmbUsuario.DataSource = this.usuárioBindingSource;
            this.cmbUsuario.DisplayMember = "Nome";
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(145, 30);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(120, 21);
            this.cmbUsuario.TabIndex = 3;
            this.cmbUsuario.ValueMember = "idUsuário";
            // 
            // usuárioBindingSource
            // 
            this.usuárioBindingSource.DataMember = "Usuário";
            this.usuárioBindingSource.DataSource = this.banco_de_DadosDataSet;
            // 
            // banco_de_DadosDataSet
            // 
            this.banco_de_DadosDataSet.DataSetName = "Banco_de_DadosDataSet";
            this.banco_de_DadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bannerTelaLogin
            // 
            this.bannerTelaLogin.Image = ((System.Drawing.Image)(resources.GetObject("bannerTelaLogin.Image")));
            this.bannerTelaLogin.Location = new System.Drawing.Point(-1, 0);
            this.bannerTelaLogin.Name = "bannerTelaLogin";
            this.bannerTelaLogin.Size = new System.Drawing.Size(458, 87);
            this.bannerTelaLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bannerTelaLogin.TabIndex = 2;
            this.bannerTelaLogin.TabStop = false;
            // 
            // usuárioTableAdapter
            // 
            this.usuárioTableAdapter.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 257);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bannerTelaLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuárioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_de_DadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerTelaLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox bannerTelaLogin;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private Banco_de_DadosDataSet banco_de_DadosDataSet;
        private System.Windows.Forms.BindingSource usuárioBindingSource;
        private Banco_de_DadosDataSetTableAdapters.UsuárioTableAdapter usuárioTableAdapter;
    }
}