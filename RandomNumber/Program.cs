Random rnd = new();

int myRandomNum;

int randomSum = 0;

for (int i = 0; i < 7; i++)
{
    myRandomNum = rnd.Next(0, 11);
    randomSum += myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}
Console.WriteLine($" random sum total: {randomSum}");