using System.Runtime.CompilerServices;
using System.ComponentModel;
using System;

namespace Nico_Claes_r0661818_2ITF1.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // informatiebron https://www.c-sharpcorner.com/article/explain-radio-button-binding-in-mvvm-wpf/
        public void OnPropertyChange(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
