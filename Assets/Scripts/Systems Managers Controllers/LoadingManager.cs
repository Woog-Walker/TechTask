using UnityEngine.SceneManagement;
using System.Collections;
using TechnicalTask.UI;
using UnityEngine;
using Zenject;

namespace TechnicalTask.Loading
{
    public class LoadingManager : MonoBehaviour
    {
        int levelToLoad = 1; // SCENE INDEX

        [Inject] CanvasLoadingManager canvasLoadingManager;

        private void Start() => StartCoroutine(SceneLoadingDelay());

        IEnumerator SceneLoadingDelay()
        {
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(levelToLoad);

            asyncLoad.allowSceneActivation = false;

            while (!asyncLoad.isDone)
            {
                // UPDATE UI
                canvasLoadingManager.UiUpdateLoadingBar(asyncLoad.progress);
                canvasLoadingManager.UiUpdateLoadingText(asyncLoad.progress * 100);

                // When the scene is almost done loading (progress reaches 90%), wait for 1 second
                if (asyncLoad.progress >= 0.9f)
                {
                    yield return new WaitForSeconds(1f);
                    asyncLoad.allowSceneActivation = true;
                }

                yield return null;
            }
        }
    }
}