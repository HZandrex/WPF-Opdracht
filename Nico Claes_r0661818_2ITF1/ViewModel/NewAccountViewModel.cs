using Nico_Claes_r0661818_2ITF1.Extensions;
using Nico_Claes_r0661818_2ITF1.Messages;
using Nico_Claes_r0661818_2ITF1.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Nico_Claes_r0661818_2ITF1.ViewModel
{
    class NewAccountViewModel : BaseViewModel
    {
        #region parameters
        private Account selectedAccount;
        public Account SelectedAccount
        {
            get
            {
                return selectedAccount;
            }
            set
            {
                selectedAccount = value;
                NotifyPropertyChanged();
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChange("Name");
            }
        }

        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                NotifyPropertyChanged();
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                NotifyPropertyChanged();
            }
        }

        private byte securityLevel;
        public byte SecurityLevel
        {
            get { return securityLevel; }
            set
            {
                securityLevel = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand InsertAccountCommand { get; set; }
        public ICommand SelectSecurityLevelCommand { get; set; }
        #endregion

        public NewAccountViewModel()
        {
            Messenger.Default.Register<Account>(this, OnAccountReceived);

            InsertAccountCommand = new BaseCommand(InsertAccount);
            SelectSecurityLevelCommand = new RelayCommand(executemethod, canexecutemethod);
        }

        private void OnAccountReceived(Account account)
        {
            SelectedAccount = account;
        }

        private void InsertAccount()
        {
            AccountDataService accountDS = new AccountDataService();
            accountDS.InsertAccount(new Account(0, Username, null, Password, null, SecurityLevel));

            int id = accountDS.GetIdByUsername(Username);
            Trace.WriteLine("ID: " + id);

            PlayerDataService playerDS = new PlayerDataService();
            playerDS.InsertPlayer(new Player(id, 0, 0, 0, 10000, 10000, 0, 0, 0));

            Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage("Account Created"));
        }

        private bool canexecutemethod(object parameter)
        {
            if (parameter != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void executemethod(object parameter)
        {
            Name = (string)parameter;
        }
    }
}
