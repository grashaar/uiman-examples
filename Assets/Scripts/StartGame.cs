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
        UIManAssetLoader.SetLoadMethodGameObject(LoadGameObject);
        UIManAssetLoader.SetLoadMethodSprite(LoadSprite);
        UIManAssetLoader.SetLoadMethodTexture2D(LoadTexture2D);

        AddressableManager.Initialize(DoStartGame);
    }

    private void DoStartGame()
    {
        Debug.Log("START");
        UIMan.Instance.ShowScreen<UIMainMenu>();
    }

    private static IEnumerator LoadGameObject(string key, Action<string, UnityObject> callback)
    {
        yield return AddressableManager.LoadAssetCoroutine<GameObject>(key, callback);
    }

    private static IEnumerator LoadSprite(string key, Action<string, UnityObject> callback)
    {
        yield return AddressableManager.LoadAssetCoroutine<Sprite>(key, callback);
    }

    private static IEnumerator LoadTexture2D(string key, Action<string, UnityObject> callback)
    {
        yield return AddressableManager.LoadAssetCoroutine<Texture2D>(key, callback);
    }
}