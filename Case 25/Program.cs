// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Degree()
{
Console.WriteLine("Введите целое число А ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число B ");
int B = Convert.ToInt32(Console.ReadLine());
double digr= Math.Pow(A,B);
return digr;
}
Console.WriteLine(Degree());