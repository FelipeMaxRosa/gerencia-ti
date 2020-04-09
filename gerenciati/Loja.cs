using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gerenciati
{
  class Loja
  {
    //Atributos
    //---------------------------------------------------------------------
    private BancoDados bd;
    private SqlCommand cmd;
    private DataSet ds;
    private DataTable dt;

    private int idLoja;
    private string razaoSocial;
    private string bairro;
    private string cidade;
    private string uf;

    //Propriedades
    //---------------------------------------------------------------------
    public int IdLoja
    {
      get { return idLoja; }
      set { idLoja = value; }
    }
    public string RazaoSocial
    {
      get { return razaoSocial; }
      set { razaoSocial = value; }
    }
    public string Bairro
    {
      get { return bairro; }
      set { bairro = value; }
    }
    public string Cidade
    {
      get { return cidade; }
      set { cidade = value; }
    }
    public string Uf
    {
      get { return uf; }
      set { uf = value; }
    }

    //Construtor
    //---------------------------------------------------------------------
    public Loja()
    {
      bd = new BancoDados();
    }

    //Metodos Gerais
    //---------------------------------------------------------------------
    public DataTable PreencheComboBox()
    {
      string SQL = "SELECT * FROM loja";
      dt = new DataTable();
      dt = bd.PreencherCbx(SQL, dt);

      return dt;
    }

    public void RetornaIdLoja()
    {
      string sql = "SELECT TOP (1) id FROM loja ORDER BY id DESC";
      cmd = new SqlCommand();
      cmd.CommandText = sql;

      idLoja = bd.RetornaQtdeRegistros(cmd);
      idLoja++;
    }

    public void InserirLoja()
    {
      string SQL = "INSERT INTO loja VALUES (NULL, @raz, @bai, @cid, @uf)";
      cmd = new SqlCommand();
      cmd.CommandText = SQL;

      SqlParameter pRaz = new SqlParameter("@raz", razaoSocial);
      cmd.Parameters.Add(pRaz);
      SqlParameter pBai = new SqlParameter("@bai", bairro);
      cmd.Parameters.Add(pBai);
      SqlParameter pCid = new SqlParameter("@cid", cidade);
      cmd.Parameters.Add(pCid);
      SqlParameter pUf = new SqlParameter("@uf", uf);
      cmd.Parameters.Add(pUf);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro inserido com sucesso!", "Registro Inserido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }

    }




  }
}
