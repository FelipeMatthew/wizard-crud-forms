using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WizardForms.Professor
{
    internal class ProfessorDAO
    {

        //boll -> verificar se o INSERT deu certo .T. or .F.
        // Caso rode todo o código de maneira correta retorna o true
        public bool cadastar(Professor p_professor)
        {

            string sql_insert = @"INSERT INTO Professor (nome,email,senha,celular,linguagem,estado,cidade,experiencia) VALUES(?,?,?,?);";
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
                sql_comando.Parameters.AddWithValue("@nome", p_professor.getNome());
                sql_comando.Parameters.AddWithValue("@email", p_professor.getEmail());
                sql_comando.Parameters.AddWithValue("@senha", p_professor.getSenha());
                sql_comando.Parameters.AddWithValue("@celular", p_professor.getCelular());
                sql_comando.Parameters.AddWithValue("@linguagem", p_professor.getLinguagem());
                sql_comando.Parameters.AddWithValue("@estado", p_professor.getEstado());
                sql_comando.Parameters.AddWithValue("@cidade", p_professor.getCidade());
                sql_comando.Parameters.AddWithValue("@experiencia", p_professor.getExperiencia());
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

        public static DataTable consultar()
        {
            //SELECT * FROM Jogador
            string sql_SELECT = @"SELECT * FROM Professor";
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


    }
}
