string input = Console.ReadLine();

Stack<char> name = new Stack<char>();

foreach (var VARIABLE in input)
{
    name.Push(VARIABLE);
}

while (name.Count != 0)
{
    Console.Write(name.Pop()); 
}

