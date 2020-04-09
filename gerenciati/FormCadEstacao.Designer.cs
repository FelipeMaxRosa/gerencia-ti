namespace gerenciati
{
  partial class FormCadEstacao
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnOcorrencia = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.dtUltLimpeza = new System.Windows.Forms.DateTimePicker();
      this.txtMidia = new System.Windows.Forms.TextBox();
      this.txtMemoria = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtProcessador = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtHD = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.btnConsCPU = new System.Windows.Forms.Button();
      this.txtIDCpu = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtUsuario = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtEstacao = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.btnConsultar = new System.Windows.Forms.Button();
      this.txtID = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnAlterar = new System.Windows.Forms.Button();
      this.btnSalvar = new System.Windows.Forms.Button();
      this.btnExcluir = new System.Windows.Forms.Button();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.btnNovo = new System.Windows.Forms.Button();
      this.btnSair = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnOcorrencia);
      this.groupBox1.Controls.Add(this.groupBox2);
      this.groupBox1.Controls.Add(this.txtUsuario);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.txtEstacao);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.btnConsultar);
      this.groupBox1.Controls.Add(this.txtID);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(12, 8);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(735, 227);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Dados da Estação de Trabalho";
      // 
      // btnOcorrencia
      // 
      this.btnOcorrencia.Enabled = false;
      this.btnOcorrencia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnOcorrencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnOcorrencia.Location = new System.Drawing.Point(583, 170);
      this.btnOcorrencia.Name = "btnOcorrencia";
      this.btnOcorrencia.Size = new System.Drawing.Size(133, 35);
      this.btnOcorrencia.TabIndex = 10;
      this.btnOcorrencia.Text = "Ocorrência";
      this.btnOcorrencia.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.dtUltLimpeza);
      this.groupBox2.Controls.Add(this.txtMidia);
      this.groupBox2.Controls.Add(this.txtMemoria);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.txtProcessador);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.txtHD);
      this.groupBox2.Controls.Add(this.label10);
      this.groupBox2.Controls.Add(this.label9);
      this.groupBox2.Controls.Add(this.btnConsCPU);
      this.groupBox2.Controls.Add(this.txtIDCpu);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Location = new System.Drawing.Point(29, 93);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(526, 112);
      this.groupBox2.TabIndex = 4;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "CPU";
      // 
      // dtUltLimpeza
      // 
      this.dtUltLimpeza.Enabled = false;
      this.dtUltLimpeza.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtUltLimpeza.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtUltLimpeza.Location = new System.Drawing.Point(382, 18);
      this.dtUltLimpeza.Name = "dtUltLimpeza";
      this.dtUltLimpeza.Size = new System.Drawing.Size(115, 23);
      this.dtUltLimpeza.TabIndex = 24;
      this.dtUltLimpeza.TabStop = false;
      this.dtUltLimpeza.Value = new System.DateTime(1990, 1, 1, 18, 14, 0, 0);
      // 
      // txtMidia
      // 
      this.txtMidia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtMidia.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMidia.Location = new System.Drawing.Point(429, 74);
      this.txtMidia.MaxLength = 50;
      this.txtMidia.Name = "txtMidia";
      this.txtMidia.ReadOnly = true;
      this.txtMidia.Size = new System.Drawing.Size(68, 21);
      this.txtMidia.TabIndex = 5;
      this.txtMidia.TabStop = false;
      // 
      // txtMemoria
      // 
      this.txtMemoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtMemoria.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMemoria.Location = new System.Drawing.Point(98, 74);
      this.txtMemoria.MaxLength = 50;
      this.txtMemoria.Name = "txtMemoria";
      this.txtMemoria.ReadOnly = true;
      this.txtMemoria.Size = new System.Drawing.Size(149, 21);
      this.txtMemoria.TabIndex = 3;
      this.txtMemoria.TabStop = false;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(43, 78);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(51, 13);
      this.label4.TabIndex = 23;
      this.label4.Text = "Memória:";
      // 
      // txtProcessador
      // 
      this.txtProcessador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtProcessador.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtProcessador.Location = new System.Drawing.Point(98, 47);
      this.txtProcessador.MaxLength = 50;
      this.txtProcessador.Name = "txtProcessador";
      this.txtProcessador.ReadOnly = true;
      this.txtProcessador.Size = new System.Drawing.Size(180, 21);
      this.txtProcessador.TabIndex = 2;
      this.txtProcessador.TabStop = false;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(295, 23);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(81, 13);
      this.label6.TabIndex = 22;
      this.label6.Text = "Última Limpeza:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(22, 51);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(70, 13);
      this.label3.TabIndex = 22;
      this.label3.Text = "Processador:";
      // 
      // txtHD
      // 
      this.txtHD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtHD.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtHD.Location = new System.Drawing.Point(283, 74);
      this.txtHD.MaxLength = 50;
      this.txtHD.Name = "txtHD";
      this.txtHD.ReadOnly = true;
      this.txtHD.Size = new System.Drawing.Size(97, 21);
      this.txtHD.TabIndex = 4;
      this.txtHD.TabStop = false;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(388, 78);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(35, 13);
      this.label10.TabIndex = 16;
      this.label10.Text = "Mídia:";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(253, 77);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(25, 13);
      this.label9.TabIndex = 17;
      this.label9.Text = "HD:";
      // 
      // btnConsCPU
      // 
      this.btnConsCPU.Enabled = false;
      this.btnConsCPU.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.btnConsCPU.Location = new System.Drawing.Point(172, 19);
      this.btnConsCPU.Name = "btnConsCPU";
      this.btnConsCPU.Size = new System.Drawing.Size(27, 22);
      this.btnConsCPU.TabIndex = 1;
      this.btnConsCPU.Text = "...";
      this.btnConsCPU.UseVisualStyleBackColor = true;
      this.btnConsCPU.Click += new System.EventHandler(this.btnConsCPU_Click);
      // 
      // txtIDCpu
      // 
      this.txtIDCpu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtIDCpu.Location = new System.Drawing.Point(98, 20);
      this.txtIDCpu.Name = "txtIDCpu";
      this.txtIDCpu.ReadOnly = true;
      this.txtIDCpu.Size = new System.Drawing.Size(68, 21);
      this.txtIDCpu.TabIndex = 0;
      this.txtIDCpu.TabStop = false;
      this.txtIDCpu.Leave += new System.EventHandler(this.txtIDCpu_Leave);
      this.txtIDCpu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(70, 24);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(22, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "ID:";
      // 
      // txtUsuario
      // 
      this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUsuario.Location = new System.Drawing.Point(439, 56);
      this.txtUsuario.MaxLength = 50;
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.ReadOnly = true;
      this.txtUsuario.Size = new System.Drawing.Size(116, 21);
      this.txtUsuario.TabIndex = 3;
      this.txtUsuario.TabStop = false;
      this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(386, 59);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(47, 13);
      this.label7.TabIndex = 9;
      this.label7.Text = "Usuário:";
      // 
      // txtEstacao
      // 
      this.txtEstacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtEstacao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtEstacao.Location = new System.Drawing.Point(72, 56);
      this.txtEstacao.MaxLength = 50;
      this.txtEstacao.Name = "txtEstacao";
      this.txtEstacao.ReadOnly = true;
      this.txtEstacao.Size = new System.Drawing.Size(208, 21);
      this.txtEstacao.TabIndex = 2;
      this.txtEstacao.TabStop = false;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(17, 59);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(49, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Estação:";
      // 
      // btnConsultar
      // 
      this.btnConsultar.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.btnConsultar.Location = new System.Drawing.Point(146, 28);
      this.btnConsultar.Name = "btnConsultar";
      this.btnConsultar.Size = new System.Drawing.Size(27, 22);
      this.btnConsultar.TabIndex = 1;
      this.btnConsultar.Text = "...";
      this.btnConsultar.UseVisualStyleBackColor = true;
      this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
      // 
      // txtID
      // 
      this.txtID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtID.Location = new System.Drawing.Point(72, 29);
      this.txtID.Name = "txtID";
      this.txtID.Size = new System.Drawing.Size(68, 21);
      this.txtID.TabIndex = 0;
      this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
      this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
      this.txtID.Enter += new System.EventHandler(this.txtID_Enter);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(44, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(22, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "ID:";
      // 
      // btnAlterar
      // 
      this.btnAlterar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnAlterar.Location = new System.Drawing.Point(196, 242);
      this.btnAlterar.Name = "btnAlterar";
      this.btnAlterar.Size = new System.Drawing.Size(86, 27);
      this.btnAlterar.TabIndex = 3;
      this.btnAlterar.Text = "Alterar";
      this.btnAlterar.UseVisualStyleBackColor = true;
      this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
      // 
      // btnSalvar
      // 
      this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnSalvar.Location = new System.Drawing.Point(104, 242);
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(86, 27);
      this.btnSalvar.TabIndex = 2;
      this.btnSalvar.Text = "&Salvar";
      this.btnSalvar.UseVisualStyleBackColor = true;
      this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
      // 
      // btnExcluir
      // 
      this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnExcluir.Location = new System.Drawing.Point(288, 242);
      this.btnExcluir.Name = "btnExcluir";
      this.btnExcluir.Size = new System.Drawing.Size(86, 27);
      this.btnExcluir.TabIndex = 4;
      this.btnExcluir.Text = "Excluir";
      this.btnExcluir.UseVisualStyleBackColor = true;
      // 
      // btnCancelar
      // 
      this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnCancelar.Location = new System.Drawing.Point(380, 242);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(86, 27);
      this.btnCancelar.TabIndex = 5;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // btnNovo
      // 
      this.btnNovo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnNovo.Location = new System.Drawing.Point(12, 242);
      this.btnNovo.Name = "btnNovo";
      this.btnNovo.Size = new System.Drawing.Size(86, 27);
      this.btnNovo.TabIndex = 1;
      this.btnNovo.Text = "&Novo";
      this.btnNovo.UseVisualStyleBackColor = true;
      this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
      // 
      // btnSair
      // 
      this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnSair.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.btnSair.Location = new System.Drawing.Point(472, 242);
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(86, 27);
      this.btnSair.TabIndex = 6;
      this.btnSair.Text = "Sair";
      this.btnSair.UseVisualStyleBackColor = true;
      this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
      // 
      // FormCadEstacao
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(759, 277);
      this.Controls.Add(this.btnAlterar);
      this.Controls.Add(this.btnSalvar);
      this.Controls.Add(this.btnExcluir);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnNovo);
      this.Controls.Add(this.btnSair);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormCadEstacao";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cadastro de Estações de Trabalho";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadEstacao_KeyDown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnConsultar;
    public System.Windows.Forms.TextBox txtID;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    public System.Windows.Forms.TextBox txtUsuario;
    private System.Windows.Forms.Label label7;
    public System.Windows.Forms.TextBox txtEstacao;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnConsCPU;
    public System.Windows.Forms.TextBox txtIDCpu;
    private System.Windows.Forms.Label label2;
    public System.Windows.Forms.TextBox txtMidia;
    public System.Windows.Forms.TextBox txtMemoria;
    private System.Windows.Forms.Label label4;
    public System.Windows.Forms.TextBox txtProcessador;
    private System.Windows.Forms.Label label3;
    public System.Windows.Forms.TextBox txtHD;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label9;
    public System.Windows.Forms.Button btnAlterar;
    public System.Windows.Forms.Button btnSalvar;
    public System.Windows.Forms.Button btnExcluir;
    public System.Windows.Forms.Button btnCancelar;
    public System.Windows.Forms.Button btnNovo;
    public System.Windows.Forms.Button btnSair;
    public System.Windows.Forms.DateTimePicker dtUltLimpeza;
    private System.Windows.Forms.Label label6;
    public System.Windows.Forms.Button btnOcorrencia;
  }
}