//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int size = Prompt("Введите размер массива");
int[] array = new int[size];
int count = 0;
for (int i = 0; i < size; i++)
{
    array[i] = Prompt("Введите число");
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Пользователь ввел {count} чисел");