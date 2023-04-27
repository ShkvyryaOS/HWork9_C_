

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
 void ShowSumNums(int m, int n)
{
    Console.Write("Сумма чисел заданного промежутка равна:");
     Console.Write(SumNums(m - 1, n));
}
int SumNums(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SumNums(m, n);
        return result;
    } 
}      
Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n>m)
ShowSumNums(m,n);
 if (m>n)
 ShowSumNums(n,m);
*/

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
 /*
 Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n>m)
ShowNums(m,n);
 if (m>n)
 ShowNums(n,m);


void ShowNums(int a, int b)
{
    if (a > b)
    {
        return;
    }
    else
    {
        Console.Write(a + " ");
        ShowNums(a+1,b);
        
    }
}

 */


// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
 


Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);



void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}


