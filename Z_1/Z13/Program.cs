// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Введите чило: ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine($"Число {num} четное.");
}
else{
    Console.WriteLine($"Число {num} нечетное. ");
}