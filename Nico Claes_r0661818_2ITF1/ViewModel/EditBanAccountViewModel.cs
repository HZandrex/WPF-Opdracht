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
    class EditBanAccountViewModel : BaseViewModel
    {
        #region parameters
        private Ban selectedBan;
        public Ban SelectedBan
        {
            get
            {
                return selectedBan;
            }
            set
            {
                selectedBan = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand UpdateBanAccountCommand { get; set; }
        #endregion

        public EditBanAccountViewModel()
        {
            Messenger.Default.Register<Ban>(this, OnBanAccountReceived);

            UpdateBanAccountCommand = new BaseCommand(UpdateBanAccount);
        }

        private void OnBanAccountReceived(Ban ban)
        {
            SelectedBan = ban;
        }

        private void UpdateBanAccount()
        {
            BanDataService banDS = new BanDataService();
            banDS.UpdateBan(SelectedBan);

            Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage("Ban Edited"));
        }
    }
}
