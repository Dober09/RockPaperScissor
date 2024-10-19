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

        public string score = "0";
        public ObservableCollection<GameModel>  AvailableHand { get; }
        //commands events
        public ICommand RulesButton => new Command(RulesButtonEvent);
        public ICommand HandPlayed => new Command<GameModel>(HandPlayedEvent);

        private GameModel _cpuHand;
        
        public GameModel CpuHand
        {
            get=> _cpuHand; 
            set
            {
                if (_cpuHand != value)
                {
                    _cpuHand = value;
                }
            }
        }
     
      

        public GameViewModel()
        {
            AvailableHand = new ObservableCollection<GameModel> { 
            new GameModel {Id=0, HandName = "rock" ,HandColor= "#dc2e4e" , HandImage ="rock.svg"},
            new GameModel {Id=1, HandName = "paper" ,HandColor= "#ec9e0e" , HandImage ="paper.svg"},
            new GameModel {Id=2, HandName = "scissor" ,HandColor= "#4865f4" , HandImage ="scissors.svg"},
            };
        }


        // Button event for all hands button
        public void HandPlayedEvent(GameModel handplayed) {
            CpuHand = new GameLogic().CpuHand(this.AvailableHand);
            ResultsPage resultsPagePopUp = new ResultsPage(handplayed,CpuHand);
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