
using UnuGames;
using UnuGames.MVVM;

// This code is generated automatically by UIMan - UI Generator, please do not modify!

namespace UnuGames.Examples.UI
{
    public partial class UILoadingActivity
    {
        private string m_tip = "";

        [UIManAutoProperty]
        public string Tip
        {
            get { return this.m_tip; }
            set { this.m_tip = value; OnPropertyChanged(nameof(this.Tip), value); }
        }
    }
}
