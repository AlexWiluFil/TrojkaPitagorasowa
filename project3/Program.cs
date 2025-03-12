try
{
    Console.WriteLine("Wpisz 3 liczby całkowite");
    Console.WriteLine("Pierwsza:");
    double ans1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Druga:");
    double ans2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Trzecia:");
    double ans3 = double.Parse(Console.ReadLine());
    double[] answers = { ans1, ans2, ans3 };
    Array.Sort(answers);
    if (Math.Pow(answers[0], 2) + Math.Pow(answers[1], 2) == Math.Pow(answers[2], 2))
    {
        Console.WriteLine("Yuh uh");
    }
    else
    {
        Console.WriteLine("Nuh uh");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}