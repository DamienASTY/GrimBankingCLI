using GuichetBanque_HelioBank.kernel;
using MySql.Data.MySqlClient;

namespace GuichetBanque_HelioBank.models;

public class SavingAccountQuery: Factory
{
    public void CreateAccount(int interest_rate, string number)
    {
        string query = $"INSERT INTO savingaccount (number, balance, interest_rate, client) VALUES ('{number}', 0.0, {interest_rate}, {Session._sessionId})";
        MySqlCommand command = new MySqlCommand(query, _connection);
        command.ExecuteNonQuery();
    }

    public void deposit(float amount, string to)
    {
        
    }

    public void payment(float amount, string from, string to)
    {
        
    }
}