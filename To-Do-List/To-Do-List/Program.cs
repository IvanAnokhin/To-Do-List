using System;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Добавить задачу");
                Console.WriteLine("2. Отметить задачу как выполненную");
                Console.WriteLine("3. Удалить задачу");
                Console.WriteLine("4. Вывести список задач");
                Console.WriteLine("5. Выход");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите задачу:");
                        string task = Console.ReadLine();
                        tasks.Add(task);
                        Console.WriteLine("Задача добавлена!");
                        break;
                    case 2:
                        Console.WriteLine("Введите номер задачи, которую хотите отметить как выполненную:");
                        int taskIndex = int.Parse(Console.ReadLine());
                        if (taskIndex >= 1 && taskIndex <= tasks.Count)
                        {
                            Console.WriteLine("Задача \"" + tasks[taskIndex - 1] + "\" отмечена как выполненная!");
                            tasks.RemoveAt(taskIndex - 1);
                        }
                        else
                        {
                            Console.WriteLine("Некорректный номер задачи.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Введите номер задачи, которую хотите удалить:");
                        int taskToRemoveIndex = int.Parse(Console.ReadLine());
                        if (taskToRemoveIndex >= 1 && taskToRemoveIndex <= tasks.Count)
                        {
                            Console.WriteLine("Задача \"" + tasks[taskToRemoveIndex - 1] + "\" удалена!");
                            tasks.RemoveAt(taskToRemoveIndex - 1);
                        }
                        else
                        {
                            Console.WriteLine("Некорректный номер задачи.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Список задач:");
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + tasks[i]);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Программа завершена.");
                        return;
                    default:
                        Console.WriteLine("Некорректный выбор.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
