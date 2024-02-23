

string[] snacks = { "sushi", "pitsa", "burks", "kanatiivad", "hiinakas" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Täna on õhtusöögiks {snacks[randomIndex]}.");