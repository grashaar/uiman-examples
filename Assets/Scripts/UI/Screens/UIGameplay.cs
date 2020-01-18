using UnuGames;

// This code is generated automatically by UIMan - UI Generator, please do not modify!

namespace UnuGames.Examples.UI
{
    public sealed partial class UIGameplay : UIManScreen
    {
        private float m_circleProgress = 0;

        [UIManAutoProperty]
        public float CircleProgress
        {
            get { return this.m_circleProgress; }
            set { this.m_circleProgress = value; OnPropertyChanged(nameof(this.CircleProgress), value); }
        }

        private float m_progress = 0;

        [UIManAutoProperty]
        public float Progress
        {
            get { return this.m_progress; }
            set { this.m_progress = value; OnPropertyChanged(nameof(this.Progress), value); }
        }

        private int m_timer = 0;

        [UIManAutoProperty]
        public int Timer
        {
            get { return this.m_timer; }
            set { this.m_timer = value; OnPropertyChanged(nameof(this.Timer), value); }
        }
    }
}