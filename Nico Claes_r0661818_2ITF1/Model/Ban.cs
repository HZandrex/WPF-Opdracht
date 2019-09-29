using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Nico_Claes_r0661818_2ITF1.Model
{
    public class Ban : BaseModel
    {
        private int id;
        private int accountId;
        private int date;
        private int duration;
        private string reason;

        public Ban(int id, int accountId, int date, int duration,string reason)
        {
            Id = id;
            AccountId = accountId;
            Date = date;
            Duration = duration;
            Reason = reason;
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

        public int Date
        {
            get { return date; }
            set
            {
                date = value;
                NotifyPropertyChanged();
            }
        }

        public int Duration
        {
            get { return duration; }
            set
            {
                duration = value;
                NotifyPropertyChanged();
            }
        }

        public string Reason
        {
            get { return reason; }
            set
            {
                reason = value;
                NotifyPropertyChanged();
            }
        }
    }
}
