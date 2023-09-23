using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader
{
    private class loadingMonoBehavior : MonoBehaviour { }

    private static Action onLoaderCallback;
    private static AsyncOperation loaadingAsyncOperation;

    public static void Load(string scene)
    {
        onLoaderCallback = () => {
            GameObject loadingGameObject = new GameObject("Loading Game Object");
            loadingGameObject.AddComponent<loadingMonoBehavior>().StartCoroutine(LoadSceneAsync(scene));
        };

        // show loading screen
        SceneManager.LoadScene("loading-menu");
    }

    private static IEnumerator LoadSceneAsync(string scene)
    {
        yield return null;
        loaadingAsyncOperation = SceneManager.LoadSceneAsync(scene);
        while (!loaadingAsyncOperation.isDone)
        {
            yield return null;
        }
    }

    public static float GetLoadingProgress()
    {
        if (loaadingAsyncOperation != null)
        {
            return loaadingAsyncOperation.progress;
        }
        else
        {
            return 0.9f;
        }
    }

    public static void LoaderCallback()
    {
        if (onLoaderCallback != null)
        {
            onLoaderCallback();
            onLoaderCallback = null;
        }
    }
}