// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("введите число:");
int A = int.Parse(Console.ReadLine());
int sum = 0;

while (A > 0)
{
    int num = A % 10;
    A = A / 10;
    sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);