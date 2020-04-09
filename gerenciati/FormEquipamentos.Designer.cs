namespace gerenciati
{
  partial class FormEquipamentos
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEquipamentos));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.btnConsultar = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.txtObservacao = new System.Windows.Forms.TextBox();
      this.cbxPortaCom = new System.Windows.Forms.ComboBox();
      this.cbxStatus = new System.Windows.Forms.ComboBox();
      this.cbxLoja = new System.Windows.Forms.ComboBox();
      this.txtDescricao = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtNumSerie = new System.Windows.Forms.TextBox();
      this.txtVersao = new System.Windows.Forms.TextBox();
      this.txtTipo = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.txtModelo = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtMarca = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtGenero = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtCodigo = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnNovo = new System.Windows.Forms.Button();
      this.btnSalvar = new System.Windows.Forms.Button();
      this.btnAlterar = new System.Windows.Forms.Button();
      this.btnExcluir = new System.Windows.Forms.Button();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.btnSair = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.pictureBox1);
      this.groupBox1.Controls.Add(this.btnConsultar);
      this.groupBox1.Controls.Add(this.groupBox2);
      this.groupBox1.Controls.Add(this.cbxPortaCom);
      this.groupBox1.Controls.Add(this.cbxStatus);
      this.groupBox1.Controls.Add(this.cbxLoja);
      this.groupBox1.Controls.Add(this.txtDescricao);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txtNumSerie);
      this.groupBox1.Controls.Add(this.txtVersao);
      this.groupBox1.Controls.Add(this.txtTipo);
      this.groupBox1.Controls.Add(this.label10);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.txtModelo);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.txtMarca);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.txtGenero);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.txtCodigo);
      this.groupBox1.Controls.Add(this.label11);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(12, 8);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(704, 409);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Dados do Equipamento / Dispositivo";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(530, 33);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(150, 151);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox1.TabIndex = 5;
      this.pictureBox1.TabStop = false;
      // 
      // btnConsultar
      // 
      this.btnConsultar.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.btnConsultar.Location = new System.Drawing.Point(154, 27);
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
      this.groupBox2.Location = new System.Drawing.Point(20, 230);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(666, 158);
      this.groupBox2.TabIndex = 12;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Observação";
      // 
      // txtObservacao
      // 
      this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtObservacao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.txtObservacao.Location = new System.Drawing.Point(7, 19);
      this.txtObservacao.MaxLength = 300;
      this.txtObservacao.Multiline = true;
      this.txtObservacao.Name = "txtObservacao";
      this.txtObservacao.Size = new System.Drawing.Size(652, 132);
      this.txtObservacao.TabIndex = 0;
      // 
      // cbxPortaCom
      // 
      this.cbxPortaCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxPortaCom.FormattingEnabled = true;
      this.cbxPortaCom.Location = new System.Drawing.Point(286, 190);
      this.cbxPortaCom.Name = "cbxPortaCom";
      this.cbxPortaCom.Size = new System.Drawing.Size(125, 21);
      this.cbxPortaCom.TabIndex = 11;
      // 
      // cbxStatus
      // 
      this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxStatus.FormattingEnabled = true;
      this.cbxStatus.Location = new System.Drawing.Point(265, 28);
      this.cbxStatus.Name = "cbxStatus";
      this.cbxStatus.Size = new System.Drawing.Size(146, 21);
      this.cbxStatus.TabIndex = 2;
      // 
      // cbxLoja
      // 
      this.cbxLoja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxLoja.FormattingEnabled = true;
      this.cbxLoja.Location = new System.Drawing.Point(80, 55);
      this.cbxLoja.Name = "cbxLoja";
      this.cbxLoja.Size = new System.Drawing.Size(331, 21);
      this.cbxLoja.TabIndex = 3;
      // 
      // txtDescricao
      // 
      this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDescricao.Location = new System.Drawing.Point(80, 109);
      this.txtDescricao.MaxLength = 50;
      this.txtDescricao.Name = "txtDescricao";
      this.txtDescricao.Size = new System.Drawing.Size(399, 21);
      this.txtDescricao.TabIndex = 5;
      this.txtDescricao.TextChanged += new System.EventHandler(this.txtGenero_Leave);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(17, 112);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Descrição:";
      // 
      // txtNumSerie
      // 
      this.txtNumSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNumSerie.Location = new System.Drawing.Point(286, 163);
      this.txtNumSerie.MaxLength = 50;
      this.txtNumSerie.Name = "txtNumSerie";
      this.txtNumSerie.Size = new System.Drawing.Size(193, 21);
      this.txtNumSerie.TabIndex = 9;
      // 
      // txtVersao
      // 
      this.txtVersao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtVersao.Location = new System.Drawing.Point(80, 190);
      this.txtVersao.MaxLength = 50;
      this.txtVersao.Name = "txtVersao";
      this.txtVersao.Size = new System.Drawing.Size(68, 21);
      this.txtVersao.TabIndex = 10;
      // 
      // txtTipo
      // 
      this.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtTipo.Location = new System.Drawing.Point(80, 163);
      this.txtTipo.MaxLength = 50;
      this.txtTipo.Name = "txtTipo";
      this.txtTipo.Size = new System.Drawing.Size(135, 21);
      this.txtTipo.TabIndex = 8;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(162, 193);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(118, 13);
      this.label10.TabIndex = 0;
      this.label10.Text = "Porta de Comunicação:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(221, 166);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(63, 13);
      this.label8.TabIndex = 0;
      this.label8.Text = "Núm. Série:";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(30, 193);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(44, 13);
      this.label9.TabIndex = 0;
      this.label9.Text = "Versão:";
      // 
      // txtModelo
      // 
      this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtModelo.Location = new System.Drawing.Point(344, 136);
      this.txtModelo.MaxLength = 50;
      this.txtModelo.Name = "txtModelo";
      this.txtModelo.Size = new System.Drawing.Size(135, 21);
      this.txtModelo.TabIndex = 7;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(43, 166);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(31, 13);
      this.label7.TabIndex = 0;
      this.label7.Text = "Tipo:";
      // 
      // txtMarca
      // 
      this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtMarca.Location = new System.Drawing.Point(80, 136);
      this.txtMarca.MaxLength = 50;
      this.txtMarca.Name = "txtMarca";
      this.txtMarca.Size = new System.Drawing.Size(208, 21);
      this.txtMarca.TabIndex = 6;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(294, 139);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(45, 13);
      this.label6.TabIndex = 0;
      this.label6.Text = "Modelo:";
      // 
      // txtGenero
      // 
      this.txtGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtGenero.Location = new System.Drawing.Point(80, 82);
      this.txtGenero.MaxLength = 50;
      this.txtGenero.Name = "txtGenero";
      this.txtGenero.Size = new System.Drawing.Size(180, 21);
      this.txtGenero.TabIndex = 4;
      this.txtGenero.TextChanged += new System.EventHandler(this.txtGenero_Leave);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(34, 139);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(40, 13);
      this.label5.TabIndex = 0;
      this.label5.Text = "Marca:";
      // 
      // txtCodigo
      // 
      this.txtCodigo.Location = new System.Drawing.Point(80, 28);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new System.Drawing.Size(68, 21);
      this.txtCodigo.TabIndex = 0;
      this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
      this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
      this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(218, 31);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(42, 13);
      this.label11.TabIndex = 0;
      this.label11.Text = "Status:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(28, 85);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(46, 13);
      this.label4.TabIndex = 0;
      this.label4.Text = "Gênero:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(43, 58);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(31, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Loja:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(30, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Código:";
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
      // FormEquipamentos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnSair;
      this.ClientSize = new System.Drawing.Size(728, 460);
      this.Controls.Add(this.btnSair);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnExcluir);
      this.Controls.Add(this.btnAlterar);
      this.Controls.Add(this.btnSalvar);
      this.Controls.Add(this.btnNovo);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormEquipamentos";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cadastro de Equipamentos e Dispositivos";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEquipamentos_KeyDown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btnConsultar;
    private System.Windows.Forms.PictureBox pictureBox1;
    public System.Windows.Forms.TextBox txtCodigo;
    public System.Windows.Forms.ComboBox cbxLoja;
    public System.Windows.Forms.TextBox txtDescricao;
    public System.Windows.Forms.TextBox txtGenero;
    public System.Windows.Forms.TextBox txtModelo;
    public System.Windows.Forms.TextBox txtMarca;
    public System.Windows.Forms.TextBox txtNumSerie;
    public System.Windows.Forms.TextBox txtTipo;
    public System.Windows.Forms.ComboBox cbxPortaCom;
    public System.Windows.Forms.TextBox txtVersao;
    public System.Windows.Forms.ComboBox cbxStatus;
    public System.Windows.Forms.TextBox txtObservacao;
    public System.Windows.Forms.Button btnNovo;
    public System.Windows.Forms.Button btnSalvar;
    public System.Windows.Forms.Button btnAlterar;
    public System.Windows.Forms.Button btnExcluir;
    public System.Windows.Forms.Button btnCancelar;
    public System.Windows.Forms.Button btnSair;
  }
}