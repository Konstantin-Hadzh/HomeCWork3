/*
Задача 23 Программа, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int getEenteringMean(string mean) // Функция ввода значения и его конвертации из string в int
{
    Console.Write($" {mean} ");
    return Convert.ToInt32(Console.ReadLine());
}

int number = getEenteringMean("Введите число N: ");

Console.Write(" -> ");

for (int i = 1; i <= number; i++) // инициализация счетечика; проверка условия; увеличение счетчика на 1
{ 
    Console.Write($"  {i*i*i}  ");
}

Console.WriteLine();
