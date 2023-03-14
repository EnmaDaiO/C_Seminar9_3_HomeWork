// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные
//  числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
System.Console.WriteLine("Введите значение : ");
int N = Convert.ToInt32(System.Console.ReadLine());


/// <summary>
/// Метод выводит все натуральные числа в промежутку от N до 1
/// </summary>
/// <param name="start"> N </param>
/// <param name="end"> 1 </param>
/// <returns> Возвращает последовательность натуральных чисел от N до 1 с помощью рекурсии.  </returns>
string NaturNumbers( int start , int end)
{
    if(start == end) return start.ToString(); 
    return(start + ", " + NaturNumbers(start - 1, end) );
}
System.Console.WriteLine(NaturNumbers(N,1));