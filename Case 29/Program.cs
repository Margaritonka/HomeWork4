// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int [] array = FillArray(8);

int []  FillArray(int N)
{
int [] array = new int[N];
for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(1,10);
}
return array;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i!=8-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
}

PrintArray(array);