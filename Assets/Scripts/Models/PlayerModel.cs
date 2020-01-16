using UnuGames;
using UnuGames.MVVM;

// This code is generated automatically by UIMan - UI Generator, please do not modify!

namespace UnuGames.Examples.Models
{
    public partial class PlayerModel : ObservableModel
    {
        private int m_gold = 0;

        [UIManAutoProperty]
        public int Gold
        {
            get { return this.m_gold; }
            set { this.m_gold = value; OnPropertyChanged(nameof(this.Gold), value); }
        }
    }
}