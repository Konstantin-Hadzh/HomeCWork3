/*

Задача 19 Программа, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

*/

Console.Write("Введите пятизначное число: ");
string userNumber = Console.ReadLine(); // создаем строковую переменную userNumber и присваиваем ей прочтенное из консоли
int length = userNumber.Length; // обращение к свойству, показывающему количество символов в строке

if (length == 5)
{
    if (userNumber[0] == userNumber[4] && userNumber[1] == userNumber[3])
    {
        Console.WriteLine($"{userNumber} -> да");
    }
    else
    {
        Console.WriteLine($"{userNumber} -> нет");
    }
}
else
{
    Console.WriteLine($"{userNumber} не является пятизначным или целым числом");
}