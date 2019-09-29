using Nico_Claes_r0661818_2ITF1.Model;
using System.Collections.ObjectModel;
using Nico_Claes_r0661818_2ITF1.Messages;
using System.Diagnostics;
using System.Windows.Input;
using Nico_Claes_r0661818_2ITF1.Extensions;
using Nico_Claes_r0661818_2ITF1.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Nico_Claes_r0661818_2ITF1.ViewModel
{
    public class AccountsViewModel : BaseViewModel
    {
        #region parameters
        private DialogService dialogService = new DialogService();

        private ObservableCollection<Account> accounts;
        public ObservableCollection<Account> Accounts
        {
            get { return accounts; }
            set
            {
                accounts = value;
                NotifyPropertyChanged();
            }
        }

        private Account selectedAccount;
        public Account SelectedAccount
        {
            get { return selectedAccount; }
            set
            {
                selectedAccount = value;
                NotifyPropertyChanged();
                SyncronizeAccountData();
            }
        }

        private Player selectedPlayer;
        public Player SelectedPlayer
        {
            get { return selectedPlayer; }
            set
            {
                selectedPlayer = value;
                NotifyPropertyChanged();
            }
        }

        private Ban selectedBan;
        public Ban SelectedBan
        {
            get { return selectedBan; }
            set
            {
                selectedBan = value;
                NotifyPropertyChanged();
            }
        }

        private bool selectedBanCheck;
        public bool SelectedBanCheck
        {
            get { return selectedBanCheck; }
            set
            {
                selectedBanCheck = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand DeleteAccountCommand { get; set; }
        public ICommand EditAccountCommand { get; set; }
        public ICommand CreateAccountCommand { get; set; }
        public ICommand BanAccountCommand { get; set; }
        public ICommand UnbanAccountCommand { get; set; }
        public ICommand EditPlayerCommand { get; set; }
        public ICommand EditBanAccountCommand { get; set; }
        #endregion

        public AccountsViewModel()
        {
            ReadAccounts();
            ConnectCommands();

            Messenger.Default.Register<UpdateFinishedMessage>(this, OnMessageReceived);
        }

        private void ConnectCommands()
        {
            DeleteAccountCommand = new BaseCommand(DeleteAccount);
            EditAccountCommand = new BaseCommand(EditAccount);
            CreateAccountCommand = new BaseCommand(CreateAccount);
            BanAccountCommand = new BaseCommand(BanAccount);
            UnbanAccountCommand = new BaseCommand(UnbanAccount);
            EditPlayerCommand = new BaseCommand(EditPlayer);
            EditBanAccountCommand = new BaseCommand(EditBanAccount);
        }

        private void SyncronizeAccountData()
        {
            PlayerDataService playerDS = new PlayerDataService();
            SelectedPlayer = playerDS.GetPlayerById(SelectedAccount.Id);

            BanDataService banDS = new BanDataService();
            SelectedBanCheck = banDS.CheckBanExistByAccountId(SelectedAccount.Id);

            if (SelectedBanCheck)
            {
                //SelectedBan = banDS.GetBanByAccountId(SelectedAccount.Id);
            }
        }
        
        private void ReadAccounts()
        {
            AccountDataService accountDS = new AccountDataService();
            Accounts = accountDS.GetAccounts();
        }

        public void DeleteAccount()
        {
            if (SelectedAccount != null)
            {
                AccountDataService accountDS = new AccountDataService();
                accountDS.DeleteAccount(SelectedAccount.Id);

                PlayerDataService playerDS = new PlayerDataService();
                playerDS.DeletePlayer(SelectedAccount.Id);

                //Refresh
                ReadAccounts();
            }
        }

        public void EditAccount()
        {
            if (SelectedAccount != null)
            {
                Messenger.Default.Send<Account>(SelectedAccount);

                dialogService.ShowEditAccountDialog();
            }
        }
        
        public void CreateAccount()
        {
            dialogService.ShowNewAccountDialog();
        }

        public void BanAccount()
        {
            if (SelectedAccount != null)
            {
                Messenger.Default.Send<Account>(SelectedAccount);

                dialogService.ShowBanAccountDialog();
            }
        }

        public void EditPlayer()
        {
            if (SelectedPlayer != null)
            {
                Messenger.Default.Send<Account>(SelectedAccount);

                dialogService.ShowEditPlayerDialog();
            }
        }

        public void EditBanAccount()
        {
            if (SelectedBan != null)
            {
                Messenger.Default.Send<Ban>(SelectedBan);

                dialogService.ShowBanAccountDialog();
            }
        }

        public void UnbanAccount()
        {
            if (SelectedBan != null)
            {
                BanDataService banDS = new BanDataService();
                banDS.DeleteBan(SelectedAccount.Id);
            }
        }

        private void OnMessageReceived(UpdateFinishedMessage message)
        {
            switch(message.State)
            {
                    case "Account Edited":
                        dialogService.CloseEditAccountDialog();
                        break;
                    case "Account Created":
                        ReadAccounts();
                        dialogService.CloseNewAccountDialog();
                        break;
                    case "Account Banned":
                        dialogService.CloseBanAccountDialog();
                        break;
                    case "Player Edited":
                        dialogService.CloseEditPlayerDialog();
                        break;
                    case "Ban Edited":
                        dialogService.CloseBanAccountDialog();
                        break;
            }
        }
    }
}
