using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinIndividualExercise.Droid.Effects;
using XamarinIndividualExercise.Effects;

[assembly: ResolutionGroupName("IndividualExercise")]
[assembly: ExportEffect(typeof(AndroidFocusEffect), "FocusEffect")]
namespace XamarinIndividualExercise.Droid.Effects
{
    public class AndroidFocusEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                Control.SetBackgroundColor(Android.Graphics.Color.YellowGreen);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }
        protected override void OnDetached()
        {

        }
        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            try
            {
                if (args.PropertyName == "IsFocused")
                {
                    if (((Android.Graphics.Drawables.ColorDrawable)Control.Background).Color == Android.Graphics.Color.YellowGreen)
                    {
                        Control.SetBackgroundColor(Android.Graphics.Color.Red);
                    }
                    else
                    {
                        Control.SetBackgroundColor(Android.Graphics.Color.YellowGreen);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }
    }
}