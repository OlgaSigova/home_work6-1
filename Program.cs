//Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4


Console.Clear();
Console.WriteLine("Сколько чисел вы хотите ввести ");

int numb = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numb];

int PositiveNumbers(int count)
{
    int countOfPositive = 0;
    for (int i = 0; i < count; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
        {
            countOfPositive++;
        }
        Console.WriteLine(string.Join (", ", array));
    }
    return countOfPositive;
}
int posCount = PositiveNumbers(numb);


Console.WriteLine("Колличество чисел больше 0 равно: " + posCount);
