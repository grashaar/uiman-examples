using System;
using System.Collections;
using UnityEngine.AddressableAssets;
using UnityEngine;
using UnuGames;

using UnityObject = UnityEngine.Object;

public class StartGame : MonoBehaviour
{
    private void Start()
    {
        UIManAssetLoader.RegisterLoadMethodGameObject(LoadGameObject);
        UIManAssetLoader.RegisterLoadMethodSprite(LoadSprite);
        UIManAssetLoader.RegisterLoadMethodTexture2D(LoadTexture2D);

        UIMan.Instance.ShowScreen<UIMainMenu>();
    }

    private static IEnumerator LoadGameObject(string key, Action<string, UnityObject> callback)
    {
        yield return AddressableManager.Load<GameObject>(key, callback);
    }

    private static IEnumerator LoadSprite(string key, Action<string, UnityObject> callback)
    {
        yield return AddressableManager.Load<Sprite>(key, callback);
    }

    private static IEnumerator LoadTexture2D(string key, Action<string, UnityObject> callback)
    {
        yield return AddressableManager.Load<Texture2D>(key, callback);
    }
}