// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите первое число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int max = Convert.ToInt32(Console.ReadLine());;
Ackerman(min, max);
Console.WriteLine(Ackerman(min, max));

int Ackerman(int first, int second)
{
    if (first == 0) return second + 1;
    else if (second == 0 && first > 0) return Ackerman(first - 1, 1);
    else return Ackerman(first - 1, Ackerman(first, second - 1));
}
