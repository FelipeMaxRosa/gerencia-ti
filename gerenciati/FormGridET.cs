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
  public partial class FormGridET : Form
  {
    //Atributos
    //-----------------------------------------------------
    private DataSet ds;
    private BancoDados bd;
    private FormCadEstacao frmEst;
    private FormCadOcorrencia frmOco;

    //Construtor
    //-----------------------------------------------------
    public FormGridET(object frm, string tipo)
    {
      InitializeComponent();
      bd = new BancoDados();

      if (tipo == "estacao")
        frmEst = (FormCadEstacao)frm;
      else if (tipo == "ocorrencia")
        frmOco = (FormCadOcorrencia)frm;
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      if (frmEst != null)
        frmEst.txtID.Select();
      else if (frmOco != null)
        frmOco.txtIDEstacao.Select();
      this.Close();
    }

    private void txtEstacao_Leave(object sender, EventArgs e)
    {
      if (txtEstacao.Text.Length > 0)
      {
        string sql = "SELECT e.id ID, e.estacao Estação, e.idcpu, e.usuario Usuário, c.memoria Memória, c.processador Processador, c.hd HD, c.midia Mídia, c.dtultlimpeza Limpeza FROM estacao AS e INNER JOIN cpu AS c ON e.idcpu = c.id WHERE (e.estacao LIKE '"+ txtEstacao.Text +"%')";
        string table = "estacao";
        ds = new DataSet();
        ds = bd.ConsultarParaGrid(sql, table);
        gridET.DataSource = ds.Tables[0];
        if (gridET.RowCount > 0)
        {
          gridET.Focus();
          gridET.FirstDisplayedScrollingRowIndex = 0;
          gridET.Refresh();
          gridET.CurrentCell = gridET.Rows[0].Cells[0];
          gridET.Rows[0].Selected = true;
          this.CancelButton = null;
        }
        else
        {
          MessageBox.Show("Nenhum registro encontrado com essa informação!", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          txtEstacao.Clear();
          txtEstacao.Select();
          this.CancelButton = btnSair;
        }
      }
    }

    private void FormGridET_KeyDown(object sender, KeyEventArgs e)
    {
      if (gridET.Focused == false)
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
      }
      else
      {
        if (e.KeyCode == Keys.Enter)
        {
          e.SuppressKeyPress = true;
          DataGridViewRow linhaAtual = gridET.CurrentRow;
          int i = linhaAtual.Index;
          if (frmEst != null)
          {
            frmEst.txtID.Text = gridET.Rows[i].Cells[0].Value.ToString();
            frmEst.txtEstacao.Text = gridET.Rows[i].Cells[1].Value.ToString();
            frmEst.txtIDCpu.Text = gridET.Rows[i].Cells[2].Value.ToString();
            frmEst.txtUsuario.Text = gridET.Rows[i].Cells[3].Value.ToString();
            frmEst.txtMemoria.Text = gridET.Rows[i].Cells[4].Value.ToString();
            frmEst.txtProcessador.Text = gridET.Rows[i].Cells[5].Value.ToString();
            frmEst.txtHD.Text = gridET.Rows[i].Cells[6].Value.ToString();
            frmEst.txtMidia.Text = gridET.Rows[i].Cells[7].Value.ToString();
            frmEst.dtUltLimpeza.Value = Convert.ToDateTime(gridET.Rows[i].Cells[8].Value);

            frmEst.btnAlterar.Enabled = true;
            frmEst.btnExcluir.Enabled = true;
            frmEst.txtID.Select();
            frmEst.txtID.SelectAll();
          }
          else if (frmOco != null)
          {
            frmOco.txtIDEstacao.Text = gridET.Rows[i].Cells[0].Value.ToString();
            frmOco.txtEstacao.Text = gridET.Rows[i].Cells[1].Value.ToString();
            frmOco.txtUsuario.Text = gridET.Rows[i].Cells[3].Value.ToString();
            frmOco.btnSalvar.Enabled = true;
            frmOco.txtOcorrencia.Select();
          }
          this.Close();
        }
        else if (e.KeyCode == Keys.Escape)
        {
          txtEstacao.Clear();
          txtUsuario.Clear();
          txtEstacao.Focus();
          txtEstacao.SelectAll();
          this.CancelButton = btnSair;
        }
      }
    }

    private void txtUsuario_Leave(object sender, EventArgs e)
    {
      string sql = "";
      if (txtUsuario.Text.Length > 0)
        sql = "SELECT e.id ID, e.estacao Estação, e.idcpu, e.usuario Usuário, c.memoria Memória, c.processador Processador, c.hd HD, c.midia Mídia, c.dtultlimpeza Limpeza FROM estacao AS e INNER JOIN cpu AS c ON e.idcpu = c.id WHERE (e.usuario LIKE '" + txtUsuario.Text + "%')";
      else
        sql = "SELECT e.id ID, e.estacao Estação, e.idcpu, e.usuario Usuário, c.memoria Memória, c.processador Processador, c.hd HD, c.midia Mídia, c.dtultlimpeza Limpeza FROM estacao AS e INNER JOIN cpu AS c ON e.idcpu = c.id";
      
      string table = "estacao";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(sql, table);
      gridET.DataSource = ds.Tables[0];
      if (gridET.RowCount > 0)
      {
        gridET.Focus();
        gridET.FirstDisplayedScrollingRowIndex = 0;
        gridET.Refresh();
        gridET.CurrentCell = gridET.Rows[0].Cells[0];
        gridET.Rows[0].Selected = true;
        this.CancelButton = null;
      }
      else
      {
        MessageBox.Show("Nenhum registro encontrado com essa informação!", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtUsuario.Clear();
        txtUsuario.Select();
        this.CancelButton = btnSair;
      }
    }

    private void gridET_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        int i = e.RowIndex;
        if (frmEst != null)
        {
          frmEst.txtID.Text = gridET.Rows[i].Cells[0].Value.ToString();
          frmEst.txtEstacao.Text = gridET.Rows[i].Cells[1].Value.ToString();
          frmEst.txtIDCpu.Text = gridET.Rows[i].Cells[2].Value.ToString();
          frmEst.txtUsuario.Text = gridET.Rows[i].Cells[3].Value.ToString();
          frmEst.txtMemoria.Text = gridET.Rows[i].Cells[4].Value.ToString();
          frmEst.txtProcessador.Text = gridET.Rows[i].Cells[5].Value.ToString();
          frmEst.txtHD.Text = gridET.Rows[i].Cells[6].Value.ToString();
          frmEst.txtMidia.Text = gridET.Rows[i].Cells[7].Value.ToString();
          frmEst.dtUltLimpeza.Value = Convert.ToDateTime(gridET.Rows[i].Cells[8].Value);

          frmEst.btnAlterar.Enabled = true;
          frmEst.btnExcluir.Enabled = true;
          frmEst.txtID.Select();
          frmEst.txtID.SelectAll();
        }
        else if (frmOco != null)
        {
          frmOco.txtIDEstacao.Text = gridET.Rows[i].Cells[0].Value.ToString();
          frmOco.txtEstacao.Text = gridET.Rows[i].Cells[1].Value.ToString();
          frmOco.txtUsuario.Text = gridET.Rows[i].Cells[3].Value.ToString();
          frmOco.btnSalvar.Enabled = true;
          frmOco.txtOcorrencia.Select();
        }
        this.Close();
      }
    }

    private void gridET_Enter(object sender, EventArgs e)
    {
      this.CancelButton = null;
    }

    private void gridET_Leave(object sender, EventArgs e)
    {
      this.CancelButton = btnSair;
    }
  }
}
