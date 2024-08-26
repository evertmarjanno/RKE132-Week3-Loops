Random rnd = new();
int cpuRandom;

while (true)
{
    cpuRandom = rnd.Next(1, 4);
    // Console.WriteLine($"cpu has generated {cpuRandom}");
    Console.WriteLine("Make a guess. Enter a number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won");
        break;
    }
    else
    {
        Console.WriteLine("Oops, Try again.");
    }
}
Console.WriteLine("Have a nice day.");