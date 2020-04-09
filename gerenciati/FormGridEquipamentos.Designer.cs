namespace gerenciati
{
  partial class FormGridEquipamentos
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGridEquipamentos));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtNumSerie = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.txtDescricao = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtMarca = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.gridEquip = new System.Windows.Forms.DataGridView();
      this.btnSair = new System.Windows.Forms.Button();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idloja = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.numserie = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.versao = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.portacom = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridEquip)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtNumSerie);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Controls.Add(this.txtDescricao);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txtMarca);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.groupBox1.Location = new System.Drawing.Point(6, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(893, 107);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Pesquisa por: ";
      // 
      // txtNumSerie
      // 
      this.txtNumSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNumSerie.Location = new System.Drawing.Point(82, 74);
      this.txtNumSerie.MaxLength = 50;
      this.txtNumSerie.Name = "txtNumSerie";
      this.txtNumSerie.Size = new System.Drawing.Size(193, 21);
      this.txtNumSerie.TabIndex = 12;
      this.txtNumSerie.Leave += new System.EventHandler(this.txtNumSerie_Leave);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(17, 77);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(63, 13);
      this.label8.TabIndex = 11;
      this.label8.Text = "Núm. Série:";
      // 
      // txtDescricao
      // 
      this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDescricao.Location = new System.Drawing.Point(82, 20);
      this.txtDescricao.MaxLength = 50;
      this.txtDescricao.Name = "txtDescricao";
      this.txtDescricao.Size = new System.Drawing.Size(375, 21);
      this.txtDescricao.TabIndex = 9;
      this.txtDescricao.Leave += new System.EventHandler(this.txtDescricao_Leave);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(23, 23);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "Descrição:";
      // 
      // txtMarca
      // 
      this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtMarca.Location = new System.Drawing.Point(82, 47);
      this.txtMarca.MaxLength = 50;
      this.txtMarca.Name = "txtMarca";
      this.txtMarca.Size = new System.Drawing.Size(208, 21);
      this.txtMarca.TabIndex = 10;
      this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(40, 50);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(40, 13);
      this.label5.TabIndex = 7;
      this.label5.Text = "Marca:";
      // 
      // gridEquip
      // 
      this.gridEquip.AllowUserToAddRows = false;
      this.gridEquip.AllowUserToDeleteRows = false;
      this.gridEquip.AllowUserToOrderColumns = true;
      this.gridEquip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridEquip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idloja,
            this.status,
            this.descricao,
            this.marca,
            this.modelo,
            this.tipo,
            this.numserie,
            this.versao,
            this.portacom,
            this.obs,
            this.genero});
      this.gridEquip.Location = new System.Drawing.Point(6, 116);
      this.gridEquip.MultiSelect = false;
      this.gridEquip.Name = "gridEquip";
      this.gridEquip.ReadOnly = true;
      this.gridEquip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gridEquip.Size = new System.Drawing.Size(893, 331);
      this.gridEquip.TabIndex = 1;
      this.gridEquip.Enter += new System.EventHandler(this.gridEquip_Enter);
      this.gridEquip.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEquip_CellDoubleClick);
      this.gridEquip.Leave += new System.EventHandler(this.gridEquip_Leave);
      this.gridEquip.Click += new System.EventHandler(this.gridEquip_Click);
      // 
      // btnSair
      // 
      this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSair.Location = new System.Drawing.Point(818, 453);
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(81, 23);
      this.btnSair.TabIndex = 3;
      this.btnSair.Text = "Sair";
      this.btnSair.UseVisualStyleBackColor = true;
      this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
      // 
      // id
      // 
      this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.id.DataPropertyName = "id";
      this.id.Frozen = true;
      this.id.HeaderText = "ID";
      this.id.Name = "id";
      this.id.ReadOnly = true;
      this.id.Width = 43;
      // 
      // idloja
      // 
      this.idloja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.idloja.DataPropertyName = "idloja";
      this.idloja.Frozen = true;
      this.idloja.HeaderText = "Loja";
      this.idloja.Name = "idloja";
      this.idloja.ReadOnly = true;
      this.idloja.Width = 52;
      // 
      // status
      // 
      this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.status.DataPropertyName = "status";
      this.status.Frozen = true;
      this.status.HeaderText = "Status";
      this.status.Name = "status";
      this.status.ReadOnly = true;
      this.status.Width = 63;
      // 
      // descricao
      // 
      this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.descricao.DataPropertyName = "descricao";
      this.descricao.Frozen = true;
      this.descricao.HeaderText = "Descrição";
      this.descricao.Name = "descricao";
      this.descricao.ReadOnly = true;
      this.descricao.Width = 78;
      // 
      // marca
      // 
      this.marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.marca.DataPropertyName = "marca";
      this.marca.Frozen = true;
      this.marca.HeaderText = "Marca";
      this.marca.Name = "marca";
      this.marca.ReadOnly = true;
      this.marca.Width = 61;
      // 
      // modelo
      // 
      this.modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.modelo.DataPropertyName = "modelo";
      this.modelo.Frozen = true;
      this.modelo.HeaderText = "Modelo";
      this.modelo.Name = "modelo";
      this.modelo.ReadOnly = true;
      this.modelo.Width = 66;
      // 
      // tipo
      // 
      this.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.tipo.DataPropertyName = "tipo";
      this.tipo.Frozen = true;
      this.tipo.HeaderText = "Tipo";
      this.tipo.Name = "tipo";
      this.tipo.ReadOnly = true;
      this.tipo.Width = 52;
      // 
      // numserie
      // 
      this.numserie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.numserie.DataPropertyName = "numserie";
      this.numserie.Frozen = true;
      this.numserie.HeaderText = "Núm. Série";
      this.numserie.Name = "numserie";
      this.numserie.ReadOnly = true;
      this.numserie.Width = 84;
      // 
      // versao
      // 
      this.versao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.versao.DataPropertyName = "versao";
      this.versao.Frozen = true;
      this.versao.HeaderText = "Versão";
      this.versao.Name = "versao";
      this.versao.ReadOnly = true;
      this.versao.Width = 65;
      // 
      // portacom
      // 
      this.portacom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.portacom.DataPropertyName = "portacom";
      this.portacom.Frozen = true;
      this.portacom.HeaderText = "Porta Comunicação";
      this.portacom.Name = "portacom";
      this.portacom.ReadOnly = true;
      this.portacom.Width = 114;
      // 
      // obs
      // 
      this.obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.obs.DataPropertyName = "obs";
      this.obs.Frozen = true;
      this.obs.HeaderText = "Observação";
      this.obs.Name = "obs";
      this.obs.ReadOnly = true;
      this.obs.Width = 90;
      // 
      // genero
      // 
      this.genero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.genero.DataPropertyName = "genero";
      this.genero.Frozen = true;
      this.genero.HeaderText = "Gênero";
      this.genero.Name = "genero";
      this.genero.ReadOnly = true;
      this.genero.Visible = false;
      this.genero.Width = 67;
      // 
      // FormGridEquipamentos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnSair;
      this.ClientSize = new System.Drawing.Size(905, 481);
      this.Controls.Add(this.btnSair);
      this.Controls.Add(this.gridEquip);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.Name = "FormGridEquipamentos";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consulta - Equipamentos e Dispositivos";
      this.SizeChanged += new System.EventHandler(this.FormGridEquipamentos_SizeChanged);
      this.Resize += new System.EventHandler(this.FormGridEquipamentos_Resize);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGridEquipamentos_KeyDown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridEquip)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtDescricao;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtMarca;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtNumSerie;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.DataGridView gridEquip;
    private System.Windows.Forms.Button btnSair;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn idloja;
    private System.Windows.Forms.DataGridViewTextBoxColumn status;
    private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
    private System.Windows.Forms.DataGridViewTextBoxColumn marca;
    private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
    private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
    private System.Windows.Forms.DataGridViewTextBoxColumn numserie;
    private System.Windows.Forms.DataGridViewTextBoxColumn versao;
    private System.Windows.Forms.DataGridViewTextBoxColumn portacom;
    private System.Windows.Forms.DataGridViewTextBoxColumn obs;
    private System.Windows.Forms.DataGridViewTextBoxColumn genero;
  }
}