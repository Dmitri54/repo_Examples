﻿// Написать программу сложения двух чисел.
// Алгоритм:
// * Начало
// * Определить первое число; 
// * Определить второе число;
// * Вывести сумму введенных чисел на экран;
// * Конец.
// ---------------------------------------------------------------------------------------
// Первый вариант.
// int numberA = 3;
// int numberB = 5;
// Console.WriteLine(numberA + numberB); // Привыводе сразу посчитает и покажет результат.
// ---------------------------------------------------------------------------------------
// Второй вариант.
// int numberA = 3;
// int numberB = 5;
// int result = numberA + numberB; // Тоже самое, но через промежуточную переменную.
// Console.WriteLine(result);
// --------------------------------------------------------------------------------------
// Третий вариант с генератором случайных чисел.
int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9 или можно спросить у пользователя как в файле Hello User.
Console.WriteLine(numberA); // покажет первое число и перейдет на новую строку.
int numberB = new Random().Next(1, 10); 
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);

// int numberA = new Random().Next(1,10); - что я объявляю новую переменную numberA,
// в токорую записываю результат new Rendom().Next(1,10) - генератор случайных чисел, выдаст 
// случайное число в у казанном диапазоне [1,10), т.е.невключая 10.