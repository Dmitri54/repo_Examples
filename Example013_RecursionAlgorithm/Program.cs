//  Урок 4. Ресурсия и двумерные массивы.
// 1. Определю таблицу строк.
// string[,] table = new string[2, 5]; 
// Для того, чтобы обратиться к нужному мне элементу, пишу имя массива в [], 
// указываю индекс строки и индекс столбца. Пример:
//  String.Empty - Инициализация, для строк по умолчанию. String empty - Строка пустая. 

// Индексы у строк и столбцов меняются от нуля. Пример:
// table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]

// table[1, 2] = "слово"; // Обратиться и записать новое значение.

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }
// 2. Сделаю тоже самое, для чисел.

// int[,] matrix = new int[3, 4];

// for (int i = 0; i < matrix.GetLength(0); i++)
//     matrix.GetLength(0); -чтобы получить количество строк, при создании МЕТОДА. (0) -это количество строк
// {
//     for (int j = 0; j < matrix.GetLength(1); j++) // (1) - количество столбцов.
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine(); // Чтобы перейти на новую строку при отображении в консоли.
// }

// 3. Метод - печатает двумерную матрицу в консоль и заполнять её числами.
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// 4. Метод - заполнит матрицу случайными числами.
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        
        }
        
    }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine(); // Добавил в консоль пустую строку.
PrintArray(matrix);
