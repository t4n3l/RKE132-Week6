

int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
Console.WriteLine(numbers.Length);

string[] myNumbers = { "1, 2, 3", "4, 5, 6", "7, 8, 9" };
Console.WriteLine(myNumbers.Length);

string[] seasons = { "autumn", "winter", "spring", "summer" };
Console.WriteLine(seasons.Length);

string[] colors = { "red", "green", "blue", "pink", "yellow" };
Console.WriteLine(colors.Length);

string[] colors2 = { "red", "green", "blue", "pink", "yellow" };
for (int i =colors2.Length - 1; i >= 0;i--)
{
    Console.WriteLine(colors2[i]);
}

string hello2 = " hello ";
Console.WriteLine(hello2.Length);
string hello3 = " hello";
Console.WriteLine(hello3.Length);

string hello4 = " hello ".Trim();
Console.WriteLine(hello4.Length);

