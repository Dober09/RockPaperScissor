
using RockPaperScissor.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor.ViewModels
{
    public class GameLogic
    {
        
        
       public  GameModel CpuHand(ObservableCollection<GameModel> handPlayeds)
       { 
            Random random = new Random();

            int idx = random.Next(handPlayeds.Count);
            Console.WriteLine(idx.ToString());

            return handPlayeds.Where(handplayed => handplayed.Id == idx).FirstOrDefault();


       }

        public string Logic(string user_player , string cpu_player)
        {

            if (user_player == "paper" && cpu_player == "rock")
            {
                // user win

                return "Win";


            }else if (user_player == "rock" && cpu_player == "scissors")
            {
                
                //user win
                return "Win";

            }else if (user_player == "scissors" && cpu_player == "paper")
            {
               
                //use win
                return "Win";

            }else if (user_player == cpu_player){

                //draw game
               
                return "Draw";

            }else { 

                // you lose
                return "Lose";
               

            }
        }
    }
}
