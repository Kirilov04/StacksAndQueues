/*
5 2 13   
1 13 45 32 4

4 1 666
420 69 13 666

3 3 90
90 90 90
*/


using System.Xml;

int[] input = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();


string[] secondLine = Console.ReadLine()
    .Split(' ');

Stack<int> intStack = new();

foreach (var s in secondLine)
{
    int temp = int.Parse(s);

    intStack.Push(temp);
}

for (int i = 0; i < input[1]; i++)
{
    intStack.Pop();
}

if (intStack.Contains(input[2]))
{
    Console.WriteLine("true");
}
else if (intStack.Any())
{
    Console.WriteLine(intStack.Min());
}
else
{
    Console.WriteLine(0);
}