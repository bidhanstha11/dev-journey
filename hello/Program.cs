Console.WriteLine("What is your name?");
string? name = Console.ReadLine();
Console.WriteLine("Hello " + name + '!');


Console.WriteLine("How old are you?");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("So, Next year " + name + "  will be " + (age + 1) + " years old.");
Console.WriteLine("So, after " + (30 - age) + " years, you will be 30");
git