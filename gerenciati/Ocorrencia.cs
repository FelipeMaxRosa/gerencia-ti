using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gerenciati
{
  class Ocorrencia
  {
    //Atributos
    //---------------------------------------------------------------------
    private BancoDados bd;
    private SqlCommand cmd;
    private DataSet ds;

    private int id;
    private int idEstacao;
    private int idLoja;
    private DateTime dtOcorrencia;
    private string descOcorrencia;
    private string solicitante;
    private string status;

    //Propriedades
    //---------------------------------------------------------------------
    public int Id
    {
      get { return id; }
      set { id = value; }
    }
    public int IdEstacao
    {
      get { return idEstacao; }
      set { idEstacao = value; }
    }
    public DateTime DtOcorrencia
    {
      get { return dtOcorrencia; }
      set { dtOcorrencia = value; }
    }
    public string DescOcorrencia
    {
      get { return descOcorrencia; }
      set { descOcorrencia = value; }
    }
    public string Solicitante
    {
      get { return solicitante; }
      set { solicitante = value; }
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

    //Construtor
    //---------------------------------------------------------------------
    public Ocorrencia()
    {
      bd = new BancoDados();
    }

    //Métodos Gerais
    //---------------------------------------------------------------------
    public void RetornaID()
    {
      string sql = "SELECT TOP (1) id FROM ocorrencia ORDER BY id DESC";
      string table = "ocorrencia";
      ds = bd.ConsultarRegistro(sql, table);
      if (ds.Tables[table].Rows.Count <= 0)
        id = 0;
      else
        id = Convert.ToInt32(ds.Tables[table].Rows[0]["id"]);
    }

    public void InserirOcorrencia()
    {
      string sql = "INSERT INTO ocorrencia (idestacao, data, ocorrencia, solicitante, status, idloja) VALUES (@ide, @data, @oco, @sol, @sta, @idl)";
      cmd = new SqlCommand();
      cmd.CommandText = sql;

      SqlParameter pIde = new SqlParameter("@ide", idEstacao);
      cmd.Parameters.Add(pIde);
      SqlParameter pDat = new SqlParameter("@data", dtOcorrencia);
      cmd.Parameters.Add(pDat);
      SqlParameter pOco = new SqlParameter("@oco",descOcorrencia);
      cmd.Parameters.Add(pOco);
      SqlParameter pSol = new SqlParameter("@sol", solicitante);
      cmd.Parameters.Add(pSol);
      SqlParameter pSta = new SqlParameter("@sta", status);
      cmd.Parameters.Add(pSta);
      SqlParameter pIdl = new SqlParameter("@idl", idLoja);
      cmd.Parameters.Add(pIdl);

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
      string sql = "SELECT COUNT(*) FROM ocorrencia WHERE id = @id";
      cmd = new SqlCommand();
      cmd.CommandText = sql;

      SqlParameter pId = new SqlParameter("@id", id);
      cmd.Parameters.Add(pId);
      localizado = bd.VerificarRegistro(cmd);
      if (localizado)
      {
        sql = "SELECT * FROM ocorrencia WHERE id ='" + id + "'";
        string table = "ocorrencia";

        ds = bd.ConsultarRegistro(sql, table);

        id = Convert.ToInt32(ds.Tables[table].Rows[0]["id"]);
        idEstacao = Convert.ToInt32(ds.Tables[table].Rows[0]["idestacao"]);
        idLoja = Convert.ToInt32(ds.Tables[table].Rows[0]["idloja"]);
        dtOcorrencia = Convert.ToDateTime(ds.Tables[table].Rows[0]["data"]);
        descOcorrencia = Convert.ToString(ds.Tables[table].Rows[0]["ocorrencia"]);
        solicitante = Convert.ToString(ds.Tables[table].Rows[0]["solicitante"]);
        status = Convert.ToString(ds.Tables[table].Rows[0]["status"]);
      }
      else
      {
        MessageBox.Show("Ocorrência não cadastrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public void AtualizarEquipamento()
    {
      string sql = "UPDATE equip SET idloja = @idl, genero = @gen, descricao = @des, marca = @mar, modelo = @mod, tipo = @tip, numserie = @num, versao = @ver, portacom = @por, obs = @obs, status = @sta WHERE id = @id";
      cmd = new SqlCommand();
      cmd.CommandText = sql;

      SqlParameter pIdl = new SqlParameter("@idl", idLoja);
      cmd.Parameters.Add(pIdl);
      
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
