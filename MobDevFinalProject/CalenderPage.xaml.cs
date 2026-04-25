using MobDevFinalProject.Models;
namespace MobDevFinalProject;

public partial class CalenderPage : ContentPage
{
    public CalenderPage()
	{
		InitializeComponent();
    }
    
    private void Next_Page(object sender, EventArgs e)
    {
        var selectedDate = chosenDate.Date;
        Day selectedDay = null;

        for (int i = 0; i < Global.InfoList.Count; i++)
        {
            Day d = Global.InfoList[i];
            if (d.Time == selectedDate)
            {
                selectedDay = d;
            }
        }
        if (selectedDay == null)
        {
            selectedDay = new Day(){Time = selectedDate, WOType = "", Calories=0, Protein=0, Length=0, Carbs=0, Fat=0, Water=0};
            Global.InfoList.Add(selectedDay);
        }
        var detailsModel = new ViewModels.DetailsPageViewModel { Day = selectedDay};
        var dayDetails = new DetailsPage();
        dayDetails.BindingContext = detailsModel;
        Navigation.PushAsync(dayDetails);
    }

    private void Back_Button(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}