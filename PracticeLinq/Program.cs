using System;
using System.Collections.Generic;
using System.Linq;
namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {



            /*          
                    Create a list of video game names..
                    Order the list of games by length of the game name.
                    Use the lambda expression in this exercise as well.
                  
             */
            var videoGames = new List<string>() { "gow2", "gow", "modernW2", "gowar3"};
            videoGames.Sort();

            foreach (var videoGame in videoGames)
            {
                Console.WriteLine(videoGame);
            }
            
            Console.ReadLine();



        }
    }
}
