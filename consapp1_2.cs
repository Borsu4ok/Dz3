Console.WriteLine("Enter an integer:");
string? input = Console.ReadLine();
if (int.TryParse(input, out int number))
{
    Console.WriteLine($"You wrote {number}");
}
else
{
    Console.WriteLine("This is not an integer");
}

