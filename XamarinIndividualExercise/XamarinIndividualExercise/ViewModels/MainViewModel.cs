using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using XamarinIndividualExercise.Services;
using Prism.Commands;
using Prism.Services;

namespace XamarinIndividualExercise.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand GetCommand { get; }
        public DeviceOrientation Orientation { get; set; }

        public MainViewModel()
        {
            IDeviceOrientationService DeviceOrientationService = DependencyService.Get<IDeviceOrientationService>();

            GetCommand = new Command(() =>
           {
               Orientation = DeviceOrientationService.GetOrientation();
           });
        }
    }
}
