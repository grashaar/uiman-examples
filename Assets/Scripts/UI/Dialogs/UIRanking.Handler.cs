using UnuGames.MVVM;

namespace UnuGames.Examples.UI
{
    using Models;

    public partial class UIRanking : UIManDialog
    {
        [UIManProperty]
        public ObservableList<UserModel> Users { get; }
            = new ObservableList<UserModel>();

        public override void OnShow(params object[] args)
        {
            base.OnShow(args);
            if (args != null && args.Length > 0)
            {
                var fakeUserCount = (int)args[0];

                this.Users.Clear();
                for (var i = 0; i < fakeUserCount; i++)
                {
                    this.Users.Add(new UserModel() {
                        Name = "User " + i.ToString(),
                        Avatar = "user_avatar",
                        Level = fakeUserCount - i,
                        Rank = i + 1
                    });
                }
            }
        }
    }
}