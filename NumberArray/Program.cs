


int[] numbrid = new int[10];
Random rnd = new Random();

int sum = 0;

for (int i = 0; i < numbrid.Length; i++)
{
    numbrid[i] = rnd.Next(1, numbrid.Length + 1);
    sum = sum + numbrid[i];
}

foreach (int number in numbrid)
{
    Console.WriteLine(number);
}

Console.WriteLine($"Kokku: {sum}");