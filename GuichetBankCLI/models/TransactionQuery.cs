using GuichetBanque_HelioBank.kernel;

namespace GuichetBanque_HelioBank.models;
using MySql.Data.MySqlClient;

public class TransactionQuery: Factory
{
    public void make(float amount, string from, string to, string type)
    {
        string query = $"INSERT INTO transaction (from_account, to_account, amount, type) VALUES ('{from}', '{to}', {amount}, '{type}')";
        MySqlCommand command = new MySqlCommand(query, _connection);
        command.ExecuteNonQuery();
    }
}