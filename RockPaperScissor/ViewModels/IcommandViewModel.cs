using CommunityToolkit.Maui.Views;

using System.Windows.Input;

namespace RockPaperScissor.ViewModels
{
    public class IcommandViewModel
    {
        public ICommand RulePopup_Clicked => new Command(ClickedEvent);

        public void ClickedEvent(Object obj)
        {
            var pop_up = new Views.RulesPopUp();
            App.Current.MainPage.ShowPopup(pop_up);


        }
    }
}
