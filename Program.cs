/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которы меньше или ровна
3 символа. Первоначальний массив можно ввести с клавиатуры или задать на страрте выаполнения алгоритма. При решении 
не рекомендуется использовать колекциями, лучше обойтись исклюбчительно массивами.*/


using System;
using static System.Console;

Clear();

string[] array = new string[8] {"Привет", "167", "Hi", "Wel", ":)", "Russia", "Kazan", "356"};

PrintArray(array);
WriteLine();
PrintArray(ChangeArray(array));

string[] ChangeArray(string[] array)
{
    string[] res = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        res[count] = array[i];
        count++;
        }
    }
    return res;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}
