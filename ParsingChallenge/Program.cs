string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// Convert string to an array and sorting it
string[] orders = orderStream.Split(",");
Array.Sort(orders);

for (int i = 0; i < orders.Length; i++)
{
    char[] orderCharacters = orders[i].ToCharArray();
    if (orderCharacters.Length != 4)
    {
        Console.WriteLine($"{orders[i]}\t - Error");
    }
    else
    {
        Console.WriteLine(orders[i]);
    }
}
