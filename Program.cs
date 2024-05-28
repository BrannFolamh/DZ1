using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
          
            
          
           
            /*
            Достаточно решить 3 задачи. Записывайте в начало программы условие и свою фамилию.
            Все программы создавайте в одном решении. Со звездочками задания выполняйте в том случае,
            если вы решили задачи без звездочек. */

            Console.WriteLine("Hello,select a task(1-6):");
            int taskNumber = int.Parse(Console.ReadLine());

            switch (taskNumber)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;

            }



        }

                                                            /*
                                            1. Написать программу «Анкета». 
                                             Последовательно задаются вопросы
                                               (имя, фамилия, возраст, рост, вес).
                                             В результате вся информация выводится в одну строчку:
                                            а) используя  склеивание;
                                            б) используя форматированный вывод;
                                            в) используя вывод со знаком $.
                                                            */
        static void Task1()
        {
            Console.Title = "RESUME"; 

            Console.WriteLine("What's your name ?");
            string name = Console.ReadLine();

            Console.WriteLine($"Well {name},now type your surname");
            string surname = Console.ReadLine();

            Console.WriteLine("How old are you dear ?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("And how tall are you ?");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine($"{name},last question here");
            Console.Write("...");
            Console.WriteLine("How much do you weight ?");
            int weight = int.Parse(Console.ReadLine());

            if (weight >= 30)
            {
                Console.WriteLine("Your type is Jirnich");   // Хочется ради прикола добавить вариативности и ответов в зависимости от опредленных чисел
                Console.WriteLine("!!Congrats!!");
            }
            else
            {
                Console.WriteLine("Your type doska dva soska");
            }

            Console.WriteLine($"Is you ?:{surname},{name}, \n  Age: {age}. Weight: {weight}, Height: {height}, right ?");
            Console.ReadKey();
        }


                                                                  /*
                                                    2. Ввести вес и рост человека.
                                                    Рассчитать и вывести
                                                    индекс массы тела (ИМТ) по формуле
                                       I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
                                                                   */

        static void Task2()
        {
            Console.WriteLine("Task 2,calculate your IMT !!!");
            Console.WriteLine("Write your height in meters please");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("And weight");
            double weight = double.Parse(Console.ReadLine());

            double imt = weight / (height * height);
            Console.WriteLine($"Your IMT (BMI):{imt:F2}");
            Console.ReadKey();

        }



        /*
3. а) Написать программу, которая подсчитывает расстояние между точками
с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
         */

        static void Task3()
        {
            Console.WriteLine("Calculate distance between points");
            Console.WriteLine("Enter coordinate x1");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinate y1");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinate x2");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinate y2");
            double y2 = double.Parse(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"Distanse:{distance:F2}");
            Console.ReadKey();




        }
        static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }



        /*
4. Написать программу обмена значениями двух переменных:
а) с использованием третьей переменной;
б) *без использования третьей переменной.
       */


        static void Task4()
        {
            // Объявляем переменные и присваивем им значения 
            int a = 5;
            int b = 10;

            // Вывод на экран исходных значений
            Console.WriteLine($"До обмена:a = {a}, b = {b}");

            // Обмен значениями без третьей переменной,я пока не понимаю логики

            a = a + b;        // Сложение значений а и ь и сохранение результата в а
            b = a - b;        // Вычетание значения ь из нового значения а (а + ь - ь),что дает исходное значение а
            a = a - b;        // Вычетание нового значения ь (исходное значение а) из нового значения а(а + б),что дает исхожное значение ь

            //Вывод значений после обмена 
            Console.WriteLine($"После обмена: a = {a}, b = {b} ");
            Console.ReadKey();
        }



        /*
5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) *Сделать задание, только вывод организовать в центре экрана.
в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
           */


        static void Task5()
        {
            Console.WriteLine("Take your choice: a?(basic) or b?(center)");

            char variant = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine("Type your name:");
            string name = Console.ReadLine();

            Console.WriteLine("And your surname:");
            string surname = Console.ReadLine();

            Console.WriteLine($"Where are you from?(City):{name}");
            string city = Console.ReadLine();

            string output = ($"{name}{surname}{city}");

            if (variant == 'a')
            {
                // Обычный ввод
                Console.WriteLine(output);
            }
            else if (variant == 'b')
            {
                //Вывод в центре экрана
                PrintCentered(output);
            }

        }
        static void PrintCentered(string mesage)
        {
            int screenWidth = Console.WindowWidth; //Ширина окна консоли
            int stringWidth = mesage.Length;       // Длина строки
            int spaces = (screenWidth - stringWidth) / 2; // Вычесляем количество пробелов для выравнивания по центру 
            Console.WriteLine($"{}{}{}");
            Console.ReadKey();
        }

    }

}
