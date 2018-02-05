using System;

namespace CConsoleAppGraKolkoKrzyzykP2PiP2C
{
    class Program
    {
        static void Main(string[] args)
        {
            char player1; // gdzie chce postawić X gracz 1
            char player2; // gdzie chce postawić O gracz 2
            string wygrana = "";
            bool wolnePole = true;
            char[] tab = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            //ta petla się powtarza dopuki wszystkie znaki są nie postawione
            while (tab[1] == '1' || tab[2] == '2' || tab[3] == '3' || tab[4] == '4' || tab[5] == '5' || tab[6] == '6' || tab[7] == '7' || tab[8] == '8' || tab[9] == '9')
            {
                while (wolnePole)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Player 1 wybierz pole: ");
                    Console.WriteLine($@"
                                {tab[1]} | {tab[2]} | {tab[3]}
                                ---------
                                {tab[4]} | {tab[5]} | {tab[6]}
                                ---------
                                {tab[7]} | {tab[8]} | {tab[9]}
                                ");
                    player1 = Console.ReadKey().KeyChar;
                    if (player1 == '1' && tab[1] != 'O' && tab[1] != 'X')
                    {
                        tab[1] = 'X';
                        wolnePole = false;
                    }
                    else if (player1 == '2' && tab[2] != 'O' && tab[2] != 'X')
                    {
                        tab[2] = 'X';
                        wolnePole = false;
                    }
                    else if (player1 == '3' && tab[3] != 'O' && tab[3] != 'X')
                    {
                        tab[3] = 'X';
                        wolnePole = false;
                    }
                    else if (player1 == '4' && tab[4] != 'O' && tab[4] != 'X')
                    {
                        tab[4] = 'X';
                        wolnePole = false;
                    }
                    else if (player1 == '5' && tab[5] != 'O' && tab[5] != 'X')
                    {
                        tab[5] = 'X';
                        wolnePole = false;
                    }
                    else if (player1 == '6' && tab[6] != 'O' && tab[6] != 'X')
                    {
                        tab[6] = 'X';
                        wolnePole = false;
                    }
                    else if (player1 == '7' && tab[7] != 'O' && tab[7] != 'X')
                    {
                        tab[7] = 'X';
                        wolnePole = false;
                    }
                    else if (player1 == '8' && tab[8] != 'O' && tab[8] != 'X')
                    {
                        tab[8] = 'X';
                        wolnePole = false;
                    }
                    else if (player1 == '9' && tab[9] != 'O' && tab[9] != 'X')
                    {
                        tab[9] = 'X';
                        wolnePole = false;
                    }
                }
                wolnePole = true;


                //ten kod zatrzymuje grę bo gracz 1 wygrał
                if ((tab[1] == 'X' && tab[2] == 'X' && tab[3] == 'X') || (tab[4] == 'X' && tab[5] == 'X' && tab[6] == 'X') || (tab[7] == 'X' && tab[8] == 'X' && tab[9] == 'X') || (tab[1] == 'X' && tab[4] == 'X' && tab[7] == 'X') || (tab[2] == 'X' && tab[5] == 'X' && tab[8] == 'X') || (tab[3] == 'X' && tab[6] == 'X' && tab[9] == 'X') || (tab[1] == 'X' && tab[5] == 'X' && tab[9] == 'X') || (tab[3] == 'X' && tab[5] == 'X' && tab[7] == 'X'))
                {
                    wygrana = "pla1";
                    break;
                }




                //ten if jest po to by by stawianie znaków się skończyło, jeśli jest ich 9 już i by rych gracza 2 się nie wykonał. Remis
                if (tab[1] != '1' && tab[2] != '2' && tab[3] != '3' && tab[4] != '4' && tab[5] != '5' && tab[6] != '6' && tab[7] != '7' && tab[8] != '8' && tab[9] != '9')
                {
                    break;
                }


                while (wolnePole)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Player 2 wybierz pole: ");
                    Console.WriteLine($@"
                                {tab[1]} | {tab[2]} | {tab[3]}
                                ---------
                                {tab[4]} | {tab[5]} | {tab[6]}
                                ---------
                                {tab[7]} | {tab[8]} | {tab[9]}
                                ");
                    player2 = Console.ReadKey().KeyChar;
                    if (player2 == '1' && tab[1] != 'O' && tab[1] != 'X')
                    {
                        tab[1] = 'O';
                        wolnePole = false;
                    }
                    else if (player2 == '2' && tab[2] != 'O' && tab[2] != 'X')
                    {
                        tab[2] = 'O';
                        wolnePole = false;
                    }
                    else if (player2 == '3' && tab[3] != 'O' && tab[3] != 'X')
                    {
                        tab[3] = 'O';
                        wolnePole = false;
                    }
                    else if (player2 == '4' && tab[4] != 'O' && tab[4] != 'X')
                    {
                        tab[4] = 'O';
                        wolnePole = false;
                    }
                    else if (player2 == '5' && tab[5] != 'O' && tab[5] != 'X')
                    {
                        tab[5] = 'O';
                        wolnePole = false;
                    }
                    else if (player2 == '6' && tab[6] != 'O' && tab[6] != 'X')
                    {
                        tab[6] = 'O';
                        wolnePole = false;
                    }
                    else if (player2 == '7' && tab[7] != 'O' && tab[7] != 'X')
                    {
                        tab[7] = 'O';
                        wolnePole = false;
                    }
                    else if (player2 == '8' && tab[8] != 'O' && tab[8] != 'X')
                    {
                        tab[8] = 'O';
                        wolnePole = false;
                    }
                    else if (player2 == '9' && tab[9] != 'O' && tab[9] != 'X')
                    {
                        tab[9] = 'O';
                        wolnePole = false;
                    }
                }
                wolnePole = true;

                //ten kod zatrzymuje grę bo gracz 2 wygrał
                if ((tab[1] == 'O' && tab[2] == 'O' && tab[3] == 'O') || (tab[4] == 'O' && tab[5] == 'O' && tab[6] == 'O') || (tab[7] == 'O' && tab[8] == 'O' && tab[9] == 'O') || (tab[1] == 'O' && tab[4] == 'O' && tab[7] == 'O') || (tab[2] == 'O' && tab[5] == 'O' && tab[8] == 'O') || (tab[3] == 'O' && tab[6] == 'O' && tab[9] == 'O') || (tab[1] == 'O' && tab[5] == 'O' && tab[9] == 'O') || (tab[3] == 'O' && tab[5] == 'O' && tab[7] == 'O'))
                {
                    wygrana = "pla2";
                    break;
                }
            }

            Console.Clear();

            if (wygrana == "pla1")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Wygrał Player 1. Koniec gry. Aby zamknąć wciśnij dowolny klawisz. ");
            }
            else if (wygrana == "pla2")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wygrał Player 2. Koniec gry. Aby zamknąć wciśnij dowolny klawisz. ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Remis. Koniec gry. Aby zamknąć wciśnij dowolny klawisz. ");
            }
            Console.WriteLine($@"
                                {tab[1]} | {tab[2]} | {tab[3]}
                                ---------
                                {tab[4]} | {tab[5]} | {tab[6]}
                                ---------
                                {tab[7]} | {tab[8]} | {tab[9]}
                                ");



            Console.ReadKey();
        }
    }
}

