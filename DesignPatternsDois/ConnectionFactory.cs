using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DesignPatternsDois
{
  public static class ConnectionFactory
  {
    public static IDbConnection ObterConexao() 
    {
      IDbConnection conexao = new SqlConnection();
      conexao.ConnectionString = "User Id=root;Password=;Server=localhost;Database=meuBanco";

      conexao.Open();

      return conexao;

    }
  }
}
