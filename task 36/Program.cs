//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int[]arr = new int [10];
Random rnd = new Random();
for (int i=0;i<10;i++)
{
    arr[i]=rnd.Next(0,10);
    Console.WriteLine("{0}", arr[i]);
}
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 == 1)
        sum += arr[i];
}
Console.WriteLine($"Сумма нечетных элементов' = {sum}");