//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число: от 100 до 888 ");
string A = (Console.ReadLine());
int num = int.Parse(A);
if (num > 100 && num <= 999)
{
    char x = A[1];
    Console.WriteLine($"Число - {x} ");
}
else{
    System.Console.WriteLine($"Читай условие задачи!");
}