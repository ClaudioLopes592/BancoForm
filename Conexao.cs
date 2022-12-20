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
            try
            {
                String conn = "SERVER=" + this.host + ";DATABASE=" + this.nomeBanco + ";UID=" + this.usuario + ";PASSWORD=" + this.senha + ";";
                this.conn = new MySqlConnection(conn);
                this.cmd = this.conn.CreateCommand();
                this.conn.Open();
                //MessageBox.Show("Conectado com sucesso ao BD!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão com BD" + ex.Message);
            }
        }

        public void NonQuery(String sql)
        {
            try
            {
                this.cmd.CommandText = sql;
                this.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public MySqlDataReader Query(String sql)
        {
            try
            {
                this.cmd.CommandText = sql;
                return this.cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
