using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public LoadingScript loadingScript; // Reference to the LoadingScript

    public void StartGame()
    {
        loadingScript.LoadScene("GameScene"); // Ensure "GameScene" is added to the build settings
    }
}