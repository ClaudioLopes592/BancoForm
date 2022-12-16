using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Conexao
    {
        private String host = "localhost";
        private String nomeBanco = "bd_banco";
        private String usuario = "root";
        private String senha = "";

        private MySqlConnection conn;
        private MySqlCommand cmd;

        public Conexao()
        {
            this.Conectar();
        }

        public void Conectar()
        {
            String conn = "SERVER=" + this.host + ";DATABASE=" + this.nomeBanco + ";UID=" + this.usuario + ";PASSWORD=" + this.senha + ";";
            this.conn = new MySqlConnection(conn);
            this.cmd = this.conn.CreateCommand();
            this.conn.Open();
        }

        public void NonQuery(String sql)
        {
            this.cmd.CommandText = sql;
            this.cmd.ExecuteNonQuery();
        }

        public MySqlDataReader Query(String sql)
        {
            this.cmd.CommandText = sql;
            return this.cmd.ExecuteReader();
        }
    }
}
