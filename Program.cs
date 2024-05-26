﻿using System;



class Program

{

    static void Main()

    {

        // Исходный массив строк

        string[] inputArray = { "Hello", "(!*", "Russia", "-5", "789" };



        // Подсчитываем количество строк, удовлетворяющих условию

        int count = 0;

        foreach (string str in inputArray)

        {

            if (str.Length <= 3)

            {

                count++;

            }

        }



        // Создаем новый массив нужного размера

        string[] newArray = new string[count];



        // Заполняем новый массив

        int index = 0;

        foreach (string str in inputArray)

        {

            if (str.Length <= 3)

            {

                newArray[index] = str;

                index++;

            }

        }



        // Выводим новый массив на экран

        Console.WriteLine("Новый массив:");

        foreach (string str in newArray)

        {

            Console.WriteLine(str);

        }

    }
}