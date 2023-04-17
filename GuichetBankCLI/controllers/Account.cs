namespace GuichetBanque_HelioBank.controllers;

public interface Account
{
    public bool transaction(float amount, int from, int to);
}