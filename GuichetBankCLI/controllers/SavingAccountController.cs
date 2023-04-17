using GuichetBanque_HelioBank.models;

namespace GuichetBanque_HelioBank.controllers;

public class SavingAccountController: AccountController, Account
{
    // en % par ans
    private int _interest_rate = 2;

    public void CreateAccount()
    {
        base.createAccount();
        SavingAccountQuery sva = new SavingAccountQuery();
        sva.CreateAccount(2, _account_number);
    }
    
    public bool transaction(float amount, int from, int to)
    {
        if (to != from)
        {
            return false;
        }
        else
        {
            //transféré l'argent
            return true;
        }
    }
}