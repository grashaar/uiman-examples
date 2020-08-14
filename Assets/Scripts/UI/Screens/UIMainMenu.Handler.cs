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
            UIMan.Instance.GetActivity<UILoadingActivity>(OnShowLoading);
        }

        private void OnShowLoading(UILoadingActivity loading)
        {
            if (!loading)
                return;

            loading.SetTip("Fectching data from server... please wait!");
            loading.Show(FakeLoadRanking());
        }

        private IEnumerator FakeLoadRanking()
        {
            yield return new WaitForSeconds(3f);

            UIMan.Instance.ShowDialog<UIRanking>(999);
        }
    }
}