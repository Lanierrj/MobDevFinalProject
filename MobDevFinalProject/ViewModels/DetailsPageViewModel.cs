using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MobDevFinalProject.Models;

namespace MobDevFinalProject.ViewModels
{
    partial class DetailsPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private Day day;
    }
}
