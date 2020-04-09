using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gerenciati
{
  public partial class FormCadCpu : Form
  {
    //Atributos
    //-------------------------------------------------------------
    private bool novaCpu;
    private DataTable dt;

    //Construtor
    //-------------------------------------------------------------
    public FormCadCpu(FormPrincipal parent)
    {
      InitializeComponent();
      this.MdiParent = parent;
      this.OrganizaBotoes();
      this.HabiDesaCampos(false);
      txtCodigo.Select();
    }

    //Métodos Gerais
    //-------------------------------------------------------------
    public void OrganizaBotoes()
    {
      btnAlterar.Enabled = false;
      btnCancelar.Enabled = false;
      btnConsultar.Enabled = true;
      btnExcluir.Enabled = false;
      btnNovo.Enabled = true;
      btnSair.Enabled = true;
      btnSalvar.Enabled = false;
    }

    public void HabiDesaCampos(bool flag)
    {
      txtCodigo.ReadOnly = flag;
      txtHD.ReadOnly = !flag;
      txtMarca.ReadOnly = !flag;
      txtMemoria.ReadOnly = !flag;
      txtModelo.ReadOnly = !flag;
      txtNumSerie.ReadOnly = !flag;
      txtObservacao.ReadOnly = !flag;
      txtPlacaMae.ReadOnly = !flag;
      txtProcessador.ReadOnly = !flag;
      txtMidia.ReadOnly = !flag;

      cbxLoja.Enabled = flag;
      cbxStatus.Enabled = flag;
      dtUltLimpeza.Enabled = flag;
      dtUltManutencao.Enabled = flag;

      txtCodigo.TabStop = !flag;
      txtHD.TabStop = flag;
      txtMarca.TabStop = flag;
      txtMemoria.TabStop = flag;
      txtMidia.TabStop = flag;
      txtModelo.TabStop = flag;
      txtNumSerie.TabStop = flag;
      txtObservacao.TabStop = flag;
      txtPlacaMae.TabStop = flag;
      txtProcessador.TabStop = flag;
      cbxLoja.TabStop = flag;
      cbxStatus.TabStop = flag;
      dtUltLimpeza.TabStop = flag;
      dtUltManutencao.TabStop = flag;
    }

    public void LimpaCampos()
    {
      txtCodigo.Clear();
      txtHD.Clear();
      txtMarca.Clear();
      txtMemoria.Clear();
      txtMidia.Clear();
      txtModelo.Clear();
      txtNumSerie.Clear();
      txtObservacao.Clear();
      txtPlacaMae.Clear();
      txtProcessador.Clear();
      cbxLoja.DataSource = null;
      cbxStatus.Items.Clear();
      dtUltLimpeza.Value = Convert.ToDateTime("01/01/1990");
      dtUltManutencao.Value = Convert.ToDateTime("01/01/1990");
    }

    private void FormCadCpu_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        e.SuppressKeyPress = true;
        if (e.Shift)
        {
          SendKeys.Send("+{TAB}");
        }
        else
        {
          SendKeys.Send("{TAB}");
        }
      }
      else if (e.KeyCode == Keys.F6)
      {
        btnConsultar.PerformClick();
      }
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnNovo_Click(object sender, EventArgs e)
    {
      novaCpu = true;
      //this.LimpaCampos();
      //Limpa alguns campos
      //---------------------------------------------------
      cbxLoja.DataSource = null;
      cbxStatus.Items.Clear();

      this.HabiDesaCampos(true);
      btnAlterar.Enabled = false;
      btnCancelar.Enabled = true;
      btnConsultar.Enabled = false;
      btnExcluir.Enabled = false;
      btnNovo.Enabled = false;
      if (txtProcessador.Text.Length > 0)
        btnSalvar.Enabled = true;
      else
        btnSalvar.Enabled = false;
      this.CancelButton = btnCancelar;

      //Preenche ComboBox Loja
      //-----------------------------------------------
      dt = new DataTable();
      Loja lj = new Loja();
      dt = lj.PreencheComboBox();
      cbxLoja.DisplayMember = "razaosocial";
      cbxLoja.ValueMember = "id";
      cbxLoja.DataSource = dt;

      //Preenche ComboBox Status
      //-----------------------------------------------
      cbxStatus.Items.Add("EM USO");
      cbxStatus.Items.Add("NAO UTILIZADO");
      cbxStatus.Items.Add("ENVIADO P/ REPARO");
      cbxStatus.Items.Add("S/ CONSERTO");
      cbxStatus.Text = "EM USO";

      Cpu cpu = new Cpu();
      cpu.RetornaID();
      int id = cpu.Id + 1;
      txtCodigo.Text = id.ToString();
      cbxLoja.Focus();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Deseja realmente cancelar a operação?", "Cancelar Operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        this.LimpaCampos();
        this.HabiDesaCampos(false);
        this.OrganizaBotoes();
        txtCodigo.Focus();
        this.CancelButton = btnSair;
        novaCpu = false;
      }
    }

    private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void txtCodigo_Enter(object sender, EventArgs e)
    {
      txtCodigo.SelectAll();
    }

    private void txtCodigo_Leave(object sender, EventArgs e)
    {
      if (txtCodigo.Text.Length > 0)
      {
        Cpu cpu = new Cpu();
        cpu.Id = Convert.ToInt32(txtCodigo.Text);
        cpu.ConsultarCpu();
        if (cpu.Status != null)
        {
          this.LimpaCampos();
          btnAlterar.Enabled = true;

          txtCodigo.Text = Convert.ToString(cpu.Id);
          //Preenche ComboBox Loja
          //-----------------------------------------------
          dt = new DataTable();
          Loja lj = new Loja();
          dt = lj.PreencheComboBox();
          cbxLoja.DisplayMember = "razaosocial";
          cbxLoja.ValueMember = "id";
          cbxLoja.DataSource = dt;

          //Preenche ComboBox Status
          //-----------------------------------------------
          cbxStatus.Items.Add("EM USO");
          cbxStatus.Items.Add("NAO UTILIZADO");
          cbxStatus.Items.Add("ENVIADO P/ REPARO");
          cbxStatus.Items.Add("S/ CONSERTO");
          cbxStatus.Text = "EM USO";

          cbxLoja.SelectedValue = cpu.IdLoja;
          cbxStatus.Text = cpu.Status;
          txtHD.Text = cpu.Hd;
          txtMarca.Text = cpu.Marca;
          txtMemoria.Text = cpu.Memoria;
          txtMidia.Text = cpu.Midia;
          txtModelo.Text = cpu.Modelo;
          txtNumSerie.Text = cpu.NumSerie;
          txtObservacao.Text = cpu.Obs;
          txtPlacaMae.Text = cpu.PlacaMae;
          txtProcessador.Text = cpu.Processador;
          dtUltLimpeza.Value = cpu.DtUltLimpeza;
          dtUltManutencao.Value = cpu.DtUltManut;

          if (cbxStatus.Text != "EXCLUIDO")
            btnExcluir.Enabled = true;
          else
            btnExcluir.Enabled = false;

          btnNovo.Focus();
        }
        else
        {
          this.LimpaCampos();
          this.OrganizaBotoes();
          txtCodigo.Select();
        }
      }
      else
      {
        this.LimpaCampos();
        this.OrganizaBotoes();
      }
    }

    private void txtProcessador_Leave(object sender, EventArgs e)
    {
      if (novaCpu == true && btnAlterar.Enabled == false)
      {
        if (txtProcessador.Text.Length > 0)
          btnSalvar.Enabled = true;
        else
          btnSalvar.Enabled = false;
      }
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
      Cpu cpu = new Cpu();
      cpu.DtUltLimpeza = dtUltLimpeza.Value;
      cpu.DtUltManut = dtUltManutencao.Value;
      cpu.Hd = txtHD.Text;
      cpu.Id = Convert.ToInt32(txtCodigo.Text);
      cpu.IdLoja = Convert.ToInt32(cbxLoja.SelectedValue);
      cpu.Marca = txtMarca.Text;
      cpu.Memoria = txtMemoria.Text;
      cpu.Midia = txtMidia.Text;
      cpu.Modelo = txtModelo.Text;
      cpu.NumSerie = txtNumSerie.Text;
      cpu.Obs = txtObservacao.Text;
      cpu.PlacaMae = txtPlacaMae.Text;
      cpu.Processador = txtProcessador.Text;
      cpu.Status = cbxStatus.Text;

      if (novaCpu)
      {
        DialogResult res = MessageBox.Show("Confirma a inserção do registro?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          cpu.InserirCpu();
          cpu.RetornaID();
          txtCodigo.Text = Convert.ToString(cpu.Id);
          this.HabiDesaCampos(false);
          this.OrganizaBotoes();
          this.CancelButton = btnSair;
          btnAlterar.Enabled = true;
          btnExcluir.Enabled = true;
          novaCpu = false;
          txtCodigo.Focus();
          txtCodigo.SelectAll();
        }
      }
      else
      {
        DialogResult res = MessageBox.Show("Confirma a alteração do registro?", "Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          cpu.Id = Convert.ToInt32(txtCodigo.Text);
          cpu.AtualizarCpu();
          this.HabiDesaCampos(false);
          this.OrganizaBotoes();
          this.CancelButton = btnSair;
          btnAlterar.Enabled = true;
          btnExcluir.Enabled = true;
          txtCodigo.Focus();
          txtCodigo.SelectAll();
        }
      }
            
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
      novaCpu = false;
      this.HabiDesaCampos(true);
      btnAlterar.Enabled = false;
      btnCancelar.Enabled = true;
      btnConsultar.Enabled = false;
      btnExcluir.Enabled = false;
      btnNovo.Enabled = false;
      btnSalvar.Enabled = true;
      cbxStatus.Focus();
      this.CancelButton = btnCancelar;
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Confirma a exclusão do registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        Cpu cpu = new Cpu();
        cpu.Id = Convert.ToInt32(txtCodigo.Text);
        cpu.ExcluirCpu();

        this.LimpaCampos();
        this.HabiDesaCampos(false);
        this.OrganizaBotoes();
        txtCodigo.Focus();
      }
    }

    private void btnConsultar_Click(object sender, EventArgs e)
    {
      this.LimpaCampos();
      this.OrganizaBotoes();
      btnAlterar.Enabled = false;

      FormGridCpu grid = new FormGridCpu(this, "cpu");
      grid.MdiParent = this.ParentForm;
      grid.WindowState = FormWindowState.Maximized;
      grid.Show();
    }

    private void txtCodigo_Click(object sender, EventArgs e)
    {
      txtCodigo.SelectAll();
    }
  }
}
