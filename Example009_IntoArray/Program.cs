// 1. Нахождение максимума из 9 чисел используч массивы;

int Max(int arg1, int arg2, int arg3) // Функция (метод), которая ищет max значение из трёх.
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//ИндексЭлемента 0   1   2   3   4   5   6   7   8
int [] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 }; // Определю массив
// array[0] = 12; // Так можно обратиться к элементу массива и записать в него значение.
// Console.WriteLine(array[0]); // Так можно обратиться к массиву и получить значение нужного элемента.
int result = Max( // Функция (метод), которая ищет max значение в массиве.
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);

