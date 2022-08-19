//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2


int[]arr = new int [10];
int k = 0;
Random rnd = new Random();
Console.WriteLine ("Массив");
for (int i=0;i<10;i++)
{
    arr[i]=rnd.Next(100,999);
    Console.WriteLine("{0}", arr[i]);
}
foreach (int g in arr)
{
    if (g % 2==0)
    {
        k++;
    }
}
Console.WriteLine ();
Console.WriteLine ("Количество четных элементов в массиве {0}",k);