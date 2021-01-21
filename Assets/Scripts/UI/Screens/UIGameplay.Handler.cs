using System.Collections;
using UnityEngine;

namespace UnuGames.Examples.UI
{
    public partial class UIGameplay : UIManScreen
    {
        [SerializeField]
        private HeaderModule header = null;

        private float timer;
        private float circleTimer;
        private float circleMultiplier = 1;

        public override void OnShowComplete()
        {
            base.OnShowComplete();
            StartGameplay();
        }

        public override void OnHide()
        {
            base.OnHide();
            StopCoroutine(SimulateSlider());
        }

        private void StartGameplay()
        {
            this.Progress = 0;
            this.CircleProgress = 0;

            StartCoroutine(SimulateSlider());
            this.timer = 0;
        }

        private IEnumerator SimulateSlider()
        {
            while (true)
            {
                this.Progress = 1;
                yield return new WaitForSeconds(5);

                this.Progress = 0;
                yield return new WaitForSeconds(5);
            }
        }

        // Your custom code here
        private void Update()
        {
            if (this.State != UIState.Show)
                return;

            this.circleTimer += this.circleMultiplier * Time.deltaTime * 10;

            if (this.circleTimer > 10)
            {
                this.circleMultiplier = -1;
                this.header.DataInstance.Gold += Random.Range(500, 5000);
            }
            else if (this.circleTimer < 0)
            {
                this.circleMultiplier = 1;
            }

            this.CircleProgress = this.circleTimer / 10;
            this.Progress = 1f - this.CircleProgress;
            this.timer += Time.deltaTime;

            if (this.timer > 10)
            {
                this.timer = 0;

                if (!UIMan.Instance.IsShowingDialog<UIMissionComplete>())
                    UIMan.Instance.ShowDialog<UIMissionComplete>();
            }

            this.Timer = Mathf.FloorToInt(this.timer);
        }

        public void Replay()
        {
            StopCoroutine(SimulateSlider());
            StartGameplay();
        }

        public override IEnumerator AnimationShow()
        {
            var position = new Vector2(Screen.width, 0);
            this.RectTransform.anchoredPosition = position;

            var tweener = UITweener.Move(this.gameObject, this.animShowTime, Vector2.zero);

            while (tweener.isRunning)
            {
                yield return null;
            }
        }

        public override IEnumerator AnimationHide()
        {
            var position = new Vector2(Screen.width, 0);
            var tweener = UITweener.Move(this.gameObject, this.animHideTime, position);

            while (tweener.isRunning)
            {
                yield return null;
            }
        }
    }
}