namespace MobDevFinalProject;

public partial class DetailsPage : ContentPage
{
	public DetailsPage()
	{
		InitializeComponent();
	}

    private void Back_Button(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}