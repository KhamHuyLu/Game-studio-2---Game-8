using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextSceneButton : MonoBehaviour
{
    public Button button;
    public string nextSceneName;

    void Start()
    {
        // Add a listener to the button so that it calls the LoadNextScene function when clicked
        button.onClick.AddListener(LoadNextScene);
    }

    void LoadNextScene()
    {
        // Load the next scene by name
        SceneManager.LoadScene(nextSceneName);
    }
}

