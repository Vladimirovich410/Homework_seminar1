// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Console.WriteLine("Привет!");
// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int max = 0;

// if (num1 > num2){
//     max = num1;
//     Console.WriteLine(num1+" > "+num2);
//     Console.WriteLine("max = "+max);
// }
// else if(num2 > num1){
//         max = num2;
//         Console.WriteLine(num2+" > "+num1);
//         Console.WriteLine("max = "+max);
// }
// else if(num1 == num2)
//         Console.WriteLine("Эти числа равны");


// Напишите программу, которая принимает
// на вход три числа и выдаёт
// максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите три числа");

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;
// if((b==max)&&(c==max))
// {
//     Console.WriteLine("Эти числа равны");
// }
// if(b > max)
// {
//     max = b;
// }
// if(c > max)
// {
//         max = c;
// }

// Console.WriteLine(max+" наибольшее число");

// Задача 6: Напишите программу, которая 
// на вход принимает число и выдаёт, 
// является ли число чётным 
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = num % 2;
// if(num1 == 0)
// {
//     Console.WriteLine("ДА");
// }
// else
//     Console.WriteLine("Нет");


// Задача 8: Напишите программу, которая 
// на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if(n < 0)
{
    n = n * -1;
}
Console.WriteLine("Чётныечисла от 1 до "+n);
int count = 1;
while(count <= n)
{
    int a = count % 2;
    if(a == 0)
    {
        Console.WriteLine(count);
    }
    count++;

}