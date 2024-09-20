using System;

class Program
{
    static void Main()
    {
        // Задаємо масив B з 10 елементів
        int[] B = { -1, 2, -3, 4, -5, 6, 7, -8, 9, -10 };

        // Лічильник додатніх елементів
        int positiveCount = 0;
        int thirdPositive = -1; // Для збереження значення третього додатнього елемента
        int thirdPositiveIndex = -1; // Для збереження індексу третього додатнього елемента

        // Перебір масиву
        for (int i = 0; i < B.Length; i++)
        {
            if (B[i] > 0) // Якщо елемент додатній
            {
                positiveCount++; // Збільшуємо лічильник додатніх елементів

                if (positiveCount == 3) // Якщо це третій додатній елемент
                {
                    thirdPositive = B[i];
                    thirdPositiveIndex = i;
                    break; // Завершуємо цикл після знаходження
                }
            }
        }

        // Виводимо результат
        if (thirdPositiveIndex != -1)
        {
            Console.WriteLine("Третій додатній елемент: " + thirdPositive);
            Console.WriteLine("Його індекс: " + thirdPositiveIndex);
        }
        else
        {
            Console.WriteLine("Третій додатній елемент не знайдено.");
        }
    }
}
