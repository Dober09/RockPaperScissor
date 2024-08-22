using CommunityToolkit.Maui.Views;

namespace RockPaperScissor.Views;

public partial class GamePage : ContentPage
{
	public GamePage()
	{
		InitializeComponent();
	}

	private void RulePopup_Clicked(object sender ,EventArgs e)
	{

		
		var popup = new RulesPopUp();
		Console.WriteLine("open");
		this.ShowPopup(popup);
	}

    private void PlayAgain_Clicked(object sender, EventArgs e)
    {
		PlayGame.IsVisible = true;
		Result.IsVisible = false;
    }
}