namespace gerenciati
{
  partial class FormGridET
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGridET));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtUsuario = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtEstacao = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.gridET = new System.Windows.Forms.DataGridView();
      this.idcpu = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnSair = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridET)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtUsuario);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txtEstacao);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.groupBox1.Location = new System.Drawing.Point(6, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(644, 82);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Pesquisa por: ";
      // 
      // txtUsuario
      // 
      this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtUsuario.Location = new System.Drawing.Point(82, 47);
      this.txtUsuario.MaxLength = 50;
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.Size = new System.Drawing.Size(208, 21);
      this.txtUsuario.TabIndex = 1;
      this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(29, 50);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(47, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "Usuário:";
      // 
      // txtEstacao
      // 
      this.txtEstacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtEstacao.Location = new System.Drawing.Point(82, 20);
      this.txtEstacao.MaxLength = 50;
      this.txtEstacao.Name = "txtEstacao";
      this.txtEstacao.Size = new System.Drawing.Size(208, 21);
      this.txtEstacao.TabIndex = 0;
      this.txtEstacao.Leave += new System.EventHandler(this.txtEstacao_Leave);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(27, 23);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(49, 13);
      this.label5.TabIndex = 7;
      this.label5.Text = "Estação:";
      // 
      // gridET
      // 
      this.gridET.AllowUserToAddRows = false;
      this.gridET.AllowUserToDeleteRows = false;
      this.gridET.AllowUserToOrderColumns = true;
      this.gridET.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.gridET.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridET.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcpu});
      this.gridET.Location = new System.Drawing.Point(6, 90);
      this.gridET.MultiSelect = false;
      this.gridET.Name = "gridET";
      this.gridET.ReadOnly = true;
      this.gridET.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gridET.Size = new System.Drawing.Size(644, 216);
      this.gridET.TabIndex = 2;
      this.gridET.Enter += new System.EventHandler(this.gridET_Enter);
      this.gridET.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridET_CellDoubleClick);
      this.gridET.Leave += new System.EventHandler(this.gridET_Leave);
      // 
      // idcpu
      // 
      this.idcpu.DataPropertyName = "idcpu";
      this.idcpu.HeaderText = "ID CPU";
      this.idcpu.Name = "idcpu";
      this.idcpu.ReadOnly = true;
      this.idcpu.Visible = false;
      // 
      // btnSair
      // 
      this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSair.Location = new System.Drawing.Point(569, 312);
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(81, 23);
      this.btnSair.TabIndex = 3;
      this.btnSair.Text = "Sair";
      this.btnSair.UseVisualStyleBackColor = true;
      this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
      // 
      // FormGridET
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnSair;
      this.ClientSize = new System.Drawing.Size(658, 341);
      this.Controls.Add(this.btnSair);
      this.Controls.Add(this.gridET);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "FormGridET";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consulta - Estações de Trabalho";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGridET_KeyDown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridET)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtUsuario;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtEstacao;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.DataGridView gridET;
    private System.Windows.Forms.Button btnSair;
    private System.Windows.Forms.DataGridViewTextBoxColumn idcpu;
  }
}