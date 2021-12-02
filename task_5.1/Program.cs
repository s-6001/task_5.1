using System;

namespace task_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите 7 чисел для нахождения среднего арифметического:");
                double[] numbers = new double[7]; //массив из 7 чисел
                double sum = 0; //сумма чисел массива
                bool sumIsExist = true; //сумма существует?
                try
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = Convert.ToDouble(Console.ReadLine()); //заполняем массив числами
                        sum = sum + numbers[i]; //находим сумму чисел
                    }
                }
                catch
                {
                    Console.Write("Не удалось распознать число."); //выводим сообщение в случае если не удалось распознать число
                    sumIsExist = false; //отмечаем, что сумма не существует
                }
                if (sumIsExist == true) //Если сумма существует, то находим среднее арифметическое
                {
                    Console.Write("Среднее арифметическое этих чисел равно {0}.", sum / numbers.Length);
                }
                Console.WriteLine("");
            }
        }
    }
}