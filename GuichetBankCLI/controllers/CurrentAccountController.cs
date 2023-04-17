using GuichetBanque_HelioBank.models;

namespace GuichetBanque_HelioBank.controllers;

public class CurrentAccountController: AccountController, Account
{
    private float _payment_limit;


    public void CreateAccount()
    {
        base.createAccount();
        CurrentAccountQuery cmd = new CurrentAccountQuery();
        cmd.CreateAccount(150, _account_number);
    }

    public void deposit(float amount, string to)
    {
        CurrentAccountQuery caq = new CurrentAccountQuery();
        caq.deposit(amount, to);
    }
    
    public bool transaction(float amount, int from, int to)
    {
        return false;
    }
}