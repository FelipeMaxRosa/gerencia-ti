namespace gerenciati
{
  partial class FormGridCpu
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGridCpu));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtNumSerie = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.txtModelo = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtMarca = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.btnSair = new System.Windows.Forms.Button();
      this.gridCpu = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idloja = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dtultlimpeza = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dtultmanut = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.numserie = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.placamae = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.processador = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.memoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.hd = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.midia = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridCpu)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtNumSerie);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Controls.Add(this.txtModelo);
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
      this.txtNumSerie.Size = new System.Drawing.Size(208, 21);
      this.txtNumSerie.TabIndex = 2;
      this.txtNumSerie.Click += new System.EventHandler(this.txtNumSerie_Click);
      this.txtNumSerie.Leave += new System.EventHandler(this.txtNumSerie_Leave);
      this.txtNumSerie.Enter += new System.EventHandler(this.txtNumSerie_Enter);
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
      // txtModelo
      // 
      this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtModelo.Location = new System.Drawing.Point(82, 47);
      this.txtModelo.MaxLength = 50;
      this.txtModelo.Name = "txtModelo";
      this.txtModelo.Size = new System.Drawing.Size(208, 21);
      this.txtModelo.TabIndex = 1;
      this.txtModelo.Click += new System.EventHandler(this.txtModelo_Click);
      this.txtModelo.Leave += new System.EventHandler(this.txtModelo_Leave);
      this.txtModelo.Enter += new System.EventHandler(this.txtModelo_Enter);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(35, 50);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(45, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "Modelo:";
      // 
      // txtMarca
      // 
      this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtMarca.Location = new System.Drawing.Point(82, 20);
      this.txtMarca.MaxLength = 50;
      this.txtMarca.Name = "txtMarca";
      this.txtMarca.Size = new System.Drawing.Size(208, 21);
      this.txtMarca.TabIndex = 0;
      this.txtMarca.Click += new System.EventHandler(this.txtMarca_Click);
      this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(40, 23);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(40, 13);
      this.label5.TabIndex = 7;
      this.label5.Text = "Marca:";
      // 
      // btnSair
      // 
      this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSair.Location = new System.Drawing.Point(818, 453);
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(81, 23);
      this.btnSair.TabIndex = 2;
      this.btnSair.Text = "Sair";
      this.btnSair.UseVisualStyleBackColor = true;
      this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
      // 
      // gridCpu
      // 
      this.gridCpu.AllowUserToAddRows = false;
      this.gridCpu.AllowUserToDeleteRows = false;
      this.gridCpu.AllowUserToOrderColumns = true;
      this.gridCpu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridCpu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idloja,
            this.status,
            this.dtultlimpeza,
            this.dtultmanut,
            this.marca,
            this.modelo,
            this.numserie,
            this.placamae,
            this.processador,
            this.memoria,
            this.hd,
            this.midia,
            this.obs});
      this.gridCpu.Location = new System.Drawing.Point(6, 116);
      this.gridCpu.MultiSelect = false;
      this.gridCpu.Name = "gridCpu";
      this.gridCpu.ReadOnly = true;
      this.gridCpu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gridCpu.Size = new System.Drawing.Size(893, 331);
      this.gridCpu.TabIndex = 1;
      this.gridCpu.Enter += new System.EventHandler(this.gridCpu_Enter);
      this.gridCpu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCpu_CellDoubleClick);
      this.gridCpu.Leave += new System.EventHandler(this.gridCpu_Leave);
      this.gridCpu.Click += new System.EventHandler(this.gridCpu_Click);
      // 
      // id
      // 
      this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.id.DataPropertyName = "id";
      this.id.HeaderText = "ID";
      this.id.Name = "id";
      this.id.ReadOnly = true;
      this.id.Width = 43;
      // 
      // idloja
      // 
      this.idloja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.idloja.DataPropertyName = "idloja";
      this.idloja.HeaderText = "Loja";
      this.idloja.Name = "idloja";
      this.idloja.ReadOnly = true;
      this.idloja.Width = 52;
      // 
      // status
      // 
      this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.status.DataPropertyName = "status";
      this.status.HeaderText = "Status";
      this.status.Name = "status";
      this.status.ReadOnly = true;
      this.status.Width = 63;
      // 
      // dtultlimpeza
      // 
      this.dtultlimpeza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.dtultlimpeza.DataPropertyName = "dtultlimpeza";
      this.dtultlimpeza.HeaderText = "Últ. Limpeza";
      this.dtultlimpeza.Name = "dtultlimpeza";
      this.dtultlimpeza.ReadOnly = true;
      this.dtultlimpeza.Width = 90;
      // 
      // dtultmanut
      // 
      this.dtultmanut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.dtultmanut.DataPropertyName = "dtultmanut";
      this.dtultmanut.HeaderText = "Últ. Manutenção";
      this.dtultmanut.Name = "dtultmanut";
      this.dtultmanut.ReadOnly = true;
      this.dtultmanut.Width = 102;
      // 
      // marca
      // 
      this.marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.marca.DataPropertyName = "marca";
      this.marca.HeaderText = "Marca";
      this.marca.Name = "marca";
      this.marca.ReadOnly = true;
      this.marca.Width = 61;
      // 
      // modelo
      // 
      this.modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.modelo.DataPropertyName = "modelo";
      this.modelo.HeaderText = "Modelo";
      this.modelo.Name = "modelo";
      this.modelo.ReadOnly = true;
      this.modelo.Width = 66;
      // 
      // numserie
      // 
      this.numserie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.numserie.DataPropertyName = "numserie";
      this.numserie.HeaderText = "Núm. Série";
      this.numserie.Name = "numserie";
      this.numserie.ReadOnly = true;
      this.numserie.Width = 78;
      // 
      // placamae
      // 
      this.placamae.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.placamae.DataPropertyName = "placamae";
      this.placamae.HeaderText = "Placa Mãe";
      this.placamae.Name = "placamae";
      this.placamae.ReadOnly = true;
      this.placamae.Width = 74;
      // 
      // processador
      // 
      this.processador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.processador.DataPropertyName = "processador";
      this.processador.HeaderText = "Processador";
      this.processador.Name = "processador";
      this.processador.ReadOnly = true;
      this.processador.Width = 91;
      // 
      // memoria
      // 
      this.memoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.memoria.DataPropertyName = "memoria";
      this.memoria.HeaderText = "Memória";
      this.memoria.Name = "memoria";
      this.memoria.ReadOnly = true;
      this.memoria.Width = 72;
      // 
      // hd
      // 
      this.hd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.hd.DataPropertyName = "hd";
      this.hd.HeaderText = "HD";
      this.hd.Name = "hd";
      this.hd.ReadOnly = true;
      this.hd.Width = 46;
      // 
      // midia
      // 
      this.midia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.midia.DataPropertyName = "midia";
      this.midia.HeaderText = "Mídia";
      this.midia.Name = "midia";
      this.midia.ReadOnly = true;
      this.midia.Width = 56;
      // 
      // obs
      // 
      this.obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.obs.DataPropertyName = "obs";
      this.obs.HeaderText = "Observação";
      this.obs.Name = "obs";
      this.obs.ReadOnly = true;
      this.obs.Width = 90;
      // 
      // FormGridCpu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnSair;
      this.ClientSize = new System.Drawing.Size(905, 481);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnSair);
      this.Controls.Add(this.gridCpu);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.Name = "FormGridCpu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consulta - CPUs";
      this.SizeChanged += new System.EventHandler(this.FormGridCpu_SizeChanged);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGridCpu_KeyDown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridCpu)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtNumSerie;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtModelo;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtMarca;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnSair;
    private System.Windows.Forms.DataGridView gridCpu;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn idloja;
    private System.Windows.Forms.DataGridViewTextBoxColumn status;
    private System.Windows.Forms.DataGridViewTextBoxColumn dtultlimpeza;
    private System.Windows.Forms.DataGridViewTextBoxColumn dtultmanut;
    private System.Windows.Forms.DataGridViewTextBoxColumn marca;
    private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
    private System.Windows.Forms.DataGridViewTextBoxColumn numserie;
    private System.Windows.Forms.DataGridViewTextBoxColumn placamae;
    private System.Windows.Forms.DataGridViewTextBoxColumn processador;
    private System.Windows.Forms.DataGridViewTextBoxColumn memoria;
    private System.Windows.Forms.DataGridViewTextBoxColumn hd;
    private System.Windows.Forms.DataGridViewTextBoxColumn midia;
    private System.Windows.Forms.DataGridViewTextBoxColumn obs;
  }
}