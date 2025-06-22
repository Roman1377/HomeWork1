using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class TicTacToe
    {
        public TicTacToe() 
        {
            char firstPlace = '1';
            char secondPlace = '2';
            char thirdPlace = '3';
            char fourthPlace = '4';
            char fifthPlace = '5';
            char sixthPlace = '6';
            char seventhPlace = '7';
            char eighthPlace = '8';
            char ninthPlace = '9';

            char currentPlayer = 'X';

            void DrawBoard()
            {
                Console.Clear();
                Console.WriteLine($"{firstPlace} | {secondPlace} | {thirdPlace}");
                Console.WriteLine("----------");
                Console.WriteLine($"{fourthPlace} | {fifthPlace} | {sixthPlace}");
                Console.WriteLine("----------");
                Console.WriteLine($"{seventhPlace} | {eighthPlace} | {ninthPlace}");
            }

            bool IsValidMove(int move)
            {
                return (move == 1 && firstPlace == '1') ||
                       (move == 2 && secondPlace == '2') ||
                       (move == 3 && thirdPlace == '3') ||
                       (move == 4 && fourthPlace == '4') ||
                       (move == 5 && fifthPlace == '5') ||
                       (move == 6 && sixthPlace == '6') ||
                       (move == 7 && seventhPlace == '7') ||
                       (move == 8 && eighthPlace == '8') ||
                       (move == 9 && ninthPlace == '9');
            }

            void MakeMove(int move, char player)
            {
                switch (move)
                {
                    case 1: firstPlace = player; break;
                    case 2: secondPlace = player; break;
                    case 3: thirdPlace = player; break;
                    case 4: fourthPlace = player; break;
                    case 5: fifthPlace = player; break;
                    case 6: sixthPlace = player; break;
                    case 7: seventhPlace = player; break;
                    case 8: eighthPlace = player; break;
                    case 9: ninthPlace = player; break;
                }
            }

            bool CheckWin(char player)
            {
                return
                    (firstPlace == player && secondPlace == player && thirdPlace == player) ||
                    (fourthPlace == player && fifthPlace == player && sixthPlace == player) ||
                    (seventhPlace == player && eighthPlace == player && ninthPlace == player) ||
                    (firstPlace == player && fourthPlace == player && seventhPlace == player) ||
                    (secondPlace == player && fifthPlace == player && eighthPlace == player) ||
                    (thirdPlace == player && sixthPlace == player && ninthPlace == player) ||
                    (firstPlace == player && fifthPlace == player && ninthPlace == player) ||
                    (thirdPlace == player && fifthPlace == player && seventhPlace == player);
            }

            bool IsDraw()
            {
                return firstPlace != '1' && secondPlace != '2' && thirdPlace != '3' &&
                       fourthPlace != '4' && fifthPlace != '5' && sixthPlace != '6' &&
                       seventhPlace != '7' && eighthPlace != '8' && ninthPlace != '9';
            }

            while (true)
            {
                DrawBoard();
                Console.WriteLine($"Player {currentPlayer}, choose a position (1-9):");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int choice) || choice < 1 || choice > 9)
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 9.");
                    continue;
                }

                if (!IsValidMove(choice))
                {
                    Console.WriteLine("This place is already taken! Choose another one.");
                    continue;
                }

                MakeMove(choice, currentPlayer);

                if (CheckWin(currentPlayer))
                {
                    DrawBoard();
                    Console.WriteLine($"Congratulations! Player {currentPlayer} wins!");
                    break;
                }

                if (IsDraw())
                {
                    DrawBoard();
                    Console.WriteLine("It's a draw!");
                    break;
                }

                currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
            }
        }
    }
}
