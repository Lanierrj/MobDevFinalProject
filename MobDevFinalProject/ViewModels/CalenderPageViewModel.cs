using CommunityToolkit.Mvvm.ComponentModel;
using MobDevFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobDevFinalProject.ViewModels
{
    partial class CalenderPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<Day> daysList;
    }
}
