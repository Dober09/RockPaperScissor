using CommunityToolkit.Maui.Views;

namespace RockPaperScissor.Views;

public partial class RulesPopUp : Popup
{
	public RulesPopUp()
	{
		InitializeComponent();
	
	}

    private void CloseBtn_Clicked(object sender, EventArgs e)
    {
		Close();
    }
}