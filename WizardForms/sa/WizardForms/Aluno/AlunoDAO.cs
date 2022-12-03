using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WizardForms.Aluno
{
    internal class AlunoDAO
    {

        //boll -> verificar se o INSERT deu certo .T. or .F.
        // Caso rode todo o código de maneira correta retorna o true
        public bool cadastar(Aluno p_aluno)
        {

            string sql_insert = @"INSERT INTO alunos (id, nome, sobrenome, email,senha,celular,linguagem,estado,cidade,experiencia) VALUES(?,?,?,?,?,?,?,?,?,?);";
            //INSERT INTO Jogador (id,nome,camisa,pais) VALUES(1,'Felipe',10,'Paisandu'); 
            try
            {
                MySqlConnection conexao = Conexao.conectar();
                conexao.Open();
                // São dois parametros 
                // 1- qual comando / 2- Qual a conexão
                MySqlCommand sql_comando = new MySqlCommand(sql_insert, conexao);

                // Pega o comando e troca o parametro
                // Trocou os ? para ps get();
                sql_comando.Parameters.AddWithValue("@id", p_aluno.getId());
                sql_comando.Parameters.AddWithValue("@nome", p_aluno.getNome());
                sql_comando.Parameters.AddWithValue("@sobrenome", p_aluno.getSobreNome());
                sql_comando.Parameters.AddWithValue("@email", p_aluno.getEmail());
                sql_comando.Parameters.AddWithValue("@senha", p_aluno.getSenha());
                sql_comando.Parameters.AddWithValue("@celular", p_aluno.getCelular());
                sql_comando.Parameters.AddWithValue("@linguagem", p_aluno.getLinguagem());
                sql_comando.Parameters.AddWithValue("@estado", p_aluno.getEstado());
                sql_comando.Parameters.AddWithValue("@cidade", p_aluno.getCidade());
                sql_comando.Parameters.AddWithValue("@experiencia", p_aluno.getExperiencia());
                // Execução do comando 
                sql_comando.ExecuteNonQuery();

                // Fecha a conexão
                conexao.Close();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
                return false;
            }
        }

        public  DataTable consultar()
        {
            //SELECT * FROM Jogador
            string sql_SELECT = @"SELECT * FROM alunos"; 
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection conexao = Conexao.conectar();
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(sql_SELECT, conexao);// ESSE METODO RETORNA O DATA TABLE
                using (da)
                // esse using é basicamente "Utilizando esse (da) preencha tal" como se fosse um for
                {
                    da.Fill(dt); //Preencherar o da com o as informaçoes do DT
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);
            }
            return dt;
        }

        public bool alterar(Aluno p_aluno)
        {

            string sql_update = @"UPDATE alunos SET nome=?, sobrenome=?, email=?, senha=?, celular=?, linguagem=? ,estado=? ,cidade=? ,experiencia=? WHERE id=?";
            try
            {
                MySqlConnection conexao = Conexao.conectar();
                conexao.Open();
                // São dois parametros 
                // 1- qual comando / 2- Qual a conexão
                MySqlCommand sql_comando = new MySqlCommand(sql_update, conexao);

                // Pega o comando e troca o parametro
                // Trocou os ? para ps get();

                sql_comando.Parameters.AddWithValue("@nome", p_aluno.getNome());
                sql_comando.Parameters.AddWithValue("@sobrenome", p_aluno.getSobreNome());
                sql_comando.Parameters.AddWithValue("@email", p_aluno.getEmail());
                sql_comando.Parameters.AddWithValue("@senha", p_aluno.getSenha());
                sql_comando.Parameters.AddWithValue("@celular", p_aluno.getCelular());
                sql_comando.Parameters.AddWithValue("@linguagem", p_aluno.getLinguagem());
                sql_comando.Parameters.AddWithValue("@estado", p_aluno.getEstado());
                sql_comando.Parameters.AddWithValue("@cidade", p_aluno.getCidade());
                sql_comando.Parameters.AddWithValue("@experiencia", p_aluno.getExperiencia());
                sql_comando.Parameters.AddWithValue("@id", p_aluno.getId());
                // Execução do comando 
                sql_comando.ExecuteNonQuery();

                // Fecha a conexão
                conexao.Close();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
                return false;
            }
        }

        public bool excluir(Aluno p_aluno)
        {

            string sql_excluir = @"DELETE FROM alunos WHERE id=?";

            try
            {
                MySqlConnection conexao = Conexao.conectar();
                conexao.Open();
                // São dois parametros 
                // 1- qual comando / 2- Qual a conexão
                MySqlCommand sql_comando = new MySqlCommand(sql_excluir, conexao);

                // Pega o comando e troca o parametro
                // Trocou os ? para ps get();

                sql_comando.Parameters.AddWithValue("@id", p_aluno.getId());

                // Execução do comando 
                sql_comando.ExecuteNonQuery();

                // Fecha a conexão
                conexao.Close();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
                return false;
            }
        }
    }
}
