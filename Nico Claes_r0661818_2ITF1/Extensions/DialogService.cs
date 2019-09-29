using Nico_Claes_r0661818_2ITF1.View;
using Nico_Claes_r0661818_2ITF1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Nico_Claes_r0661818_2ITF1.Extensions
{
    class DialogService
    {
        private Window editAccountView = null;
        private Window newAccountView = null;
        private Window banAccountView = null;
        private Window editPlayerView = null;
        private Window editBanAccountView = null;

        public DialogService() { }

        public void ShowEditAccountDialog()
        {
            editAccountView = new EditAccountWindow();
            editAccountView.ShowDialog();
        }

        public void CloseEditAccountDialog()
        {
            if (editAccountView != null)
                editAccountView.Close();
        }

        public void ShowNewAccountDialog()
        {
            newAccountView = new NewAccountWindow();
            newAccountView.ShowDialog();
        }

        public void CloseNewAccountDialog()
        {
            if (newAccountView != null)
                newAccountView.Close();
        }

        public void ShowBanAccountDialog()
        {
            banAccountView = new BanAccountWindow();
            banAccountView.ShowDialog();
        }

        public void CloseBanAccountDialog()
        {
            if (banAccountView != null)
                banAccountView.Close();
        }

        public void ShowEditPlayerDialog()
        {
            editPlayerView = new EditPlayerWindow();
            editPlayerView.ShowDialog();
        }

        public void CloseEditPlayerDialog()
        {
            if (editPlayerView != null)
                editPlayerView.Close();
        }

        public void ShowEditBanAccountDialog()
        {
            editBanAccountView = new EditBanAccountWindow();
            editBanAccountView.ShowDialog();
        }

        public void CloseEditBanAccountDialog()
        {
            if (editBanAccountView != null)
                editBanAccountView.Close();
        }
    }
}