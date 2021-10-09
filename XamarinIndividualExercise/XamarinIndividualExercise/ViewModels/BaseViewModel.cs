using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace XamarinIndividualExercise.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
