Stack<int> nums = new Stack<int> ();

nums.Push (1);
nums.Push (2);
nums.Push (3);
nums.Push (4);
nums.Push (5);


while (nums.Count != 0)
{
    int topElement = nums.Pop();
    Console.WriteLine(topElement);
}

