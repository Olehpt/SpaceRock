using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    UImanager uiManager;
    private void Awake()
    {
        uiManager = FindFirstObjectByType<UImanager>();
    }
    public void Resume()
    {
        Debug.Log("Resume button clicked");
        //
        uiManager.CloseMenu();
    }
    public void Quit()
    {
        Debug.Log("Quit to main menu button clicked");
        Time.timeScale = 1f;
        GameManager.Instance.SaveGame();
        SceneManager.LoadScene(0);
    }
}
