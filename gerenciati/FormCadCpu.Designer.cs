namespace gerenciati
{
  partial class FormCadCpu
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadCpu));
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.dtUltManutencao = new System.Windows.Forms.DateTimePicker();
      this.label13 = new System.Windows.Forms.Label();
      this.dtUltLimpeza = new System.Windows.Forms.DateTimePicker();
      this.label12 = new System.Windows.Forms.Label();
      this.txtMidia = new System.Windows.Forms.TextBox();
      this.txtMemoria = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtProcessador = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnConsultar = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.txtObservacao = new System.Windows.Forms.TextBox();
      this.cbxStatus = new System.Windows.Forms.ComboBox();
      this.cbxLoja = new System.Windows.Forms.ComboBox();
      this.txtNumSerie = new System.Windows.Forms.TextBox();
      this.txtHD = new System.Windows.Forms.TextBox();
      this.txtPlacaMae = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.txtModelo = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtMarca = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtCodigo = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.btnSair = new System.Windows.Forms.Button();
      this.btnNovo = new System.Windows.Forms.Button();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.btnExcluir = new System.Windows.Forms.Button();
      this.btnSalvar = new System.Windows.Forms.Button();
      this.btnAlterar = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(507, 20);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(163, 136);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 5;
      this.pictureBox1.TabStop = false;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.dtUltManutencao);
      this.groupBox1.Controls.Add(this.label13);
      this.groupBox1.Controls.Add(this.dtUltLimpeza);
      this.groupBox1.Controls.Add(this.label12);
      this.groupBox1.Controls.Add(this.txtMidia);
      this.groupBox1.Controls.Add(this.txtMemoria);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.txtProcessador);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.pictureBox1);
      this.groupBox1.Controls.Add(this.btnConsultar);
      this.groupBox1.Controls.Add(this.groupBox2);
      this.groupBox1.Controls.Add(this.cbxStatus);
      this.groupBox1.Controls.Add(this.cbxLoja);
      this.groupBox1.Controls.Add(this.txtNumSerie);
      this.groupBox1.Controls.Add(this.txtHD);
      this.groupBox1.Controls.Add(this.txtPlacaMae);
      this.groupBox1.Controls.Add(this.label10);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.txtModelo);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.txtMarca);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.txtCodigo);
      this.groupBox1.Controls.Add(this.label11);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.label14);
      this.groupBox1.Controls.Add(this.label15);
      this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(12, 8);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(704, 409);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Dados da CPU";
      // 
      // dtUltManutencao
      // 
      this.dtUltManutencao.Enabled = false;
      this.dtUltManutencao.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtUltManutencao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtUltManutencao.Location = new System.Drawing.Point(552, 273);
      this.dtUltManutencao.Name = "dtUltManutencao";
      this.dtUltManutencao.Size = new System.Drawing.Size(115, 23);
      this.dtUltManutencao.TabIndex = 13;
      this.dtUltManutencao.Value = new System.DateTime(1990, 1, 1, 18, 14, 0, 0);
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Tahoma", 9F);
      this.label13.Location = new System.Drawing.Point(430, 246);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(134, 14);
      this.label13.TabIndex = 20;
      this.label13.Text = "ÚLTIMA MANUTENÇÃO";
      // 
      // dtUltLimpeza
      // 
      this.dtUltLimpeza.Enabled = false;
      this.dtUltLimpeza.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtUltLimpeza.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtUltLimpeza.Location = new System.Drawing.Point(552, 342);
      this.dtUltLimpeza.Name = "dtUltLimpeza";
      this.dtUltLimpeza.Size = new System.Drawing.Size(115, 23);
      this.dtUltLimpeza.TabIndex = 14;
      this.dtUltLimpeza.Value = new System.DateTime(1990, 1, 1, 18, 14, 0, 0);
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Tahoma", 9F);
      this.label12.Location = new System.Drawing.Point(430, 315);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(102, 14);
      this.label12.TabIndex = 18;
      this.label12.Text = "ÚLTIMA LIMPEZA";
      // 
      // txtMidia
      // 
      this.txtMidia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtMidia.Location = new System.Drawing.Point(411, 191);
      this.txtMidia.MaxLength = 50;
      this.txtMidia.Name = "txtMidia";
      this.txtMidia.Size = new System.Drawing.Size(68, 21);
      this.txtMidia.TabIndex = 11;
      // 
      // txtMemoria
      // 
      this.txtMemoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtMemoria.Location = new System.Drawing.Point(80, 191);
      this.txtMemoria.MaxLength = 50;
      this.txtMemoria.Name = "txtMemoria";
      this.txtMemoria.Size = new System.Drawing.Size(149, 21);
      this.txtMemoria.TabIndex = 9;
      this.txtMemoria.Leave += new System.EventHandler(this.txtProcessador_Leave);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(25, 195);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(51, 13);
      this.label4.TabIndex = 15;
      this.label4.Text = "Memória:";
      // 
      // txtProcessador
      // 
      this.txtProcessador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtProcessador.Location = new System.Drawing.Point(80, 164);
      this.txtProcessador.MaxLength = 50;
      this.txtProcessador.Name = "txtProcessador";
      this.txtProcessador.Size = new System.Drawing.Size(180, 21);
      this.txtProcessador.TabIndex = 8;
      this.txtProcessador.Leave += new System.EventHandler(this.txtProcessador_Leave);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(4, 168);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(70, 13);
      this.label2.TabIndex = 13;
      this.label2.Text = "Processador:";
      // 
      // btnConsultar
      // 
      this.btnConsultar.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.btnConsultar.Location = new System.Drawing.Point(154, 28);
      this.btnConsultar.Name = "btnConsultar";
      this.btnConsultar.Size = new System.Drawing.Size(27, 22);
      this.btnConsultar.TabIndex = 1;
      this.btnConsultar.Text = "...";
      this.btnConsultar.UseVisualStyleBackColor = true;
      this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtObservacao);
      this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.groupBox2.Location = new System.Drawing.Point(18, 224);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(402, 165);
      this.groupBox2.TabIndex = 12;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Observação";
      // 
      // txtObservacao
      // 
      this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtObservacao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.txtObservacao.Location = new System.Drawing.Point(7, 20);
      this.txtObservacao.MaxLength = 300;
      this.txtObservacao.Multiline = true;
      this.txtObservacao.Name = "txtObservacao";
      this.txtObservacao.Size = new System.Drawing.Size(385, 132);
      this.txtObservacao.TabIndex = 0;
      // 
      // cbxStatus
      // 
      this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxStatus.FormattingEnabled = true;
      this.cbxStatus.Location = new System.Drawing.Point(265, 29);
      this.cbxStatus.Name = "cbxStatus";
      this.cbxStatus.Size = new System.Drawing.Size(146, 21);
      this.cbxStatus.TabIndex = 2;
      // 
      // cbxLoja
      // 
      this.cbxLoja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxLoja.FormattingEnabled = true;
      this.cbxLoja.Location = new System.Drawing.Point(80, 56);
      this.cbxLoja.Name = "cbxLoja";
      this.cbxLoja.Size = new System.Drawing.Size(331, 21);
      this.cbxLoja.TabIndex = 3;
      // 
      // txtNumSerie
      // 
      this.txtNumSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNumSerie.Location = new System.Drawing.Point(80, 110);
      this.txtNumSerie.MaxLength = 50;
      this.txtNumSerie.Name = "txtNumSerie";
      this.txtNumSerie.Size = new System.Drawing.Size(208, 21);
      this.txtNumSerie.TabIndex = 6;
      // 
      // txtHD
      // 
      this.txtHD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtHD.Location = new System.Drawing.Point(265, 191);
      this.txtHD.MaxLength = 50;
      this.txtHD.Name = "txtHD";
      this.txtHD.Size = new System.Drawing.Size(97, 21);
      this.txtHD.TabIndex = 10;
      // 
      // txtPlacaMae
      // 
      this.txtPlacaMae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtPlacaMae.Location = new System.Drawing.Point(80, 137);
      this.txtPlacaMae.MaxLength = 50;
      this.txtPlacaMae.Name = "txtPlacaMae";
      this.txtPlacaMae.Size = new System.Drawing.Size(180, 21);
      this.txtPlacaMae.TabIndex = 7;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(370, 195);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(35, 13);
      this.label10.TabIndex = 0;
      this.label10.Text = "Mídia:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(11, 114);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(63, 13);
      this.label8.TabIndex = 0;
      this.label8.Text = "Núm. Série:";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(235, 194);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(25, 13);
      this.label9.TabIndex = 0;
      this.label9.Text = "HD:";
      // 
      // txtModelo
      // 
      this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtModelo.Location = new System.Drawing.Point(344, 83);
      this.txtModelo.MaxLength = 50;
      this.txtModelo.Name = "txtModelo";
      this.txtModelo.Size = new System.Drawing.Size(135, 21);
      this.txtModelo.TabIndex = 5;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(15, 141);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(59, 13);
      this.label7.TabIndex = 0;
      this.label7.Text = "Placa Mãe:";
      // 
      // txtMarca
      // 
      this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtMarca.Location = new System.Drawing.Point(80, 83);
      this.txtMarca.MaxLength = 50;
      this.txtMarca.Name = "txtMarca";
      this.txtMarca.Size = new System.Drawing.Size(208, 21);
      this.txtMarca.TabIndex = 4;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(294, 86);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(45, 13);
      this.label6.TabIndex = 0;
      this.label6.Text = "Modelo:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(34, 87);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(40, 13);
      this.label5.TabIndex = 0;
      this.label5.Text = "Marca:";
      // 
      // txtCodigo
      // 
      this.txtCodigo.Location = new System.Drawing.Point(80, 29);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new System.Drawing.Size(68, 21);
      this.txtCodigo.TabIndex = 0;
      this.txtCodigo.Click += new System.EventHandler(this.txtCodigo_Click);
      this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
      this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
      this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(218, 32);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(42, 13);
      this.label11.TabIndex = 0;
      this.label11.Text = "Status:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(43, 60);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(31, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Loja:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(30, 33);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Código:";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.label14.Location = new System.Drawing.Point(430, 256);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(242, 14);
      this.label14.TabIndex = 20;
      this.label14.Text = "-----------------------------------------------";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.label15.Location = new System.Drawing.Point(430, 325);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(242, 14);
      this.label15.TabIndex = 20;
      this.label15.Text = "-----------------------------------------------";
      // 
      // btnSair
      // 
      this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnSair.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnSair.Location = new System.Drawing.Point(472, 425);
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(86, 27);
      this.btnSair.TabIndex = 6;
      this.btnSair.Text = "Sair";
      this.btnSair.UseVisualStyleBackColor = true;
      this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
      // 
      // btnNovo
      // 
      this.btnNovo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnNovo.Location = new System.Drawing.Point(12, 425);
      this.btnNovo.Name = "btnNovo";
      this.btnNovo.Size = new System.Drawing.Size(86, 27);
      this.btnNovo.TabIndex = 1;
      this.btnNovo.Text = "&Novo";
      this.btnNovo.UseVisualStyleBackColor = true;
      this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
      // 
      // btnCancelar
      // 
      this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnCancelar.Location = new System.Drawing.Point(380, 425);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(86, 27);
      this.btnCancelar.TabIndex = 5;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // btnExcluir
      // 
      this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnExcluir.Location = new System.Drawing.Point(288, 425);
      this.btnExcluir.Name = "btnExcluir";
      this.btnExcluir.Size = new System.Drawing.Size(86, 27);
      this.btnExcluir.TabIndex = 4;
      this.btnExcluir.Text = "Excluir";
      this.btnExcluir.UseVisualStyleBackColor = true;
      this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
      // 
      // btnSalvar
      // 
      this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnSalvar.Location = new System.Drawing.Point(104, 425);
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(86, 27);
      this.btnSalvar.TabIndex = 2;
      this.btnSalvar.Text = "&Salvar";
      this.btnSalvar.UseVisualStyleBackColor = true;
      this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
      // 
      // btnAlterar
      // 
      this.btnAlterar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnAlterar.Location = new System.Drawing.Point(196, 425);
      this.btnAlterar.Name = "btnAlterar";
      this.btnAlterar.Size = new System.Drawing.Size(86, 27);
      this.btnAlterar.TabIndex = 3;
      this.btnAlterar.Text = "Alterar";
      this.btnAlterar.UseVisualStyleBackColor = true;
      this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
      // 
      // FormCadCpu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnSair;
      this.ClientSize = new System.Drawing.Size(728, 460);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnAlterar);
      this.Controls.Add(this.btnSalvar);
      this.Controls.Add(this.btnExcluir);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnNovo);
      this.Controls.Add(this.btnSair);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormCadCpu";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cadastro de CPUs";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadCpu_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnConsultar;
    private System.Windows.Forms.GroupBox groupBox2;
    public System.Windows.Forms.TextBox txtObservacao;
    public System.Windows.Forms.ComboBox cbxStatus;
    public System.Windows.Forms.ComboBox cbxLoja;
    public System.Windows.Forms.TextBox txtNumSerie;
    public System.Windows.Forms.TextBox txtHD;
    public System.Windows.Forms.TextBox txtPlacaMae;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    public System.Windows.Forms.TextBox txtModelo;
    private System.Windows.Forms.Label label7;
    public System.Windows.Forms.TextBox txtMarca;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    public System.Windows.Forms.TextBox txtCodigo;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.TextBox txtProcessador;
    private System.Windows.Forms.Label label2;
    public System.Windows.Forms.TextBox txtMemoria;
    private System.Windows.Forms.Label label4;
    public System.Windows.Forms.TextBox txtMidia;
    private System.Windows.Forms.Label label12;
    public System.Windows.Forms.DateTimePicker dtUltLimpeza;
    public System.Windows.Forms.DateTimePicker dtUltManutencao;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label15;
    public System.Windows.Forms.Button btnSair;
    public System.Windows.Forms.Button btnNovo;
    public System.Windows.Forms.Button btnCancelar;
    public System.Windows.Forms.Button btnExcluir;
    public System.Windows.Forms.Button btnSalvar;
    public System.Windows.Forms.Button btnAlterar;
  }
}