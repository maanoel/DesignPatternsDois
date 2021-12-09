using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DesignPatternsDois
{
  public class ConnectionFactory
  {
    public IDbConnection ObterConexao() 
    {
      IDbConnection conexao = new SqlConnection();
      conexao.ConnectionString = "User Id=root;Password=;Server=localhost;Database=meuBanco";
      IDbConnection conexao = new SqlConnection();
      conexao.ConnectionString = "User Id=root;Password=;Server=localhost;Database=meuBanco";
      conexao.Open();
      conexao.Open();

      return conexao;

    }
  }
}
