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
  public partial class FormGridCpu : Form
  {
    //Atributos
    //--------------------------------------------------------
    private DataSet ds;
    private BancoDados bd;
    private FormCadCpu frmCpu;
    private FormCadEstacao frmEst;

    //Construtor
    //--------------------------------------------------------
    public FormGridCpu(object frm, string tipo)
    {
      InitializeComponent();
      bd = new BancoDados();

      if (tipo == "cpu")
      {
        frmCpu = (FormCadCpu)frm;
      }
      else if (tipo == "estacao")
      {
        frmEst = (FormCadEstacao)frm;
      }
    }

    //Eventos
    //---------------------------------------------------------
    private void FormGridCpu_SizeChanged(object sender, EventArgs e)
    {
      //Pega o tamanho do Form menos o tamanho do grid
      //Form: 911 x 509
      //Grid: 893 x 331
      gridCpu.Width = this.Width - 18;
      gridCpu.Height = this.Height - 178;

      //Pega o tamanho do Form menos a posição atuao do botão
      //Form: 911 x 509
      //Position: 818 x 453
      btnSair.Location = new Point(this.Width - 93, this.Height - 56);
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      if (frmCpu != null)
      {
        frmCpu.txtCodigo.Select();
      }
      else if (frmEst != null)
      {
        frmEst.txtIDCpu.Select();
      }
      this.Close();
    }

    private void txtMarca_Leave(object sender, EventArgs e)
    {
      if (txtMarca.Text.Length > 0)
      {
        string SQL = "SELECT * FROM cpu WHERE marca LIKE ('" + txtMarca.Text + "%') ORDER BY id";
        string table = "cpu";
        ds = new DataSet();
        ds = bd.ConsultarParaGrid(SQL, table);
        gridCpu.DataSource = ds.Tables[table];
        if (gridCpu.RowCount > 0)
        {
          gridCpu.Focus();
          gridCpu.FirstDisplayedScrollingRowIndex = 0;
          gridCpu.Refresh();
          gridCpu.CurrentCell = gridCpu.Rows[0].Cells[0];
          gridCpu.Rows[0].Selected = true;
          this.CancelButton = null;
        }
        else
        {
          MessageBox.Show("Nenhum produto encontrado com essa informação!", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          txtMarca.Clear();
          txtMarca.Select();
          this.CancelButton = btnSair;
        }
      }      
    }

    private void FormGridCpu_KeyDown(object sender, KeyEventArgs e)
    {
      if (gridCpu.Focused == false)
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
          DataGridViewRow linhaAtual = gridCpu.CurrentRow;
          int i = linhaAtual.Index;
          if (frmCpu != null)
          {
            frmCpu.txtCodigo.Text = gridCpu.Rows[i].Cells["id"].Value.ToString();
            frmCpu.txtHD.Text = gridCpu.Rows[i].Cells["hd"].Value.ToString();
            frmCpu.txtMarca.Text = gridCpu.Rows[i].Cells["marca"].Value.ToString();
            frmCpu.txtMemoria.Text = gridCpu.Rows[i].Cells["memoria"].Value.ToString();
            frmCpu.txtMidia.Text = gridCpu.Rows[i].Cells["midia"].Value.ToString();
            frmCpu.txtModelo.Text = gridCpu.Rows[i].Cells["modelo"].Value.ToString();
            frmCpu.txtNumSerie.Text = gridCpu.Rows[i].Cells["numserie"].Value.ToString();
            frmCpu.txtObservacao.Text = gridCpu.Rows[i].Cells["obs"].Value.ToString();
            frmCpu.txtPlacaMae.Text = gridCpu.Rows[i].Cells["placamae"].Value.ToString();
            frmCpu.txtProcessador.Text = gridCpu.Rows[i].Cells["processador"].Value.ToString();

            DataTable dt = new DataTable();
            Loja lj = new Loja();
            dt = lj.PreencheComboBox();
            frmCpu.cbxLoja.DisplayMember = "razaosocial";
            frmCpu.cbxLoja.ValueMember = "id";
            frmCpu.cbxLoja.DataSource = dt;
            frmCpu.cbxLoja.SelectedValue = Convert.ToInt32(gridCpu.Rows[i].Cells["idloja"].Value);

            //Preenche ComboBox Status
            //-----------------------------------------------
            frmCpu.cbxStatus.Items.Clear();
            frmCpu.cbxStatus.Items.Add("EM USO");
            frmCpu.cbxStatus.Items.Add("NAO UTILIZADO");
            frmCpu.cbxStatus.Items.Add("ENVIADO P/ REPARO");
            frmCpu.cbxStatus.Items.Add("S/ CONSERTO");
            frmCpu.cbxStatus.Text = gridCpu.Rows[i].Cells["status"].Value.ToString();

            frmCpu.dtUltLimpeza.Value = Convert.ToDateTime(gridCpu.Rows[i].Cells["dtultlimpeza"].Value);
            frmCpu.dtUltManutencao.Value = Convert.ToDateTime(gridCpu.Rows[i].Cells["dtultmanut"].Value);
            frmCpu.btnAlterar.Enabled = true;
            frmCpu.btnExcluir.Enabled = true;
            frmCpu.txtCodigo.Select();
            frmCpu.txtCodigo.SelectAll();
          }
          else if (frmEst != null)
          {
            frmEst.txtIDCpu.Text = gridCpu.Rows[i].Cells["id"].Value.ToString();
            frmEst.txtHD.Text = gridCpu.Rows[i].Cells["hd"].Value.ToString();
            frmEst.txtMemoria.Text = gridCpu.Rows[i].Cells["memoria"].Value.ToString();
            frmEst.txtMidia.Text = gridCpu.Rows[i].Cells["midia"].Value.ToString();
            frmEst.txtProcessador.Text = gridCpu.Rows[i].Cells["processador"].Value.ToString();
            frmEst.dtUltLimpeza.Value = Convert.ToDateTime(gridCpu.Rows[i].Cells["dtultlimpeza"].Value);

            frmEst.txtIDCpu.Select();
            frmEst.txtIDCpu.SelectAll();
            frmEst.btnSalvar.Enabled = true;
            frmEst.btnSalvar.Focus();
          }
          this.Dispose();
        }
        else if (e.KeyCode == Keys.Escape)
        {
          txtModelo.Clear();
          txtMarca.Clear();
          txtNumSerie.Clear();
          txtMarca.Focus();
          txtMarca.SelectAll();
          this.CancelButton = btnSair;
        }
      }
    }

    private void gridCpu_Enter(object sender, EventArgs e)
    {
      this.CancelButton = null;
    }

    private void gridCpu_Click(object sender, EventArgs e)
    {
      this.CancelButton = null;
    }

    private void gridCpu_Leave(object sender, EventArgs e)
    {
      this.CancelButton = btnSair;
    }

    private void txtMarca_Click(object sender, EventArgs e)
    {
      txtMarca.SelectAll();
    }

    private void txtModelo_Click(object sender, EventArgs e)
    {
      txtModelo.SelectAll();
    }

    private void txtModelo_Enter(object sender, EventArgs e)
    {
      txtModelo.SelectAll();
    }

    private void txtModelo_Leave(object sender, EventArgs e)
    {
      if (txtModelo.Text.Length > 0)
      {
        string SQL = "SELECT * FROM cpu WHERE modelo LIKE ('" + txtModelo.Text + "%') ORDER BY id";
        string table = "cpu";
        ds = new DataSet();
        ds = bd.ConsultarParaGrid(SQL, table);
        gridCpu.DataSource = ds.Tables[table];
        if (gridCpu.RowCount > 0)
        {
          gridCpu.Focus();
          gridCpu.FirstDisplayedScrollingRowIndex = 0;
          gridCpu.Refresh();
          gridCpu.CurrentCell = gridCpu.Rows[0].Cells[0];
          gridCpu.Rows[0].Selected = true;
          this.CancelButton = null;
        }
        else
        {
          MessageBox.Show("Nenhum produto encontrado com essa informação!", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          txtModelo.Clear();
          txtModelo.Select();
          this.CancelButton = btnSair;
        }
      }
    }

    private void txtNumSerie_Click(object sender, EventArgs e)
    {
      txtNumSerie.SelectAll();
    }

    private void txtNumSerie_Enter(object sender, EventArgs e)
    {
      txtNumSerie.SelectAll();
    }

    private void txtNumSerie_Leave(object sender, EventArgs e)
    {
      string SQL;
      string table;
      if (txtNumSerie.Text.Length > 0)
      {
        SQL = "SELECT * FROM cpu WHERE numserie LIKE ('" + txtNumSerie.Text + "%') ORDER BY id";
        table = "cpu";
      }
      else
	    {
        SQL = "SELECT * FROM cpu ORDER BY id";
        table = "cpu";
	    }
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, table);
      gridCpu.DataSource = ds.Tables[table];
      if (gridCpu.RowCount > 0)
      {
        gridCpu.Focus();
        gridCpu.FirstDisplayedScrollingRowIndex = 0;
        gridCpu.Refresh();
        gridCpu.CurrentCell = gridCpu.Rows[0].Cells[0];
        gridCpu.Rows[0].Selected = true;
        this.CancelButton = null;
      }
      else
      {
        MessageBox.Show("Nenhum produto encontrado com essa informação!", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtNumSerie.Clear();
        txtNumSerie.Select();
        this.CancelButton = btnSair;
      }       
    }

    private void gridCpu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        int i = e.RowIndex;
        if (frmCpu != null)
        {
          frmCpu.txtCodigo.Text = gridCpu.Rows[i].Cells["id"].Value.ToString();
          frmCpu.txtHD.Text = gridCpu.Rows[i].Cells["hd"].Value.ToString();
          frmCpu.txtMarca.Text = gridCpu.Rows[i].Cells["marca"].Value.ToString();
          frmCpu.txtMemoria.Text = gridCpu.Rows[i].Cells["memoria"].Value.ToString();
          frmCpu.txtMidia.Text = gridCpu.Rows[i].Cells["midia"].Value.ToString();
          frmCpu.txtModelo.Text = gridCpu.Rows[i].Cells["modelo"].Value.ToString();
          frmCpu.txtNumSerie.Text = gridCpu.Rows[i].Cells["numserie"].Value.ToString();
          frmCpu.txtObservacao.Text = gridCpu.Rows[i].Cells["obs"].Value.ToString();
          frmCpu.txtPlacaMae.Text = gridCpu.Rows[i].Cells["placamae"].Value.ToString();
          frmCpu.txtProcessador.Text = gridCpu.Rows[i].Cells["processador"].Value.ToString();

          DataTable dt = new DataTable();
          Loja lj = new Loja();
          dt = lj.PreencheComboBox();
          frmCpu.cbxLoja.DisplayMember = "razaosocial";
          frmCpu.cbxLoja.ValueMember = "id";
          frmCpu.cbxLoja.DataSource = dt;
          frmCpu.cbxLoja.SelectedValue = Convert.ToInt32(gridCpu.Rows[i].Cells["idloja"].Value);

          //Preenche ComboBox Status
          //-----------------------------------------------
          frmCpu.cbxStatus.Items.Clear();
          frmCpu.cbxStatus.Items.Add("EM USO");
          frmCpu.cbxStatus.Items.Add("NAO UTILIZADO");
          frmCpu.cbxStatus.Items.Add("ENVIADO P/ REPARO");
          frmCpu.cbxStatus.Items.Add("S/ CONSERTO");
          frmCpu.cbxStatus.Text = gridCpu.Rows[i].Cells["status"].Value.ToString();

          frmCpu.dtUltLimpeza.Value = Convert.ToDateTime(gridCpu.Rows[i].Cells["dtultlimpeza"].Value);
          frmCpu.dtUltManutencao.Value = Convert.ToDateTime(gridCpu.Rows[i].Cells["dtultmanut"].Value);
          frmCpu.btnAlterar.Enabled = true;
          frmCpu.btnExcluir.Enabled = true;
          frmCpu.txtCodigo.Select();
          frmCpu.txtCodigo.SelectAll();
        }
        else if (frmEst != null)
        {
          frmEst.txtIDCpu.Text = gridCpu.Rows[i].Cells["id"].Value.ToString();
          frmEst.txtHD.Text = gridCpu.Rows[i].Cells["hd"].Value.ToString();
          frmEst.txtMemoria.Text = gridCpu.Rows[i].Cells["memoria"].Value.ToString();
          frmEst.txtMidia.Text = gridCpu.Rows[i].Cells["midia"].Value.ToString();
          frmEst.txtProcessador.Text = gridCpu.Rows[i].Cells["processador"].Value.ToString();
          frmEst.dtUltLimpeza.Value = Convert.ToDateTime(gridCpu.Rows[i].Cells["dtultlimpeza"].Value);

          frmEst.txtIDCpu.Select();
          frmEst.txtIDCpu.SelectAll();
          frmEst.btnSalvar.Enabled = true;
          frmEst.btnSalvar.Focus();
        }
        this.Dispose();
      }
      else
      {

      }
    }

  }
}
