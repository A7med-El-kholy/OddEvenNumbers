int[] numbers = {1,2,3,4,5,6,7,8,9};
PrintNumbers("Numbers",numbers);
PrintNumbers("Even No", numbers.Where(x => x % 2 == 0));
PrintNumbers("Odd No", numbers.Where(x => x % 2 != 0));


static void PrintNumbers(string title, IEnumerable<int> numbers)
{
    Console.Write($"title: {title}: [");
    foreach(var n in numbers)
    {
        Console.Write($" {n}");
    }
    Console.Write($" ]");
    Console.WriteLine();
}


