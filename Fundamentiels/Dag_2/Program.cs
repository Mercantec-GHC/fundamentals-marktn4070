Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);

Random dice_2 = new Random();
int roll1 = dice_2.Next();
int roll2 = dice_2.Next(101);
int roll3 = dice_2.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");


int firstValue = 500;
int secondValue = 600;
int largerValue;

if (firstValue > secondValue)
{
    largerValue = firstValue;
    Console.WriteLine(largerValue);
}
else if (secondValue > firstValue)
{
    largerValue = secondValue;
    Console.WriteLine(largerValue);
}
else
{
    Console.WriteLine("Lige");
}

