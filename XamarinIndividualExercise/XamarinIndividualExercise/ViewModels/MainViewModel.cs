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
        public ICommand GetDeviceOrientation { get; set; }
        public MainViewModel()
        {
            IDeviceOrientationService service = DependencyService.Get<IDeviceOrientationService>();
            GetDeviceOrientation = new Command(() =>
            {
                Orientation = service.GetOrientation();
            });
        }
    }
}
