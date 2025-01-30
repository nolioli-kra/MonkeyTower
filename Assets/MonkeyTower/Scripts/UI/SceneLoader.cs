using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string loadingSceneName; // Name of the loading screen scene

    public void LoadScene()
    {
        if (!string.IsNullOrEmpty(loadingSceneName))
        {
            SceneManager.LoadScene(loadingSceneName); // Load the loading screen scene
        }
        else
        {
            Debug.LogError("No loading scene specified to load.");
        }
    }
}
