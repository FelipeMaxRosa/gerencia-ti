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
  public partial class FormGridEquipamentos : Form
  {
    //Atributos
    //--------------------------------------------------------
    private DataSet ds;
    private BancoDados bd;
    private FormEquipamentos frmEquip;


    //Construtor
    //--------------------------------------------------------
    public FormGridEquipamentos(object frm1, string tipoObj)
    {
      InitializeComponent();
      bd = new BancoDados();
      
      if (tipoObj == "equip")
      {
        frmEquip = (FormEquipamentos)frm1;
      }      
    }

    private void FormGridEquipamentos_Load(object sender, EventArgs e)
    {
      string SQL = "SELECT * FROM equip";
      string table = "equip";
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, table);
      gridEquip.DataSource = ds.Tables[table];
      txtDescricao.Select();
    }

    private void FormGridEquipamentos_Resize(object sender, EventArgs e)
    {

      //btnSair.Location = new Point(this.ClientSize.Width - 93, this.ClientSize.Height - 56 - 38);
    }

    private void FormGridEquipamentos_SizeChanged(object sender, EventArgs e)
    {
      //Pega o tamanho do Form menos o tamanho do grid
      //Form: 911 x 509
      //Grid: 893 x 331
      gridEquip.Width = this.Width - 18;
      gridEquip.Height = this.Height - 178;

      //Pega o tamanho do Form menos a posição atuao do botão
      //Form: 911 x 509
      //Position: 818 x 453
      btnSair.Location = new Point(this.Width - 93, this.Height - 56);
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      if (frmEquip != null)
      {
        frmEquip.txtCodigo.Select();
      }
      this.Close();
    }

    private void txtDescricao_Leave(object sender, EventArgs e)
    {
      if (txtDescricao.Text.Length != 0)
      {
        string SQL = "SELECT * FROM equip WHERE descricao LIKE ('"+ txtDescricao.Text +"%') AND status <> 'excluido' ORDER BY descricao";
        string table = "equip";
        ds = new DataSet();
        ds = bd.ConsultarParaGrid(SQL, table);
        gridEquip.DataSource = ds.Tables[table];
        if (gridEquip.RowCount > 0)
        {
          gridEquip.Focus();
          gridEquip.FirstDisplayedScrollingRowIndex = 0;
          gridEquip.Refresh();
          gridEquip.CurrentCell = gridEquip.Rows[0].Cells[0];
          gridEquip.Rows[0].Selected = true;
          this.CancelButton = null;
        }
        else
        {
          MessageBox.Show("Nenhum produto encontrado com essa informação!", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          txtDescricao.Clear();
          txtDescricao.Select();
          this.CancelButton = btnSair;
        }
      }
    }

    private void FormGridEquipamentos_KeyDown(object sender, KeyEventArgs e)
    {
      if (gridEquip.Focused == false)
      {
        if (e.KeyCode == Keys.Enter)
        {
          if (e.Shift)
          {
            SendKeys.Send("+{TAB}");
            e.SuppressKeyPress = true;
          }
          else
          {
            SendKeys.Send("{TAB}");
            e.SuppressKeyPress = true;
          }
        }
      }
      else
      {
        if (e.KeyCode == Keys.Enter)
        {
          e.SuppressKeyPress = true;
          DataGridViewRow linhaAtual = gridEquip.CurrentRow;
          int i = linhaAtual.Index;
          if (frmEquip != null)
          {
            frmEquip.txtCodigo.Text = gridEquip.Rows[i].Cells["id"].Value.ToString();
            frmEquip.txtDescricao.Text = gridEquip.Rows[i].Cells["descricao"].Value.ToString();
            frmEquip.txtGenero.Text = gridEquip.Rows[i].Cells["genero"].Value.ToString();
            frmEquip.txtMarca.Text = gridEquip.Rows[i].Cells["marca"].Value.ToString();
            frmEquip.txtModelo.Text = gridEquip.Rows[i].Cells["modelo"].Value.ToString();
            frmEquip.txtNumSerie.Text = gridEquip.Rows[i].Cells["numserie"].Value.ToString();
            frmEquip.txtObservacao.Text = gridEquip.Rows[i].Cells["obs"].Value.ToString();
            frmEquip.txtTipo.Text = gridEquip.Rows[i].Cells["tipo"].Value.ToString();
            frmEquip.txtVersao.Text = gridEquip.Rows[i].Cells["versao"].Value.ToString();

            //Preenche ComboBox Loja
            //-----------------------------------------------
            DataTable dt = new DataTable();
            Loja lj = new Loja();
            dt = lj.PreencheComboBox();
            frmEquip.cbxLoja.DisplayMember = "razaosocial";
            frmEquip.cbxLoja.ValueMember = "id";
            frmEquip.cbxLoja.DataSource = dt;
            frmEquip.cbxLoja.SelectedValue = Convert.ToInt32(gridEquip.Rows[i].Cells["idloja"].Value);

            //Preenche ComboBox Status
            //-----------------------------------------------
            frmEquip.cbxStatus.Items.Clear();
            frmEquip.cbxStatus.Items.Add("EM USO");
            frmEquip.cbxStatus.Items.Add("NAO UTILIZADO");
            frmEquip.cbxStatus.Items.Add("ENVIADO P/ REPARO");
            frmEquip.cbxStatus.Items.Add("S/ CONSERTO");
            frmEquip.cbxStatus.Text = gridEquip.Rows[i].Cells["status"].Value.ToString();

            //Preenche ComboBox Porta de Comunicação
            //-----------------------------------------------
            frmEquip.cbxPortaCom.Items.Clear();
            frmEquip.cbxPortaCom.Items.Add("SERIAL (DB9)");
            frmEquip.cbxPortaCom.Items.Add("LPT (DB25)");
            frmEquip.cbxPortaCom.Items.Add("USB");
            frmEquip.cbxPortaCom.Items.Add("WIRELESS");
            frmEquip.cbxPortaCom.Items.Add("ETHERNET");
            frmEquip.cbxPortaCom.Items.Add("PS/2");
            frmEquip.cbxPortaCom.Items.Add("NENHUMA");
            frmEquip.cbxPortaCom.Sorted = true;
            frmEquip.cbxPortaCom.Text = gridEquip.Rows[i].Cells["portacom"].Value.ToString();

            frmEquip.btnAlterar.Enabled = true;
            frmEquip.btnExcluir.Enabled = true;
            frmEquip.txtCodigo.Select();
            frmEquip.txtCodigo.SelectAll();
            this.Dispose();
          }  
        }
        else if (e.KeyCode == Keys.Escape)
        {
          txtDescricao.Clear();
          txtMarca.Clear();
          txtNumSerie.Clear();
          txtDescricao.Focus();
          txtDescricao.SelectAll();
          this.CancelButton = btnSair;
        }
      }
    }

    private void gridEquip_Enter(object sender, EventArgs e)
    {
      this.CancelButton = null;
    }

    private void gridEquip_Leave(object sender, EventArgs e)
    {
      this.CancelButton = btnSair;
    }

    private void txtMarca_Leave(object sender, EventArgs e)
    {
      if (txtMarca.Text.Length > 0)
      {
        string SQL = "SELECT * FROM equip WHERE marca LIKE ('" + txtMarca.Text + "%') AND status <> 'excluido' ORDER BY descricao";
        string table = "equip";
        ds = new DataSet();
        ds = bd.ConsultarParaGrid(SQL, table);
        gridEquip.DataSource = ds.Tables[0];
        if (gridEquip.RowCount > 0)
        {
          gridEquip.Focus();
          gridEquip.FirstDisplayedScrollingRowIndex = 0;
          gridEquip.Refresh();
          gridEquip.CurrentCell = gridEquip.Rows[0].Cells[0];
          gridEquip.Rows[0].Selected = true;
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

    private void gridEquip_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        if (frmEquip != null)
        {
          frmEquip.txtCodigo.Text = gridEquip.Rows[e.RowIndex].Cells["id"].Value.ToString();
          frmEquip.txtDescricao.Text = gridEquip.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
          frmEquip.txtGenero.Text = gridEquip.Rows[e.RowIndex].Cells["genero"].Value.ToString();
          frmEquip.txtMarca.Text = gridEquip.Rows[e.RowIndex].Cells["marca"].Value.ToString();
          frmEquip.txtModelo.Text = gridEquip.Rows[e.RowIndex].Cells["modelo"].Value.ToString();
          frmEquip.txtNumSerie.Text = gridEquip.Rows[e.RowIndex].Cells["numserie"].Value.ToString();
          frmEquip.txtObservacao.Text = gridEquip.Rows[e.RowIndex].Cells["obs"].Value.ToString();
          frmEquip.txtTipo.Text = gridEquip.Rows[e.RowIndex].Cells["tipo"].Value.ToString();
          frmEquip.txtVersao.Text = gridEquip.Rows[e.RowIndex].Cells["versao"].Value.ToString();

          //Preenche ComboBox Loja
          //-----------------------------------------------
          DataTable dt = new DataTable();
          Loja lj = new Loja();
          dt = lj.PreencheComboBox();
          frmEquip.cbxLoja.DisplayMember = "razaosocial";
          frmEquip.cbxLoja.ValueMember = "id";
          frmEquip.cbxLoja.DataSource = dt;
          frmEquip.cbxLoja.SelectedValue = Convert.ToInt32(gridEquip.Rows[e.RowIndex].Cells["idloja"].Value);

          //Preenche ComboBox Status
          //-----------------------------------------------
          frmEquip.cbxStatus.Items.Clear();
          frmEquip.cbxStatus.Items.Add("EM USO");
          frmEquip.cbxStatus.Items.Add("NAO UTILIZADO");
          frmEquip.cbxStatus.Items.Add("ENVIADO P/ REPARO");
          frmEquip.cbxStatus.Items.Add("S/ CONSERTO");
          frmEquip.cbxStatus.Text = gridEquip.Rows[e.RowIndex].Cells["status"].Value.ToString();

          //Preenche ComboBox Porta de Comunicação
          //-----------------------------------------------
          frmEquip.cbxPortaCom.Items.Clear();
          frmEquip.cbxPortaCom.Items.Add("SERIAL (DB9)");
          frmEquip.cbxPortaCom.Items.Add("LPT (DB25)");
          frmEquip.cbxPortaCom.Items.Add("USB");
          frmEquip.cbxPortaCom.Items.Add("WIRELESS");
          frmEquip.cbxPortaCom.Items.Add("ETHERNET");
          frmEquip.cbxPortaCom.Items.Add("PS/2");
          frmEquip.cbxPortaCom.Items.Add("NENHUMA");
          frmEquip.cbxPortaCom.Sorted = true;
          frmEquip.cbxPortaCom.Text = gridEquip.Rows[e.RowIndex].Cells["portacom"].Value.ToString();

          frmEquip.btnAlterar.Enabled = true;
          frmEquip.btnExcluir.Enabled = true;
          frmEquip.txtCodigo.Select();
          frmEquip.txtCodigo.SelectAll();
          this.Dispose();          
        }
      }
      else
      {
 
      }
    }

    private void txtNumSerie_Leave(object sender, EventArgs e)
    {
      string SQL;
      string table;
      if (txtNumSerie.Text.Length > 0)
      {
        SQL = "SELECT * FROM equip WHERE numserie LIKE ('" + txtNumSerie.Text + "%') AND status <> 'excluido' ORDER BY descricao";
        table = "equip";
      }
      else
      {
        SQL = "SELECT * FROM equip WHERE status <> 'excluido' ORDER BY descricao ";
        table = "equip";
      }
      ds = new DataSet();
      ds = bd.ConsultarParaGrid(SQL, table);
      gridEquip.DataSource = ds.Tables[0];
      if (gridEquip.RowCount > 0)
      {
        gridEquip.Focus();
        gridEquip.FirstDisplayedScrollingRowIndex = 0;
        gridEquip.Refresh();
        gridEquip.CurrentCell = gridEquip.Rows[0].Cells[0];
        gridEquip.Rows[0].Selected = true;
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

    private void gridEquip_Click(object sender, EventArgs e)
    {
      this.CancelButton = null;
    }

    //Resize
    //--------------------------------------------------------
    /*private void FormConsultaPaciente_Resize(object sender, EventArgs e)
    {
      gridPaciente.Width = this.Width - 14;
      gridPaciente.Height = this.Height - 165;
      btSair.Location = new Point(this.Width - 95, this.Height - 69);
    }*/


  }
}
