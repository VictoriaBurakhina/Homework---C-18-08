// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

double []arr = new double[5];
Random rnd = new Random();
for (int i=0;i<5;i++)
{
    arr[i]=rnd.NextDouble();
    Console.WriteLine("{0}", Math.Round(arr[i], 2) );
}
double min = arr[0];
double max = arr[0];
 
for (int i = 0; i < 5; i++)
{
    if (arr[i] < min)
    {
     min =arr[i];
    }
    else if (arr[i] > max)
    {
    max =arr[i];
    }
} 
double result = max-min;
Console.WriteLine($"Разность между максимальным и минимальным элементом массива "+ Math.Round(result, 2));