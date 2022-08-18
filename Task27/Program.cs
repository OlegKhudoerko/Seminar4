﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число = ");
int numA = Convert.ToInt32(Console.ReadLine());

int numB = numA;//Сохраним, чтоб не затереть входное число
int sum = 0;    //Назначим переменную "sum" для суммирования цифр из числа
int i = 0;      //Обнулим счетчик 

while (numB != 0)      //Выполнять пока число не равно "0", 
{
    sum += numB % 10;  //Прибавить к сумме цифр остаток при делении числа на "10"
    numB /= 10;        //Разделить число на "10" и присвоить ему новое значение
    i++;               //Увеличить счетчик на "1"
}

Console.WriteLine($"{numA} -> {sum}"); //Вывести сумму цифр числа