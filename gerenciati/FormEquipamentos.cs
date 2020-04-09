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
  public partial class FormEquipamentos : Form
  {
    //Atributos
    //--------------------------------------------------------
    private bool novoEquip = false;
    private DataTable dt;

    //Construtor
    //--------------------------------------------------------
    public FormEquipamentos(FormPrincipal parent)
    {
      InitializeComponent();
      this.MdiParent = parent;
      this.OrganizaBotoes();
      this.HabiDesaCampos(false);
      txtCodigo.Select();
    }
    
    //Metodos Gerais
    //--------------------------------------------------------
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
      txtDescricao.ReadOnly = !flag;
      txtGenero.ReadOnly = !flag;
      txtMarca.ReadOnly = !flag;
      txtModelo.ReadOnly = !flag;
      txtNumSerie.ReadOnly = !flag;
      txtObservacao.ReadOnly = !flag;
      txtTipo.ReadOnly = !flag;
      txtVersao.ReadOnly = !flag;

      cbxLoja.Enabled = flag;
      cbxPortaCom.Enabled = flag;
      cbxStatus.Enabled = flag;

      txtCodigo.TabStop = !flag;
      txtDescricao.TabStop = flag;
      txtGenero.TabStop = flag;
      txtMarca.TabStop = flag;
      txtModelo.TabStop = flag;
      txtNumSerie.TabStop = flag;
      txtObservacao.TabStop = flag;
      txtTipo.TabStop = flag;
      txtVersao.TabStop = flag;
      cbxLoja.TabStop = flag;
      cbxPortaCom.TabStop = flag;
      cbxStatus.TabStop = flag;
    }

    public void LimpaCampos()
    {
      txtCodigo.Clear();
      txtDescricao.Clear();
      txtGenero.Clear();
      txtMarca.Clear();
      txtModelo.Clear();
      txtNumSerie.Clear();
      txtObservacao.Clear();
      txtTipo.Clear();
      txtVersao.Clear();
      cbxLoja.DataSource = null;
      cbxPortaCom.Items.Clear();
      cbxStatus.Items.Clear();
    }

    //Eventos
    //--------------------------------------------------------
    private void FormEquipamentos_KeyDown(object sender, KeyEventArgs e)
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
      novoEquip = true;
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
      if (txtDescricao.Text.Length > 0)
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

      //Preenche ComboBox Porta de Comunicação
      //-----------------------------------------------
      cbxPortaCom.Items.Add("SERIAL (DB9)");
      cbxPortaCom.Items.Add("LPT (DB25)");
      cbxPortaCom.Items.Add("USB");
      cbxPortaCom.Items.Add("WIRELESS");
      cbxPortaCom.Items.Add("ETHERNET");
      cbxPortaCom.Items.Add("PS/2");
      cbxPortaCom.Items.Add("NENHUMA");
      cbxPortaCom.Sorted = true;

      Equipamento equip = new Equipamento();
      equip.RetornaID();
      int id = equip.Id + 1;
      txtCodigo.Text = Convert.ToString(id);
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
        novoEquip = false;
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
      if (txtCodigo.Text.Length != 0)
      {
        Equipamento equip = new Equipamento();
        equip.Id = Convert.ToInt32(txtCodigo.Text);
        equip.ConsultarEquipamento();
        if (equip.Descricao != null)
        {
          this.LimpaCampos();
          btnAlterar.Enabled = true;

          txtCodigo.Text = Convert.ToString(equip.Id);
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

          //Preenche ComboBox Porta de Comunicação
          //-----------------------------------------------
          cbxPortaCom.Items.Add("SERIAL (DB9)");
          cbxPortaCom.Items.Add("LPT (DB25)");
          cbxPortaCom.Items.Add("USB");
          cbxPortaCom.Items.Add("WIRELESS");
          cbxPortaCom.Items.Add("ETHERNET");
          cbxPortaCom.Items.Add("PS/2");
          cbxPortaCom.Items.Add("NENHUMA");
          cbxPortaCom.Sorted = true;

          cbxLoja.SelectedValue = equip.IdLoja;
          cbxPortaCom.Text = equip.PortaCom;
          cbxStatus.Text = equip.Status;
          txtDescricao.Text = equip.Descricao;
          txtGenero.Text = equip.Genero;
          txtMarca.Text = equip.Marca;
          txtModelo.Text = equip.Modelo;
          txtNumSerie.Text = equip.NumSerie;
          txtObservacao.Text = equip.Obs;
          txtTipo.Text = equip.Tipo;
          txtVersao.Text = equip.Versao;

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

    private void txtGenero_Leave(object sender, EventArgs e)
    {
      if (novoEquip == true && btnAlterar.Enabled == false)
      {
        if (txtGenero.Text.Length > 0 && txtDescricao.Text.Length > 0)
          btnSalvar.Enabled = true;
        else
          btnSalvar.Enabled = false;  
      }      
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
      Equipamento equip = new Equipamento();
      equip.Descricao = txtDescricao.Text;
      equip.Genero = txtGenero.Text;
      equip.Id = Convert.ToInt32(txtCodigo.Text);
      equip.IdLoja = Convert.ToInt32(cbxLoja.SelectedValue);
      equip.Marca = txtMarca.Text;
      equip.Modelo = txtModelo.Text;
      equip.NumSerie = txtNumSerie.Text;
      equip.Obs = txtObservacao.Text;
      equip.PortaCom = cbxPortaCom.Text;
      equip.Status = cbxStatus.Text;
      equip.Tipo = txtTipo.Text;
      equip.Versao = txtVersao.Text;
      
      if (novoEquip)
      {
        DialogResult res = MessageBox.Show("Confirma a inserção do registro?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          equip.InserirEquipamento();
          equip.RetornaID();
          txtCodigo.Text = Convert.ToString(equip.Id);
          this.HabiDesaCampos(false);
          this.OrganizaBotoes();
          this.CancelButton = btnSair;
          btnAlterar.Enabled = true;
          btnExcluir.Enabled = true;
          novoEquip = false;
          txtCodigo.Focus();
          txtCodigo.SelectAll();
        }
      }
      else
      {
        DialogResult res = MessageBox.Show("Confirma a alteração do registro?", "Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          equip.Id = Convert.ToInt32(txtCodigo.Text);
          equip.AtualizarEquipamento();

          this.HabiDesaCampos(false);
          this.OrganizaBotoes();
          this.CancelButton = btnSair;
          btnAlterar.Enabled = true;
          btnExcluir.Enabled = true;
          novoEquip = false;
          txtCodigo.Focus();
          txtCodigo.SelectAll();
        }
      }
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
      novoEquip = false;
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
        Equipamento equip = new Equipamento();
        equip.Id = Convert.ToInt32(txtCodigo.Text);
        equip.ExcluirEquipamento();

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
      FormGridEquipamentos grid = new FormGridEquipamentos(this, "equip");
      grid.MdiParent = this.ParentForm;
      grid.WindowState = FormWindowState.Maximized;
      grid.Show();
    }
  }
}
