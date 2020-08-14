using UnuGames;

// This code is generated automatically by UIMan - UI Generator, please do not modify!

namespace UnuGames.Examples.UI
{
    public sealed partial class UIMainMenu
    {
        private bool m_soundOff = false;

        [UIManAutoProperty]
        public bool SoundOff
        {
            get { return this.m_soundOff; }
            set { this.m_soundOff = value; OnPropertyChanged(nameof(this.SoundOff), value); }
        }
    }
}