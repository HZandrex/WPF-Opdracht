using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Nico_Claes_r0661818_2ITF1.Model
{
    public class Account : BaseModel
    {
        private int id;
        private string username;
        private string nickname;
        private string password;
        private string salt;
        private byte securityLevel;

        public Account(int id, string username, string nickname, string password, string salt, byte securityLevel)
        {
            Id = id;
            Username = username;
            Nickname = nickname;
            Password = password;
            Salt = salt;
            SecurityLevel = securityLevel;
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

        public string Username
        {
            get { return username; }
            set
            {
                username = value;
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

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                NotifyPropertyChanged();
            }
        }

        public string Salt
        {
            get { return salt; }
            set
            {
                salt = value;
                NotifyPropertyChanged();
            }
        }

        public byte SecurityLevel
        {
            get { return securityLevel; }
            set
            {
                securityLevel = value;
                NotifyPropertyChanged();
            }
        }
    }
}
