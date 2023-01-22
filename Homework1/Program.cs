// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (без использования Math.Pow)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



Console.WriteLine ("Введите число которое хотите возвести в степень: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите степень: ");
int x = Convert.ToInt32(Console.ReadLine());

int number_x = 1;

for (int i=0; i<x; i++)
 number_x*=number;

Console.WriteLine ("Ответ:" + number_x);