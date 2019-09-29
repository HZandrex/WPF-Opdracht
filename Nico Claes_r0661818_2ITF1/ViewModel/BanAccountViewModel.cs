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
    class BanAccountViewModel : BaseViewModel
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

        private string reason;
        public string Reason
        {
            get
            {
                return reason;
            }
            set
            {
                reason = value;
                NotifyPropertyChanged();
            }
        }

        private int duration;
        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand InsertBanCommand { get; set; }
        #endregion
        
        public BanAccountViewModel()
        {
            Messenger.Default.Register<Account>(this, OnAccountReceived);

            InsertBanCommand = new BaseCommand(InsertBan);
        }

        private void OnAccountReceived(Account account)
        {
            SelectedAccount = account;
        }

        private void InsertBan()
        {
            BanDataService ds = new BanDataService();
            ds.InsertBan(new Ban(0, SelectedAccount.Id, (int)(DateTime.Now.Ticks), Duration, Reason));

            Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage("Account Banned"));
        }
    }
}
