Console.WriteLine("Введите 1-e число");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2-e число");
int numB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 3-e число");
int numC = int.Parse(Console.ReadLine());
//int max = 0;
if (numA > numB)
{
    if (numA < numC)
    {
        int max = numC;
        Console.WriteLine($"Число {max} - больше всех");
    }
    else{
        int max = numA;
        Console.WriteLine($"Число {max} - больше всех");
    }

}
if (numB < numC)
{
    int max = numC;
    Console.WriteLine($"Число {max} - больше всех");
}
else{
    int max = numB;
    Console.WriteLine($"Число {max} - больше всех");
}