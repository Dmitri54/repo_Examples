//  Рекурсия. Урок 7.
// Задача 1. Собрать строку с числамиот a до b, a <= b.

// Итеративный подход.
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++) // i++ - это инкремент, т.е. от меньшего к большему.
    {
        result += $"{i} ";
    }
    return result;
}

// Используя рекурсию.
string NumbersRes(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRes(a + 1, b); // прибавляю слева.
    else return String.Empty;
}
Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRes(1, 10)); // 1 2 3 4 5 6 7 8 9 10

// Если нужно вывести числа от большего к меньшему.
// При итеративном подходе:
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--) // i--  это декремент, т.е. от большего к меньшему.
    {
        result += $"{i} ";
    }
    return result;
}

// Используя рекурсию.
string NumbersRes(int a, int b)
{
    if (a <= b) return NumbersRes(a + 1, b) + $"{a} "; // прибавляю справо.
    else return String.Empty;
}
Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRes(1, 10)); // 1 2 3 4 5 6 7 8 9 10

// Задача 2.
// Сумма чисел от 1 до n.
// Итеративный подход.
int SunFor(int n)
{
    int result = 0;
    for (int i = 0; i <= n; i++) result += i;
    return result;
}

// Используя рекурсию.
int SumRec(int n)
{
    if (n == 0) return 0; // Можно сделать на один вывод меньше (n == 1) return 1
    else return n + SumRec(n - 1);
}
Console.WriteLine(SunFor(10)); // 55
Console.WriteLine(SumRec(10)); // 55

// Факториал числа от 1 до N.
// Итеративный подход:
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}
// Рекурсивный подход:
int FactorialRec(int n)
{
    if (n == 1) return 1; // Тут нужно прописать, что Факториал 0 = 1.
    else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800

// Вычислить a в степени n.
// Итеративный подход:
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}
// Рекурсивный подход:
int PowerRec(int a, int n)
{
    // return n == 0 ? 1 : PowerRec(a, n - 1) * a; // Эта запись с использованием тернарного оператора ?. Он позволяет записать одной строкой.
    if (n == 0) return 1; // Тут описан частный случай, где мы договорились, что n в степени 0 = 1. В общем случае нужно расмотреть это отдельным вариантом.
    else return PowerRec(a, n - 1) * a;
}
// Применив знания базовой математики, можно переписать код:
int PowerRecMath(int a, int n) // Этот подход будет лучше.
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024

