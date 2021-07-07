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

        public char CheckGame()
        {
            return arr[0];
        }
        public void Board()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", arr[7], arr[8], arr[9]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", arr[1], arr[2], arr[3]);
            Console.WriteLine("     |     |     ");
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
    }
}
