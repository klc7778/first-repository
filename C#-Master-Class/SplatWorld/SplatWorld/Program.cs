using System;

namespace SplatWorld
{
    class MyWorld
    {
        /*
        * Tic, Tac, Toe Challenge Game 
        * Utilizing multidimensional arrays
        */

        static char[,] board =
        {
            {'0','1','2'}, // row 0
            {'3','4','5'}, // row 1
            {'6','7','8'}  // row 2
        };

        static int turns = 0; 

        static void Main(string[] args)
        {
           int player = 2; // player 1 will start
           bool inputCorrect = true;
           int input = 0;
           //Console.ReadKey();


            do{
                
                if(player == 2)
                {
                    player = 1; 
                    EnterXOrO(player, input); 
                }
                else if(player == 1)
                {
                    player = 2; 
                    EnterXOrO(player, input); 
                }

                SetField();

                #region
                // Check for a winner
                chars[] playerChar = {"X", "O"};

                foreach(char playerChar in playerChar)
                {
                    if(((board[0,0] == playerChar) && (board[0,1] == playerChar) && (board[0,2] == playerChar))
                        || ((board[1,0] == playerChar) && (board[1,1] == playerChar) && (board[1,2] == playerChar))
                        || ((board[2,0] == playerChar) && (board[2,1] == playerChar) && (board[2,2] == playerChar))
                        || ((board[0,0] == playerChar) && (board[1,0] == playerChar) && (board[2,0] == playerChar))
                        || ((board[1,1] == playerChar) && (board[0,1] == playerChar) && (board[0,2] == playerChar))
                        || ((board[0,1] == playerChar) && (board[1,1] == playerChar) && (board[2,1] == playerChar))
                        || ((board[0,2] == playerChar) && (board[2,1] == playerChar) && (board[2,2] == playerChar))
                        || ((board[0,0] == playerChar) && (board[1,1] == playerChar) && (board[2,2] == playerChar))
                        || ((board[1,2] == playerChar) && (board[1,1] == playerChar) && (board[2,0] == playerChar)))
                    {
                       if(playerChar == "X")
                       {
                            Console.WriteLine("\n Player 2 is the winner!");
                       }
                       else
                        {
                            Console.WriteLine("\n Player 1 is the winner!");
                        }

                       // reset the field of play here
                       Console.WriteLine("Press any key to start the fuck over");
                       Console.ReadKey(); 
                       ResetField(); 

                       break; 
                        
                    }
                    else if(turns == 10)
                    {
                        Console.WriteLine("Issa tie!");
                        // reset the field of play here
                       Console.WriteLine("Press any key to start the fuck over");
                       Console.ReadKey(); 
                       ResetField(); 

                       break; 
                    }
                }

                #endregion

                #region
                // test if input is correct 
                do{
                    Console.WriteLine("\nPlayer {0}, choose your field: ", player);
                    try
                    {
                         input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Please enter a number between 1 and 9");
                    }

                    // check to see if user input is already been selected 
                    if((input == 1) && (board[0,0] == '1'))
                        inputCorrect = true; 
                    else if((input == 2) && (board[0,1] == '2'))
                        inputCorrect = true;
                    else if((input == 3) && (board[0,2] == '3'))
                        inputCorrect = true;
                    else if((input == 4) && (board[1,0] == '4'))
                        inputCorrect = true;
                    else if((input == 5) && (board[1,1] == '5'))
                        inputCorrect = true;
                    else if((input == 6) && (board[1,2] == '6'))
                        inputCorrect = true;
                    else if((input == 7) && (board[2,0] == '7'))
                        inputCorrect = true;
                    else if((input == 8) && (board[2,1] == '8'))
                        inputCorrect = true;
                    else if((input == 9) && (board[2,2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("ENTER SOMETHING ELSE BITCH!"); 
                        inputCorrect = false; 
                    }       
                   
                }while(!inputCorrect); 

            #endregion

            }while(true); 
        } 

        public static void ResetField()
        {
            char[,] boardInit =
            {
                {'0','1','2'}, // row 0
                {'3','4','5'}, // row 1
                {'6','7','8'}  // row 2
            };

            board = boardInit;
            SetField();
            turns = 0; 
        }

        public static void SetField()
        {
            Console.Clear(); 
            Console.WriteLine("|_____|_________|_________|");
            Console.WriteLine("   {0}|      {1}|      {2}|",board[0,0], board[0,1], board[0,2]);
            Console.WriteLine("|_____|_________|_________|");
            Console.WriteLine("   {0}|      {1}|      {2}|",board[0,0], board[0,1], board[0,2]);
            turns++; 

        }

        public static void EnterXOrO(int player, int input)
        {
            char playerSign = " ";

            if(player == 1)
            {
                playerSign = "X"; 
            }
            else if(player == 2)
            {
                playerSign = "O"; 
            }

            switch(input)
                {
                    case 1: board[0,0] = playerSign; 
                        break;
                    case 2: board[0,1] = playerSign; 
                        break;

                    case 3: board[0,2] = playerSign; 
                        break;

                    case 4: board[1,0] = playerSign; 
                        break;

                    case 5: board[1,1] = playerSign; 
                        break;

                    case 6: board[1,2] = playerSign; 
                        break;
                    case 7: board[2,0] = playerSign; 
                        break;

                    case 8: board[2,1] = playerSign; 
                        break;

                    case 9: board[2,2] = playerSign; 
                        break;
                } // end input switch 
        }
    }
}
