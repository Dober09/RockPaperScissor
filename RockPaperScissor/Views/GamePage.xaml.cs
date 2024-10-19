using CommunityToolkit.Maui.Views;
using RockPaperScissor.ViewModels;

namespace RockPaperScissor.Views;

public partial class GamePage : ContentPage
{
	public GamePage()
	{
		InitializeComponent();
		BindingContext = new GameViewModel();
		listview.ItemsSource = new GameViewModel().AvailableHand;
	}


}