// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120

Console.Clear();
Console.WriteLine("<- Найдём сумму натуральных элементов в промежутке от M до N ->");
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

// Проверка
if (m < 0 || n < 0)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

// Метод
int SumElem(int num1, int num2)
{
    int sum = m;
    if (num1 == num2) return 0;
    sum = m + SumElem(m++, n);
    return sum;
}

int sumElem = SumElem(m,n);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N -> {sumElem}");