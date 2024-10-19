
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
        
        
       public  int CpuHand(ObservableCollection<GameModel> handPlayeds)
       { 
            Random random = new Random();

            return random.Next(handPlayeds.Count);

       }

        public void Logic(string user_player , string cpu_player)
        {

            if (user_player == "user_paper" && cpu_player == "cpu_rock")
            {
                // user win
                
                


            }else if (user_player == "user_rock" && cpu_player == "cpu_scissors")
            {
                
                //user win

            }else if (user_player == "user_scissors" && cpu_player == "cpu_paper")
            {
               
                //use win

            }else if (user_player == cpu_player){

                //draw game
               

            }else { 

                // you lose
               

            }
        }
    }
}
