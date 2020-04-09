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
  public partial class FormPrincipal : Form
  {
    //Atributos
    //---------------------------------------------------------
    private BancoDados bd;
    private FormEquipamentos frmEquip = null;
    private FormCadCpu frmCpu = null;
    private FormCadEstacao frmEst = null;
    private FormCadOcorrencia frmOcEst = null;

    //Construtor
    //---------------------------------------------------------
    public FormPrincipal()
    {
      InitializeComponent();
      //bd = new BancoDados();
      //bd.OpenBD();
    }

    //Métodos Gerais
    //---------------------------------------------------------


    //Métodos Eventos
    //---------------------------------------------------------
    private void button1_Click(object sender, EventArgs e)
    {
      bd.OpenBD();
    }

    private void equipamentosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormEquipamentos)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmEquip = new FormEquipamentos(this);
        frmEquip.Show();
      }
    }

    private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
    {
      DialogResult res = MessageBox.Show("Deseja realmente encerrar o aplicativo?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      e.Cancel = (res == DialogResult.No);
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnCpus_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadCpu)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmCpu = new FormCadCpu(this);
        frmCpu.Show();
      }
    }

    private void estaçõesDeTrabalhoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadEstacao)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmEst = new FormCadEstacao(this);
        frmEst.Show();
      }
    }

    private void estaçõesDeTrabalhoToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      bool open = false;
      foreach (Form frm in this.MdiChildren)
      {
        if (frm is FormCadOcorrencia)
        {
          frm.BringToFront();
          open = true;
        }
      }
      if (!open)
      {
        frmOcEst = new FormCadOcorrencia(this);
        frmOcEst.Show();
      }
    }
  }
}
