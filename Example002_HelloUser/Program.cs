﻿// Напишу приложение, которое будет запрашивать данные у пользователя, 
// для того чтобы дальше с ними работать.
// Алгоритм: 
// * Начало (Приветствие или объяснение, что делает программа);
// * Ввести имя (Прошу ввисти имя);
// * Вывести "Привет, "
// * Вывести имя пользователя;
// * Конец.

Console.Write("Ввидете ваше имя ");
string username = Console.ReadLine();
Console.Write("Привет, ");
Console.Write(username);