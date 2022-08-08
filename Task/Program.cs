void Zadacha29()
{
    // Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

    int size = 8;
    int[] array = new int[size];

    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-10, 11);
    }

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

    for (int i = array.Length - 1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (Math.Abs(array[j]) > Math.Abs(array[j + 1]))
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();


}


void Zadacha25()
{
    //Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.


    Console.WriteLine("Введите первое число ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число ");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = a;

    for (int i = 1; i < b; i++)
    {
        result *= a;
    }
    Console.WriteLine(result);

}

void Zadacha27()
{
    // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    Console.WriteLine("Введите число ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    Console.Write("Сумма цифр числа " + number);
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    Console.WriteLine(" равна " + sum);
}



Zadacha29();
//Zadacha25();
//Zadacha27();
