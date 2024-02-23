
string hello = "hello!";

hello = hello.Replace(hello[0], char.ToUpper(hello[0]));

Console.WriteLine(hello);