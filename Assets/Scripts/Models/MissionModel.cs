using UnuGames;
using UnuGames.MVVM;

namespace UnuGames.Examples.Models
{
    [System.Serializable]
    public partial class MissionModel : ObservableModel
    {
        private int m_level;

        [UIManAutoProperty]
        public int Level
        {
            get { return this.m_level; }
            set { this.m_level = value; OnPropertyChanged(nameof(this.Level), value); }
        }

        private int m_star;

        [UIManAutoProperty]
        public int Star
        {
            get { return this.m_star; }
            set { this.m_star = value; OnPropertyChanged(nameof(this.Star), value); }
        }

        private bool m_locked;

        [UIManAutoProperty]
        public bool Locked
        {
            get { return this.m_locked; }
            set { this.m_locked = value; OnPropertyChanged(nameof(this.Locked), value); }
        }
    }
}