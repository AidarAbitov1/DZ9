
//Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.


using System ;
using static System.Console ;

Clear();
Write("Введите m: ");
int m = int.Parse(ReadLine());
Write("Введите n: ");
int n = int.Parse(ReadLine());

WriteLine($"Функция Аккермана = {Akkerman(m, n)}");

int Akkerman(int m, int i)
{
    if (m == 0) return i + 1;
    if (i == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, i - 1));
}