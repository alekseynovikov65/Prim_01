Console.WriteLine("Введите число: ");  //
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");  //
int numB = int.Parse(Console.ReadLine());
//int max = 0;
if (numA > numB)
{
    System.Console.WriteLine($"Число {numA} больше {numB}");
}
else{
    System.Console.WriteLine($"Число {numB} больше {numA}");
}