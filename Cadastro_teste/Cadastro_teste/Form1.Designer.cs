namespace Cadastro_teste
{
    partial class frm_CRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CRUD));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbCidadeCad = new System.Windows.Forms.ComboBox();
            this.cbUfCad = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCadNome_Mae = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTelefoneCad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIdadeCad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCadNome_Pai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmailCad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEnderecoCad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomeCad = new System.Windows.Forms.TextBox();
            this.dtAdicionar = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.tbEditCodigo = new System.Windows.Forms.TextBox();
            this.cbEditCidade = new System.Windows.Forms.ComboBox();
            this.cbEditUF = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbEditMae = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEditTelefone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbEditIdade = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbEditPai = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbEditEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbEditEndereco = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbEditNome = new System.Windows.Forms.TextBox();
            this.dtEditar = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbExcluir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtExcluir = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPorNome = new System.Windows.Forms.RadioButton();
            this.rbPorCodigo = new System.Windows.Forms.RadioButton();
            this.tbPesquisar = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.dgPesquisar = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAdicionar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditar)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtExcluir)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisar)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 441);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 379);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbCidadeCad);
            this.tabPage1.Controls.Add(this.cbUfCad);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.tbCadNome_Mae);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tbTelefoneCad);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbIdadeCad);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbCadNome_Pai);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbEmailCad);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbEnderecoCad);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbNomeCad);
            this.tabPage1.Controls.Add(this.dtAdicionar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(545, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adicionar Aluno";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // cbCidadeCad
            // 
            this.cbCidadeCad.FormattingEnabled = true;
            this.cbCidadeCad.Location = new System.Drawing.Point(335, 180);
            this.cbCidadeCad.Name = "cbCidadeCad";
            this.cbCidadeCad.Size = new System.Drawing.Size(141, 24);
            this.cbCidadeCad.TabIndex = 19;
            // 
            // cbUfCad
            // 
            this.cbUfCad.FormattingEnabled = true;
            this.cbUfCad.Items.AddRange(new object[] {
            "01",
            "02",
            "03"});
            this.cbUfCad.Location = new System.Drawing.Point(294, 180);
            this.cbUfCad.Name = "cbUfCad";
            this.cbUfCad.Size = new System.Drawing.Size(35, 24);
            this.cbUfCad.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(291, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "UF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(291, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nome da Mãe";
            // 
            // tbCadNome_Mae
            // 
            this.tbCadNome_Mae.Location = new System.Drawing.Point(294, 242);
            this.tbCadNome_Mae.Name = "tbCadNome_Mae";
            this.tbCadNome_Mae.Size = new System.Drawing.Size(182, 22);
            this.tbCadNome_Mae.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(332, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(291, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Telefone";
            // 
            // tbTelefoneCad
            // 
            this.tbTelefoneCad.Location = new System.Drawing.Point(294, 127);
            this.tbTelefoneCad.Name = "tbTelefoneCad";
            this.tbTelefoneCad.Size = new System.Drawing.Size(182, 22);
            this.tbTelefoneCad.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(291, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Idade";
            // 
            // tbIdadeCad
            // 
            this.tbIdadeCad.Location = new System.Drawing.Point(294, 68);
            this.tbIdadeCad.Name = "tbIdadeCad";
            this.tbIdadeCad.Size = new System.Drawing.Size(182, 22);
            this.tbIdadeCad.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(72, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome do Pai";
            // 
            // tbCadNome_Pai
            // 
            this.tbCadNome_Pai.Location = new System.Drawing.Point(75, 242);
            this.tbCadNome_Pai.Name = "tbCadNome_Pai";
            this.tbCadNome_Pai.Size = new System.Drawing.Size(182, 22);
            this.tbCadNome_Pai.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(72, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // tbEmailCad
            // 
            this.tbEmailCad.Location = new System.Drawing.Point(75, 182);
            this.tbEmailCad.Name = "tbEmailCad";
            this.tbEmailCad.Size = new System.Drawing.Size(182, 22);
            this.tbEmailCad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(72, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endereço";
            // 
            // tbEnderecoCad
            // 
            this.tbEnderecoCad.Location = new System.Drawing.Point(75, 127);
            this.tbEnderecoCad.Name = "tbEnderecoCad";
            this.tbEnderecoCad.Size = new System.Drawing.Size(182, 22);
            this.tbEnderecoCad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(72, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // tbNomeCad
            // 
            this.tbNomeCad.Location = new System.Drawing.Point(75, 68);
            this.tbNomeCad.Name = "tbNomeCad";
            this.tbNomeCad.Size = new System.Drawing.Size(182, 22);
            this.tbNomeCad.TabIndex = 1;
            // 
            // dtAdicionar
            // 
            this.dtAdicionar.AllowUserToAddRows = false;
            this.dtAdicionar.AllowUserToDeleteRows = false;
            this.dtAdicionar.BackgroundColor = System.Drawing.Color.White;
            this.dtAdicionar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAdicionar.Location = new System.Drawing.Point(3, 0);
            this.dtAdicionar.Name = "dtAdicionar";
            this.dtAdicionar.ReadOnly = true;
            this.dtAdicionar.Size = new System.Drawing.Size(539, 334);
            this.dtAdicionar.TabIndex = 0;
            this.dtAdicionar.Enter += new System.EventHandler(this.dtAdicionar_Enter);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.tbEditCodigo);
            this.tabPage2.Controls.Add(this.cbEditCidade);
            this.tabPage2.Controls.Add(this.cbEditUF);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tbEditMae);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tbEditTelefone);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.tbEditIdade);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.tbEditPai);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.tbEditEmail);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.tbEditEndereco);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.tbEditNome);
            this.tabPage2.Controls.Add(this.dtEditar);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(545, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar Aluno";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(15, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 16);
            this.label20.TabIndex = 36;
            this.label20.Text = "Código";
            // 
            // tbEditCodigo
            // 
            this.tbEditCodigo.Location = new System.Drawing.Point(18, 40);
            this.tbEditCodigo.Name = "tbEditCodigo";
            this.tbEditCodigo.Size = new System.Drawing.Size(84, 22);
            this.tbEditCodigo.TabIndex = 35;
            // 
            // cbEditCidade
            // 
            this.cbEditCidade.FormattingEnabled = true;
            this.cbEditCidade.Location = new System.Drawing.Point(370, 90);
            this.cbEditCidade.Name = "cbEditCidade";
            this.cbEditCidade.Size = new System.Drawing.Size(153, 24);
            this.cbEditCidade.TabIndex = 34;
            // 
            // cbEditUF
            // 
            this.cbEditUF.FormattingEnabled = true;
            this.cbEditUF.Items.AddRange(new object[] {
            "01",
            "02",
            "03"});
            this.cbEditUF.Location = new System.Drawing.Point(329, 90);
            this.cbEditUF.Name = "cbEditUF";
            this.cbEditUF.Size = new System.Drawing.Size(35, 24);
            this.cbEditUF.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(326, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 16);
            this.label18.TabIndex = 32;
            this.label18.Text = "UF";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(367, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 16);
            this.label19.TabIndex = 31;
            this.label19.Text = "Cidade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(367, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Nome da Mãe";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // tbEditMae
            // 
            this.tbEditMae.Location = new System.Drawing.Point(370, 142);
            this.tbEditMae.Name = "tbEditMae";
            this.tbEditMae.Size = new System.Drawing.Size(153, 22);
            this.tbEditMae.TabIndex = 29;
            this.tbEditMae.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(208, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Telefone";
            // 
            // tbEditTelefone
            // 
            this.tbEditTelefone.Location = new System.Drawing.Point(211, 92);
            this.tbEditTelefone.Name = "tbEditTelefone";
            this.tbEditTelefone.Size = new System.Drawing.Size(106, 22);
            this.tbEditTelefone.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(450, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Idade";
            // 
            // tbEditIdade
            // 
            this.tbEditIdade.Location = new System.Drawing.Point(453, 40);
            this.tbEditIdade.Name = "tbEditIdade";
            this.tbEditIdade.Size = new System.Drawing.Size(70, 22);
            this.tbEditIdade.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(208, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "Nome do Pai";
            // 
            // tbEditPai
            // 
            this.tbEditPai.Location = new System.Drawing.Point(211, 143);
            this.tbEditPai.Name = "tbEditPai";
            this.tbEditPai.Size = new System.Drawing.Size(153, 22);
            this.tbEditPai.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(15, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Email";
            // 
            // tbEditEmail
            // 
            this.tbEditEmail.Location = new System.Drawing.Point(18, 143);
            this.tbEditEmail.Name = "tbEditEmail";
            this.tbEditEmail.Size = new System.Drawing.Size(182, 22);
            this.tbEditEmail.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(15, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 16);
            this.label16.TabIndex = 20;
            this.label16.Text = "Endereço";
            // 
            // tbEditEndereco
            // 
            this.tbEditEndereco.Location = new System.Drawing.Point(18, 92);
            this.tbEditEndereco.Name = "tbEditEndereco";
            this.tbEditEndereco.Size = new System.Drawing.Size(182, 22);
            this.tbEditEndereco.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(120, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 16);
            this.label17.TabIndex = 18;
            this.label17.Text = "Nome";
            // 
            // tbEditNome
            // 
            this.tbEditNome.Location = new System.Drawing.Point(123, 40);
            this.tbEditNome.Name = "tbEditNome";
            this.tbEditNome.Size = new System.Drawing.Size(324, 22);
            this.tbEditNome.TabIndex = 17;
            // 
            // dtEditar
            // 
            this.dtEditar.BackgroundColor = System.Drawing.Color.White;
            this.dtEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEditar.GridColor = System.Drawing.Color.Gainsboro;
            this.dtEditar.Location = new System.Drawing.Point(3, 171);
            this.dtEditar.Name = "dtEditar";
            this.dtEditar.Size = new System.Drawing.Size(539, 163);
            this.dtEditar.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.dtExcluir);
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(545, 350);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Excluir Aluno";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbExcluir);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Excluir Aluno";
            // 
            // tbExcluir
            // 
            this.tbExcluir.Location = new System.Drawing.Point(9, 63);
            this.tbExcluir.Name = "tbExcluir";
            this.tbExcluir.Size = new System.Drawing.Size(150, 22);
            this.tbExcluir.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código Aluno";
            // 
            // dtExcluir
            // 
            this.dtExcluir.BackgroundColor = System.Drawing.Color.White;
            this.dtExcluir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtExcluir.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtExcluir.Location = new System.Drawing.Point(0, 115);
            this.dtExcluir.Name = "dtExcluir";
            this.dtExcluir.Size = new System.Drawing.Size(545, 220);
            this.dtExcluir.TabIndex = 0;
            this.dtExcluir.Enter += new System.EventHandler(this.dtExcluir_Enter);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.dgPesquisar);
            this.tabPage4.ForeColor = System.Drawing.Color.Black;
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(545, 350);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pesquisar Aluno";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbPesquisar);
            this.groupBox1.Controls.Add(this.btPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Aluno";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPorNome);
            this.groupBox2.Controls.Add(this.rbPorCodigo);
            this.groupBox2.Location = new System.Drawing.Point(388, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 79);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Pesquisa";
            // 
            // rbPorNome
            // 
            this.rbPorNome.AutoSize = true;
            this.rbPorNome.Checked = true;
            this.rbPorNome.Location = new System.Drawing.Point(41, 21);
            this.rbPorNome.Name = "rbPorNome";
            this.rbPorNome.Size = new System.Drawing.Size(77, 20);
            this.rbPorNome.TabIndex = 6;
            this.rbPorNome.TabStop = true;
            this.rbPorNome.Text = "Por Nome";
            this.rbPorNome.UseVisualStyleBackColor = true;
            // 
            // rbPorCodigo
            // 
            this.rbPorCodigo.AutoSize = true;
            this.rbPorCodigo.Location = new System.Drawing.Point(41, 47);
            this.rbPorCodigo.Name = "rbPorCodigo";
            this.rbPorCodigo.Size = new System.Drawing.Size(86, 20);
            this.rbPorCodigo.TabIndex = 8;
            this.rbPorCodigo.Text = "Por Código";
            this.rbPorCodigo.UseVisualStyleBackColor = true;
            // 
            // tbPesquisar
            // 
            this.tbPesquisar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesquisar.Location = new System.Drawing.Point(8, 49);
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.Size = new System.Drawing.Size(287, 25);
            this.tbPesquisar.TabIndex = 7;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(301, 45);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 30);
            this.btPesquisar.TabIndex = 5;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // dgPesquisar
            // 
            this.dgPesquisar.BackgroundColor = System.Drawing.Color.White;
            this.dgPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesquisar.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgPesquisar.Location = new System.Drawing.Point(3, 109);
            this.dgPesquisar.Name = "dgPesquisar";
            this.dgPesquisar.Size = new System.Drawing.Size(539, 224);
            this.dgPesquisar.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 361);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 80);
            this.panel2.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 19);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(553, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 58);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(553, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Black;
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(0, 17);
            this.lbTime.Click += new System.EventHandler(this.lbTime_Click);
            // 
            // frm_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 441);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frm_CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cadastro de Alunos";
            this.Load += new System.EventHandler(this.frm_CRUD_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAdicionar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtExcluir)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbTime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.DataGridView dtAdicionar;
        private System.Windows.Forms.DataGridView dtEditar;
        private System.Windows.Forms.DataGridView dtExcluir;
        private System.Windows.Forms.DataGridView dgPesquisar;
        private System.Windows.Forms.RadioButton rbPorCodigo;
        private System.Windows.Forms.TextBox tbPesquisar;
        private System.Windows.Forms.RadioButton rbPorNome;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbExcluir;
        private System.Windows.Forms.ComboBox cbCidadeCad;
        private System.Windows.Forms.ComboBox cbUfCad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCadNome_Mae;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTelefoneCad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIdadeCad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCadNome_Pai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmailCad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEnderecoCad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomeCad;
        private System.Windows.Forms.ComboBox cbEditCidade;
        private System.Windows.Forms.ComboBox cbEditUF;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbEditMae;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbEditTelefone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbEditIdade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbEditPai;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbEditEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbEditEndereco;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbEditNome;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbEditCodigo;
    }
}

