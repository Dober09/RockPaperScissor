using CommunityToolkit.Maui.Views;
using RockPaperScissor.ViewModels;
namespace RockPaperScissor.Views;

public partial class ResultsPage : Popup
{
	public ResultsPage()
	{
		InitializeComponent();
		BindingContext = new HandsToBePlayed();
		listview.ItemsSource = new HandsToBePlayed().Result;
	}

    private void PlayAgainBtn_Clicked(object sender, EventArgs e)
    {
		Close();
    }
}