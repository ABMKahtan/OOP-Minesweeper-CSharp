using System;

namespace testapp
{
    class Program
    {
        static void Main(String[] args)
        {
           bool userPlaying;
           string userInput;
           
           do{
            userPlaying = true;
            userInput = "";
            Board gameBoard = new Board(10);

            //Currently an infinite loop needs fixing
            Console.WriteLine("Would you like to keep playing? (Y / N)");
            while (userInput.ToLower() == ""){
            
            userInput = Console.ReadLine();

            if(userInput.ToLower() != "y" || userInput.ToLower() != "n" ){
                userInput = "";
                Console.WriteLine("Please enter a valid option.");
            }
            else if(userInput.ToLower() == "y"){
                userPlaying = true;
                gameBoard = new Board(10);
            }
            else{
                userPlaying = false;
            }
            }
           } while(userPlaying);
        }
    }
}