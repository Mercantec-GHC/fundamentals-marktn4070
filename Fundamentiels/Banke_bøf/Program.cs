for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(i + " = Banke bøf");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine(i + " = Bøf");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine(i + " = Banke");
    }
    //else
    //{
    //    Console.WriteLine(i);
    //}
}
