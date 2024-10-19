using CommunityToolkit.Maui.Views;
using RockPaperScissor.Models;
using RockPaperScissor.ViewModels;
namespace RockPaperScissor.Views;

public partial class ResultsPage : Popup
{
	public ResultsPage(GameModel playerHand,GameModel cpuHand)
	{
		InitializeComponent();
		BindingContext = new GameViewModel();
		imageBtn.Source = playerHand.HandImage;
		imageBtn.BorderColor = Color.FromHex(playerHand.HandColor);

		cpuBtn.Source = cpuHand.HandImage;
		cpuBtn.BorderColor = Color.FromHex(cpuHand.HandColor);
		
		
	}

    private void PlayAgainBtn_Clicked(object sender, EventArgs e)
    {
		Close();
    }
}