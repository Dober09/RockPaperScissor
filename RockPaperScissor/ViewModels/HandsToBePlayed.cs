
using CommunityToolkit.Maui.Views;
using RockPaperScissor.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace RockPaperScissor.ViewModels
{

    
        public class HandsToBePlayed
        {
            public ObservableCollection<HandPlayed>? Handsplayed;

            public ObservableCollection<HandPlayed>? Result;

        private HandPlayed? playerHand;
            private HandPlayed? PlayerHand 
            { 
                get => playerHand; 
                set
            {
                {
                    playerHand = value;
                }
            }  
            }
        
        
            public HandsToBePlayed()
            {
                Initialize();   
            }

            public void Initialize()
            {
                Handsplayed = new ObservableCollection<HandPlayed> {
                    new HandPlayed { Id= 1, HandImage= "rock.svg", Hands="Rock", Color = "#dc2e4e"},
                    new HandPlayed { Id= 2, HandImage= "paper.svg", Hands="Paper" ,Color = "#ec9e0e" },
                    new HandPlayed { Id= 3, HandImage= "scissors.svg", Hands="Scissor" , Color = "#4865f4"}
                };

                Result = new ObservableCollection<HandPlayed>();
                UpdateResult();
            
            }

            public void UpdateResult()
            {
          
                if (Result != null)
                {
                    Result.Clear();
                    if (PlayerHand != null)
                    {
                        Result.Add(PlayerHand);
                    }
                    Result.Add(new HandPlayed { Id = 1, HandImage = "rock.svg", Hands = "Rock", Color = "#dc2e4e" });
                }

            }
            public ICommand PlayerSelectedHand => new Command<HandPlayed>(ClickedEvent);
            public ICommand RulePopup_Clicked => new Command(ClickedEvent);

            public void ClickedEvent(Object obj)
            {
                var pop_up = new Views.RulesPopUp();
                App.Current.MainPage.ShowPopup(pop_up);


            }
            public void ClickedEvent(HandPlayed handPlayed)
            {
                PlayerHand = handPlayed;
                // Console.WriteLine(handPlayed.Hands);
                var popUp = new Views.ResultsPage();
                App.Current.MainPage.ShowPopup(popUp);
            }

        



        }
}
