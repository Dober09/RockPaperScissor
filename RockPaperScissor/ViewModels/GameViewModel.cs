using CommunityToolkit.Maui.Views;
using RockPaperScissor.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using RockPaperScissor.Views;
using System.Runtime.CompilerServices;

namespace RockPaperScissor.ViewModels
{
    class GameViewModel
    {

        public int score = 0;
        public ObservableCollection<GameModel>  AvailableHand { get; }
        //commands events
        public ICommand RulesButton => new Command(RulesButtonEvent);
        public ICommand HandPlayed => new Command<GameModel>(HandPlayedEvent);

      

        public GameViewModel()
        {
            AvailableHand = new ObservableCollection<GameModel> { 
            new GameModel { HandName = "rock" ,HandColor= "#dc2e4e" , HandImage ="rock.svg"},
            new GameModel { HandName = "paper" ,HandColor= "#ec9e0e" , HandImage ="paper.svg"},
            new GameModel { HandName = "scissor" ,HandColor= "#4865f4" , HandImage ="scissors.svg"},
            };
        }


        // Button event for all hands button
        public void HandPlayedEvent(GameModel handplayed) {
        
            ResultsPage resultsPagePopUp = new ResultsPage(handplayed.HandImage,handplayed.HandColor);
            App.Current.MainPage.ShowPopup(resultsPagePopUp);
        }

        // Button event for rules button
        public void RulesButtonEvent()
        {

            RulesPopUp rulesPopUp = new RulesPopUp();
            App.Current.MainPage.ShowPopup(rulesPopUp);
        }
           


    }
}