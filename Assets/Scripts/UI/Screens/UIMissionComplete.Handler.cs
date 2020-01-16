namespace UnuGames.Examples.UI
{
    public partial class UIMissionComplete : UIManDialog
    {
        public void Home()
        {
            HideMe();
            UIMan.Instance.ShowScreen<UIMainMenu>();
        }

        public void Replay()
        {
            HideMe();
            UIMan.Instance.GetHandler<UIGameplay>().Replay();
        }
    }
}