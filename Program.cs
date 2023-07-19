// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

            // var array = new int[4];
            // var random = new Random();
            // var evenCount = 0;

            // for (var i = 0; i < array.Length; i++)
            // {
            //     array[i] = random.Next(100, 999);

            //     if (array[i] % 2 == 0)
            //     {
            //         evenCount++;
            //     }

            //     Console.Write(array[i] + " ");
            // }

            // Console.WriteLine();
            // Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");

// int arrayLangth = 4;
// int [] array = new int[arrayLangth];
// int countEvenNum = 0;

//  for (int i = 0; i < array.Length; i++)
// {
//      array[i]= new Random().Next(100,999 );
//      Console.Write(array[i]+" ");

//      if (array[i] % 2 == 0)
//     {
//         countEvenNum++;
        
//     }
    
// }
// Console.WriteLine($"Количество четных чисел :{countEvenNum}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int arrayLangth = 4;
// int [] array = new int[arrayLangth];
// int resultSum = 0;

//  for (int i = 0; i < array.Length; i++)
// {
//      array[i]= new Random().Next(10,100 );
//      Console.WriteLine(array[i] + " ");

//      if ((i+1) % 2 > 0 )
// {   
//     resultSum += array[i];
    
// }

// }
// Console.WriteLine($"Сумма элементов на нечётных позициях: {resultSum}");


// Задайте массив вещественных чисел. Найдите разницу между максимальным
//  и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// float doubleLangth = 4;
// float [] array = new float[doubleLangth]; 
// float arrMax = array[0];
// float arrMin = array[0];
// float result = 0;

//  for (int i = 0; i < doubleLength; i++)
// {
//      array[i]= new Random().NextDouble(33.3f);
//      Console.Write(array[i]+" ");
// }
// Поиск максимального и мин. числа => находим разницу  