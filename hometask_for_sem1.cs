
//##Задача 1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.##
// Console.WriteLine("Введите 2 числа, а я скажу какое наибольшее");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// if (a>b)
//     Console.WriteLine("max=" + a);
// if (a<b)
//     Console.WriteLine("max=" + b);
// if (a==b)
//     Console.WriteLine("они равны, дружище!");

//##Задача 2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел##
// Console.WriteLine("Введите 3 числа, а я скажу какое наибольшее");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
// if (a>b & a>c)
//     Console.WriteLine("max=" + a);
// if (b>a & b>c)
//     Console.WriteLine("max=" + b);
// if (c>a & c>b)
//     Console.WriteLine("max=" + c);

//##Задача 3 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)##
// Console.WriteLine("введи целое!! число, а я скажу четное оно или нет ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a%2==0)
//     Console.WriteLine("четное");
// if (a%2!=0)
//     Console.WriteLine("нечетное");
// if (a==0)
//     Console.WriteLine("нечетное");


//##Задача 4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.##
// Console.WriteLine("Введите целое число N, а я покажу все четные числа от одного до N");
// int n = Convert.ToInt32(Console.ReadLine());
// int a = 1;
// if (n>1)
// {
//     while (a<n)
//     {
//         if (a%2==0)
//         {
//             Console.WriteLine(a);
//         }
//     a++;
//     }
// }
// if (n<1)
// {
//     while (a>n)
//     {
//         if (a%2==0 & a!=0)
//         {
//             Console.WriteLine(a);
//         }
//     a--;
//     }
// }
// if (n==1 || n==-1 || n==0)
// {
//     Console.WriteLine("вы ввели некоррктное число");
// }
//##Дополнительная: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// Console.WriteLine("Введите число N, а я покажу все целые числа от -N до N");
// int n = Convert.ToInt32(Console.ReadLine());
// //double a = (-n);
// int a = (-n);
// if (n!=0 & a<n)
// {
//     while (a<=n)
//     {
//         Console.WriteLine(a);
//     a++;
//     }
// }
// if (n!=0 & a>n)
// {
//     while (a>=n)
//     {
//         Console.WriteLine(a);
//      a--;
//     }
// }
// else
// {
//     Console.WriteLine("вы ввели 0. попробуйте заново");
// }

//##Дополнительная: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.WriteLine("Введите трехзначное число, а я покажу его последнюю цифру");
int n = Convert.ToInt32(Console.ReadLine());
int delenie =n/100;
if (n>0)
{
    if (delenie>=1 & delenie<10)
    {
        Console.WriteLine(n%10);
    }
    else
    {
        Console.WriteLine("вы ввели не трехзначное число");
    }
}
if (n<0)
{
    if (delenie<=-1 & delenie>-10)
    {
        Console.WriteLine(n%10);
    }
    else
    {
        Console.WriteLine("вы ввели не трехзначное число");
    }
}