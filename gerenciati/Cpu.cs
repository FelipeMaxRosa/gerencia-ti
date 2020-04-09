using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gerenciati
{
  class Cpu
  {
    //Atributos
    //---------------------------------------------------------------
    private BancoDados bd;
    private SqlCommand cmd;
    private DataSet ds;

    private int id;
    private int idLoja;
    private string marca;
    private string modelo;
    private string numSerie;
    private string placaMae;
    private string processador;
    private string memoria;
    private string hd;
    private string midia;
    private DateTime dtUltLimpeza;
    private string obs;
    private string status;
    private DateTime dtUltManut;

    //Propriedades
    //---------------------------------------------------------------
    public int Id
    {
      get { return id; }
      set { id = value; }
    }
    public int IdLoja
    {
      get { return idLoja; }
      set { idLoja = value; }
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
    public string NumSerie
    {
      get { return numSerie; }
      set { numSerie = value; }
    }
    public string PlacaMae
    {
      get { return placaMae; }
      set { placaMae = value; }
    }
    public string Processador
    {
      get { return processador; }
      set { processador = value; }
    }
    public string Memoria
    {
      get { return memoria; }
      set { memoria = value; }
    }
    public string Hd
    {
      get { return hd; }
      set { hd = value; }
    }
    public string Midia
    {
      get { return midia; }
      set { midia = value; }
    }
    public DateTime DtUltLimpeza
    {
      get { return dtUltLimpeza; }
      set { dtUltLimpeza = value; }
    }
    public string Obs
    {
      get { return obs; }
      set { obs = value; }
    }
    public string Status
    {
      get { return status; }
      set { status = value; }
    }
    public DateTime DtUltManut
    {
      get { return dtUltManut; }
      set { dtUltManut = value; }
    }

    //Construtor
    //---------------------------------------------------------------
    public Cpu()
    {
      bd = new BancoDados();
    }

    //Métodos Gerais
    //---------------------------------------------------------------
    public void RetornaID()
    {
      string sql = "SELECT TOP (1) id FROM cpu ORDER BY id DESC";
      string table = "cpu";
      ds = bd.ConsultarRegistro(sql, table);
      id = Convert.ToInt32(ds.Tables[table].Rows[0]["id"]);
    }

    public void InserirCpu()
    {
      string SQL = "INSERT INTO cpu (idloja, marca, modelo, numserie, placamae, processador, memoria, hd, midia, dtultlimpeza, obs, status, dtultmanut) VALUES (@idl, @mar, @mod, @num, @pla, @pro, @mem, @hd, @mid, @dt, @obs, @sta, @man)";
      cmd = new SqlCommand();
      cmd.CommandText = SQL;

      SqlParameter pIdL = new SqlParameter("@idl", idLoja);
      cmd.Parameters.Add(pIdL);
      SqlParameter pMar = new SqlParameter("@mar", marca);
      cmd.Parameters.Add(pMar);
      SqlParameter pMod = new SqlParameter("@mod", modelo);
      cmd.Parameters.Add(pMod);
      SqlParameter pNum = new SqlParameter("@num", numSerie);
      cmd.Parameters.Add(pNum);
      SqlParameter pPla = new SqlParameter("@pla", placaMae);
      cmd.Parameters.Add(pPla);
      SqlParameter pPro = new SqlParameter("@pro", processador);
      cmd.Parameters.Add(pPro);
      SqlParameter pMem = new SqlParameter("@mem", memoria);
      cmd.Parameters.Add(pMem);
      SqlParameter pHd = new SqlParameter("@hd", hd);
      cmd.Parameters.Add(pHd);
      SqlParameter pMid = new SqlParameter("@mid", midia);
      cmd.Parameters.Add(pMid);
      SqlParameter pDt = new SqlParameter("@dt", dtUltLimpeza);
      cmd.Parameters.Add(pDt);
      SqlParameter pObs = new SqlParameter("@obs", obs);
      cmd.Parameters.Add(pObs);
      SqlParameter pSta = new SqlParameter("@sta", status);
      cmd.Parameters.Add(pSta);
      SqlParameter pMan = new SqlParameter("@man", dtUltManut);
      cmd.Parameters.Add(pMan);

      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro inserido com sucesso!", "Registro Inserido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void ConsultarCpu()
    {
      bool localizado = false;
      string SQL = "SELECT COUNT(*) FROM cpu WHERE id = @id";
      cmd = new SqlCommand();
      cmd.CommandText = SQL;

      SqlParameter pId = new SqlParameter("@id", id);
      cmd.Parameters.Add(pId);
      localizado = bd.VerificarRegistro(cmd);
      if (localizado)
      {
        SQL = "SELECT * FROM cpu WHERE id ='" + id + "'";
        string table = "cpu";

        ds = bd.ConsultarRegistro(SQL, table);
        idLoja = Convert.ToInt32(ds.Tables[0].Rows[0]["idloja"]);
        marca = Convert.ToString(ds.Tables[0].Rows[0]["marca"]);
        modelo = Convert.ToString(ds.Tables[0].Rows[0]["modelo"]);
        numSerie = Convert.ToString(ds.Tables[0].Rows[0]["numserie"]);
        placaMae = Convert.ToString(ds.Tables[0].Rows[0]["placamae"]);
        processador = Convert.ToString(ds.Tables[0].Rows[0]["processador"]);
        memoria = Convert.ToString(ds.Tables[0].Rows[0]["memoria"]);
        hd = Convert.ToString(ds.Tables[0].Rows[0]["hd"]);
        midia = Convert.ToString(ds.Tables[0].Rows[0]["midia"]);
        dtUltLimpeza = Convert.ToDateTime(ds.Tables[0].Rows[0]["dtultlimpeza"]);
        obs = Convert.ToString(ds.Tables[0].Rows[0]["obs"]);
        status = Convert.ToString(ds.Tables[0].Rows[0]["status"]);
        dtUltManut = Convert.ToDateTime(ds.Tables[0].Rows[0]["dtultmanut"]);
      }
      else
      {
        MessageBox.Show("CPU não cadastrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public void AtualizarCpu()
    {
      string SQL = "UPDATE cpu SET idloja = @idl, marca = @mar, modelo = @mod, numserie = @num, placamae = @pla, processador = @pro, memoria = @mem, hd = @hd, midia = @mid, dtultlimpeza = @dt, obs = @obs, status = @sta, dtultmanut = @man WHERE id = @id";
      cmd = new SqlCommand();
      cmd.CommandText = SQL;

      SqlParameter pIdL = new SqlParameter("@idl", idLoja);
      cmd.Parameters.Add(pIdL);
      SqlParameter pMar = new SqlParameter("@mar", marca);
      cmd.Parameters.Add(pMar);
      SqlParameter pMod = new SqlParameter("@mod", modelo);
      cmd.Parameters.Add(pMod);
      SqlParameter pNum = new SqlParameter("@num", numSerie);
      cmd.Parameters.Add(pNum);
      SqlParameter pPla = new SqlParameter("@pla", placaMae);
      cmd.Parameters.Add(pPla);
      SqlParameter pPro = new SqlParameter("@pro", processador);
      cmd.Parameters.Add(pPro);
      SqlParameter pMem = new SqlParameter("@mem", memoria);
      cmd.Parameters.Add(pMem);
      SqlParameter pHd = new SqlParameter("@hd", hd);
      cmd.Parameters.Add(pHd);
      SqlParameter pMid = new SqlParameter("@mid", midia);
      cmd.Parameters.Add(pMid);
      SqlParameter pDt = new SqlParameter("@dt", dtUltLimpeza);
      cmd.Parameters.Add(pDt);
      SqlParameter pObs = new SqlParameter("@obs", obs);
      cmd.Parameters.Add(pObs);
      SqlParameter pSta = new SqlParameter("@sta", status);
      cmd.Parameters.Add(pSta);
      SqlParameter pMan = new SqlParameter("@man", dtUltManut);
      cmd.Parameters.Add(pMan);
      SqlParameter pId = new SqlParameter("@id", id);
      cmd.Parameters.Add(pId);

      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro atualizado com sucesso!", "Registro Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void ExcluirCpu()
    {
      string SQL = "UPDATE cpu SET status = 'EXCLUIDO' WHERE id = @id";
      cmd = new SqlCommand();
      cmd.CommandText = SQL;

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
