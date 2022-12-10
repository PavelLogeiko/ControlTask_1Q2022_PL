/*
Задача: 
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
*/

Console.Clear();
Console.WriteLine();
Console.WriteLine("Задача: из имеющегося массива сформировать массив из строк, длина которых меньше либо равна 3 символам.");
Console.WriteLine();

string[] array1 = new string[5] {"GB", "456", "Macbook", "Air", "Control"}; // Инициализация и заполнение первого массива
string[] array2 = new string[array1.Length]; // Инициализация второго массива


Console.WriteLine();
Console.WriteLine("Дан следующий массив строк:");
PrintArray1(array1); // Вызов метода вывода на экран первого заданного массива
Console.WriteLine();

SecondArray(array1, array2); // Вызов метода формирования второго массива, строками из первого длина которых меньше либо равна 3 символам

Console.WriteLine();
Console.WriteLine("Ответ: Новый массив строк, длина которых меньше либо равна 3 символам:");
PrintArray2(array2); // Вызов метода вывода на экран первого заданного массива
Console.WriteLine();

void PrintArray1(string[] array1) // Метод вывода на экран первого заданного массива
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]}  ");
    }  
    Console.WriteLine();
}

void SecondArray(string[] array1, string[] array2) // Метод формирования второго массива, строками из первого длина которых меньше либо равна 3 символам
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray2(string[] array2) // Метод вывода на экран второго массива
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]}  ");
    }  
    Console.WriteLine();
}