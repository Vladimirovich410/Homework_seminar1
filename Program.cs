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

Console.WriteLine("Введите три числа");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if((b==max)&&(c==max))
{
    Console.WriteLine("Эти числа равны");
}
if(b > max)
{
    max = b;
}
if(c > max)
{
        max = c;
}

Console.WriteLine(max+" наибольшее число");

