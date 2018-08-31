using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCSharp.DAL
{
	class Conexao
	{
		SqlConnection conexaoBD;

		public Conexao()
		{
			conexaoBD = new SqlConnection();
			conexaoBD.ConnectionString = "Data Source=localhost;Initial Catalog=CrudCSharpPessoasNoite;Integrated Security=True";
		}

		public SqlConnection Conectar()
		{
			if (conexaoBD.State == System.Data.ConnectionState.Closed)
				conexaoBD.Open();
			return conexaoBD;
		}

		public void Desconectar()
		{
			if (conexaoBD.State == System.Data.ConnectionState.Open)
				conexaoBD.Close();
		}
	}
}
