using System.Collections;
using UnityEngine;

namespace UnuGames.Examples.UI
{
    public partial class UIMainMenu : UIManScreen
    {
        public override void OnShow(params object[] args)
        {
            base.OnShow(args);
            this.SoundOff = false;
        }

        public void Play()
        {
            UIMan.Instance.ShowScreen<UIMissionList>();
        }

        public void About()
        {
            UIMan.Instance.ShowPopup("About", "UIMan version 1.0.1 \n Best UI Development & Management System", "OK");
        }

        public void OnOffSound()
        {
            this.SoundOff = !this.SoundOff;
            FindObjectOfType<AudioSource>().enabled = !this.SoundOff;
        }

        public void Ranking()
        {
            UIMan.Instance.Loading(OnShowLoading);
        }

        private void OnShowLoading(UIActivity loading)
        {
            if (loading)
                loading.Show(FakeLoadRanking(), true, true, false, true, "Fetching data from server... please wait!");
        }

        private IEnumerator FakeLoadRanking()
        {
            yield return new WaitForSeconds(3);
            UIMan.Instance.ShowDialog<UIRanking>(999);
        }
    }
}