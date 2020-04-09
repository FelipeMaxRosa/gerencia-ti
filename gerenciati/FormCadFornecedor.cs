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
  public partial class FormCadFornecedor : Form
  {
    public FormCadFornecedor()
    {
      InitializeComponent();
    }

    private void FormCadFornecedor_Load(object sender, EventArgs e)
    {

    }

    private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
      {
        e.Handled = true;
      }
    }
  }
}
