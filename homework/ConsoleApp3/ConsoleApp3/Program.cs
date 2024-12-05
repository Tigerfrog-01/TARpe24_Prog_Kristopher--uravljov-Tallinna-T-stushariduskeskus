// See https://aka.ms/new-console-template for more information

Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine("Quiz on Float!");
Console.WriteLine("Wich one is Float");
Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine("A: a");
Console.WriteLine("B: 4,5");
Console.WriteLine("C: 1");
Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine("If it says single you are correct!");
string tree = Console.ReadLine();
float leaf = float.Parse(tree);
Console.WriteLine(leaf);
Console.WriteLine(leaf.GetType().Name);