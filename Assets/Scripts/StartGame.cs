using System;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.AddressableAssets;

namespace UnuGames.Examples
{
    using UI;

    using UnityObject = UnityEngine.Object;

    public class StartGame : MonoBehaviour
    {
        private void Start()
        {
            UIManAssetLoader.SetLoadMethodGameObject(LoadGameObject);
            UIManAssetLoader.SetLoadMethodSprite(LoadSprite);
            UIManAssetLoader.SetLoadMethodSpriteAtlas(LoadSpriteAtlas);
            UIManAssetLoader.SetLoadMethodTexture2D(LoadTexture2D);
            UIManAssetLoader.SetLoadMethodFallback(LoadFallback);

            SpriteAtlasManager.atlasRequested += LoadSpriteAtlas;

            AddressableManager.Initialize(DoStartGame);
        }

        private void DoStartGame()
        {
            UIMan.Instance.ShowScreen<UIMainMenu>();
        }

        private void LoadGameObject(string key, Action<string, UnityObject> callback)
        {
            AddressableManager.LoadAsset<GameObject>(key, callback);
        }

        private void LoadSprite(string key, Action<string, UnityObject> callback)
        {
            AddressableManager.LoadAsset<Sprite>(key, callback);
        }

        private void LoadTexture2D(string key, Action<string, UnityObject> callback)
        {
            AddressableManager.LoadAsset<Texture2D>(key, callback);
        }

        private void LoadSpriteAtlas(string key, Action<string, UnityObject> callback)
        {
            AddressableManager.LoadAsset<SpriteAtlas>(key, callback);
        }

        private void LoadFallback(string key, Action<string, UnityObject> callback)
        {
            AddressableManager.LoadAsset(key, callback);
        }

        private void LoadSpriteAtlas(string key, Action<SpriteAtlas> onSucceeded)
        {
            AddressableManager.LoadAsset<SpriteAtlas>(key, (_, atlas) => onSucceeded?.Invoke(atlas));
        }
    }
}