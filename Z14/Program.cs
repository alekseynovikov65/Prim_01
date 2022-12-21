// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число - ");
int N = int.Parse(Console.ReadLine());
int i = 2;
int count = 0;
while (i <= N)
{
    int x = i % 2;
    if (x == 0)
    {
        Console.WriteLine($" {i}, ");
    }
i++;
}




