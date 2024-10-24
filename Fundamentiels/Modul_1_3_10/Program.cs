//Random coin = new Random();
//int flip = coin.Next(0, 2);
//Console.WriteLine((flip == 0) ? "heads" : "tails");

//Denne kode er blot "én mulig løsning." Du kunne have elimineret den midlertidige variabel flip ved at kalde Next() inde i det boolske udtryk sådan:
Console.Clear();


Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");