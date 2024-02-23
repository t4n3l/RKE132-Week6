

string[] colors = { "red", "green", "blue", "pink", "yellow" };
Random rnd = new Random();
int randomColor = rnd.Next(0, colors.Length);
Console.WriteLine($"You should wear {colors[randomColor]} today.");