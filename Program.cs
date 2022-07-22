using System;
namespace Dice_Game
{
    class Program
    {
        static void Main()
        {
            int playerRandomNum;
            int opponentRandomNum;
            
            int playerPoints = 0;
            int opponentPoints = 0;
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");
            Console.ReadKey();
            
            playerRandomNum = random.Next(1, 7);
            Console.WriteLine(" You rolled a " + playerRandomNum);

            Console.WriteLine("...........");
            System.Threading.Thread.Sleep(1000);

            opponentRandomNum = random.Next(1, 7);
            Console.WriteLine("Opponent AI rolles a " + opponentRandomNum);

            if(playerRandomNum > opponentRandomNum)
            {
                playerPoints++;
                Console.WriteLine("Player wins this round!");
            }
            else if(playerRandomNum < opponentRandomNum)
            {
                opponentPoints++;
                Console.WriteLine("Opponent AI wins this round!");
            }
            else
            {
                Console.WriteLine("Draw!");
            }
            Console.WriteLine("The score is now Player : " + playerPoints + ". Opponent : " + opponentPoints + ".");
            Console.WriteLine();

            }
            if(playerPoints > opponentPoints)
            {
                System.Console.WriteLine("You win!");
            }
            else if(playerPoints < opponentPoints)
            {
                Console.WriteLine(" You lose AI opponent wins!");
            }
            else
            {
                Console.WriteLine("Wow its a Draw!");
            }
            Console.ReadKey();
        
        
        }
            


        
        

        
    }
}
