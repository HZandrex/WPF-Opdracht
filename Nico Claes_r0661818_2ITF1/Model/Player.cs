using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nico_Claes_r0661818_2ITF1.Model
{
    public class Player : BaseModel
    {
        private int id;
        private byte tutorialState;
        private byte level;
        private int totalExperience;
        private int pen;
        private int ap;
        private int coins1;
        private int coins2;
        private byte currentCharacterSlot;

        public Player(int id, byte tutorialState, byte level, int totalExperience, int pen, int ap, int coins1, int coins2, byte currentCharacterSlot)
        {
            Id = id;
            TutorialState = tutorialState;
            Level = level;
            TotalExperience = totalExperience;
            Pen = pen;
            Ap = ap;
            Coins1 = coins1;
            Coins2 = coins2;
            CurrentCharacterSlot = currentCharacterSlot;
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

        public byte TutorialState
        {
            get { return tutorialState; }
            set
            {
                tutorialState = value;
                NotifyPropertyChanged();
            }
        }

        public byte Level
        {
            get { return level; }
            set
            {
                level = value;
                NotifyPropertyChanged();
            }
        }

        public int TotalExperience
        {
            get { return totalExperience; }
            set
            {
                totalExperience = value;
                NotifyPropertyChanged();
            }
        }

        public int Pen
        {
            get { return pen; }
            set
            {
                pen = value;
                NotifyPropertyChanged();
            }
        }

        public int Ap
        {
            get { return ap; }
            set
            {
                ap = value;
                NotifyPropertyChanged();
            }
        }

        public int Coins1
        {
            get { return coins1; }
            set
            {
                coins1 = value;
                NotifyPropertyChanged();
            }
        }

        public int Coins2
        {
            get { return coins2; }
            set
            {
                coins2 = value;
                NotifyPropertyChanged();
            }
        }

        public byte CurrentCharacterSlot
        {
            get { return currentCharacterSlot; }
            set
            {
                currentCharacterSlot = value;
                NotifyPropertyChanged();
            }
        }
    }
}
