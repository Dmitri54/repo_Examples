﻿/* Напишу программу, которая увеличит каждую из координат в два раза и вывести ответ в консоль.
координаты (1,2) (2,3) (4,5) (6,7)
*/
// ---------------------------------------------------------------------------------------
using System.Linq; // Это дополнительный модель.

string text = "(1,2) (2,3) (4,5) (9,7)"
              .Replace("(", "") // 2.Метод уберет скобки из text и заменет на (,), т.к. они мне не нужны.
              .Replace(")", "")
              ;
Console.WriteLine(text);
var data = text.Split(" ") // 1.Метод .Split() - позволит сделать разбивку строки с учетом символа разделителя. В данном случае (" ") указан пробел.
               .Select(item => item.Split(',')) // 2.1. Метод сделает выборку, т.е. разобъет каждый элемент и получу на основе него массив из двух чисел. item - условный элемент.
               .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // 4. Метод превратит мой массив в кортеж чисел. [0] первый, а [1] второй элем.массива.
               .Where(e => e.x % 2 == 0) // 7. Метод. Перед домножением, я получу только те точки, которые четные.
               .Select(point => (point.x * 10, point.y)) // 6. Метод. Если нужно один раз и навсегда сделать увеличение координат.
               .ToArray(); // 1.2. Метод. Превратит полученный набор данных в массив.

for (int i = 0; i < data.Length; i++)
{
    // Console.WriteLine(data[i].x * 10); // 1.3.Покажет, что лежит в data[i]. ,4.,5. x*10 - первая координата умноженная на 10.
    // for (int k = 0; k < data[i].Length; k++) // 3.
    // {
    //     Console.WriteLine(data[i] [k]); // 3.
    // }
    // Console.WriteLine(); // 3.,4.
    Console.WriteLine(data[i]);
}