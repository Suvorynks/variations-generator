using System;

namespace Lab2_Variant12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Українська мова в консолі

            bool continueProgram = true;

            while (continueProgram)
            {
                Console.WriteLine("Введіть елементи множини через пробіл (наприклад: A B C D або 1 2 3 4):");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Помилка: множина не може бути порожньою.\n");
                    continue;
                }

                // Розділяємо введені елементи
                string[] elements = input.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (elements.Length < 3)
                {
                    Console.WriteLine("Помилка: потрібно ввести щонайменше 3 елементи!\n");
                    continue;
                }

                Console.WriteLine("\nКомбінації з 3 елементів (з можливими повтореннями):");

                int count = 0;           // рахуємо лише дійсні комбінації
                int totalCount = 0;      // усі виведені комбінації

                for (int i = 0; i < elements.Length; i++)
                {
                    for (int j = 0; j < elements.Length; j++)
                    {
                        for (int k = 0; k < elements.Length; k++)
                        {
                            totalCount++;
                            // Перевірка, чи всі три однакові
                            if (elements[i] == elements[j] && elements[j] == elements[k])
                            {
                                Console.WriteLine($"{elements[i]} {elements[j]} {elements[k]}  —  не рахується (всі елементи однакові)");
                            }
                            else
                            {
                                Console.WriteLine($"{elements[i]} {elements[j]} {elements[k]}");
                                count++;
                            }
                        }
                    }
                }

                Console.WriteLine($"\nУсього виведено комбінацій: {totalCount}");
                Console.WriteLine($"Дійсних комбінацій (рахуються): {count}\n");

                // Меню продовження з перевіркою правильного вводу
                bool validChoice = false;

                while (!validChoice)
                {
                    Console.WriteLine("Бажаєте створити іншу множину?");
                    Console.WriteLine("1 - Так");
                    Console.WriteLine("2 - Ні");
                    Console.Write("Ваш вибір: ");
                    string choice = Console.ReadLine()?.Trim();

                    if (choice == "1")
                    {
                        validChoice = true;
                        Console.WriteLine(); // порожній рядок для зручності
                    }
                    else if (choice == "2")
                    {
                        validChoice = true;
                        continueProgram = false;
                        Console.WriteLine("\nПрограма завершена. Гарного дня!");
                    }
                    else
                    {
                        Console.WriteLine("Невірне введення! Введіть 1 або 2.\n");
                    }
                }
            }
        }
    }
}

