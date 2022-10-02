// Задача :
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Описание решения задачи: 


Console.WriteLine(" Введите массив строк через пробел ");
string arr = Console.ReadLine();
string[] Q = arr.Split(" ");

var result = new string[Q.Length];
var realSize = 0;
foreach (var value in Q)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;

    }
}
Console.Write(string.Join(Environment.NewLine, result, 0, realSize));
