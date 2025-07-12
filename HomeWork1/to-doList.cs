using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class to_doList
    {
        class TodoItem
        {
            public string Title { get; set; }
            public bool IsDone { get; set; }

            public TodoItem(string title)
            {
                Title = title;
                IsDone = false;
            }

            public override string ToString()
            {
                return (IsDone ? "[Виконано] " : "[Невиконано] ") + Title;
            }
        }

        static List<TodoItem> todoList = new List<TodoItem>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.WriteLine(GetMenu());

                Console.Write("Оберіть пункт меню (1-5): ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        AddTodo();
                        break;
                    case "2":
                        ShowTodos();
                        break;
                    case "3":
                        MarkAsDone();
                        break;
                    case "4":
                        DeleteTodo();
                        break;
                    case "5":
                        Console.WriteLine("Завершення роботи програми. До побачення!");
                        return;
                    default:
                        Console.WriteLine("Помилка: введено неправильний пункт меню.");
                        break;
                }
            }
        }

        static string GetMenu()
        {
            StringBuilder menu = new StringBuilder();
            menu.AppendLine("========== МЕНЮ ==========");
            menu.AppendLine("1. Додати нову справу");
            menu.AppendLine("2. Переглянути всі справи");
            menu.AppendLine("3. Позначити справу як виконану");
            menu.AppendLine("4. Видалити справу зі списку");
            menu.AppendLine("5. Вийти з програми");
            menu.AppendLine("==========================");
            return menu.ToString();
        }

        static void AddTodo()
        {
            Console.Write("Введіть назву справи: ");
            string title = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(title))
            {
                todoList.Add(new TodoItem(title));
                Console.WriteLine("Справу успішно додано до списку.");
            }
            else
            {
                Console.WriteLine("Помилка: назва справи не може бути порожньою.");
            }
        }

        static void ShowTodos()
        {
            if (todoList.Count == 0)
            {
                Console.WriteLine("Список справ наразі порожній.");
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ваш список справ:");

            for (int i = 0; i < todoList.Count; i++)
            {
                sb.AppendLine($"{i + 1}. {todoList[i]}");
            }

            Console.WriteLine(sb.ToString());
        }

        static void MarkAsDone()
        {
            ShowTodos();

            Console.Write("Введіть номер справи, яку потрібно позначити як виконану: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                if (index >= 1 && index <= todoList.Count)
                {
                    todoList[index - 1].IsDone = true;
                    Console.WriteLine("Справу позначено як виконану.");
                }
                else
                {
                    Console.WriteLine("Помилка: номер справи не існує.");
                }
            }
            else
            {
                Console.WriteLine("Помилка: введено нечислове значення.");
            }
        }

        static void DeleteTodo()
        {
            ShowTodos();

            Console.Write("Введіть номер справи, яку потрібно видалити: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                if (index >= 1 && index <= todoList.Count)
                {
                    string deletedTitle = todoList[index - 1].Title;
                    todoList.RemoveAt(index - 1);
                    Console.WriteLine($"Справу \"{deletedTitle}\" успішно видалено.");
                }
                else
                {
                    Console.WriteLine("Помилка: номер справи не існує.");
                }
            }
            else
            {
                Console.WriteLine("Помилка: введено нечислове значення.");
            }
        }
    }
}
