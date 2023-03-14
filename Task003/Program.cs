// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

System.Console.WriteLine("Ведите первое не отрицательное число :  ");
int Numb1=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ведите второе не отрицательное число :  ");
int Numb2=Convert.ToInt32(Console.ReadLine());



 int A(int n, int m)
{
  if (n == 0) return m + 1;
  else
    if ((n != 0) && (m == 0)) return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}
System.Console.WriteLine(A(1,2)); // ЗАДАЮ КОНКРЕТНО 1 И 2 вместо чисел вводимых с консоли для теста
// код найден, но когда я выполняю в уме построчно у меня на выходе получается 2 а не 4