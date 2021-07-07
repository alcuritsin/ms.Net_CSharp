using System;
using System.Threading;

namespace TicTacToe
{
    class Program
    {

        static int player = 1; // Чей сейчас ход. По умолчанию начинают 'Крестики'.

        static int choice; //  Ход вводится на номпаде

        static void Main()
        {
            Logic game = new Logic();
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine(":: TicTacToe ::\n");
                Console.WriteLine("Игрок 1: \"X\"   vs   Игрок 2: \"O\"\n");
                Console.WriteLine(game.CheckGame());
                if (player % 2 == 0)
                {
                    Console.WriteLine("Игрок 2 \"O\" ходит...");
                }
                else
                {
                    Console.WriteLine("Игрок 1 \"X\" ходит...");
                }
                Console.WriteLine("\n");

                game.Board();

                do
                {
                    cki = Console.ReadKey(true);
                    choice = cki.KeyChar - 48;
                } while (choice < 1 || choice > 9);


                //  Проверяем занята ли позиция
                if (game.FreePosition(choice))
                {
                    //  Свободна
                    //  Делаем ход
                    if (player % 2 == 0)
                    {
                        game.Move(choice, 'O');
                    }
                    else
                    {
                        game.Move(choice, 'X');
                    }
                    player++;
                }
                else
                {
                    //  Занята
                    Console.WriteLine("Позиция занята.");
                    Thread.Sleep(1500);
                }



            } while (game.CheckGame() != 'v' && game.CheckGame() != 'd');

            Console.Clear();
            Console.WriteLine(":: TicTacToe ::\n");
            Console.WriteLine("Игрок 1: \"X\"   vs   Игрок 2: \"O\"\n");
            Console.WriteLine(game.CheckGame());
            
            game.Board();

            if (game.CheckGame() == 'v')
            {
                var viner = (player % 2) + 1;
                var symbol = (viner % 2) == 0 ? 'O' : 'X';
                Console.WriteLine($"Игрок {viner}: \"{symbol}\" выиграл.");
            }
            else
            {
                Console.WriteLine("Ничья :)");
            }

        }

    }
}
