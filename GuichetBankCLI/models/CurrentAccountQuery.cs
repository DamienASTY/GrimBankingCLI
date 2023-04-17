using GuichetBanque_HelioBank.kernel;
using MySql.Data.MySqlClient;

namespace GuichetBanque_HelioBank.models;

public class CurrentAccountQuery: Factory
{ 
    public void CreateAccount(float payment_limit, string number)
    {
        string query = $"INSERT INTO currentaccount (number, balance, payment_limit, client) VALUES ('{number}', 0.0, '{payment_limit}', {Session._sessionId})";
        MySqlCommand command = new MySqlCommand(query, _connection);
        command.ExecuteNonQuery();
        
    }

    public void deposit(float amount, string to)
    {
        float lastBalance = GetBalance(to);
        
        string query = $"UPDATE currentaccount SET balance = {amount+lastBalance} WHERE number = '{to}'";        
        MySqlCommand command = new MySqlCommand(query, _connection);
        command.ExecuteNonQuery();
        TransactionQuery tq = new TransactionQuery();
        tq.make(amount, "distributeur", to, "deposit");
    }

    // Méthode qui fait un virement à un compte courant
    public void paymentCurrentAccount()
    {
        
    }
    
    // Méthode qui fait un virement à un compte épargne
    public void paymentSavingAccount()
    {
        
    }
    
    public float GetBalance(string account)
    {
        string query = $"SELECT balance FROM currentaccount WHERE number = '{account}'";
        MySqlCommand command = new MySqlCommand(query, _connection);
        MySqlDataReader reader = command.ExecuteReader();
        reader.Read();
        float balance = float.Parse(reader.GetString(0));
        reader.Close();
        return balance;
    }
}