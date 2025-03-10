using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{
    // virtual methods for easier mocking
    protected virtual void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    protected virtual void QuitApplication()
    {
        Application.Quit();
    }
    public void ReturnToMenu()
    {
        LoadScene("Menu");
    }
    public void RestartGame()
    {
        LoadScene("FullMap");
    }
    public void PlayGame()
    {
        LoadScene("FullMap");
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        QuitApplication();
    }
}