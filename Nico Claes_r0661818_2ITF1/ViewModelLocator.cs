using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nico_Claes_r0661818_2ITF1.ViewModel;

namespace Nico_Claes_r0661818_2ITF1
{
    class ViewModelLocator
    {
        private static AccountsViewModel accountsViewModel = new AccountsViewModel();
        private static EditAccountViewModel editAccountViewModel = new EditAccountViewModel();
        private static NewAccountViewModel newAccountViewModel = new NewAccountViewModel();
        private static BanAccountViewModel banAccountViewModel = new BanAccountViewModel();
        private static EditPlayerViewModel editPlayerViewModel = new EditPlayerViewModel();
        private static EditBanAccountViewModel editBanAccountViewModel = new EditBanAccountViewModel();

        public static AccountsViewModel AccountsViewModel
        {
            get
            {
                return accountsViewModel;
            }
        }

        public static EditAccountViewModel EditAccountViewModel
        {
            get
            {
                return editAccountViewModel;
            }
        }

        public static NewAccountViewModel NewAccountViewModel
        {
            get
            {
                return newAccountViewModel;
            }
        }

        public static BanAccountViewModel BanAccountViewModel
        {
            get
            {
                return banAccountViewModel;
            }
        }

        public static EditPlayerViewModel EditPlayerViewModel
        {
            get
            {
                return editPlayerViewModel;
            }
        }

        public static EditBanAccountViewModel EditBanAccountViewModel
        {
            get
            {
                return editBanAccountViewModel;
            }
        }
    }
}
