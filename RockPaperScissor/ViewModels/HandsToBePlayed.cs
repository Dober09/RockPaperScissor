
using RockPaperScissor.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace RockPaperScissor.ViewModels
{
    public class HandsToBePlayed
    {
        public ObservableCollection<HandPlayed> Handsplayed;
        public ICommand PlayerSelectedHand => new Command<HandPlayed>(ClickedEvent);
        public HandsToBePlayed()
        {

            Handsplayed = new ObservableCollection<HandPlayed> {
                new HandPlayed { Id= 1, HandImage= "rock.svg", Hands="Rock", Color = "#dc2e4e"},
                new HandPlayed { Id= 2, HandImage= "paper.svg", Hands="Paper" ,Color = "#ec9e0e" },
                new HandPlayed { Id= 3, HandImage= "scissors.svg", Hands="Scissor" , Color = "#4865f4"}
            };


        }

        public void ClickedEvent (HandPlayed handPlayed){

            App.Current.MainPage.DisplayAlert("hi", $"you played {handPlayed.Hands}", "close");
        }



    }
}
