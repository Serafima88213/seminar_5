
// /*
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int[] array = new int[6];
Console.WriteLine("Введите число");
int num =  Convert.ToInt32(Console.ReadLine());

bool tr=false;

for (int i = 0; i < array.Length; i ++)
{
    array[i] = new Random().Next(6);
    Console.WriteLine(array[i]);

    if (array[i]==num)
    {
      tr=true;  
    }
}
if(tr)
{
   Console.WriteLine("Да"); 
}
else
{
   Console.WriteLine("Нет"); 
}
// */

// /*
// Задача 35: Задайте одномерный массив из 5 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = new int[5];

for (int i = 0; i < array.Length; i ++)
{
    array[i] = new Random().Next(150);
}
for (int i = 0; i < array.Length; i ++)
{
     Consol.WriteLine(array)
}

for (int i = 0; i < array.Length; i ++)
{
   if(array[i] > 10 && array [i] < 100)
   {
    count++;
   }
}
// */

// /*
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] inputArray = {1,6,72,2,84};
int astIndex = inputArray.Length - 1;  // 5-1=4
int resultArray = new int [inputArray.Length / 2 + inputArray.Length % 2];



for (int i = 0; i < array.Length; i++)
{
    resaltArray[i]= inputArray[i]*inputArray[LastIndex-i];
    Cosole.WriteLine(resalt[i]);
    if(i==lastIndex - i)
    {
      resultArray[i] = inputArray[i];
    }
}
Console.WriteLine($"Ответ:[{String.Join(";",resultArray)}]");
*/

/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

 Console.WriteLine("Input the size of the array");
 int size = Covert.ToInt32(Console.ReadLine());

 int[]array = GetArray(size);
 int[] GetArray(int size)
 {
   int[] array = new int[size];

   for (int i=0; i<size; i++)
   {
      array[i]=new Random().Next(-100,100);
   }
   return array;

 }
 Console.WriteLine(string.Join(",",array));

 int max = array[0];
 for (int i=0; i<size; i++)
 {
   if (array[i]>max)
   max = array[i];
 }

 int min = array[0];
 for (int i=0; i<size; i++)
 {
   if (array[i]>min)
   min = array[i];
 }
 Console.WriteLine($"The difference between max and min : {max - min}");
 */

/*
//  Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Input the size of the array");
 int size = Covert.ToInt32(Console.ReadLine());
  int sum = 0;

  int[]array = GetArray(size);

  int[] GetArray(int size)
  {
   int[] array = new int[size];

   for (int i=0; i<size; i++)
  {
   array[i]=new Random().Next(-100,1000);
      int aelement = array[i];
      if (i%2 !=0)
      {
        sum =sum + element;
      }

   }
   return array;

   }
Console.WriteLine(string.Join(",",array));
Console.WriteLine($"Sum elements of odd numbers: {sum}");
*/


 /*
//  Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] Array()
 {
    int[] arrayNumber = new int[0];
    for (int i = 0; i < 1; i++)
    {
        arrayNumber[i] = new Random().Next(0,100);
    }
    return arrayNumber;
 }

 void printArray(int[]arrPrint)
 {
    System.Console.WriteLine(string.Join(",", arrPrint));
 }

 printArray(printArray());
  */