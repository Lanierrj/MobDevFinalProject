using Microcharts;
using MobDevFinalProject.Models;
using SkiaSharp;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace MobDevFinalProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            woMins.Chart = new LineChart
            {
                Entries = Global.InfoList.Select(v => new ChartEntry(v.Length) { Color = SKColor.Parse("#FFFFFF") }),
                LineMode = LineMode.Straight,
                LineSize = 8,
                PointSize = 1,
                BackgroundColor = SKColor.Parse("#222222")
            };
            calList.Chart = new LineChart
            {
                Entries = Global.InfoList.Select(v => new ChartEntry(v.Calories) { Color = SKColor.Parse("#FFFFFF") }),
                LineMode = LineMode.Straight,
                LineSize = 8,
                PointSize = 1,
                BackgroundColor = SKColor.Parse("#222222")
            };
            protList.Chart = new LineChart
            {
                Entries = Global.InfoList.Select(v => new ChartEntry(v.Protein) { Color = SKColor.Parse("#FFFFFF") }),
                LineMode = LineMode.Straight,
                LineSize = 8,
                PointSize = 1,
                BackgroundColor = SKColor.Parse("#222222")
            };
            fatList.Chart = new LineChart
            {
                Entries = Global.InfoList.Select(v => new ChartEntry(v.Fat) { Color = SKColor.Parse("#FFFFFF") }),
                LineMode = LineMode.Straight,
                LineSize = 8,
                PointSize = 1,
                BackgroundColor = SKColor.Parse("#222222")
            };
            carbList.Chart = new LineChart
            {
                Entries =  Global.InfoList.Select(v => new ChartEntry(v.Carbs) { Color = SKColor.Parse("#FFFFFF") }),
                LineMode = LineMode.Straight,
                LineSize = 8,
                PointSize = 1,
                BackgroundColor = SKColor.Parse("#222222")
            };
            waterList.Chart = new LineChart
            {
                Entries = Global.InfoList.Select(v => new ChartEntry(v.Water) { Color = SKColor.Parse("#FFFFFF") }),
                LineMode = LineMode.Straight,
                LineSize = 8,
                PointSize = 1,
                BackgroundColor = SKColor.Parse("#222222")
            };
            

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CalenderPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            woMins.Chart = new LineChart
            {
                Entries = Global.InfoList.Select(v => new ChartEntry(v.Length) { Color = SKColor.Parse("#FFFFFF") }),
                LineMode = LineMode.Straight,
                LineSize = 8,
                PointSize = 1,
                BackgroundColor = SKColor.Parse("#222222")
            };
            calList.Chart = new LineChart
            {
                Entries = Global.InfoList.Select(v => new ChartEntry(v.Calories) { Color = SKColor.Parse("#FFFFFF") }),
                LineMode = LineMode.Straight,
                LineSize = 8,
                PointSize = 1,
                BackgroundColor = SKColor.Parse("#222222")
            };
            protList.Chart = new LineChart
            {
                Entries = Global.InfoList.Select(v => new ChartEntry(v.Protein) { Color = SKColor.Parse("#FFFFFF") }),
                LineMode = LineMode.Straight,
                LineSize = 8,
                PointSize = 1,
                BackgroundColor = SKColor.Parse("#222222")
            };
            fatList.Chart = new LineChart
            {
                Entries = Global.InfoList.Select(v => new ChartEntry(v.Fat) { Color = SKColor.Parse("#FFFFFF") }),
                LineMode = LineMode.Straight,
                LineSize = 8,
                PointSize = 1,
                BackgroundColor = SKColor.Parse("#222222")
            };
            carbList.Chart = new LineChart
            {
                Entries = Global.InfoList.Select(v => new ChartEntry(v.Carbs) { Color = SKColor.Parse("#FFFFFF") }),
                LineMode = LineMode.Straight,
                LineSize = 8,
                PointSize = 1,
                BackgroundColor = SKColor.Parse("#222222")
            };
            waterList.Chart = new LineChart
            {
                Entries = Global.InfoList.Select(v => new ChartEntry(v.Water) { Color = SKColor.Parse("#FFFFFF") }),
                LineMode = LineMode.Straight,
                LineSize = 8,
                PointSize = 1,
                BackgroundColor = SKColor.Parse("#222222")
            };
        }
    }
}
