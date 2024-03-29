﻿// 1.Перепишу предыдущий код с использованием генератора псевдослучайных чисел и с использованием методов.
// Потренирую то как можно взять метод и передать в него массив и соответственно 
// заполню массив нужным количеством элементов.
// 2.На следующем этапе опишу метод, который будет выводить все элементы по порядку.
// 3.Опишу код поиска нужного мне индекса в метод.
// ----------------------------------------------------------------------------------------------

void FillArray(int[] collection)// 1.1.Что бы заполнить new int[10] случайными числами 
// воспользуюсь методом, который сам опишу. void - тип данных, FillArray - имя метода, 
// (int[] collection) - в качестве аргумента массив.
{
   int length = collection.Length; // Получу длинну массива.
   int index = 0; // Задам index = 0.

   while (index < length) // Цикл
   {
       collection[index] = new Random().Next(1, 10); // Запишу в collection[index] новое число в диапозоне.
       index++;

   }

}


void PrintArray(int[] col) // 2. void PrintArray - Будет печатать(выводить) массив (int[] col).
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}
// void - не возвращает значение.Он называется void метод. Поэтому в коде я не использую оператор return.
// col - имя аргумента.Принято различные аргументы называть различными именами!

int IndexOf(int[] collection, int find) //3. Адаптирую решение задачи 10, в которой я находил 
// нужную позицию элемента в массиве с использованием метода.
// Опишу метод отличный от void, который будет возвращать позицию (index). IndexOf - имя. 
// В качестве аргумента будет приходить массив int[] collection и элемент int find.
{
    int count = collection.Length; // определю количество элементов count.
    int index = 0; // определю, т.к.нужно сщелкать index массива.
    int position = -1; // определю переменную, чтобы можно было сохрянять резельтат. 
    // !Написал -1, чтобы было понятно, что выбранный элемента нет в массиве.Можно написать хоть -2, без раздницы!
    while (index < count) //напишу цикл, который будет проверять, если index < count, то сразу буду сщелкать index++.
    {
        if (collection[index] == find) //если collection[index] совпал с find, то в этом случае нужно сохрать позицию.
        {
            position = index; 
            break; // 3.4.Добавля оператор. Чтобы при первом вхождении остановить процесс и вывести ответ на экран.
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // 1. Определю новый массив int[] array
// new int[10] - означает создай (определить) новый массив в котором будет 10 элементов. 
// По умолчанию он будет заполнен нулями.

//3.Одаптирую решение предыдущей задачи, в которой я находил позицию(index) нужного мне элемента в массиве с использованием метода.
// Для тестирования напишу FillArray(array)
FillArray(array); // 2.1.Заполнит мне массив.
array[4] = 4;
array[6] = 4;
PrintArray(array); // 2.2.Распечатал массив.
Console.WriteLine(); // 3.1.Выведу пустую строчку, чтобы быть уверенным, что выход не явзяется частью массива.

int pos = IndexOf(array, 444); // 3.2.Определю переменную pos и в неё положу результат работы метода IndexOf. 
// В качестве аргумента будет передоваться мой массив и для примера число.
// За место (array, 4) напишу (array, 444) - ответом будет позиция 0, это не верно.Задам int position = -1.
Console.WriteLine(pos); // 3.3.Вывод на экране.Получаю последнее вхождение, 
// т.е. если два одинаковых, покажет позицию второго. 
