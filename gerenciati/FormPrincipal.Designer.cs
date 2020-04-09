namespace gerenciati
{
  partial class FormPrincipal
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
      this.menuPrincipal = new System.Windows.Forms.MenuStrip();
      this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.equipamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cPUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.estaçõesDeTrabalhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.redeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.lANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ordemDeOrçamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.barraBotoes = new System.Windows.Forms.ToolStrip();
      this.btnEquipamentos = new System.Windows.Forms.ToolStripButton();
      this.btnCpus = new System.Windows.Forms.ToolStripButton();
      this.btnRedeLocal = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
      this.btnSair = new System.Windows.Forms.ToolStripButton();
      this.barraStatus = new System.Windows.Forms.StatusStrip();
      this.estaçõesDeTrabalhoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.equipamentosDeAutomaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuPrincipal.SuspendLayout();
      this.barraBotoes.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuPrincipal
      // 
      this.menuPrincipal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.redeToolStripMenuItem,
            this.ordemDeOrçamentoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
      this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
      this.menuPrincipal.Name = "menuPrincipal";
      this.menuPrincipal.Size = new System.Drawing.Size(1008, 24);
      this.menuPrincipal.TabIndex = 0;
      this.menuPrincipal.Text = "menuStrip1";
      // 
      // cadastrosToolStripMenuItem
      // 
      this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipamentosToolStripMenuItem,
            this.cPUsToolStripMenuItem,
            this.estaçõesDeTrabalhoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.fornecedoresToolStripMenuItem});
      this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
      this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
      this.cadastrosToolStripMenuItem.Text = "&Cadastro";
      // 
      // equipamentosToolStripMenuItem
      // 
      this.equipamentosToolStripMenuItem.Name = "equipamentosToolStripMenuItem";
      this.equipamentosToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
      this.equipamentosToolStripMenuItem.Text = "&Equipamentos / Dispositivos";
      this.equipamentosToolStripMenuItem.Click += new System.EventHandler(this.equipamentosToolStripMenuItem_Click);
      // 
      // cPUsToolStripMenuItem
      // 
      this.cPUsToolStripMenuItem.Name = "cPUsToolStripMenuItem";
      this.cPUsToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
      this.cPUsToolStripMenuItem.Text = "C&PUs";
      this.cPUsToolStripMenuItem.Click += new System.EventHandler(this.btnCpus_Click);
      // 
      // estaçõesDeTrabalhoToolStripMenuItem
      // 
      this.estaçõesDeTrabalhoToolStripMenuItem.Name = "estaçõesDeTrabalhoToolStripMenuItem";
      this.estaçõesDeTrabalhoToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
      this.estaçõesDeTrabalhoToolStripMenuItem.Text = "Estações de Trabalho";
      this.estaçõesDeTrabalhoToolStripMenuItem.Click += new System.EventHandler(this.estaçõesDeTrabalhoToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(234, 6);
      // 
      // fornecedoresToolStripMenuItem
      // 
      this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
      this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
      this.fornecedoresToolStripMenuItem.Text = "&Fornecedores";
      // 
      // redeToolStripMenuItem
      // 
      this.redeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lANToolStripMenuItem});
      this.redeToolStripMenuItem.Name = "redeToolStripMenuItem";
      this.redeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
      this.redeToolStripMenuItem.Text = "&Rede";
      // 
      // lANToolStripMenuItem
      // 
      this.lANToolStripMenuItem.Name = "lANToolStripMenuItem";
      this.lANToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
      this.lANToolStripMenuItem.Text = "LAN";
      // 
      // ordemDeOrçamentoToolStripMenuItem
      // 
      this.ordemDeOrçamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estaçõesDeTrabalhoToolStripMenuItem1,
            this.equipamentosDeAutomaçãoToolStripMenuItem});
      this.ordemDeOrçamentoToolStripMenuItem.Name = "ordemDeOrçamentoToolStripMenuItem";
      this.ordemDeOrçamentoToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
      this.ordemDeOrçamentoToolStripMenuItem.Text = "Ocorrências";
      // 
      // ajudaToolStripMenuItem
      // 
      this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
      this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
      this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.ajudaToolStripMenuItem.Text = "Ajuda";
      // 
      // sobreToolStripMenuItem
      // 
      this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
      this.sobreToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
      this.sobreToolStripMenuItem.Text = "Sobre...";
      // 
      // barraBotoes
      // 
      this.barraBotoes.AutoSize = false;
      this.barraBotoes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.barraBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEquipamentos,
            this.btnCpus,
            this.btnRedeLocal,
            this.toolStripButton4,
            this.btnSair});
      this.barraBotoes.Location = new System.Drawing.Point(0, 24);
      this.barraBotoes.Name = "barraBotoes";
      this.barraBotoes.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
      this.barraBotoes.Size = new System.Drawing.Size(1008, 51);
      this.barraBotoes.TabIndex = 1;
      this.barraBotoes.Text = "toolStrip1";
      // 
      // btnEquipamentos
      // 
      this.btnEquipamentos.AutoSize = false;
      this.btnEquipamentos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnEquipamentos.Image = ((System.Drawing.Image)(resources.GetObject("btnEquipamentos.Image")));
      this.btnEquipamentos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.btnEquipamentos.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnEquipamentos.Name = "btnEquipamentos";
      this.btnEquipamentos.Size = new System.Drawing.Size(60, 45);
      this.btnEquipamentos.Text = "Equipamentos / Dispositivos";
      this.btnEquipamentos.Click += new System.EventHandler(this.equipamentosToolStripMenuItem_Click);
      // 
      // btnCpus
      // 
      this.btnCpus.AutoSize = false;
      this.btnCpus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnCpus.Image = ((System.Drawing.Image)(resources.GetObject("btnCpus.Image")));
      this.btnCpus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.btnCpus.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnCpus.Name = "btnCpus";
      this.btnCpus.Size = new System.Drawing.Size(60, 45);
      this.btnCpus.Text = "CPUs";
      this.btnCpus.Click += new System.EventHandler(this.btnCpus_Click);
      // 
      // btnRedeLocal
      // 
      this.btnRedeLocal.AutoSize = false;
      this.btnRedeLocal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnRedeLocal.Image = ((System.Drawing.Image)(resources.GetObject("btnRedeLocal.Image")));
      this.btnRedeLocal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.btnRedeLocal.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnRedeLocal.Name = "btnRedeLocal";
      this.btnRedeLocal.Size = new System.Drawing.Size(60, 45);
      this.btnRedeLocal.Text = "Rede Local";
      // 
      // toolStripButton4
      // 
      this.toolStripButton4.AutoSize = false;
      this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
      this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton4.Name = "toolStripButton4";
      this.toolStripButton4.Size = new System.Drawing.Size(60, 45);
      this.toolStripButton4.Text = "Equipamentos / Dispositivos";
      // 
      // btnSair
      // 
      this.btnSair.AutoSize = false;
      this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
      this.btnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(60, 45);
      this.btnSair.Text = "Encerrar Aplicação";
      this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
      // 
      // barraStatus
      // 
      this.barraStatus.Location = new System.Drawing.Point(0, 633);
      this.barraStatus.Name = "barraStatus";
      this.barraStatus.Size = new System.Drawing.Size(1008, 22);
      this.barraStatus.TabIndex = 3;
      this.barraStatus.Text = "statusStrip1";
      // 
      // estaçõesDeTrabalhoToolStripMenuItem1
      // 
      this.estaçõesDeTrabalhoToolStripMenuItem1.Name = "estaçõesDeTrabalhoToolStripMenuItem1";
      this.estaçõesDeTrabalhoToolStripMenuItem1.Size = new System.Drawing.Size(344, 22);
      this.estaçõesDeTrabalhoToolStripMenuItem1.Text = "Estações de Trabalho";
      this.estaçõesDeTrabalhoToolStripMenuItem1.Click += new System.EventHandler(this.estaçõesDeTrabalhoToolStripMenuItem1_Click);
      // 
      // equipamentosDeAutomaçãoToolStripMenuItem
      // 
      this.equipamentosDeAutomaçãoToolStripMenuItem.Name = "equipamentosDeAutomaçãoToolStripMenuItem";
      this.equipamentosDeAutomaçãoToolStripMenuItem.Size = new System.Drawing.Size(344, 22);
      this.equipamentosDeAutomaçãoToolStripMenuItem.Text = "Equipamentos (ECFs, Leitores, Balanças, etc...)";
      // 
      // FormPrincipal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1008, 655);
      this.Controls.Add(this.barraStatus);
      this.Controls.Add(this.barraBotoes);
      this.Controls.Add(this.menuPrincipal);
      this.DoubleBuffered = true;
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.IsMdiContainer = true;
      this.KeyPreview = true;
      this.MainMenuStrip = this.menuPrincipal;
      this.Name = "FormPrincipal";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Sistema de Gerência de TI - Versão 1.0";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
      this.menuPrincipal.ResumeLayout(false);
      this.menuPrincipal.PerformLayout();
      this.barraBotoes.ResumeLayout(false);
      this.barraBotoes.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuPrincipal;
    private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem equipamentosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cPUsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem lANToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ordemDeOrçamentoToolStripMenuItem;
    private System.Windows.Forms.ToolStrip barraBotoes;
    private System.Windows.Forms.StatusStrip barraStatus;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    private System.Windows.Forms.ToolStripButton btnEquipamentos;
    private System.Windows.Forms.ToolStripButton btnCpus;
    private System.Windows.Forms.ToolStripButton btnRedeLocal;
    private System.Windows.Forms.ToolStripButton toolStripButton4;
    private System.Windows.Forms.ToolStripButton btnSair;
    private System.Windows.Forms.ToolStripMenuItem estaçõesDeTrabalhoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem estaçõesDeTrabalhoToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem equipamentosDeAutomaçãoToolStripMenuItem;

  }
}

