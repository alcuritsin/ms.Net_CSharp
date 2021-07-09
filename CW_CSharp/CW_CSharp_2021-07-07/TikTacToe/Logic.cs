using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Logic
    {
        //  Задаём массив для поля. Из 10 клеток
        //  Нулевой элемент используется для присвоения победы
        //  arr[0] = 'v' - (victory) кто-то выиграл
        //  arr[0] = 'd' - (draw) ничья
        //  arr[0] = 'g' - (game) игра продолжается

        static char[] arr = { 'g', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static int left_ = 0;
        static int top_ = 3;

        static void CheckWin()
        {
            if (arr[7] == arr[8] && arr[8] == arr[9])
            {
                //  Совпадение в первой строке ---
                //  Конец игры
                arr[0] = 'v';
                return;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                //  Совпадение во второй строке ---
                //  Конец игры
                arr[0] = 'v';
                return;
            }
            else if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                //  Совпадение в третьей строке ---
                //  Конец игры
                arr[0] = 'v';
                return;
            }
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                //  Совпадение первом столбце |
                //  Конец игры
                arr[0] = 'v';
                return;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                //  Совпадение втором столбце |
                //  Конец игры
                arr[0] = 'v';
                return;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                //  Совпадение третьем столбце |
                //  Конец игры
                arr[0] = 'v';
                return;
            }
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                //  Совпадение диагонали /
                //  Конец игры
                arr[0] = 'v';
                return;
            }
            else if (arr[7] == arr[5] && arr[5] == arr[3])
            {
                //  Совпадение диагонали \
                //  Конец игры
                arr[0] = 'v';
                return;
            }

            //  Проверка на ничью
            if (arr[7] != '7' && arr[8] != '8' && arr[9] != '9' &&
                arr[4] != '4' && arr[5] != '5' && arr[6] != '6' &&
                arr[1] != '1' && arr[2] != '2' && arr[3] != '3')
            {
                //  Ходы закончилмсь.
                //  Победитель не определён
                arr[0] = 'd';   //  Ничья
            }
            else
            {
                arr[0] = 'g';   //  Игра продолжается
            }
        }

        public char GetGameStatus()
        {
            return arr[0];
        }

        public void Board()
        {
            for (int i = 1; i <= 9; i++)
            {
                if (arr[i] == 'X')
                {
                    Print_X(i);
                }
                else if (arr[i] == 'O')
                {
                    Print_O(i);
                }
                else
                {
                    Print_Empty(i);
                }
            }
        }

        public bool FreePosition(int pos)
        {
            if (arr[pos] != 'O' && arr[pos] != 'X')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Move(int pos, char player)
        {
            arr[pos] = player;
            CheckWin();
        }

        private static void Print_X (int pos)
        {
            PrintPosition(in pos, out int _left, out int _top);
            Console.SetCursorPosition(_left, _top);   Console.WriteLine("::::::::::::::::::::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine(":: .===.   .===.  ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::  \\ * \\  / * /  ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::   \\ * \\/ * /   ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::    > *  * <    ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::   / * /\\ * \\   ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::  / * /  \\ * \\  ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine(":: '==='    '===' ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::::::::::::::::::::");
        }
        private static void Print_O (int pos)
        {
            PrintPosition(in pos, out int _left, out int _top);
            Console.SetCursorPosition(_left, _top);   Console.WriteLine("::::::::::::::::::::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::   .========.   ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine(":: ./   *  *   \\. ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine(":: |  *  /\\  *  | ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine(":: | *  |  |  * | ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine(":: |  *  \\/  *  | ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine(":: '\\   *  *   /' ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::   '========'   ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::::::::::::::::::::");
        }

        private static void Print_Empty(int pos)
        {
            PrintPosition(in pos, out int _left, out int _top);
            Console.SetCursorPosition(_left, _top);   Console.WriteLine("::::::::::::::::::::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::                ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine($"::  {pos}             ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::                ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::                ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::                ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::                ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::                ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::::::::::::::::::::");
        }

        private static void PrintPosition(in int pos, out int _left, out int _top)
        {
            //  Поле:
            int with = 18;
            int heigth = 8;

            switch (pos)
            {
                case 7:
                    _left = left_ + with * 0;
                    _top = top_ + heigth * 0;
                    break;
                case 8:
                    _left = left_ + with * 1;
                    _top = top_ + heigth * 0;
                    break;
                case 9:
                    _left = left_ + with * 2;
                    _top = top_ + heigth * 0;
                    break;
                case 4:
                    _left = left_ + with * 0;
                    _top = top_ + heigth * 1;
                    break;
                case 5:
                    _left = left_ + with * 1;
                    _top = top_ + heigth * 1;
                    break;
                case 6:
                    _left = left_ + with * 2;
                    _top = top_ + heigth * 1;
                    break;
                case 1:
                    _left = left_ + with * 0;
                    _top = top_ + heigth * 2;
                    break;
                case 2:
                    _left = left_ + with * 1;
                    _top = top_ + heigth * 2;
                    break;
                case 3:
                    _left = left_ + with * 2;
                    _top = top_ + heigth * 2;
                    break;
                default:
                    _left = 0;
                    _top = 0;
                    break;
            }
        }
    }
}

//Signature - подпись
/*
-------------------------------------------
|                                         |
|   "Компьютерная академия ШАГ"           |
|   Курс: PD_011                          |
|   Предмет: Платформа Microsoft .NET     |
|            и язык программирования C#   |
|                                         |
|   Исполнитель: Курицын Алексей          |
|   Преподаватель: Старинин Андрей        |
|                                         |
|   Екатеринбург - 2021                   |
|                                         |
-------------------------------------------*/