/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

int a = 0;
int b = 0;
int sum = 0;

while (true)
{
    Console.WriteLine("Введите целое число А:");

    if (int.TryParse(Console.ReadLine(), out int number))
    {
        a = number; break;
    }
    else Console.WriteLine("Некорректно указано число!\n");
}

while (true)
{
    Console.WriteLine("Введите целое число В:");

    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (number < 0)
        {
            Console.WriteLine("Вами введено НЕ натуральное число (отрицательное)!");
            continue;
        }
        else b = number; break;
    }
    else Console.WriteLine("Некорректно указано число!\n");
}

Console.WriteLine("число " + a + " в степени " + b + " = " + result(a, b));


int result(int a, int b)
{
    if (a == 0 && b == 0)
    {
        sum = 1;
    }
    else
    {
        sum = a;
        for (int i = 1; i < b; i++)
        {
            sum = sum * a;
        }
    }
    return sum;
}
