/*
5 2 32
1 13 45 32 4

4 1 666
666 69 13 420
*/





int[] input = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

string[] secondLine = Console.ReadLine()
    .Split(' ');

Queue<int> stackInts = new();

foreach (var VARIABLE in secondLine)
{
    int nParse = int.Parse( VARIABLE );

    stackInts.Enqueue(nParse); 
}

for (int i = 0; i < input[1]; i++)
{
    stackInts.Dequeue();
}

if (stackInts.Contains(input[2]))
{
    Console.WriteLine(true.ToString().ToLower());
}
else if (!stackInts.Any())
{
    Console.WriteLine(0);
}
else 
{
    Console.WriteLine(stackInts.Min());
}