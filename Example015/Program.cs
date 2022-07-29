// Перебор слов.
// В некотором машинном алфавите имеются четыре буквы "а", "и", "с" и "в". 
// Показать все слова, состоящии из Т букв, которые можно построить из букв этого алгоритма.
// char[] s = { 'а', 'и', 'с', 'в'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++) // Если мне понадобятся двух буквенные слова, то требуется писать цикл в цикле и т.д.
//     {
//         Console.WriteLine($"{n++, -5} {s[i]} {s[j]}");
//     }
// }
// Если не известно сколько букв будет в слове: Базовая математика поможет решить такую задачу.
// Пример: Есть 5 игроков.
// Нужно показать все разбиения игроков на две команды.
// 0 - игрок попадает в первую команду.
// 1 - игрок попадает во вторую команду.
// Общее решение при помощи рекурсии (можно итеративным методом), для задачи по перебору слов.
// int n = 1; // Делаю принудительно счетчик слов, чтобы быть уверенным (видеть в консоли). А так он не нужен. 
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1);
//     }

// }
// FindWords("аисв", new char[5]);
// Это можно решить другим способом!!!
// Ещё рекурсия. 
// Рекурсию можно применить в жизни.
// Алгоритм обхода директорий - это значит, что я хочу посмотреть все папки, которые находятся в этой папке
// и все файлы, которые находятся в этих папках. В свою очедеть каждая папка внутни папки, является 
// хранилищем папок и файлов. Следующая папка будет сново хранить папки и файлы и т.д.

// string path = "C:/Users/User/Desktop/Examples/Example015"; // Для примера. Тут пытался вставить путь в нежную папку.
// DirectoryInfo di = new DirectoryInfo(path); // Для того чтобы работать с Директориями есть класс.
// System.Console.WriteLine(di.CleationTime);
// FileInfo[] fi = di.GetFiles(); // di.GetFiles() - Покажет файлы в нужной папке.

// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }
// Тоже самое при помощи рекурсии.
void CatalogInfo(string path, string indent = "") // Делаю отступы, чтобы видеть структуру папки.
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }
    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }

}
string path = @"C:/Users/User/Desktop/Examples/Example015"; // Указываю путь.
CatalogInfo(path);
// Работает.