using System;
using System.Windows.Input;

namespace Nico_Claes_r0661818_2ITF1.ViewModel
{
    public class BaseCommand : ICommand
    {
        Action actie;

        public BaseCommand(Action Actie)
        {
            actie = Actie;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            actie.Invoke();
        }
    }
}
