using Nico_Claes_r0661818_2ITF1.Extensions;
using Nico_Claes_r0661818_2ITF1.Messages;
using Nico_Claes_r0661818_2ITF1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Nico_Claes_r0661818_2ITF1.ViewModel
{
    class EditAccountViewModel : BaseViewModel
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

        public ICommand UpdateAccountCommand { get; set; }
        #endregion

        public EditAccountViewModel()
        {
            Messenger.Default.Register<Account>(this, OnAccountReceived);

            UpdateAccountCommand = new BaseCommand(UpdateAccount);
        }

        private void OnAccountReceived(Account account)
        {
            SelectedAccount = account;
        }

        private void UpdateAccount()
        {
            AccountDataService ds = new AccountDataService();
            ds.UpdateAccount(SelectedAccount);

            Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage("Account Edited"));
        }
    }
}
