using CommunityToolkit.Maui.Views;
using RockPaperScissor.ViewModels;
namespace RockPaperScissor.Views;

public partial class ResultsPage : Popup
{
	public ResultsPage(string url, string color)
	{
		InitializeComponent();
		BindingContext = new GameViewModel();
		imageBtn.Source = url;
		imageBtn.BorderColor = Color.FromHex(color);

		
		
	}

    private void PlayAgainBtn_Clicked(object sender, EventArgs e)
    {
		Close();
    }
}