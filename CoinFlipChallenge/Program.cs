Random coin = new Random();
int flip = coin.Next(1, 3);
Console.WriteLine($"{(flip == 1 ? "Heads!" : "Tails!")}");