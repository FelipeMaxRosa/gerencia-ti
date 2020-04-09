using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gerenciati
{
  class Fornecedor
  {
    //Atributos
    //------------------------------------------------------------
    private BancoDados bd;
    private SqlCommand cmd;
    private DataSet ds;

    private int id;
    private string razaoSocial;
    private string nomeFantasia;
    private string cnpj;
    private string ie;
    private string cep;
    private string logradouro;
    private string numero;
    private string complemento;
    private string bairro;
    private string cidade;
    private string uf;
    private string tel1;
    private string tel2;
    private string obs;

    //Propriedades
    //------------------------------------------------------------
    public int Id
    {
      get { return id; }
      set { id = value; }
    }
    public string RazaoSocial
    {
      get { return razaoSocial; }
      set { razaoSocial = value; }
    }
    public string NomeFantasia
    {
      get { return nomeFantasia; }
      set { nomeFantasia = value; }
    }
    public string Cnpj
    {
      get { return cnpj; }
      set { cnpj = value; }
    }
    public string Ie
    {
      get { return ie; }
      set { ie = value; }
    }
    public string Cep
    {
      get { return cep; }
      set { cep = value; }
    }
    public string Logradouro
    {
      get { return logradouro; }
      set { logradouro = value; }
    }
    public string Numero
    {
      get { return numero; }
      set { numero = value; }
    }
    public string Complemento
    {
      get { return complemento; }
      set { complemento = value; }
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
    public string Tel1
    {
      get { return tel1; }
      set { tel1 = value; }
    }
    public string Tel2
    {
      get { return tel2; }
      set { tel2 = value; }
    }
    public string Obs
    {
      get { return obs; }
      set { obs = value; }
    }

    //Métodos Gerais
    //------------------------------------------------------------
    public void RetornaID()
    {
      string sql = "SELECT TOP (1) id FROM fornecedor ORDER BY id DESC";
      string table = "fornecedor";
      ds = bd.ConsultarRegistro(sql, table);
      id = Convert.ToInt32(ds.Tables[table].Rows[0]["id"]);
    }

    public void InserirFornecedor()
    {
      string sql = "INSERT INTO fornecedor (id, razaosocial, nomefantasia, cnpj, ie, cep, logradouro, numero, complemento, bairro, cidade, uf, telefone1, telefone2, obs) VALUES (@id, @raz, @cnpj, @ie, @log, @num, @com, @bai, @cid, @uf, @tel1, @tel2, @obs)";
      cmd = new SqlCommand();
      cmd.CommandText = sql;

      SqlParameter pId = new SqlParameter("@id", id);
      cmd.Parameters.Add(pId);
      SqlParameter pRaz = new SqlParameter("@raz", razaoSocial);
      cmd.Parameters.Add(pRaz);
      SqlParameter pIe = new SqlParameter("@ie", ie);
      cmd.Parameters.Add(pIe);
      SqlParameter pCep = new SqlParameter("@cep", cep);
      cmd.Parameters.Add(pCep);
      SqlParameter pLog = new SqlParameter("@log", logradouro);
      cmd.Parameters.Add(pLog);
      SqlParameter pNum = new SqlParameter("@num", numero);
      cmd.Parameters.Add(pNum);
      SqlParameter pCom = new SqlParameter("@com", complemento);
      cmd.Parameters.Add(pCom);
      SqlParameter pBai = new SqlParameter("@bai", bairro);
      cmd.Parameters.Add(pBai);
      SqlParameter pCid = new SqlParameter("@cid", cidade);
      cmd.Parameters.Add(pCid);
      SqlParameter pUf = new SqlParameter("@uf", uf);
      cmd.Parameters.Add(pUf);
      SqlParameter pTel1 = new SqlParameter("@tel1", tel1);
      cmd.Parameters.Add(pTel1);
      SqlParameter pTel2 = new SqlParameter("@tel2", tel2);
      cmd.Parameters.Add(pTel2);
      SqlParameter pObs = new SqlParameter("@obs", obs);
      cmd.Parameters.Add(pObs);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro inserido com sucesso!", "Registro Inserido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }
  }
}
