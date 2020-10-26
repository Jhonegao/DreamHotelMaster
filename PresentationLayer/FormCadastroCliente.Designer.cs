namespace PresentationLayer
{
    partial class FormCadastroCliente
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
            this.linhaNome = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.labelCadastroCliente = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.labelDadosPessoais = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.panelNome = new System.Windows.Forms.Panel();
            this.panelCpf = new System.Windows.Forms.Panel();
            this.linhaCpf = new System.Windows.Forms.Label();
            this.panelRg = new System.Windows.Forms.Panel();
            this.linhaRg = new System.Windows.Forms.Label();
            this.panelTelefone = new System.Windows.Forms.Panel();
            this.linhaTelefone = new System.Windows.Forms.Label();
            this.panelTelefone2 = new System.Windows.Forms.Panel();
            this.linhaTelefone2 = new System.Windows.Forms.Label();
            this.txtTelefone2 = new System.Windows.Forms.TextBox();
            this.panelCep = new System.Windows.Forms.Panel();
            this.linhaCep = new System.Windows.Forms.Label();
            this.panelPais = new System.Windows.Forms.Panel();
            this.linhaPais = new System.Windows.Forms.Label();
            this.panelUf = new System.Windows.Forms.Panel();
            this.LinhaUf = new System.Windows.Forms.Label();
            this.panelCidade = new System.Windows.Forms.Panel();
            this.linhaCidade = new System.Windows.Forms.Label();
            this.panelBairro = new System.Windows.Forms.Panel();
            this.linhaBairro = new System.Windows.Forms.Label();
            this.panelRua = new System.Windows.Forms.Panel();
            this.linhaRua = new System.Windows.Forms.Label();
            this.panelNome.SuspendLayout();
            this.panelCpf.SuspendLayout();
            this.panelRg.SuspendLayout();
            this.panelTelefone.SuspendLayout();
            this.panelTelefone2.SuspendLayout();
            this.panelCep.SuspendLayout();
            this.panelPais.SuspendLayout();
            this.panelUf.SuspendLayout();
            this.panelCidade.SuspendLayout();
            this.panelBairro.SuspendLayout();
            this.panelRua.SuspendLayout();
            this.SuspendLayout();
            // 
            // linhaNome
            // 
            this.linhaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaNome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaNome.Location = new System.Drawing.Point(0, 31);
            this.linhaNome.Name = "linhaNome";
            this.linhaNome.Size = new System.Drawing.Size(343, 1);
            this.linhaNome.TabIndex = 24;
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpf.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.Color.Silver;
            this.txtCpf.Location = new System.Drawing.Point(0, 0);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(343, 31);
            this.txtCpf.TabIndex = 23;
            this.txtCpf.Text = "CPF";
            this.txtCpf.Enter += new System.EventHandler(this.txtCpf_Enter);
            this.txtCpf.Leave += new System.EventHandler(this.txtCpf_Leave);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Silver;
            this.txtNome.Location = new System.Drawing.Point(0, 0);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(343, 31);
            this.txtNome.TabIndex = 22;
            this.txtNome.Text = "Nome";
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnCadastrar.Location = new System.Drawing.Point(215, 380);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(408, 40);
            this.btnCadastrar.TabIndex = 20;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // labelCadastroCliente
            // 
            this.labelCadastroCliente.AutoSize = true;
            this.labelCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.labelCadastroCliente.Location = new System.Drawing.Point(274, 23);
            this.labelCadastroCliente.Name = "labelCadastroCliente";
            this.labelCadastroCliente.Size = new System.Drawing.Size(474, 42);
            this.labelCadastroCliente.TabIndex = 21;
            this.labelCadastroCliente.Text = "CADASTRO DE CLIENTE";
            // 
            // txtRg
            // 
            this.txtRg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRg.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.ForeColor = System.Drawing.Color.Silver;
            this.txtRg.Location = new System.Drawing.Point(0, 0);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(343, 31);
            this.txtRg.TabIndex = 26;
            this.txtRg.Text = "RG";
            this.txtRg.Enter += new System.EventHandler(this.txtRg_Enter);
            this.txtRg.Leave += new System.EventHandler(this.txtRg_Leave);
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.Silver;
            this.txtCidade.Location = new System.Drawing.Point(0, 0);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(343, 31);
            this.txtCidade.TabIndex = 35;
            this.txtCidade.Text = "Cidade";
            this.txtCidade.Enter += new System.EventHandler(this.txtCidade_Enter);
            this.txtCidade.Leave += new System.EventHandler(this.txtCidade_Leave);
            // 
            // txtUf
            // 
            this.txtUf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtUf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUf.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUf.ForeColor = System.Drawing.Color.Silver;
            this.txtUf.Location = new System.Drawing.Point(0, 0);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(163, 31);
            this.txtUf.TabIndex = 34;
            this.txtUf.Text = "UF";
            this.txtUf.Enter += new System.EventHandler(this.txtUf_Enter);
            this.txtUf.Leave += new System.EventHandler(this.txtUf_Leave);
            // 
            // txtPais
            // 
            this.txtPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPais.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.ForeColor = System.Drawing.Color.Silver;
            this.txtPais.Location = new System.Drawing.Point(0, 0);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(163, 31);
            this.txtPais.TabIndex = 31;
            this.txtPais.Text = "País";
            this.txtPais.Enter += new System.EventHandler(this.txtPais_Enter);
            this.txtPais.Leave += new System.EventHandler(this.txtPais_Leave);
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCep.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.ForeColor = System.Drawing.Color.Silver;
            this.txtCep.Location = new System.Drawing.Point(0, 0);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(343, 31);
            this.txtCep.TabIndex = 30;
            this.txtCep.Text = "CEP";
            this.txtCep.Enter += new System.EventHandler(this.txtCep_Enter);
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // txtRua
            // 
            this.txtRua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRua.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.ForeColor = System.Drawing.Color.Silver;
            this.txtRua.Location = new System.Drawing.Point(0, 0);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(163, 31);
            this.txtRua.TabIndex = 43;
            this.txtRua.Text = "Rua";
            this.txtRua.Enter += new System.EventHandler(this.txtRua_Enter);
            this.txtRua.Leave += new System.EventHandler(this.txtRua_Leave);
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.Silver;
            this.txtBairro.Location = new System.Drawing.Point(0, 0);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(163, 31);
            this.txtBairro.TabIndex = 42;
            this.txtBairro.Text = "Bairro";
            this.txtBairro.Enter += new System.EventHandler(this.txtBairro_Enter);
            this.txtBairro.Leave += new System.EventHandler(this.txtBairro_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.Silver;
            this.txtTelefone.Location = new System.Drawing.Point(0, 0);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(163, 31);
            this.txtTelefone.TabIndex = 46;
            this.txtTelefone.Text = "Telefone";
            this.txtTelefone.Enter += new System.EventHandler(this.txtTelefone_Enter);
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // labelDadosPessoais
            // 
            this.labelDadosPessoais.AutoSize = true;
            this.labelDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDadosPessoais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.labelDadosPessoais.Location = new System.Drawing.Point(28, 101);
            this.labelDadosPessoais.Name = "labelDadosPessoais";
            this.labelDadosPessoais.Size = new System.Drawing.Size(304, 42);
            this.labelDadosPessoais.TabIndex = 50;
            this.labelDadosPessoais.Text = "Dados Pessoais";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.labelEndereco.Location = new System.Drawing.Point(423, 101);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(187, 42);
            this.labelEndereco.TabIndex = 51;
            this.labelEndereco.Text = "Endereço";
            // 
            // panelNome
            // 
            this.panelNome.AutoSize = true;
            this.panelNome.Controls.Add(this.txtNome);
            this.panelNome.Controls.Add(this.linhaNome);
            this.panelNome.Location = new System.Drawing.Point(35, 157);
            this.panelNome.Name = "panelNome";
            this.panelNome.Size = new System.Drawing.Size(343, 32);
            this.panelNome.TabIndex = 52;
            // 
            // panelCpf
            // 
            this.panelCpf.AutoSize = true;
            this.panelCpf.Controls.Add(this.linhaCpf);
            this.panelCpf.Controls.Add(this.txtCpf);
            this.panelCpf.Location = new System.Drawing.Point(35, 206);
            this.panelCpf.Name = "panelCpf";
            this.panelCpf.Size = new System.Drawing.Size(343, 32);
            this.panelCpf.TabIndex = 53;
            // 
            // linhaCpf
            // 
            this.linhaCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaCpf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaCpf.Location = new System.Drawing.Point(0, 31);
            this.linhaCpf.Name = "linhaCpf";
            this.linhaCpf.Size = new System.Drawing.Size(343, 1);
            this.linhaCpf.TabIndex = 24;
            // 
            // panelRg
            // 
            this.panelRg.AutoSize = true;
            this.panelRg.Controls.Add(this.linhaRg);
            this.panelRg.Controls.Add(this.txtRg);
            this.panelRg.Location = new System.Drawing.Point(35, 256);
            this.panelRg.Name = "panelRg";
            this.panelRg.Size = new System.Drawing.Size(343, 32);
            this.panelRg.TabIndex = 54;
            // 
            // linhaRg
            // 
            this.linhaRg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaRg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaRg.Location = new System.Drawing.Point(0, 31);
            this.linhaRg.Name = "linhaRg";
            this.linhaRg.Size = new System.Drawing.Size(343, 1);
            this.linhaRg.TabIndex = 24;
            // 
            // panelTelefone
            // 
            this.panelTelefone.AutoSize = true;
            this.panelTelefone.Controls.Add(this.linhaTelefone);
            this.panelTelefone.Controls.Add(this.txtTelefone);
            this.panelTelefone.Location = new System.Drawing.Point(35, 305);
            this.panelTelefone.Name = "panelTelefone";
            this.panelTelefone.Size = new System.Drawing.Size(163, 32);
            this.panelTelefone.TabIndex = 55;
            // 
            // linhaTelefone
            // 
            this.linhaTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaTelefone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaTelefone.Location = new System.Drawing.Point(0, 31);
            this.linhaTelefone.Name = "linhaTelefone";
            this.linhaTelefone.Size = new System.Drawing.Size(163, 1);
            this.linhaTelefone.TabIndex = 24;
            // 
            // panelTelefone2
            // 
            this.panelTelefone2.AutoSize = true;
            this.panelTelefone2.Controls.Add(this.linhaTelefone2);
            this.panelTelefone2.Controls.Add(this.txtTelefone2);
            this.panelTelefone2.Location = new System.Drawing.Point(215, 305);
            this.panelTelefone2.Name = "panelTelefone2";
            this.panelTelefone2.Size = new System.Drawing.Size(163, 32);
            this.panelTelefone2.TabIndex = 56;
            // 
            // linhaTelefone2
            // 
            this.linhaTelefone2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaTelefone2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaTelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaTelefone2.Location = new System.Drawing.Point(0, 31);
            this.linhaTelefone2.Name = "linhaTelefone2";
            this.linhaTelefone2.Size = new System.Drawing.Size(163, 1);
            this.linhaTelefone2.TabIndex = 24;
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtTelefone2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone2.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone2.ForeColor = System.Drawing.Color.Silver;
            this.txtTelefone2.Location = new System.Drawing.Point(0, 0);
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(163, 31);
            this.txtTelefone2.TabIndex = 46;
            this.txtTelefone2.Text = "Telefone*";
            this.txtTelefone2.Enter += new System.EventHandler(this.txtTelefone2_Enter);
            this.txtTelefone2.Leave += new System.EventHandler(this.txtTelefone2_Leave);
            // 
            // panelCep
            // 
            this.panelCep.AutoSize = true;
            this.panelCep.Controls.Add(this.linhaCep);
            this.panelCep.Controls.Add(this.txtCep);
            this.panelCep.Location = new System.Drawing.Point(430, 156);
            this.panelCep.Name = "panelCep";
            this.panelCep.Size = new System.Drawing.Size(343, 32);
            this.panelCep.TabIndex = 57;
            // 
            // linhaCep
            // 
            this.linhaCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaCep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaCep.Location = new System.Drawing.Point(0, 31);
            this.linhaCep.Name = "linhaCep";
            this.linhaCep.Size = new System.Drawing.Size(343, 1);
            this.linhaCep.TabIndex = 24;
            // 
            // panelPais
            // 
            this.panelPais.AutoSize = true;
            this.panelPais.Controls.Add(this.linhaPais);
            this.panelPais.Controls.Add(this.txtPais);
            this.panelPais.Location = new System.Drawing.Point(430, 206);
            this.panelPais.Name = "panelPais";
            this.panelPais.Size = new System.Drawing.Size(163, 32);
            this.panelPais.TabIndex = 58;
            // 
            // linhaPais
            // 
            this.linhaPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaPais.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaPais.Location = new System.Drawing.Point(0, 31);
            this.linhaPais.Name = "linhaPais";
            this.linhaPais.Size = new System.Drawing.Size(163, 1);
            this.linhaPais.TabIndex = 24;
            // 
            // panelUf
            // 
            this.panelUf.AutoSize = true;
            this.panelUf.Controls.Add(this.LinhaUf);
            this.panelUf.Controls.Add(this.txtUf);
            this.panelUf.Location = new System.Drawing.Point(610, 206);
            this.panelUf.Name = "panelUf";
            this.panelUf.Size = new System.Drawing.Size(163, 32);
            this.panelUf.TabIndex = 59;
            // 
            // LinhaUf
            // 
            this.LinhaUf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.LinhaUf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LinhaUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinhaUf.Location = new System.Drawing.Point(0, 31);
            this.LinhaUf.Name = "LinhaUf";
            this.LinhaUf.Size = new System.Drawing.Size(163, 1);
            this.LinhaUf.TabIndex = 24;
            // 
            // panelCidade
            // 
            this.panelCidade.AutoSize = true;
            this.panelCidade.Controls.Add(this.linhaCidade);
            this.panelCidade.Controls.Add(this.txtCidade);
            this.panelCidade.Location = new System.Drawing.Point(430, 256);
            this.panelCidade.Name = "panelCidade";
            this.panelCidade.Size = new System.Drawing.Size(343, 32);
            this.panelCidade.TabIndex = 60;
            // 
            // linhaCidade
            // 
            this.linhaCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaCidade.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaCidade.Location = new System.Drawing.Point(0, 31);
            this.linhaCidade.Name = "linhaCidade";
            this.linhaCidade.Size = new System.Drawing.Size(343, 1);
            this.linhaCidade.TabIndex = 24;
            // 
            // panelBairro
            // 
            this.panelBairro.AutoSize = true;
            this.panelBairro.Controls.Add(this.linhaBairro);
            this.panelBairro.Controls.Add(this.txtBairro);
            this.panelBairro.Location = new System.Drawing.Point(430, 305);
            this.panelBairro.Name = "panelBairro";
            this.panelBairro.Size = new System.Drawing.Size(163, 32);
            this.panelBairro.TabIndex = 61;
            // 
            // linhaBairro
            // 
            this.linhaBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaBairro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaBairro.Location = new System.Drawing.Point(0, 31);
            this.linhaBairro.Name = "linhaBairro";
            this.linhaBairro.Size = new System.Drawing.Size(163, 1);
            this.linhaBairro.TabIndex = 24;
            // 
            // panelRua
            // 
            this.panelRua.AutoSize = true;
            this.panelRua.Controls.Add(this.linhaRua);
            this.panelRua.Controls.Add(this.txtRua);
            this.panelRua.Location = new System.Drawing.Point(610, 305);
            this.panelRua.Name = "panelRua";
            this.panelRua.Size = new System.Drawing.Size(163, 32);
            this.panelRua.TabIndex = 62;
            // 
            // linhaRua
            // 
            this.linhaRua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaRua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaRua.Location = new System.Drawing.Point(0, 31);
            this.linhaRua.Name = "linhaRua";
            this.linhaRua.Size = new System.Drawing.Size(163, 1);
            this.linhaRua.TabIndex = 24;
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRua);
            this.Controls.Add(this.panelBairro);
            this.Controls.Add(this.panelCidade);
            this.Controls.Add(this.panelUf);
            this.Controls.Add(this.panelPais);
            this.Controls.Add(this.panelCep);
            this.Controls.Add(this.panelTelefone2);
            this.Controls.Add(this.panelTelefone);
            this.Controls.Add(this.panelRg);
            this.Controls.Add(this.panelCpf);
            this.Controls.Add(this.panelNome);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.labelDadosPessoais);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.labelCadastroCliente);
            this.Name = "FormCadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.MouseEnter += new System.EventHandler(this.FormCadastroCliente_MouseEnter);
            this.panelNome.ResumeLayout(false);
            this.panelNome.PerformLayout();
            this.panelCpf.ResumeLayout(false);
            this.panelCpf.PerformLayout();
            this.panelRg.ResumeLayout(false);
            this.panelRg.PerformLayout();
            this.panelTelefone.ResumeLayout(false);
            this.panelTelefone.PerformLayout();
            this.panelTelefone2.ResumeLayout(false);
            this.panelTelefone2.PerformLayout();
            this.panelCep.ResumeLayout(false);
            this.panelCep.PerformLayout();
            this.panelPais.ResumeLayout(false);
            this.panelPais.PerformLayout();
            this.panelUf.ResumeLayout(false);
            this.panelUf.PerformLayout();
            this.panelCidade.ResumeLayout(false);
            this.panelCidade.PerformLayout();
            this.panelBairro.ResumeLayout(false);
            this.panelBairro.PerformLayout();
            this.panelRua.ResumeLayout(false);
            this.panelRua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label linhaNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label labelCadastroCliente;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label labelDadosPessoais;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Panel panelNome;
        private System.Windows.Forms.Panel panelCpf;
        private System.Windows.Forms.Label linhaCpf;
        private System.Windows.Forms.Panel panelRg;
        private System.Windows.Forms.Label linhaRg;
        private System.Windows.Forms.Panel panelTelefone;
        private System.Windows.Forms.Label linhaTelefone;
        private System.Windows.Forms.Panel panelTelefone2;
        private System.Windows.Forms.Label linhaTelefone2;
        private System.Windows.Forms.TextBox txtTelefone2;
        private System.Windows.Forms.Panel panelCep;
        private System.Windows.Forms.Label linhaCep;
        private System.Windows.Forms.Panel panelPais;
        private System.Windows.Forms.Label linhaPais;
        private System.Windows.Forms.Panel panelUf;
        private System.Windows.Forms.Label LinhaUf;
        private System.Windows.Forms.Panel panelCidade;
        private System.Windows.Forms.Label linhaCidade;
        private System.Windows.Forms.Panel panelBairro;
        private System.Windows.Forms.Label linhaBairro;
        private System.Windows.Forms.Panel panelRua;
        private System.Windows.Forms.Label linhaRua;
    }
}