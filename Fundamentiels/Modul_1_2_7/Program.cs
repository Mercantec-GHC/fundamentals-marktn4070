using System.Xml.Linq;

string[] elements = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string element in elements)
{
    if (element.StartsWith("B"))
    {
        Console.WriteLine("The element starts with 'B' = " + element);
    }

    //Console.WriteLine(element);

}

//string name = "Bob";
//if (name.StartsWith("B"))
//{
//    Console.WriteLine("The name starts with 'B'! = " + name.StartsWith("B"));
//}