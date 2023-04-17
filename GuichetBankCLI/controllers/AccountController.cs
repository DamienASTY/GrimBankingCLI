namespace GuichetBanque_HelioBank.controllers;

public class AccountController
{
    protected string _account_number;
    protected float _balance = 0;

    protected void createAccount()
    {
        this._account_number = newAccountNumber();
    }

    private string newAccountNumber()
    {
        string result = "BE";
        Random random = new Random();
        for (int i = 0; i < 15; i++)
        {
            if (i == 4 || i == 9 || i == 14)
            {
                result += "-";
            }
            else
            {
                int randomNumber = random.Next(0, 36);
                char randomChar = randomNumber < 10 ? (char)('0' + randomNumber) : (char)('A' + randomNumber - 10);
                result += randomChar;
            }
        }
        return result;
    }
}