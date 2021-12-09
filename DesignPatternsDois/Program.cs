using System;
using System.Data;

namespace DesignPatternsDois
{
  class Program
  {
    static void Main(string[] args)
    {

      IDbConnection conexao =  ConnectionFactory.ObterConexao();

      IDbCommand comando = conexao.CreateCommand();
      comando.CommandText = "select * from tabela";




      Console.WriteLine("Hello World!");
    } 
  }
}
