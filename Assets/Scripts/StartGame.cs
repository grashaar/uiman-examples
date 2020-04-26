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

            AddressableManager.Initialize(DoStartGame);
        }

        private void DoStartGame()
        {
            UIMan.Instance.ShowScreen<UIMainMenu>();
        }

        private void LoadSpriteAtlas(string key, Action<SpriteAtlas> onSucceeded)
        {
            AddressableManager.LoadAsset<SpriteAtlas>(key, (_, atlas) => onSucceeded?.Invoke(atlas));
        }

        void IUIManLoader.LoadGameObject(string key, Action<string, UnityObject> onLoaded)
        {
            AddressableManager.LoadAsset<GameObject>(key, onLoaded);
        }

        void IUIManLoader.LoadSprite(string key, Action<string, UnityObject> onLoaded)
        {
            AddressableManager.LoadAsset<Sprite>(key, onLoaded);
        }

        void IUIManLoader.LoadTexture2D(string key, Action<string, UnityObject> onLoaded)
        {
            AddressableManager.LoadAsset<Texture2D>(key, onLoaded);
        }

        void IUIManLoader.LoadSpriteAtlas(string key, Action<string, UnityObject> onLoaded)
        {
            AddressableManager.LoadAsset<SpriteAtlas>(key, onLoaded);
        }

        void IUIManLoader.LoadObject(string key, Action<string, UnityObject> onLoaded)
        {
            AddressableManager.LoadAsset(key, onLoaded);
        }
    }
}