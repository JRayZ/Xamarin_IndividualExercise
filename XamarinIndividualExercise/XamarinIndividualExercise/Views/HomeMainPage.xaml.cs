using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinIndividualExercise.ViewModels;

namespace XamarinIndividualExercise.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeMainPage : ContentPage
    {
        public HomeMainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}