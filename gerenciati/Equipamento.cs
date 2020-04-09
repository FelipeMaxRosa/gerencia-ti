using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gerenciati
{
  class Equipamento
  {
    //Atributos
    //---------------------------------------------------------------
    private BancoDados bd;
    private SqlCommand cmd;
    private DataSet ds;

    private int id;
    private string status;
    private int idLoja;
    private string genero;
    private string descricao;
    private string marca;
    private string modelo;
    private string tipo;
    private string numSerie;
    private string versao;
    private string portaCom;
    private string obs;

    //Propriedades
    //---------------------------------------------------------------
    public int Id
    {
      get { return id; }
      set { id = value; }
    }
    public string Status
    {
      get { return status; }
      set { status = value; }
    }
    public int IdLoja
    {
      get { return idLoja; }
      set { idLoja = value; }
    }
    public string Genero
    {
      get { return genero; }
      set { genero = value; }
    }
    public string Descricao
    {
      get { return descricao; }
      set { descricao = value; }
    }
    public string Marca
    {
      get { return marca; }
      set { marca = value; }
    }
    public string Modelo
    {
      get { return modelo; }
      set { modelo = value; }
    }
    public string Tipo
    {
      get { return tipo; }
      set { tipo = value; }
    }
    public string NumSerie
    {
      get { return numSerie; }
      set { numSerie = value; }
    }
    public string Versao
    {
      get { return versao; }
      set { versao = value; }
    }
    public string PortaCom
    {
      get { return portaCom; }
      set { portaCom = value; }
    }
    public string Obs
    {
      get { return obs; }
      set { obs = value; }
    }

    //Construtor
    //---------------------------------------------------------------
    public Equipamento()
    {
      bd = new BancoDados();
    }

    //Métodos
    //---------------------------------------------------------------
    public void RetornaID()
    {
      string sql = "SELECT TOP (1) id FROM equip ORDER BY id DESC";
      string table = "equip";
      ds = bd.ConsultarRegistro(sql, table);
      if (ds.Tables[table].Rows[0]["id"] is DBNull)
        id = 0;
      else
        id = Convert.ToInt32(ds.Tables[table].Rows[0]["id"]);
    }

    public void InserirEquipamento()
    {
      string sql = "INSERT INTO equip (idloja, genero, descricao, marca, modelo, tipo, numserie, versao, portacom, obs, status) VALUES (@idl, @gen, @des, @mar, @mod, @tip, @num, @ver, @por, @obs, @sta)";
      cmd = new SqlCommand();
      cmd.CommandText = sql;

      //SqlParameter pId = new SqlParameter("@id", id);
      //cmd.Parameters.Add(pId);
      SqlParameter pIdl = new SqlParameter("@idl", idLoja);
      cmd.Parameters.Add(pIdl);
      SqlParameter pGen = new SqlParameter("@gen", genero);
      cmd.Parameters.Add(pGen);
      SqlParameter pDes = new SqlParameter("@des", descricao);
      cmd.Parameters.Add(pDes);
      SqlParameter pMar = new SqlParameter("@mar", marca);
      cmd.Parameters.Add(pMar);
      SqlParameter pMod = new SqlParameter("@mod", modelo);
      cmd.Parameters.Add(pMod);
      SqlParameter pTip = new SqlParameter("@tip", tipo);
      cmd.Parameters.Add(pTip);
      SqlParameter pNum = new SqlParameter("@num", numSerie);
      cmd.Parameters.Add(pNum);
      SqlParameter pVer = new SqlParameter("@ver", versao);
      cmd.Parameters.Add(pVer);
      SqlParameter pPor = new SqlParameter("@por", portaCom);
      cmd.Parameters.Add(pPor);
      SqlParameter pObs = new SqlParameter("@obs", obs);
      cmd.Parameters.Add(pObs);
      SqlParameter pSta = new SqlParameter("@sta", status);
      cmd.Parameters.Add(pSta);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro inserido com sucesso!", "Registro Inserido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void ConsultarEquipamento()
    {
      bool localizado = false;
      string sql = "SELECT COUNT(*) FROM equip WHERE id = @id";
      cmd = new SqlCommand();
      cmd.CommandText = sql;

      SqlParameter pId = new SqlParameter("@id", id);
      cmd.Parameters.Add(pId);
      localizado = bd.VerificarRegistro(cmd);
      if (localizado)
      {
        sql = "SELECT * FROM equip WHERE id ='" + id + "'" ;
        string table = "equip";

        ds = bd.ConsultarRegistro(sql, table);
        idLoja = Convert.ToInt32(ds.Tables[table].Rows[0]["idloja"]);
        genero = Convert.ToString(ds.Tables[table].Rows[0]["genero"]);
        descricao = Convert.ToString(ds.Tables[table].Rows[0]["descricao"]);
        marca = Convert.ToString(ds.Tables[table].Rows[0]["marca"]);
        modelo = Convert.ToString(ds.Tables[table].Rows[0]["modelo"]);
        tipo = Convert.ToString(ds.Tables[table].Rows[0]["tipo"]);
        numSerie = Convert.ToString(ds.Tables[table].Rows[0]["numserie"]);
        versao = Convert.ToString(ds.Tables[table].Rows[0]["versao"]);
        portaCom = Convert.ToString(ds.Tables[table].Rows[0]["portacom"]);
        obs = Convert.ToString(ds.Tables[table].Rows[0]["obs"]);
        status = Convert.ToString(ds.Tables[table].Rows[0]["status"]);
      }
      else
      {
        MessageBox.Show("Equipamento não cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public void AtualizarEquipamento()
    {
      string sql = "UPDATE equip SET idloja = @idl, genero = @gen, descricao = @des, marca = @mar, modelo = @mod, tipo = @tip, numserie = @num, versao = @ver, portacom = @por, obs = @obs, status = @sta WHERE id = @id";
      cmd = new SqlCommand();
      cmd.CommandText = sql;

      SqlParameter pIdl = new SqlParameter("@idl", idLoja);
      cmd.Parameters.Add(pIdl);
      SqlParameter pGen = new SqlParameter("@gen", genero);
      cmd.Parameters.Add(pGen);
      SqlParameter pDes = new SqlParameter("@des", descricao);
      cmd.Parameters.Add(pDes);
      SqlParameter pMar = new SqlParameter("@mar", marca);
      cmd.Parameters.Add(pMar);
      SqlParameter pMod = new SqlParameter("@mod", modelo);
      cmd.Parameters.Add(pMod);
      SqlParameter pTip = new SqlParameter("@tip", tipo);
      cmd.Parameters.Add(pTip);
      SqlParameter pNum = new SqlParameter("@num", numSerie);
      cmd.Parameters.Add(pNum);
      SqlParameter pVer = new SqlParameter("@ver", versao);
      cmd.Parameters.Add(pVer);
      SqlParameter pPor = new SqlParameter("@por", portaCom);
      cmd.Parameters.Add(pPor);
      SqlParameter pObs = new SqlParameter("@obs", obs);
      cmd.Parameters.Add(pObs);
      SqlParameter pSta = new SqlParameter("@sta", status);
      cmd.Parameters.Add(pSta);
      SqlParameter pId = new SqlParameter("@id", id);
      cmd.Parameters.Add(pId);

      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro atualizado com sucesso!", "Registro Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void ExcluirEquipamento()
    {
      string sql = "UPDATE equip SET status = 'EXCLUIDO' WHERE id = @id";
      cmd = new SqlCommand();
      cmd.CommandText = sql;

      SqlParameter pId = new SqlParameter("@id", id);
      cmd.Parameters.Add(pId);

      bd.ExcluirRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro excluído com sucesso!", "Registro Excluído", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }    
  }
}
