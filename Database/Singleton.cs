namespace Cwiczenia2.Database;

public static class Singleton
{
    private static List<int> SerialNumbers
    {
        get;
        set;
    } = new();

    public static int GenerateUniqueId()
    {
        if (SerialNumbers.Count == 0)
        {
            SerialNumbers.Add(1);
            return 1;
        }
        
        var number = SerialNumbers.Last() + 1;
        SerialNumbers.Add(number);
        return number;
    }

}