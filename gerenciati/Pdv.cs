using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gerenciati
{
  public class Pdv
  {
    //Atributos
    //-------------------------------------------------------
    BancoDados bd = new BancoDados();

    private int id;

    //Propriedades
    //-------------------------------------------------------

    //Construtor
    //-------------------------------------------------------
    public Pdv()
    {
      bd = new BancoDados();
    }
  }
}
