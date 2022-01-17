namespace SICOEES
{
    partial class Professor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Professor));
            this.brMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTimeFim = new System.Windows.Forms.DateTimePicker();
            this.DateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.espaçoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco_de_DadosDataSet = new SICOEES.Banco_de_DadosDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDisciplina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radSábado = new System.Windows.Forms.RadioButton();
            this.radSexta = new System.Windows.Forms.RadioButton();
            this.radQuinta = new System.Windows.Forms.RadioButton();
            this.radQuarta = new System.Windows.Forms.RadioButton();
            this.radTerça = new System.Windows.Forms.RadioButton();
            this.radSegunda = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.espaçoTableAdapter = new SICOEES.Banco_de_DadosDataSetTableAdapters.EspaçoTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ck7 = new System.Windows.Forms.CheckBox();
            this.ck21 = new System.Windows.Forms.CheckBox();
            this.ck20 = new System.Windows.Forms.CheckBox();
            this.ck19 = new System.Windows.Forms.CheckBox();
            this.ck18 = new System.Windows.Forms.CheckBox();
            this.ck17 = new System.Windows.Forms.CheckBox();
            this.ck16 = new System.Windows.Forms.CheckBox();
            this.ck15 = new System.Windows.Forms.CheckBox();
            this.ck14 = new System.Windows.Forms.CheckBox();
            this.ck13 = new System.Windows.Forms.CheckBox();
            this.ck12 = new System.Windows.Forms.CheckBox();
            this.ck11 = new System.Windows.Forms.CheckBox();
            this.ck10 = new System.Windows.Forms.CheckBox();
            this.ck9 = new System.Windows.Forms.CheckBox();
            this.ck8 = new System.Windows.Forms.CheckBox();
            this.brMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.espaçoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_de_DadosDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // brMenu
            // 
            this.brMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.brMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.brMenu.Location = new System.Drawing.Point(0, 0);
            this.brMenu.Name = "brMenu";
            this.brMenu.Size = new System.Drawing.Size(589, 24);
            this.brMenu.TabIndex = 0;
            this.brMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DateTimeFim);
            this.groupBox1.Controls.Add(this.DateTimeInicio);
            this.groupBox1.Controls.Add(this.cmbLocal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDisciplina);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCurso);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agendamento do Professor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Término do período";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Início do período";
            // 
            // DateTimeFim
            // 
            this.DateTimeFim.Location = new System.Drawing.Point(330, 140);
            this.DateTimeFim.Name = "DateTimeFim";
            this.DateTimeFim.Size = new System.Drawing.Size(220, 20);
            this.DateTimeFim.TabIndex = 5;
            // 
            // DateTimeInicio
            // 
            this.DateTimeInicio.Location = new System.Drawing.Point(330, 90);
            this.DateTimeInicio.Name = "DateTimeInicio";
            this.DateTimeInicio.Size = new System.Drawing.Size(220, 20);
            this.DateTimeInicio.TabIndex = 4;
            // 
            // cmbLocal
            // 
            this.cmbLocal.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.espaçoBindingSource, "idEspaço", true));
            this.cmbLocal.DataSource = this.espaçoBindingSource;
            this.cmbLocal.DisplayMember = "Nome";
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Location = new System.Drawing.Point(330, 40);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(170, 21);
            this.cmbLocal.TabIndex = 3;
            this.cmbLocal.ValueMember = "idEspaço";
            this.cmbLocal.SelectedIndexChanged += new System.EventHandler(this.cmbLocal_SelectedIndexChanged);
            // 
            // espaçoBindingSource
            // 
            this.espaçoBindingSource.DataMember = "Espaço";
            this.espaçoBindingSource.DataSource = this.banco_de_DadosDataSet;
            // 
            // banco_de_DadosDataSet
            // 
            this.banco_de_DadosDataSet.DataSetName = "Banco_de_DadosDataSet";
            this.banco_de_DadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Local";
            // 
            // txtDisciplina
            // 
            this.txtDisciplina.Location = new System.Drawing.Point(20, 140);
            this.txtDisciplina.MaxLength = 50;
            this.txtDisciplina.Name = "txtDisciplina";
            this.txtDisciplina.Size = new System.Drawing.Size(275, 20);
            this.txtDisciplina.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Disciplina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Curso";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(20, 90);
            this.txtCurso.MaxLength = 50;
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(275, 20);
            this.txtCurso.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 40);
            this.txtNome.MaxLength = 200;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(275, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radSábado);
            this.groupBox2.Controls.Add(this.radSexta);
            this.groupBox2.Controls.Add(this.radQuinta);
            this.groupBox2.Controls.Add(this.radQuarta);
            this.groupBox2.Controls.Add(this.radTerça);
            this.groupBox2.Controls.Add(this.radSegunda);
            this.groupBox2.Location = new System.Drawing.Point(335, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 125);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dias da Semana";
            // 
            // radSábado
            // 
            this.radSábado.AutoSize = true;
            this.radSábado.Location = new System.Drawing.Point(145, 90);
            this.radSábado.Name = "radSábado";
            this.radSábado.Size = new System.Drawing.Size(62, 17);
            this.radSábado.TabIndex = 26;
            this.radSábado.TabStop = true;
            this.radSábado.Text = "Sábado";
            this.radSábado.UseVisualStyleBackColor = true;
            // 
            // radSexta
            // 
            this.radSexta.AutoSize = true;
            this.radSexta.Location = new System.Drawing.Point(145, 65);
            this.radSexta.Name = "radSexta";
            this.radSexta.Size = new System.Drawing.Size(75, 17);
            this.radSexta.TabIndex = 25;
            this.radSexta.TabStop = true;
            this.radSexta.Text = "Sexta-feira";
            this.radSexta.UseVisualStyleBackColor = true;
            // 
            // radQuinta
            // 
            this.radQuinta.AutoSize = true;
            this.radQuinta.Location = new System.Drawing.Point(145, 35);
            this.radQuinta.Name = "radQuinta";
            this.radQuinta.Size = new System.Drawing.Size(79, 17);
            this.radQuinta.TabIndex = 24;
            this.radQuinta.TabStop = true;
            this.radQuinta.Text = "Quinta-feira";
            this.radQuinta.UseVisualStyleBackColor = true;
            // 
            // radQuarta
            // 
            this.radQuarta.AutoSize = true;
            this.radQuarta.Location = new System.Drawing.Point(15, 89);
            this.radQuarta.Name = "radQuarta";
            this.radQuarta.Size = new System.Drawing.Size(80, 17);
            this.radQuarta.TabIndex = 23;
            this.radQuarta.TabStop = true;
            this.radQuarta.Text = "Quarta-feira";
            this.radQuarta.UseVisualStyleBackColor = true;
            // 
            // radTerça
            // 
            this.radTerça.AutoSize = true;
            this.radTerça.Location = new System.Drawing.Point(15, 64);
            this.radTerça.Name = "radTerça";
            this.radTerça.Size = new System.Drawing.Size(76, 17);
            this.radTerça.TabIndex = 22;
            this.radTerça.TabStop = true;
            this.radTerça.Text = "Terça-feira";
            this.radTerça.UseVisualStyleBackColor = true;
            // 
            // radSegunda
            // 
            this.radSegunda.AutoSize = true;
            this.radSegunda.Location = new System.Drawing.Point(15, 35);
            this.radSegunda.Name = "radSegunda";
            this.radSegunda.Size = new System.Drawing.Size(91, 17);
            this.radSegunda.TabIndex = 21;
            this.radSegunda.TabStop = true;
            this.radSegunda.Text = "Segunda-feira";
            this.radSegunda.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(360, 350);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(480, 350);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // espaçoTableAdapter
            // 
            this.espaçoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ck7);
            this.groupBox3.Controls.Add(this.ck21);
            this.groupBox3.Controls.Add(this.ck20);
            this.groupBox3.Controls.Add(this.ck19);
            this.groupBox3.Controls.Add(this.ck18);
            this.groupBox3.Controls.Add(this.ck17);
            this.groupBox3.Controls.Add(this.ck16);
            this.groupBox3.Controls.Add(this.ck15);
            this.groupBox3.Controls.Add(this.ck14);
            this.groupBox3.Controls.Add(this.ck13);
            this.groupBox3.Controls.Add(this.ck12);
            this.groupBox3.Controls.Add(this.ck11);
            this.groupBox3.Controls.Add(this.ck10);
            this.groupBox3.Controls.Add(this.ck9);
            this.groupBox3.Controls.Add(this.ck8);
            this.groupBox3.Location = new System.Drawing.Point(10, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 175);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Horários";
            // 
            // ck7
            // 
            this.ck7.AutoSize = true;
            this.ck7.Location = new System.Drawing.Point(20, 40);
            this.ck7.Name = "ck7";
            this.ck7.Size = new System.Drawing.Size(63, 17);
            this.ck7.TabIndex = 6;
            this.ck7.Text = "7 Horas";
            this.ck7.UseVisualStyleBackColor = true;
            // 
            // ck21
            // 
            this.ck21.AutoSize = true;
            this.ck21.Location = new System.Drawing.Point(230, 140);
            this.ck21.Name = "ck21";
            this.ck21.Size = new System.Drawing.Size(69, 17);
            this.ck21.TabIndex = 20;
            this.ck21.Text = "21 Horas";
            this.ck21.UseVisualStyleBackColor = true;
            // 
            // ck20
            // 
            this.ck20.AutoSize = true;
            this.ck20.Location = new System.Drawing.Point(230, 115);
            this.ck20.Name = "ck20";
            this.ck20.Size = new System.Drawing.Size(69, 17);
            this.ck20.TabIndex = 19;
            this.ck20.Text = "20 Horas";
            this.ck20.UseVisualStyleBackColor = true;
            // 
            // ck19
            // 
            this.ck19.AutoSize = true;
            this.ck19.Location = new System.Drawing.Point(230, 90);
            this.ck19.Name = "ck19";
            this.ck19.Size = new System.Drawing.Size(69, 17);
            this.ck19.TabIndex = 18;
            this.ck19.Text = "19 Horas";
            this.ck19.UseVisualStyleBackColor = true;
            // 
            // ck18
            // 
            this.ck18.AutoSize = true;
            this.ck18.Location = new System.Drawing.Point(230, 65);
            this.ck18.Name = "ck18";
            this.ck18.Size = new System.Drawing.Size(69, 17);
            this.ck18.TabIndex = 17;
            this.ck18.Text = "18 Horas";
            this.ck18.UseVisualStyleBackColor = true;
            // 
            // ck17
            // 
            this.ck17.AutoSize = true;
            this.ck17.Location = new System.Drawing.Point(230, 40);
            this.ck17.Name = "ck17";
            this.ck17.Size = new System.Drawing.Size(69, 17);
            this.ck17.TabIndex = 16;
            this.ck17.Text = "17 Horas";
            this.ck17.UseVisualStyleBackColor = true;
            // 
            // ck16
            // 
            this.ck16.AutoSize = true;
            this.ck16.Location = new System.Drawing.Point(130, 140);
            this.ck16.Name = "ck16";
            this.ck16.Size = new System.Drawing.Size(69, 17);
            this.ck16.TabIndex = 15;
            this.ck16.Text = "16 Horas";
            this.ck16.UseVisualStyleBackColor = true;
            // 
            // ck15
            // 
            this.ck15.AutoSize = true;
            this.ck15.Location = new System.Drawing.Point(130, 115);
            this.ck15.Name = "ck15";
            this.ck15.Size = new System.Drawing.Size(69, 17);
            this.ck15.TabIndex = 14;
            this.ck15.Text = "15 Horas";
            this.ck15.UseVisualStyleBackColor = true;
            // 
            // ck14
            // 
            this.ck14.AutoSize = true;
            this.ck14.Location = new System.Drawing.Point(130, 90);
            this.ck14.Name = "ck14";
            this.ck14.Size = new System.Drawing.Size(69, 17);
            this.ck14.TabIndex = 13;
            this.ck14.Text = "14 Horas";
            this.ck14.UseVisualStyleBackColor = true;
            // 
            // ck13
            // 
            this.ck13.AutoSize = true;
            this.ck13.Location = new System.Drawing.Point(130, 64);
            this.ck13.Name = "ck13";
            this.ck13.Size = new System.Drawing.Size(69, 17);
            this.ck13.TabIndex = 12;
            this.ck13.Text = "13 Horas";
            this.ck13.UseVisualStyleBackColor = true;
            // 
            // ck12
            // 
            this.ck12.AutoSize = true;
            this.ck12.Location = new System.Drawing.Point(130, 40);
            this.ck12.Name = "ck12";
            this.ck12.Size = new System.Drawing.Size(69, 17);
            this.ck12.TabIndex = 11;
            this.ck12.Text = "12 Horas";
            this.ck12.UseVisualStyleBackColor = true;
            // 
            // ck11
            // 
            this.ck11.AutoSize = true;
            this.ck11.Location = new System.Drawing.Point(20, 140);
            this.ck11.Name = "ck11";
            this.ck11.Size = new System.Drawing.Size(69, 17);
            this.ck11.TabIndex = 10;
            this.ck11.Text = "11 Horas";
            this.ck11.UseVisualStyleBackColor = true;
            // 
            // ck10
            // 
            this.ck10.AutoSize = true;
            this.ck10.Location = new System.Drawing.Point(20, 115);
            this.ck10.Name = "ck10";
            this.ck10.Size = new System.Drawing.Size(69, 17);
            this.ck10.TabIndex = 9;
            this.ck10.Text = "10 Horas";
            this.ck10.UseVisualStyleBackColor = true;
            // 
            // ck9
            // 
            this.ck9.AutoSize = true;
            this.ck9.Location = new System.Drawing.Point(20, 90);
            this.ck9.Name = "ck9";
            this.ck9.Size = new System.Drawing.Size(63, 17);
            this.ck9.TabIndex = 8;
            this.ck9.Text = "9 Horas";
            this.ck9.UseVisualStyleBackColor = true;
            // 
            // ck8
            // 
            this.ck8.AutoSize = true;
            this.ck8.Location = new System.Drawing.Point(20, 65);
            this.ck8.Name = "ck8";
            this.ck8.Size = new System.Drawing.Size(63, 17);
            this.ck8.TabIndex = 7;
            this.ck8.Text = "8 Horas";
            this.ck8.UseVisualStyleBackColor = true;
            // 
            // Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 392);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.brMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.brMenu;
            this.MaximumSize = new System.Drawing.Size(605, 430);
            this.Name = "Professor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento Especial de Professor";
            this.Load += new System.EventHandler(this.Professor_Load);
            this.brMenu.ResumeLayout(false);
            this.brMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.espaçoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_de_DadosDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip brMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateTimeFim;
        private System.Windows.Forms.DateTimePicker DateTimeInicio;
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDisciplina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private Banco_de_DadosDataSet banco_de_DadosDataSet;
        private System.Windows.Forms.BindingSource espaçoBindingSource;
        private Banco_de_DadosDataSetTableAdapters.EspaçoTableAdapter espaçoTableAdapter;
        private System.Windows.Forms.RadioButton radSábado;
        private System.Windows.Forms.RadioButton radSexta;
        private System.Windows.Forms.RadioButton radQuinta;
        private System.Windows.Forms.RadioButton radQuarta;
        private System.Windows.Forms.RadioButton radTerça;
        private System.Windows.Forms.RadioButton radSegunda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ck7;
        private System.Windows.Forms.CheckBox ck21;
        private System.Windows.Forms.CheckBox ck20;
        private System.Windows.Forms.CheckBox ck19;
        private System.Windows.Forms.CheckBox ck18;
        private System.Windows.Forms.CheckBox ck17;
        private System.Windows.Forms.CheckBox ck16;
        private System.Windows.Forms.CheckBox ck15;
        private System.Windows.Forms.CheckBox ck14;
        private System.Windows.Forms.CheckBox ck13;
        private System.Windows.Forms.CheckBox ck12;
        private System.Windows.Forms.CheckBox ck11;
        private System.Windows.Forms.CheckBox ck10;
        private System.Windows.Forms.CheckBox ck9;
        private System.Windows.Forms.CheckBox ck8;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}