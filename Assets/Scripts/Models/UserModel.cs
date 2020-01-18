using UnuGames;
using UnuGames.MVVM;

// This code is generated automatically by UIMan - UI Generator, please do not modify!

namespace UnuGames.Examples.Models
{
    public sealed partial class UserModel : ObservableModel
    {
        private string m_avatar = "";

        [UIManAutoProperty]
        public string Avatar
        {
            get { return this.m_avatar; }
            set { this.m_avatar = value; OnPropertyChanged(nameof(this.Avatar), value); }
        }

        private string m_name = "";

        [UIManAutoProperty]
        public string Name
        {
            get { return this.m_name; }
            set { this.m_name = value; OnPropertyChanged(nameof(this.Name), value); }
        }

        private int m_level = 0;

        [UIManAutoProperty]
        public int Level
        {
            get { return this.m_level; }
            set { this.m_level = value; OnPropertyChanged(nameof(this.Level), value); }
        }

        private int m_rank = 0;

        [UIManAutoProperty]
        public int Rank
        {
            get { return this.m_rank; }
            set { this.m_rank = value; OnPropertyChanged(nameof(this.Rank), value); }
        }
    }
}