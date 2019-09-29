using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nico_Claes_r0661818_2ITF1.Model
{
    class LoginHistory: BaseModel
    {
        private int id;
        private int accountId;
        private int loginDate;
        private string ip;

        public LoginHistory(int id, int accountId, int loginDate, string ip)
        {
            Id = id;
            AccountId = accountId;
            LoginDate = loginDate;
            Ip = ip;
        }

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                NotifyPropertyChanged();
            }
        }

        public int AccountId
        {
            get { return accountId; }
            set
            {
                accountId = value;
                NotifyPropertyChanged();
            }
        }

        public int LoginDate
        {
            get { return loginDate; }
            set
            {
                loginDate = value;
                NotifyPropertyChanged();
            }
        }

        public string Ip
        {
            get { return ip; }
            set
            {
                ip = value;
                NotifyPropertyChanged();
            }
        }
    }
}
