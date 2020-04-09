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
  public partial class FormCadOcorrencia : Form
  {
    //Atributos
    //--------------------------------------------------------
    bool novaOcorrencia = false;
    DataTable dt;

    //Construtor
    //--------------------------------------------------------
    public FormCadOcorrencia(FormPrincipal parent)
    {
      InitializeComponent();
      this.MdiParent = parent;
      this.LimparCampos();
      this.OrganizaBotoes();
      this.HabiDesaCampos(false);
      txtID.Select();
    }

    //Metodos Gerais
    //--------------------------------------------------------
    public void LimparCampos()
    {
      txtEstacao.Clear();
      txtID.Clear();
      txtIDEstacao.Clear();
      txtOcorrencia.Clear();
      txtSolicitante.Clear();
      txtUsuario.Clear();
      cbxLoja.DataSource = null;
      cbxStatus.Items.Clear();
      dtOcorrencia.Value = DateTime.Now;
      hrOcorrencia.Value = dtOcorrencia.Value;
    }

    public void HabiDesaCampos(bool flag)
    {
      txtID.ReadOnly = flag;
      txtIDEstacao.ReadOnly = !flag;
      txtOcorrencia.ReadOnly = !flag;
      txtSolicitante.ReadOnly = !flag;
      cbxLoja.Enabled = flag;
      cbxStatus.Enabled = flag;
      dtOcorrencia.Enabled = flag;
      hrOcorrencia.Enabled = flag;

      txtID.TabStop = !flag;
      txtIDEstacao.TabStop = flag;
      txtOcorrencia.TabStop = flag;
      txtSolicitante.TabStop = flag;
      cbxLoja.TabStop = flag;
      cbxStatus.TabStop = flag;
      dtOcorrencia.TabStop = flag;
      hrOcorrencia.TabStop = flag;
    }

    public void OrganizaBotoes()
    {
      btnAlterar.Enabled = false;
      btnCancelar.Enabled = false;
      btnConsultar.Enabled = true;
      btnExcluir.Enabled = false;
      btnNovo.Enabled = true;
      btnSair.Enabled = true;
      btnSalvar.Enabled = false;
      btnConsEstacao.Enabled = false;
    }

    //Metodos Eventos
    //--------------------------------------------------------
    private void btnNovo_Click(object sender, EventArgs e)
    {
      novaOcorrencia = true;
      this.HabiDesaCampos(true);
      this.LimparCampos();
      btnAlterar.Enabled = false;
      btnCancelar.Enabled = true;
      btnConsultar.Enabled = false;
      btnExcluir.Enabled = false;
      btnNovo.Enabled = false;
      btnConsEstacao.Enabled = true;

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
      cbxStatus.Items.Add("EM ABERTO");
      cbxStatus.Items.Add("FINALIZADA");
      cbxStatus.Text = "EM ABERTO";

      this.CancelButton = btnCancelar;

      Ocorrencia oco = new Ocorrencia();
      oco.RetornaID();
      int id = oco.Id + 1;
      txtID.Text = Convert.ToString(id);
      cbxLoja.Focus();
    }

    private void FormCadOcorrencia_KeyDown(object sender, KeyEventArgs e)
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

    private void txtIDEstacao_Leave(object sender, EventArgs e)
    {
      if (txtIDEstacao.Text.Length > 0)
      {
        Estacao est = new Estacao();
        est.Id = Convert.ToInt32(txtIDEstacao.Text);
        est.ConsultarEstacao();
        if (est.Descricao != null)
        {
          txtEstacao.Clear();
          txtUsuario.Clear();
          txtEstacao.Text = est.Descricao;
          txtUsuario.Text = est.Usuario;
          txtOcorrencia.Focus();
        }
        else
        {
          txtEstacao.Clear();
          txtUsuario.Clear();
          txtIDEstacao.Select();
        }
      }
      else
      {
        txtEstacao.Clear();
        txtUsuario.Clear();
      }
    }

    private void btnConsEstacao_Click(object sender, EventArgs e)
    {
      txtIDEstacao.Clear();
      txtUsuario.Clear();
      txtEstacao.Clear();
      FormGridET grid = new FormGridET(this, "ocorrencia");
      grid.MdiParent = this.ParentForm;
      grid.Show();
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Deseja realmente cancelar a operação?", "Cancelar Operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        this.LimparCampos();
        this.HabiDesaCampos(false);
        this.OrganizaBotoes();
        txtID.Select();
        this.CancelButton = btnSair;
        novaOcorrencia = false;
      }
    }

    private void txtID_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
      Ocorrencia oco = new Ocorrencia();
      oco.DescOcorrencia = txtOcorrencia.Text;
      oco.DtOcorrencia = dtOcorrencia.Value.Date + hrOcorrencia.Value.TimeOfDay;
      oco.Id = Convert.ToInt32(txtID.Text);
      oco.IdEstacao = Convert.ToInt32(txtIDEstacao.Text);
      oco.IdLoja = Convert.ToInt32(cbxLoja.SelectedValue);
      oco.Solicitante = txtSolicitante.Text;
      oco.Status = cbxStatus.Text;

      if (novaOcorrencia)
      {
        DialogResult res = MessageBox.Show("Confirma a inserção do registro?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          oco.InserirOcorrencia();
          oco.RetornaID();
          txtID.Text = Convert.ToString(oco.Id);
          this.HabiDesaCampos(false);
          this.OrganizaBotoes();
          this.CancelButton = btnSair;
          btnAlterar.Enabled = true;
          btnExcluir.Enabled = true;
          novaOcorrencia = false;
          txtID.Focus();
          txtID.SelectAll();
        }
      }
      else
      {
        DialogResult res = MessageBox.Show("Confirma a alteração do registro?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {

        }
      }
    }
  }
}
