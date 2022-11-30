//Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4


Console.Clear();
Console.WriteLine("Введите кол-во элементов массива N ");
Console.Write(" N = ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
int count =0;
int[] GetArray( int [] array)
{
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-100, 100);
        if (array[i] > 0)
        {
           count++;
        }       
    }
    return array;
}
GetArray(array);

Console.WriteLine(String.Join(", ", array));
Console.WriteLine("Колличество чисел больше 0 равно: " +count);
