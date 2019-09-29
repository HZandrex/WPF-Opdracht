using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nico_Claes_r0661818_2ITF1.Model
{
    class NicknameHistory: BaseModel
    {
        private int id;
        private int accountId;
        private string nickname;
        private int expireDate;

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

        public string Nickname
        {
            get { return nickname; }
            set
            {
                nickname = value;
                NotifyPropertyChanged();
            }
        }

        public int ExpireDate
        {
            get { return expireDate; }
            set
            {
                expireDate = value;
                NotifyPropertyChanged();
            }
        }
    }
}
