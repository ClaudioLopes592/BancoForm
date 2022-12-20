using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Conta
    {
        private Conexao conexao;

        public Conta()
        {
            this.conexao = new Conexao();
        }

        public void CadastrarConta()
        {
            this.conexao.NonQuery(@"INSERT INTO tb_contas (numero, data_cadastro, titular, saldo) 
                                    VALUES 
                                    ('" + this.numero + "','"+ dataCadastro +"','"+ this.titular +"','"+ this.saldo +"')");
        }

        public void AlterarConta()
        {
            this.conexao.NonQuery(@"UPDATE tb_contas SET numero = '"+ this.numero +"', data_cadastro = '"+ this.dataCadastro +"', " +
                "titular = '"+ this.titular+"', saldo = '"+ this.saldo +"' WHERE id_conta = '"+ this.id_conta +"'");
        }

        public MySqlDataReader ListarContas()
        {
            return this.conexao.Query("SELECT * FROM tb_contas order by titular");
        }

        public MySqlDataReader ListarContas(String campo, String filtro)
        {
            if (filtro == "")
            {
                return ListarContas();
            }
            return this.conexao.Query("SELECT titular FROM tb_contas where " + campo + " = '" + filtro + "'order by id_conta");
        }

        public MySqlDataReader BuscarConta(String campo)
        {
            return this.conexao.Query("SELECT * FROM tb_contas where numero='" + campo + "'");
        }

        public int id_conta { get; set; }
        public int numero { get; set; }
        public string dataCadastro { get; set; }
        public string titular { get; set; }
        public double saldo { get; set; }

        public bool Saca(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Deposito(double valor)
        {
            this.saldo += valor;
        }
    }
}
