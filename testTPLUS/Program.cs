using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите 1, чтобы указать путь к файлу или нажмите 2, чтобы ввести в ручную массив");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                Console.WriteLine("Укажите путь к файлу");
                string pathToFile = Console.ReadLine();
                try
                {
                    Console.Write("Введите dig ");
                    int dig = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("dig=" + dig);

                    int summ = 0;
                    int[] arr = File.ReadAllText(pathToFile).
                    Split(new Char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).
                    Select(x => int.Parse(x)).ToArray();


                    for (int plus = 0; plus < int.MaxValue; plus++)
                    {
                        for (int i = 0; i < arr.Length; i++)
                        {
                            for (int j = i + 1; j < arr.Length; j++)
                            {
                                for (int k = j + 1; k < arr.Length; k++)
                                {

                                    summ = arr[i] + arr[j] + arr[k];

                                    if (summ == dig)
                                    {
                                        Console.WriteLine(summ + "  Самое близкое к dig");

                                        Console.WriteLine(arr[i] + "+" + arr[j] + "+" + arr[k]);

                                        return;

                                    }
                                    else if (summ + plus == dig)
                                    {
                                        Console.WriteLine(summ + "  Самое близкое к dig");

                                        Console.WriteLine(arr[i] + "+" + arr[j] + "+" + arr[k]);


                                        return;

                                    }
                                    else if (summ - plus == dig)
                                    {
                                        Console.WriteLine(summ + "  Самое близкое к dig");

                                        Console.WriteLine(arr[i] + "+" + arr[j] + "+" + arr[k]);


                                        return;

                                    }



                                }

                            }

                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
            else
            {
                try
                {
                    int summ = 0;

                    Console.WriteLine("Введите числа пробел");

                    int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                    Console.Write("Введите dig ");

                    int dig = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("dig=" + dig);

                    for (int plus = 0; plus < int.MaxValue; plus++)
                    {
                        for (int i = 0; i < arr.Length; i++)
                        {
                            for (int j = i + 1; j < arr.Length; j++)
                            {
                                for (int k = j + 1; k < arr.Length; k++)
                                {

                                    summ = arr[i] + arr[j] + arr[k];

                                    if (summ == dig)
                                    {
                                        Console.WriteLine(summ + "  Самое близкое к dig");

                                        Console.WriteLine(arr[i] + "+" + arr[j] + "+" + arr[k]);

                                        return;

                                    }
                                    else if (summ + plus == dig)
                                    {
                                        Console.WriteLine(summ + "  Самое близкое к dig");

                                        Console.WriteLine(arr[i] + "+" + arr[j] + "+" + arr[k]);


                                        return;

                                    }
                                    else if (summ - plus == dig)
                                    {
                                        Console.WriteLine(summ + "  Самое близкое к dig");

                                        Console.WriteLine(arr[i] + "+" + arr[j] + "+" + arr[k]);


                                        return;

                                    }



                                }

                            }

                        }

                    }


                }


                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }


            }
        }
    }
}