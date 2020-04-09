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
  public partial class FormCadEstacao : Form
  {
    //Atributos
    //-------------------------------------------------------
    private bool novaEstacao;
    private DataTable dt;

    //Construtor
    //-------------------------------------------------------
    public FormCadEstacao(FormPrincipal parent)
    {
      InitializeComponent();
      this.MdiParent = parent;
      this.LimparCampos();
      this.OrganizaBotoes();
      this.HabiDesaCampos(false);
      txtID.Select();
    }

    //Metodos Gerais
    //-------------------------------------------------------
    private void LimparCampos()
    {
      txtEstacao.Clear();
      txtHD.Clear();
      txtID.Clear();
      txtIDCpu.Clear();
      txtProcessador.Clear();
      txtUsuario.Clear();
      txtMidia.Clear();
      txtMemoria.Clear();
    }

    private void LimparCamposCPU()
    {
      txtHD.Clear();
      txtIDCpu.Clear();
      txtMemoria.Clear();
      txtMidia.Clear();
      txtProcessador.Clear();
      dtUltLimpeza.Value = Convert.ToDateTime("01/01/1990");
    }

    private void HabiDesaCampos(bool flag)
    {
      //Read Only
      //------------------------------------
      txtEstacao.ReadOnly = !flag;
      txtID.ReadOnly = flag;
      txtIDCpu.ReadOnly = !flag;
      txtUsuario.ReadOnly = !flag;
      
      //Enabled
      //------------------------------------
      btnConsCPU.Enabled = flag;

      //Tab Stop
      //------------------------------------
      txtEstacao.TabStop = flag;
      txtID.TabStop = !flag;
      txtIDCpu.TabStop = flag;
      txtUsuario.TabStop = flag;
    }

    private void OrganizaBotoes()
    {
      btnAlterar.Enabled = false;
      btnCancelar.Enabled = false;
      btnConsultar.Enabled = true;
      btnExcluir.Enabled = false;
      btnNovo.Enabled = true;
      btnSair.Enabled = true;
      btnSalvar.Enabled = false;
    }

    //Eventos
    //-------------------------------------------------------
    private void btnNovo_Click(object sender, EventArgs e)
    {
      novaEstacao = true;
      this.HabiDesaCampos(true);
      this.LimparCamposCPU();
      btnAlterar.Enabled = false;
      btnCancelar.Enabled = true;
      btnConsultar.Enabled = false;
      btnExcluir.Enabled = false;
      btnNovo.Enabled = false;
      this.CancelButton = btnCancelar;

      Estacao est = new Estacao();
      est.RetornaID();
      int id = est.Id + 1;
      txtID.Text = id.ToString("000");

      txtEstacao.Select();
      txtEstacao.SelectAll();
    }

    private void btnConsultar_Click(object sender, EventArgs e)
    {
      this.LimparCampos();
      this.LimparCamposCPU();
      this.OrganizaBotoes();
      this.btnAlterar.Enabled = false;

      FormGridET grid = new FormGridET(this, "estacao");
      grid.MdiParent = this.ParentForm;
      grid.Show();
    }

    private void FormCadEstacao_KeyDown(object sender, KeyEventArgs e)
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

    private void btnConsCPU_Click(object sender, EventArgs e)
    {
      FormGridCpu grid = new FormGridCpu(this, "estacao");
      grid.MdiParent = this.ParentForm;
      grid.WindowState = FormWindowState.Maximized;
      grid.Show();
    }

    private void txtIDCpu_Leave(object sender, EventArgs e)
    {
      if (txtIDCpu.Text.Length > 0)
      {
        Cpu cpu = new Cpu();
        cpu.Id = Convert.ToInt32(txtIDCpu.Text);
        cpu.ConsultarCpu();
        if (cpu.Status != null)
        {
          this.LimparCamposCPU();
          txtIDCpu.Text = Convert.ToString(cpu.Id);
          txtHD.Text = cpu.Hd;
          txtMemoria.Text = cpu.Memoria;
          txtMidia.Text = cpu.Midia;
          txtProcessador.Text = cpu.Processador;
          dtUltLimpeza.Value = cpu.DtUltLimpeza;
          btnSalvar.Enabled = true;
          btnSalvar.Focus();
        }
        else
        {
          this.LimparCamposCPU();
          btnSalvar.Enabled = false;
          txtIDCpu.Select();
        }
      }
      else
      {
        this.LimparCamposCPU();
        btnSalvar.Enabled = false;
      }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      DialogResult res = MessageBox.Show("Deseja realmente cancelar a operação?", "Cancelar Operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (res == DialogResult.Yes)
      {
        this.LimparCampos();
        this.LimparCamposCPU();
        this.HabiDesaCampos(false);
        this.OrganizaBotoes();
        txtID.Select();
        this.CancelButton = btnSair;
        novaEstacao = false;
      }
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
      Estacao est = new Estacao();
      est.IdCpu = Convert.ToInt32(txtIDCpu.Text);
      est.Usuario = txtUsuario.Text;
      est.Descricao = txtEstacao.Text;

      if (novaEstacao)
      {
        DialogResult res = MessageBox.Show("Confirma a inserção do registro?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          est.InserirEstacao();
          est.RetornaID();
          txtID.Text = est.Id.ToString();
          this.HabiDesaCampos(false);
          this.OrganizaBotoes();
          this.CancelButton = btnSair;
          btnAlterar.Enabled = true;
          //btnExcluir.Enabled = true;
          novaEstacao = false;
          txtID.Focus();
          txtID.SelectAll();
        }
      }
      else
      {
        DialogResult res = MessageBox.Show("Confirma a alteração do registro?", "Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          est.Id = Convert.ToInt32(txtID.Text);
          est.AtualizarEstacao();
          this.HabiDesaCampos(false);
          this.OrganizaBotoes();
          this.CancelButton = btnSair;
          btnAlterar.Enabled = true;
          //btnExcluir.Enabled = true;
          txtID.Focus();
          txtID.SelectAll();
        }
      }
    }

    private void txtID_Enter(object sender, EventArgs e)
    {
      txtID.SelectAll();
    }

    private void txtUsuario_Enter(object sender, EventArgs e)
    {
      txtUsuario.SelectAll();
    }

    private void txtID_Leave(object sender, EventArgs e)
    {
      if (txtID.Text.Length > 0)
      {
        Estacao est = new Estacao();
        est.Id = Convert.ToInt32(txtID.Text);
        est.ConsultarEstacao();
        if (est.Descricao != null)
        {
          this.LimparCampos();
          this.LimparCamposCPU();
          btnAlterar.Enabled = true;
          txtID.Text = est.Id.ToString();
          txtEstacao.Text = est.Descricao;
          txtUsuario.Text = est.Usuario;
          txtIDCpu.Text = Convert.ToString(est.IdCpu);

          Cpu cpu = new Cpu();
          cpu.Id = Convert.ToInt32(txtIDCpu.Text);
          cpu.ConsultarCpu();
          txtHD.Text = cpu.Hd;
          txtMemoria.Text = cpu.Memoria;
          txtMidia.Text = cpu.Midia;
          txtProcessador.Text = cpu.Processador;
          dtUltLimpeza.Value = cpu.DtUltLimpeza;
          btnNovo.Focus();
        }
        else
        {
          this.LimparCampos();
          this.LimparCamposCPU();
          this.OrganizaBotoes();
          txtID.Select();
        }
      }
      else
      {
        this.LimparCampos();
        this.LimparCamposCPU();
        this.OrganizaBotoes();
      }
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
      novaEstacao = false;
      this.HabiDesaCampos(true);
      btnAlterar.Enabled = false;
      btnCancelar.Enabled = true;
      btnConsultar.Enabled = false;
      //btnExcluir.Enabled = false;
      btnNovo.Enabled = false;
      btnSalvar.Enabled = true;
      btnConsCPU.Enabled = true;
      this.CancelButton = btnCancelar;
      txtEstacao.Select();
    }

    private void txtID_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
      {
        e.Handled = true;
      }
    }

  }
}
