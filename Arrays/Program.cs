

string[] puuvili = new string[3];

puuvili[0] = "õunad";
puuvili[1] = "banaanid";
puuvili[2] = "apelsinid";
Console.WriteLine($"{puuvili[0]}, {puuvili[1]}, {puuvili[2]}");

int puuviliArrayPikkus = puuvili.Length;

Console.WriteLine($"Sinu nimekirjas on {puuviliArrayPikkus} puuvilja.");

for (int i = 0; i < puuviliArrayPikkus; i++)
{
    puuvili[i] = puuvili[i].Replace(puuvili[i][0], char.ToUpper(puuvili[i][0]));
}

foreach (string element in puuvili)
{
    Console.WriteLine(element);
}