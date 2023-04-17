// See https://aka.ms/new-console-template for more information

using GuichetBanque_HelioBank.controllers;
using GuichetBanque_HelioBank.kernel;
using GuichetBanque_HelioBank.models;

Console.WriteLine("Banking CLI");

bool connected = Factory.setConnection("heliobank", "root", "");
if (connected)
{
    Console.WriteLine("Database connected");
}
else
{
    Console.WriteLine("Error during database connection");
}

ClientController cltrl = new ClientController();
if (cltrl.auth("dpdp@example.com", "Berna123*"))
{
    Console.WriteLine("Successfully logged");
}
else
{
    Console.WriteLine("Invalid credentials");
}

if (Session._sessionId > 0)
{
    /*CurrentAccountController cra = new CurrentAccountController();
    cra.createAccount();*/
    /*SavingAccountController sva = new SavingAccountController();
    sva.CreateAccount();*/
    CurrentAccountController cra = new CurrentAccountController();
    cra.deposit(10.5f, "BEWDK9-K2WV-YWWD-");
}

Console.WriteLine(Session._sessionId);