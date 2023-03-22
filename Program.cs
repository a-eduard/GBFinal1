/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которы меньше или ровна
3 символа. Первоначальний массив можно ввести с клавиатуры или задать на страрте выаполнения алгоритма. При решении 
не рекомендуется использовать колекциями, лучше обойтись исклюбчительно массивами.*/

using System;
using static System.Console;

Clear();

string[] array1 = new string[8] {"Привет", "167", "Hi", "Welcome", ":)", "Russia", "Kazan", "356"};
string[] array2 = new string[array1.Length];

ChangeArray(array1, array2);
PrintArray(array1);
PrintArray(array2);

void ChangeArray(string[] array1, string[] array2)
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
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}
