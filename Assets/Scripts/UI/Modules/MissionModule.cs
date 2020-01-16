using UnityEngine;

namespace UnuGames.Examples.UI
{
    using Models;

    public sealed class MissionModule : UIManModule<MissionModel>
    {
        [SerializeField]
        private GameObject[] stars = null;

        [UIManProperty]
        public override MissionModel DataInstance
        {
            get
            {
                return base.DataInstance;
            }
            set
            {
                base.DataInstance = value;
                OnChange(value);
            }
        }

        private void OnChange(MissionModel newData)
        {
            for (var i = 0; i < newData.Star; i++)
            {
                this.stars[i].SetActive(true);
            }
            for (var i = newData.Star; i < 3; i++)
            {
                this.stars[i].SetActive(false);
            }
        }

        public void OnClick()
        {
            UIMan.Instance.ShowScreen<UIGameplay>();
        }
    }
}