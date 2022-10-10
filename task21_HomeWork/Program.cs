/*
Задача 21 Программа, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double formulaDlina3D() // функция определения расстояния между A и B в трехмерном пространстве
{
    Console.Write("Точка А с соординатой x: ");
    int tochkaA_x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Точка А с соординатой y: ");
    int tochkaA_y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Точка А с соординатой z: ");
    int tochkaA_z = Convert.ToInt32(Console.ReadLine());

    Console.Write("Точка B с соординатой x: ");
    int tochkaB_x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Точка B с соординатой y: ");
    int tochkaB_y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Точка B с соординатой z: ");
    int tochkaB_z = Convert.ToInt32(Console.ReadLine());

    double result = Math.Sqrt(Math.Pow(tochkaB_x - tochkaA_x,2) + Math.Pow(tochkaB_y - tochkaA_y,2) + Math.Pow(tochkaB_z - tochkaA_z,2));
    return result;
    // Math.Pow - возведение в степень (что возводим и в какую степень)
    // Math.Sqrt - квадратный корень
}

double Dlina = formulaDlina3D();
Console.Write(Dlina);
Console.WriteLine();
