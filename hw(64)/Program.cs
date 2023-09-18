// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine("<- Выведем все натуральные числа от N до 1 ->");
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

// Проверка
if (n < 0)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

// Метод 
void NaturalNumbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers(num -1);
}

Console.WriteLine($"Натуральные числа в промежутке от {n} до 1");
Console.Write($"N = {n} -> ");
NaturalNumbers(n);