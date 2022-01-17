namespace SICOEES
{
    partial class Evento
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
            System.Windows.Forms.Label descriçãoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evento));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.brMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescrição = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDescriçãoLocal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbNome = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            descriçãoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.brMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriçãoLabel
            // 
            descriçãoLabel.AutoSize = true;
            descriçãoLabel.Location = new System.Drawing.Point(17, 104);
            descriçãoLabel.Name = "descriçãoLabel";
            descriçãoLabel.Size = new System.Drawing.Size(58, 13);
            descriçãoLabel.TabIndex = 64;
            descriçãoLabel.Text = "Descrição:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Calendario);
            this.groupBox1.Location = new System.Drawing.Point(20, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calendário";
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(12, 13);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 0;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // brMenu
            // 
            this.brMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.brMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.brMenu.Location = new System.Drawing.Point(0, 0);
            this.brMenu.Name = "brMenu";
            this.brMenu.Size = new System.Drawing.Size(639, 24);
            this.brMenu.TabIndex = 1;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescrição);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtEvento);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(300, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 175);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agendamento de Evento";
            // 
            // txtDescrição
            // 
            this.txtDescrição.Location = new System.Drawing.Point(20, 140);
            this.txtDescrição.Multiline = true;
            this.txtDescrição.Name = "txtDescrição";
            this.txtDescrição.Size = new System.Drawing.Size(275, 20);
            this.txtDescrição.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descrição";
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(20, 90);
            this.txtEvento.MaxLength = 50;
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(275, 20);
            this.txtEvento.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Evento";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 40);
            this.txtNome.MaxLength = 200;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(275, 20);
            this.txtNome.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
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
            this.groupBox3.Location = new System.Drawing.Point(300, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 175);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Horários";
            // 
            // ck7
            // 
            this.ck7.AutoSize = true;
            this.ck7.Location = new System.Drawing.Point(20, 40);
            this.ck7.Name = "ck7";
            this.ck7.Size = new System.Drawing.Size(63, 17);
            this.ck7.TabIndex = 11;
            this.ck7.Text = "7 Horas";
            this.ck7.UseVisualStyleBackColor = true;
            // 
            // ck21
            // 
            this.ck21.AutoSize = true;
            this.ck21.Location = new System.Drawing.Point(230, 140);
            this.ck21.Name = "ck21";
            this.ck21.Size = new System.Drawing.Size(69, 17);
            this.ck21.TabIndex = 25;
            this.ck21.Text = "21 Horas";
            this.ck21.UseVisualStyleBackColor = true;
            // 
            // ck20
            // 
            this.ck20.AutoSize = true;
            this.ck20.Location = new System.Drawing.Point(230, 115);
            this.ck20.Name = "ck20";
            this.ck20.Size = new System.Drawing.Size(69, 17);
            this.ck20.TabIndex = 24;
            this.ck20.Text = "20 Horas";
            this.ck20.UseVisualStyleBackColor = true;
            // 
            // ck19
            // 
            this.ck19.AutoSize = true;
            this.ck19.Location = new System.Drawing.Point(230, 90);
            this.ck19.Name = "ck19";
            this.ck19.Size = new System.Drawing.Size(69, 17);
            this.ck19.TabIndex = 23;
            this.ck19.Text = "19 Horas";
            this.ck19.UseVisualStyleBackColor = true;
            // 
            // ck18
            // 
            this.ck18.AutoSize = true;
            this.ck18.Location = new System.Drawing.Point(230, 65);
            this.ck18.Name = "ck18";
            this.ck18.Size = new System.Drawing.Size(69, 17);
            this.ck18.TabIndex = 22;
            this.ck18.Text = "18 Horas";
            this.ck18.UseVisualStyleBackColor = true;
            // 
            // ck17
            // 
            this.ck17.AutoSize = true;
            this.ck17.Location = new System.Drawing.Point(230, 40);
            this.ck17.Name = "ck17";
            this.ck17.Size = new System.Drawing.Size(69, 17);
            this.ck17.TabIndex = 21;
            this.ck17.Text = "17 Horas";
            this.ck17.UseVisualStyleBackColor = true;
            // 
            // ck16
            // 
            this.ck16.AutoSize = true;
            this.ck16.Location = new System.Drawing.Point(130, 140);
            this.ck16.Name = "ck16";
            this.ck16.Size = new System.Drawing.Size(69, 17);
            this.ck16.TabIndex = 20;
            this.ck16.Text = "16 Horas";
            this.ck16.UseVisualStyleBackColor = true;
            // 
            // ck15
            // 
            this.ck15.AutoSize = true;
            this.ck15.Location = new System.Drawing.Point(130, 115);
            this.ck15.Name = "ck15";
            this.ck15.Size = new System.Drawing.Size(69, 17);
            this.ck15.TabIndex = 19;
            this.ck15.Text = "15 Horas";
            this.ck15.UseVisualStyleBackColor = true;
            // 
            // ck14
            // 
            this.ck14.AutoSize = true;
            this.ck14.Location = new System.Drawing.Point(130, 90);
            this.ck14.Name = "ck14";
            this.ck14.Size = new System.Drawing.Size(69, 17);
            this.ck14.TabIndex = 18;
            this.ck14.Text = "14 Horas";
            this.ck14.UseVisualStyleBackColor = true;
            // 
            // ck13
            // 
            this.ck13.AutoSize = true;
            this.ck13.Location = new System.Drawing.Point(130, 64);
            this.ck13.Name = "ck13";
            this.ck13.Size = new System.Drawing.Size(69, 17);
            this.ck13.TabIndex = 17;
            this.ck13.Text = "13 Horas";
            this.ck13.UseVisualStyleBackColor = true;
            // 
            // ck12
            // 
            this.ck12.AutoSize = true;
            this.ck12.Location = new System.Drawing.Point(130, 40);
            this.ck12.Name = "ck12";
            this.ck12.Size = new System.Drawing.Size(69, 17);
            this.ck12.TabIndex = 16;
            this.ck12.Text = "12 Horas";
            this.ck12.UseVisualStyleBackColor = true;
            // 
            // ck11
            // 
            this.ck11.AutoSize = true;
            this.ck11.Location = new System.Drawing.Point(20, 140);
            this.ck11.Name = "ck11";
            this.ck11.Size = new System.Drawing.Size(69, 17);
            this.ck11.TabIndex = 15;
            this.ck11.Text = "11 Horas";
            this.ck11.UseVisualStyleBackColor = true;
            // 
            // ck10
            // 
            this.ck10.AutoSize = true;
            this.ck10.Location = new System.Drawing.Point(20, 115);
            this.ck10.Name = "ck10";
            this.ck10.Size = new System.Drawing.Size(69, 17);
            this.ck10.TabIndex = 14;
            this.ck10.Text = "10 Horas";
            this.ck10.UseVisualStyleBackColor = true;
            // 
            // ck9
            // 
            this.ck9.AutoSize = true;
            this.ck9.Location = new System.Drawing.Point(20, 90);
            this.ck9.Name = "ck9";
            this.ck9.Size = new System.Drawing.Size(63, 17);
            this.ck9.TabIndex = 13;
            this.ck9.Text = "9 Horas";
            this.ck9.UseVisualStyleBackColor = true;
            // 
            // ck8
            // 
            this.ck8.AutoSize = true;
            this.ck8.Location = new System.Drawing.Point(20, 65);
            this.ck8.Name = "ck8";
            this.ck8.Size = new System.Drawing.Size(63, 17);
            this.ck8.TabIndex = 12;
            this.ck8.Text = "8 Horas";
            this.ck8.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDescriçãoLocal);
            this.groupBox4.Controls.Add(descriçãoLabel);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.cmbNome);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Location = new System.Drawing.Point(10, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 250);
            this.groupBox4.TabIndex = 97;
            this.groupBox4.TabStop = false;
            // 
            // txtDescriçãoLocal
            // 
            this.txtDescriçãoLocal.Location = new System.Drawing.Point(20, 120);
            this.txtDescriçãoLocal.Multiline = true;
            this.txtDescriçãoLocal.Name = "txtDescriçãoLocal";
            this.txtDescriçãoLocal.Size = new System.Drawing.Size(225, 110);
            this.txtDescriçãoLocal.TabIndex = 65;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 63;
            this.label17.Text = "Nome";
            // 
            // cmbNome
            // 
            this.cmbNome.DisplayMember = "idEspaço";
            this.cmbNome.FormattingEnabled = true;
            this.cmbNome.Location = new System.Drawing.Point(20, 60);
            this.cmbNome.Name = "cmbNome";
            this.cmbNome.Size = new System.Drawing.Size(225, 21);
            this.cmbNome.TabIndex = 61;
            this.cmbNome.ValueMember = "idEspaço";
            this.cmbNome.SelectionChangeCommitted += new System.EventHandler(this.cmbNome_SelectionChangeCommitted);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(5, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 18);
            this.label18.TabIndex = 60;
            this.label18.Text = "Locais";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(350, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 98;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(500, 415);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 99;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 482);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.brMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.brMenu;
            this.MaximumSize = new System.Drawing.Size(645, 510);
            this.Name = "Evento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento Espacial de Evento";
            this.Load += new System.EventHandler(this.Evento_Load);
            this.groupBox1.ResumeLayout(false);
            this.brMenu.ResumeLayout(false);
            this.brMenu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip brMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDescrição;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDescriçãoLocal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbNome;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}