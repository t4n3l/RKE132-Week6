﻿

string hello = "Hello, world!".ToLower();
int counter = 0;
for (int i = 0; i < hello.Length; i++)
{
    if (hello[i] == 'l')
    {
        counter++;
    }
}
Console.WriteLine($"There are {counter} l's in the string \"{hello}\"");