// Задача 68: Напишите программу вычесления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();
Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

// Проверка
if (m < 0 || n < 0)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

// Метод вычесления Аккермана посредством рекурсии
int FunctionAkkerman(int m, int n)
{
    int akkerman = 0;
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
    else
    {
        akkerman = (FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1)));
    }
    return akkerman;
}

int functionAkkerman = FunctionAkkerman(m, n);
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {functionAkkerman}");
