// Игра в пирамидки.
// Есть три шпиля и некое количество объектов на одном из них. 
// Нужно перенести все объекты (блины) на нужный шпиль используя Рекурсию.

// void Towers(string with = "1", string on = "3", string some = "2", int count = 4) 
// // with - это будет шпиль на котором находятся элементы. on - это шпиль на который нужно перенести все объекты.
// // some - промежуточный шпиль. count - количество блинов.
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }
// Towers();
// ------------------------------------------------------------------------------------------------
// Обход разных структур.
// ((4 - 2) * (1 - 3)) / 10
// Рекурсию можно применять при вычислении выражений, т.к. вырожение стостои из вырожений.
// Бинароное дерего.          

// string emp = String.Empty; // Ввел переменную (для красоты), чтоб нижняя строка влезала.
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp,"4", "2", "1", "3" };
// //                 0    1    2     3    4    5    6    7   8    9    10   11
// void InOrderTraversal(int pos = 1) // Метод позволит сделать обход.
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int rigth = 2 * pos + 1;
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         Console.WriteLine(tree[pos]);
//         if (rigth < tree.Length && !String.IsNullOrEmpty(tree[rigth])) InOrderTraversal(rigth);
//     }
// }           
// InOrderTraversal();

// Возможный проблемы при использовании Рекурсии (медленное выполнение)

// decimal fRec = 0;
// decimal fIte = 0;
// // Рекурсивный подход:
// decimal FibonacciRecursion(int n)
// {
//     fRec++;
//     return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
// }
// Итеративный подход:
// decimal FibonacciIteration(int n)
// {
//     fIte++;
//     decimal result = 1;
//     decimal f0 = 1;
//     decimal f1 = 1;
//     for (int i = 2; i <= n; i++)
//     {
//         result = f0 + f1;

//         f0 = f1;
//         f1 = result;
//         fIte++;
//     }
//     return result;
// }

// // # 1 2 3 4 5 6
// // V 1 1 2 3 5 8
// Console.ReadLine();
// DateTime dt = DateTime.Now; // Засеку время выполниения кода. Время до момента начало подсчета.
// // Console.WriteLine();
// // Console.ReadLine();
// for (int n = 10; n < 40; n++)
// {
//     Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}"); // .ToString("### ### ###"), -15 - для красивого вывода в консоль.
//     fIte = 0;
// }
// System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds); // Выведу на экран разницу с тем временем которое я запомнил.

// Console.WriteLine();
// Console.ReadLine();
// dt = DateTime.Now;
// for (int n = 10; n < 40; n++)
// {
//     Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
//     fRec = 0;
// }
// System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

// Console.ReadLine();

// Возможный проблемы при использовании Рекурсии (переполнение стека)
// int i = 0;
// void Rec()
// {
//     System.Console.WriteLine(i++);
//     Rec();
// }
// Rec();

int[,] pic = new int[1000, 1000]; // При значении 1000 будет переполнение стека.
for (int i = 0; i < 1000; i++)
{
    pic[0, i] = 1;
    pic[i, 0] = 1;
    pic[i, 9] = 1;
    pic[9, 1] = 1;
}

// PrintImage(pic);
FillImage(1, 1);
Console.WriteLine();
// PrintImage(pic);

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            // Console.Write($"{image[i, j]} ");
            if (image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}
