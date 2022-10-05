//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Zadacha41()
{
    Console.WriteLine("Введите количество элементов М");
    int M = Convert.ToInt32(Console.ReadLine());
    int [] numbers = new int [M];
    int count = 0;
    Console.WriteLine("Введите элементы массива");
    for (int i = 0; i < M; i++)
    {
        numbers [i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < M; i++)
    {
        if (numbers[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Вы ввели {count} чисел больше 0");
}
Zadacha41();

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Zadacha43()
{
    Console.WriteLine("Введите значение k1");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение b1");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение k2");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение b2");
    double b2 = Convert.ToDouble(Console.ReadLine());
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пересечения двух прямых =({x},{y})");
}
Zadacha43();