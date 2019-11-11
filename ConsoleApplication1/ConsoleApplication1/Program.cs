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
/*
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
        public static int counter;
        static void Main(string[] args)
        {
            while (true)
            {
                int[] numbers = new int[7];

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine();

                M:
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


                    foreach (int num in numbers)
                    {
                        if (num == randomNumber)
                        {
                            Console.WriteLine("Такое число в массиве есть, введите число заново!");
                            goto M;
                        }
                    }
                    numbers[i] = randomNumber;

                    FinalStringBuilder(randomNumber.ToString());

                }
                
                Array.Resize(ref numbers, 10);
                Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine("База данных заполнена-воспользуйтесь новой дискетой.");
                //Console.WriteLine();
            }
        }
    
    }
}
*/

/*
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
        int[] numbers = new int[7];
            int len = 0;

            while(true)
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
                int i;
                for (i = 0; i < len; i++)
                {
                    if (numbers[i] == randomNumber)
                    {
                        flag = true;
                    }
                }

                if (flag == false)
                {
                    numbers[i] = randomNumber;
                    Console.WriteLine();
                    len++;
                    FinalStringBuilder(randomNumber.ToString());
                }

            }            
        }
    }
}
*/

namespace Lesson1
{
    class Program
    {
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
            while (true)
            {
                Console.WriteLine("Введите число");
                int myNumber = Convert.ToInt32(Console.ReadLine());

                bool flag = false;
                int i;
                for (i = 0; i < len; i++)
                {
                    if (numbers[i] == myNumber)
                    {
                        flag = true;
                    }
                }


                if (flag == false)
                {
                    try
                    {
                        numbers[i] = myNumber;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        int[] numbers1 = new int[len * 2];
                        for (int y = 0; y < numbers.Length; y++)
                        {
                            numbers1[y] = numbers[y];
                            numbers = numbers1;
                        }

                    }
                    Console.WriteLine();
                    len++;
                    //FinalStringBuilder(myNumber.ToString());
                }
            }
        }
    }
}



