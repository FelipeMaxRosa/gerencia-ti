using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gerenciati
{
  class Estacao
  {
    //Atributos
    //---------------------------------------------------------------------
    private BancoDados bd;
    private SqlCommand cmd;
    private DataSet ds;

    private int id;
    private int idLoja;
    private string descricao;
    private int idCpu; //id do cadastro de CPU
    private string usuario;

    //Propriedades
    //---------------------------------------------------------------------
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
    public string Descricao
    {
      get { return descricao; }
      set { descricao = value; }
    }
    public int IdCpu
    {
      get { return idCpu; }
      set { idCpu = value; }
    }
    public string Usuario
    {
      get { return usuario; }
      set { usuario = value; }
    }

    //Construtor
    //---------------------------------------------------------------------
    public Estacao()
    {
      bd = new BancoDados();
    }

    //Métodos
    //---------------------------------------------------------------------
    public void RetornaID()
    {
      string sql = "SELECT TOP (1) id FROM estacao ORDER BY id DESC";
      string table = "estacao";
      ds = bd.ConsultarRegistro(sql, table);
      //if (ds.Tables[table].Rows[0]["id"] is DBNull)
      if (ds.Tables[table].Rows.Count == 0)
        id = 0;
      else
        id = Convert.ToInt32(ds.Tables[table].Rows[0]["id"]);
    }

    public void InserirEstacao()
    {
      string sql = "INSERT INTO estacao (estacao, idcpu, usuario) VALUES (@est, @idc, @usu)";
      cmd = new SqlCommand();
      cmd.CommandText = sql;

      SqlParameter pEst = new SqlParameter("@est", descricao);
      cmd.Parameters.Add(pEst);
      SqlParameter pIdc = new SqlParameter("@idc", idCpu);
      cmd.Parameters.Add(pIdc);
      SqlParameter pUsu = new SqlParameter("@usu", usuario);
      cmd.Parameters.Add(pUsu);
      bd.InserirRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro inserido com sucesso!", "Registro Inserido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void ConsultarEstacao()
    {
      bool localizado = false;
      string sql = "SELECT COUNT(*) FROM estacao WHERE id = @id";
      cmd = new SqlCommand();
      cmd.CommandText = sql;
      SqlParameter pId = new SqlParameter("@id", id);
      cmd.Parameters.Add(pId);
      localizado = bd.VerificarRegistro(cmd);
      if (localizado)
      {
        sql = "SELECT * FROM estacao WHERE id ='" + id + "'";
        string table = "estacao";
        ds = bd.ConsultarRegistro(sql, table);
        descricao = Convert.ToString(ds.Tables[table].Rows[0]["estacao"]);
        idCpu = Convert.ToInt32(ds.Tables[table].Rows[0]["idcpu"]);
        usuario = Convert.ToString(ds.Tables[table].Rows[0]["usuario"]);
      }
      else
      {
        MessageBox.Show("Estação não cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public void AtualizarEstacao()
    {
      string sql = "UPDATE estacao SET estacao = @est, idcpu = @idc, usuario = @usu WHERE id = @id";
      cmd = new SqlCommand();
      cmd.CommandText = sql;

      SqlParameter pEst = new SqlParameter("@est", descricao);
      cmd.Parameters.Add(pEst);
      SqlParameter pIdc = new SqlParameter("@idc", idCpu);
      cmd.Parameters.Add(pIdc);
      SqlParameter pUsu = new SqlParameter("@usu", usuario);
      cmd.Parameters.Add(pUsu);
      SqlParameter pId = new SqlParameter("@id", id);
      cmd.Parameters.Add(pId);
      bd.AtualizarRegistro(cmd);
      if (bd.Cont > 0)
      {
        MessageBox.Show("Registro atualizado com sucesso!", "Registro Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        bd.Cont = 0;
      }
    }

    public void ExcluirEstacao()
    {
      string sql = "";
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
