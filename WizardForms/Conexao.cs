using MySql.Data.MySqlClient;
public static class Conexao
{
    // private MySqlConnection conexao;

    private static string server = "localhost";
    private static string user = "root";
    private static string dataBase = "wizard";
    private static string password = "";

    public static MySqlConnection conectar()
    {
        return new MySqlConnection($"server={server}; User Id={user}; database={dataBase}; password='{password}'");
    }

}
