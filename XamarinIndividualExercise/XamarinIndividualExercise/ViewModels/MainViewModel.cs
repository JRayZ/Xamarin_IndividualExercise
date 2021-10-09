using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using XamarinIndividualExercise.Services;

namespace XamarinIndividualExercise.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public DeviceOrientation Orientation { get; set; }
        public ICommand GetOrientationCommand { get; }
        public MainViewModel()
        {
            IDeviceOrientationService service = DependencyService.Get<IDeviceOrientationService>();
            GetOrientationCommand = new Command(() =>
            {
                Orientation = service.GetOrientation();
            });
        }
    }
}
