using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] moves = { "камень", "ножницы", "бумага" };
            Random random = new Random();

            Console.WriteLine("Добро пожаловать в игру «Камень-Ножницы-Бумага»!");
            Console.WriteLine("Введите ваш ход (камень, ножницы, бумага) или 'выход' для завершения:");

            while (true)
            {
                Console.Write("> ");
                string playerInput = Console.ReadLine()?.ToLower();

                if (playerInput == "выход")
                {
                    Console.WriteLine("Спасибо за игру! До встречи.");
                    break;
                }

                int playerMove = Array.IndexOf(moves, playerInput);
                if (playerMove == -1)
                {
                    Console.WriteLine("Некорректный ход. Попробуйте: камень, ножницы или бумага.");
                    continue;
                }

                int computerMove = random.Next(0, 3);
                Console.WriteLine($"Компьютер выбрал: {moves[computerMove]}");

                if (playerMove == computerMove)
                {
                    Console.WriteLine("Ничья!");
                }
                else if ((playerMove == 0 && computerMove == 1) ||
                         (playerMove == 1 && computerMove == 2) ||
                         (playerMove == 2 && computerMove == 0))
                {
                    Console.WriteLine("Вы выиграли!");
                }
                else
                {
                    Console.WriteLine("Компьютер выиграл!");
                }
                Console.WriteLine();
            }
        }
    }
}