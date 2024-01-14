List<int> num = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

Stack<int> stack = new Stack<int>(num);

string command = Console.ReadLine() .ToLower();

while (command != "end")
{
    string[] splitted = command.Split(' ');
    int first = int.Parse(splitted[1]);

    if (splitted[0] == "add")
    {
        int second = int.Parse(splitted[2]);
    }
    else
    {
        
    }

}