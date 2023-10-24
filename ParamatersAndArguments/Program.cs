string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    DisplayEmail(firstName: corporate[i, 0], lastName: corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++)
{
    DisplayEmail(firstName: external[i, 0], lastName: external[i, 1], domain: externalDomain);
}

void DisplayEmail(string firstName, string lastName, string domain = "contoso.com")
{
    string username = firstName.Substring(0, 2).ToLower() + lastName.ToLower();
    string email = username + "@" + domain;
    Console.WriteLine($"{email}");
}