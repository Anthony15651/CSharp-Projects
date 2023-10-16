int heroHealth = 10;
int heroAttack = 0;
int monsterHealth = 10;
int monsterAttack = 0;
Random random = new Random();

Console.WriteLine($"Hero Health:\t{heroHealth}\nMonster Health:\t{monsterHealth}\n");

do
{
    heroAttack = random.Next(1, 11);
    Console.WriteLine($"Hero attacks for {heroAttack} damage!");
    monsterHealth -= heroAttack;
    Console.WriteLine($"Monster has {monsterHealth} health left.");

    // Alternate way to write it
    if (monsterHealth <= 0) continue;

    // if (monsterHealth > 0)
    // {
    //     monsterAttack = random.Next(1, 11);
    //     Console.WriteLine($"Monster attacks for {monsterAttack} damage!");
    //     heroHealth -= monsterAttack;
    //     Console.WriteLine($"Hero has {heroHealth} health left.");
    // }

    monsterAttack = random.Next(1, 11);
    Console.WriteLine($"Monster attacks for {monsterAttack} damage!");
    heroHealth -= monsterAttack;
    Console.WriteLine($"Hero has {heroHealth} health left.");

    // if (heroHealth <= 0)
    //     Console.WriteLine("The Monster wins!");
    
    // if (monsterHealth <= 0)
    //     Console.WriteLine("The Hero wins!");

} while ((heroHealth > 0) && (monsterHealth > 0));

Console.WriteLine(heroHealth > monsterHealth ? "The Hero wins!" : "The Monster wins!");