namespace gerenciati
{
  partial class FormCadPDV
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadPDV));
      this.btnSair = new System.Windows.Forms.Button();
      this.btnSalvar = new System.Windows.Forms.Button();
      this.btnNovo = new System.Windows.Forms.Button();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.btnExcluir = new System.Windows.Forms.Button();
      this.btnAlterar = new System.Windows.Forms.Button();
      this.tabEquip = new System.Windows.Forms.TabControl();
      this.tabDados = new System.Windows.Forms.TabPage();
      this.label2 = new System.Windows.Forms.Label();
      this.dtUltManutencao = new System.Windows.Forms.DateTimePicker();
      this.label13 = new System.Windows.Forms.Label();
      this.dtUltLimpeza = new System.Windows.Forms.DateTimePicker();
      this.label12 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.btnConsultar = new System.Windows.Forms.Button();
      this.gbECF = new System.Windows.Forms.GroupBox();
      this.txtNumECF = new System.Windows.Forms.TextBox();
      this.txtIdECF = new System.Windows.Forms.TextBox();
      this.txtNumSerieECF = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.txtObservacao = new System.Windows.Forms.TextBox();
      this.cbxStatus = new System.Windows.Forms.ComboBox();
      this.cbxLoja = new System.Windows.Forms.ComboBox();
      this.txtCodigo = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.tabEquip.SuspendLayout();
      this.tabDados.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.gbECF.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnSair
      // 
      this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnSair.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnSair.Location = new System.Drawing.Point(472, 425);
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(86, 27);
      this.btnSair.TabIndex = 13;
      this.btnSair.Text = "Sair";
      this.btnSair.UseVisualStyleBackColor = true;
      // 
      // btnSalvar
      // 
      this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnSalvar.Location = new System.Drawing.Point(104, 425);
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(86, 27);
      this.btnSalvar.TabIndex = 9;
      this.btnSalvar.Text = "&Salvar";
      this.btnSalvar.UseVisualStyleBackColor = true;
      // 
      // btnNovo
      // 
      this.btnNovo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnNovo.Location = new System.Drawing.Point(12, 425);
      this.btnNovo.Name = "btnNovo";
      this.btnNovo.Size = new System.Drawing.Size(86, 27);
      this.btnNovo.TabIndex = 8;
      this.btnNovo.Text = "&Novo";
      this.btnNovo.UseVisualStyleBackColor = true;
      // 
      // btnCancelar
      // 
      this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnCancelar.Location = new System.Drawing.Point(380, 425);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(86, 27);
      this.btnCancelar.TabIndex = 12;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      // 
      // btnExcluir
      // 
      this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnExcluir.Location = new System.Drawing.Point(288, 425);
      this.btnExcluir.Name = "btnExcluir";
      this.btnExcluir.Size = new System.Drawing.Size(86, 27);
      this.btnExcluir.TabIndex = 11;
      this.btnExcluir.Text = "Excluir";
      this.btnExcluir.UseVisualStyleBackColor = true;
      // 
      // btnAlterar
      // 
      this.btnAlterar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnAlterar.Location = new System.Drawing.Point(196, 425);
      this.btnAlterar.Name = "btnAlterar";
      this.btnAlterar.Size = new System.Drawing.Size(86, 27);
      this.btnAlterar.TabIndex = 10;
      this.btnAlterar.Text = "Alterar";
      this.btnAlterar.UseVisualStyleBackColor = true;
      // 
      // tabEquip
      // 
      this.tabEquip.Controls.Add(this.tabDados);
      this.tabEquip.Controls.Add(this.tabPage2);
      this.tabEquip.Location = new System.Drawing.Point(12, 12);
      this.tabEquip.Name = "tabEquip";
      this.tabEquip.SelectedIndex = 0;
      this.tabEquip.Size = new System.Drawing.Size(704, 407);
      this.tabEquip.TabIndex = 14;
      // 
      // tabDados
      // 
      this.tabDados.BackColor = System.Drawing.Color.Transparent;
      this.tabDados.Controls.Add(this.label2);
      this.tabDados.Controls.Add(this.dtUltManutencao);
      this.tabDados.Controls.Add(this.label13);
      this.tabDados.Controls.Add(this.dtUltLimpeza);
      this.tabDados.Controls.Add(this.label12);
      this.tabDados.Controls.Add(this.pictureBox1);
      this.tabDados.Controls.Add(this.btnConsultar);
      this.tabDados.Controls.Add(this.gbECF);
      this.tabDados.Controls.Add(this.groupBox2);
      this.tabDados.Controls.Add(this.cbxStatus);
      this.tabDados.Controls.Add(this.cbxLoja);
      this.tabDados.Controls.Add(this.txtCodigo);
      this.tabDados.Controls.Add(this.label11);
      this.tabDados.Controls.Add(this.label3);
      this.tabDados.Controls.Add(this.label1);
      this.tabDados.Controls.Add(this.label14);
      this.tabDados.Controls.Add(this.label15);
      this.tabDados.Location = new System.Drawing.Point(4, 22);
      this.tabDados.Name = "tabDados";
      this.tabDados.Padding = new System.Windows.Forms.Padding(3);
      this.tabDados.Size = new System.Drawing.Size(696, 381);
      this.tabDados.TabIndex = 0;
      this.tabDados.Text = "Dados do PDV";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.label2.Location = new System.Drawing.Point(32, 73);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(387, 14);
      this.label2.TabIndex = 52;
      this.label2.Text = "----------------------------------------------------------------------------";
      // 
      // dtUltManutencao
      // 
      this.dtUltManutencao.Enabled = false;
      this.dtUltManutencao.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtUltManutencao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtUltManutencao.Location = new System.Drawing.Point(562, 259);
      this.dtUltManutencao.Name = "dtUltManutencao";
      this.dtUltManutencao.Size = new System.Drawing.Size(115, 23);
      this.dtUltManutencao.TabIndex = 45;
      this.dtUltManutencao.Value = new System.DateTime(1990, 1, 1, 18, 14, 0, 0);
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Tahoma", 9F);
      this.label13.Location = new System.Drawing.Point(440, 232);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(134, 14);
      this.label13.TabIndex = 51;
      this.label13.Text = "ÚLTIMA MANUTENÇÃO";
      // 
      // dtUltLimpeza
      // 
      this.dtUltLimpeza.Enabled = false;
      this.dtUltLimpeza.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtUltLimpeza.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtUltLimpeza.Location = new System.Drawing.Point(562, 328);
      this.dtUltLimpeza.Name = "dtUltLimpeza";
      this.dtUltLimpeza.Size = new System.Drawing.Size(115, 23);
      this.dtUltLimpeza.TabIndex = 46;
      this.dtUltLimpeza.Value = new System.DateTime(1990, 1, 1, 18, 14, 0, 0);
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Tahoma", 9F);
      this.label12.Location = new System.Drawing.Point(440, 301);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(102, 14);
      this.label12.TabIndex = 48;
      this.label12.Text = "ÚLTIMA LIMPEZA";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(519, 14);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(163, 136);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 35;
      this.pictureBox1.TabStop = false;
      // 
      // btnConsultar
      // 
      this.btnConsultar.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.btnConsultar.Location = new System.Drawing.Point(164, 14);
      this.btnConsultar.Name = "btnConsultar";
      this.btnConsultar.Size = new System.Drawing.Size(27, 22);
      this.btnConsultar.TabIndex = 31;
      this.btnConsultar.Text = "...";
      this.btnConsultar.UseVisualStyleBackColor = true;
      // 
      // gbECF
      // 
      this.gbECF.Controls.Add(this.txtNumECF);
      this.gbECF.Controls.Add(this.txtIdECF);
      this.gbECF.Controls.Add(this.txtNumSerieECF);
      this.gbECF.Controls.Add(this.label6);
      this.gbECF.Controls.Add(this.label4);
      this.gbECF.Controls.Add(this.label5);
      this.gbECF.Controls.Add(this.button1);
      this.gbECF.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.gbECF.Location = new System.Drawing.Point(28, 92);
      this.gbECF.Name = "gbECF";
      this.gbECF.Size = new System.Drawing.Size(313, 82);
      this.gbECF.TabIndex = 43;
      this.gbECF.TabStop = false;
      this.gbECF.Text = "ECF";
      // 
      // txtNumECF
      // 
      this.txtNumECF.Location = new System.Drawing.Point(232, 20);
      this.txtNumECF.Name = "txtNumECF";
      this.txtNumECF.Size = new System.Drawing.Size(68, 21);
      this.txtNumECF.TabIndex = 56;
      // 
      // txtIdECF
      // 
      this.txtIdECF.Location = new System.Drawing.Point(62, 20);
      this.txtIdECF.Name = "txtIdECF";
      this.txtIdECF.Size = new System.Drawing.Size(68, 21);
      this.txtIdECF.TabIndex = 56;
      // 
      // txtNumSerieECF
      // 
      this.txtNumSerieECF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNumSerieECF.Location = new System.Drawing.Point(62, 47);
      this.txtNumSerieECF.MaxLength = 50;
      this.txtNumSerieECF.Name = "txtNumSerieECF";
      this.txtNumSerieECF.Size = new System.Drawing.Size(240, 21);
      this.txtNumSerieECF.TabIndex = 55;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(7, 50);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(49, 13);
      this.label6.TabIndex = 54;
      this.label6.Text = "N. Série:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(169, 23);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(57, 13);
      this.label4.TabIndex = 54;
      this.label4.Text = "N. Ordem:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(34, 23);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(22, 13);
      this.label5.TabIndex = 54;
      this.label5.Text = "ID:";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.button1.Location = new System.Drawing.Point(136, 20);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(27, 22);
      this.button1.TabIndex = 31;
      this.button1.Text = "...";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtObservacao);
      this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.groupBox2.Location = new System.Drawing.Point(28, 210);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(402, 165);
      this.groupBox2.TabIndex = 43;
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
      this.cbxStatus.Location = new System.Drawing.Point(275, 15);
      this.cbxStatus.Name = "cbxStatus";
      this.cbxStatus.Size = new System.Drawing.Size(146, 21);
      this.cbxStatus.TabIndex = 32;
      // 
      // cbxLoja
      // 
      this.cbxLoja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxLoja.FormattingEnabled = true;
      this.cbxLoja.Location = new System.Drawing.Point(90, 42);
      this.cbxLoja.Name = "cbxLoja";
      this.cbxLoja.Size = new System.Drawing.Size(331, 21);
      this.cbxLoja.TabIndex = 33;
      // 
      // txtCodigo
      // 
      this.txtCodigo.Location = new System.Drawing.Point(90, 15);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new System.Drawing.Size(68, 21);
      this.txtCodigo.TabIndex = 21;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(228, 18);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(42, 13);
      this.label11.TabIndex = 30;
      this.label11.Text = "Status:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(53, 46);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(31, 13);
      this.label3.TabIndex = 28;
      this.label3.Text = "Loja:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(40, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 26;
      this.label1.Text = "Código:";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.label14.Location = new System.Drawing.Point(440, 242);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(242, 14);
      this.label14.TabIndex = 50;
      this.label14.Text = "-----------------------------------------------";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.label15.Location = new System.Drawing.Point(440, 311);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(242, 14);
      this.label15.TabIndex = 49;
      this.label15.Text = "-----------------------------------------------";
      // 
      // tabPage2
      // 
      this.tabPage2.BackColor = System.Drawing.Color.Transparent;
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(696, 381);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Equipamentos";
      // 
      // FormCadPDV
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(728, 460);
      this.Controls.Add(this.tabEquip);
      this.Controls.Add(this.btnSair);
      this.Controls.Add(this.btnSalvar);
      this.Controls.Add(this.btnNovo);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnExcluir);
      this.Controls.Add(this.btnAlterar);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormCadPDV";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cadastro de PDVs";
      this.tabEquip.ResumeLayout(false);
      this.tabDados.ResumeLayout(false);
      this.tabDados.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.gbECF.ResumeLayout(false);
      this.gbECF.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    public System.Windows.Forms.Button btnSair;
    public System.Windows.Forms.Button btnSalvar;
    public System.Windows.Forms.Button btnNovo;
    public System.Windows.Forms.Button btnCancelar;
    public System.Windows.Forms.Button btnExcluir;
    public System.Windows.Forms.Button btnAlterar;
    private System.Windows.Forms.TabControl tabEquip;
    private System.Windows.Forms.TabPage tabDados;
    private System.Windows.Forms.TabPage tabPage2;
    public System.Windows.Forms.DateTimePicker dtUltManutencao;
    private System.Windows.Forms.Label label13;
    public System.Windows.Forms.DateTimePicker dtUltLimpeza;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button btnConsultar;
    private System.Windows.Forms.GroupBox groupBox2;
    public System.Windows.Forms.TextBox txtObservacao;
    public System.Windows.Forms.ComboBox cbxStatus;
    public System.Windows.Forms.ComboBox cbxLoja;
    public System.Windows.Forms.TextBox txtCodigo;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.GroupBox gbECF;
    public System.Windows.Forms.TextBox txtNumECF;
    public System.Windows.Forms.TextBox txtIdECF;
    public System.Windows.Forms.TextBox txtNumSerieECF;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label2;
  }
}