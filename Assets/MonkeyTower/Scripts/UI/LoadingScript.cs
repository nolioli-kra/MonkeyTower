using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class LoadingScript : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider loadingBar;
    public TextMeshProUGUI loadingText;
    public string gameplaySceneName; // Name of the gameplay scene

    void Start()
    {
        LoadScene(gameplaySceneName); // Automatically start loading the gameplay scene
    }

    public void LoadScene(string sceneName)
    {
        StartCoroutine(LoadSceneAsync(sceneName));
    }

    IEnumerator LoadSceneAsync(string sceneName)
    {
        // Show loading screen
        loadingScreen.SetActive(true);

        // Start loading the scene
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        // Disable scene activation until the loading is done
        operation.allowSceneActivation = false;

        // Update the progress bar and text
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            loadingBar.value = progress;
            loadingText.text = $"Loading... {progress * 100:0.00}%";

            // Activate the scene when the loading is complete
            if (operation.progress >= 0.9f)
            {
                loadingText.text = "Press any key to continue";
                if (Input.anyKeyDown)
                {
                    operation.allowSceneActivation = true;
                }
            }

            yield return null;
        }
    }
}