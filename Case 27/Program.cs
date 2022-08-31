// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int SumNembers()
{
Console.WriteLine("Введите целое число  ");
int A = Convert.ToInt32(Console.ReadLine());
int x = A%10;
int sum = 0;
int i = 0;
while (A > 0) 
{
sum += A%10;
A = A/10;
i++;
}
return sum;
}
Console.WriteLine(SumNembers());