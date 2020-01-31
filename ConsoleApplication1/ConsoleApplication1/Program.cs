using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Привет, напиши программу, которая берет случайное число из заданного диапазона
//(диапазон задается пользователем) и кладет это число в массив,
// но кладет только в том случае, если этого числа в масиве ещё нет
//  и выводит в строку текущий массив через запятую.Снова задается случайное число из заданного диапазона(диапазон задается пользователем)
//  и кладет это число в массив и т.д.Важно начал делать. Засек время. Приблизительное время выполнения - три часа. (В идеале сорок минут). А ты засеки и посмотри сколько реально ушло
// подключение с нового компьютера ура


namespace Lesson1
{
class Program
{
    static int startDiapason()
    {
        Console.WriteLine("Введите число начала диапазона");
        int diapasonStart = Convert.ToInt32(Console.ReadLine());
        return diapasonStart;
    }

    static int stopDiapason()
    {
        Console.WriteLine("Введите число конца диапазона");
        int diapasonStop = Convert.ToInt32(Console.ReadLine());
        return diapasonStop;
    }

    static string finalStr;
    static void FinalStringBuilder(string str)
    {
        if (finalStr == null)
        {
            finalStr = str;
            Console.WriteLine(finalStr);
        }
        else
        {
            finalStr += ", ";
            finalStr += str;
            Console.WriteLine(finalStr);
        }
    }
    static void Main(string[] args)
    {
        int[] numbers = new int[2];
            int len = 0;
            int countArray = 1;
            int i = 0;
            int j = 0;

            while (true)
            { 
                Console.WriteLine();
            Console.WriteLine();

            int diapasonStart = 0;
            bool errorStart;
            do
            {
                try
                {
                    errorStart = false;
                    diapasonStart = startDiapason();
                }
                catch
                {
                    errorStart = true;
                    Console.WriteLine("Вы вели некорректный символ");
                }
            } while (errorStart == true);



            int diapasonStop = 0;
            bool errorStop;
            do
            {
                try
                {
                    errorStop = false;
                    diapasonStop = stopDiapason();
                }
                catch
                {
                    errorStop = true;
                    Console.WriteLine("Вы вели некорректный символ");
                }
            } while (errorStop == true);

            if (diapasonStart > diapasonStop)
            {
                int revers = diapasonStop;
                diapasonStop = diapasonStart;
                diapasonStart = revers;

            }
            Console.WriteLine();
            Random random = new Random();
            int randomNumber;
            randomNumber = random.Next(diapasonStart, diapasonStop);               

                bool flag = false;

                for (i = 0; i < len; i++)
                {
                    if (numbers[i] == randomNumber)
                    {
                        flag = true;
                    }
                }

                if (flag == false)
                {
                    numbers[j] = randomNumber;
                    j++;

                    if (j == numbers.Length)
                    {
                        int[] numbers1 = new int[countArray * 2];
                        for (int y = 0; y < numbers.Length; y++)
                        {
                            numbers1[y] = numbers[y];
                        }
                        numbers = numbers1;
                    }

                    countArray++;
                    len++;
                    FinalStringBuilder(randomNumber.ToString());
                }

            }            
        }
    }
}
