//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число "); //Введем число
int a = Convert.ToInt32(Console.ReadLine());
string numberS = Convert.ToString(a); //Конвертируем число в строку
if (a > 99) //Проверяем что в числе больше трех цифр 
{
    Console.WriteLine($"Третья цифра {numberS [2]}"); // Выведем в консоль третий символ строки
}
if (a < -99) //Проверяем что в числе больше трех цифр
{
    Console.WriteLine($"Третья цифра {numberS [3]}"); // Выведем в консоль четвертый символ строки (с учетом "-")
}
if  (a > -100 && a < 100) 
{
    Console.WriteLine("Третьей цифры нет"); // Если число не входит в диапазон выведем соответствующее сообщение
}