using UnityEngine;
using UnuGames.MVVM;

namespace UnuGames.Examples.UI
{
    using Models;

    public sealed partial class UIMissionList : UIManScreen
    {
        [UIManProperty]
        public ObservableList<MissionModel> Missions { get; }
            = new ObservableList<MissionModel>();

        public override void OnShow(params object[] args)
        {
            base.OnShow(args);
            this.Missions.Clear();

            for (var i = 0; i < 100; i++)
            {
                this.Missions.Add(new MissionModel() {
                    Level = i + 1,
                    Locked = i > 50 ? true : false,
                    Star = Random.Range(0, 4)
                });
            }
        }
    }
}