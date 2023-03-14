// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите значение N : ");
int Numb1 = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите значение M : ");
int Numb2 = Convert.ToInt32(System.Console.ReadLine());

int SumIntervalNumbs(int N, int M)
{
    if(M==0) return N;
    return (SumIntervalNumbs(N+M,M-1) );
}
System.Console.Write($"Сумма значений в промежутке между {Numb1} и {Numb2} равна : ");
System.Console.Write(SumIntervalNumbs(Numb1, Numb2));