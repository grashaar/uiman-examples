using System;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.AddressableAssets;

namespace UnuGames.Examples
{
    using UI;
    using UnuGames;
    using UnityObject = UnityEngine.Object;

    public class StartGame : MonoBehaviour, IUIManLoader
    {
        private void Start()
        {
            UIManLoader.Initialize(this);

            UnityEngine.U2D.SpriteAtlasManager.atlasRequested += LoadSpriteAtlas;

            AddressablesManager.Initialize(DoStartGame);
        }

        private void DoStartGame()
        {
            UIMan.Instance.ShowScreen<UIMainMenu>();
        }

        private void LoadSpriteAtlas(string key, Action<SpriteAtlas> onSucceeded)
        {
            AddressablesManager.LoadAsset<SpriteAtlas>(key, (_, atlas) => onSucceeded?.Invoke(atlas));
        }

        void IUIManLoader.LoadGameObject(string key, Action<string, UnityObject> onLoaded)
        {
            AddressablesManager.LoadAsset<GameObject>(key, onLoaded);
        }

        void IUIManLoader.LoadSprite(string key, Action<string, UnityObject> onLoaded)
        {
            AddressablesManager.LoadAsset<Sprite>(key, onLoaded);
        }

        void IUIManLoader.LoadTexture2D(string key, Action<string, UnityObject> onLoaded)
        {
            AddressablesManager.LoadAsset<Texture2D>(key, onLoaded);
        }

        void IUIManLoader.LoadSpriteAtlas(string key, Action<string, UnityObject> onLoaded)
        {
            AddressablesManager.LoadAsset<SpriteAtlas>(key, onLoaded);
        }

        void IUIManLoader.LoadObject(string key, Action<string, UnityObject> onLoaded)
        {
            AddressablesManager.LoadAsset(key, onLoaded);
        }
    }
}