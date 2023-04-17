using GuichetBanque_HelioBank.models;

namespace GuichetBanque_HelioBank.controllers.parsers;

public class ClientParser
{
    public static Client Parse(string[] values)
    {
        int id = int.Parse(values[0]);
        int pin = int.Parse(values[5]);
        //comment savoir qu'elle valeur à été renvoyé ?
        return new Client(id, values[1], values[2], values[3], values[4], pin);
    }
}