using CommunityToolkit.Maui.Views;
namespace RockPaperScissor.Views;

public partial class ResultsPage : Popup
{
	public ResultsPage()
	{
		InitializeComponent();
	}

    private void PlayAgainBtn_Clicked(object sender, EventArgs e)
    {
		Close();
    }
}