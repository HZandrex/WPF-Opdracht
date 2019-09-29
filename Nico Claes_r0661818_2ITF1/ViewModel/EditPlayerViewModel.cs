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
    class EditPlayerViewModel : BaseViewModel
    {
        #region parameters
        private Player selectedPlayer;
        public Player SelectedPlayer
        {
            get
            {
                return selectedPlayer;
            }
            set
            {
                selectedPlayer = value;
                NotifyPropertyChanged();
            }
        }

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

        public ICommand UpdatePlayerCommand { get; set; }
        #endregion

        public EditPlayerViewModel()
        {
            Messenger.Default.Register<Account>(this, OnAccountReceived);

            UpdatePlayerCommand = new BaseCommand(UpdatePlayer);
        }

        private void OnAccountReceived(Account account)
        {
            SelectedAccount = account;

            PlayerDataService playerDS = new PlayerDataService();
            SelectedPlayer = playerDS.GetPlayerById(selectedAccount.Id);
        }

        private void UpdatePlayer()
        {
            AccountDataService accountDS = new AccountDataService();
            accountDS.UpdateAccount(SelectedAccount);

            PlayerDataService playerDS = new PlayerDataService();
            playerDS.UpdatePlayer(SelectedPlayer);

            Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage("Player Edited"));
        }
    }
}
