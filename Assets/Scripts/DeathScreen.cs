using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public UImanager UIManager;
    void Start()
    {
        this.gameObject.SetActive(false);
    }
    public void ShowDeathScreen()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
        this.gameObject.SetActive(true);
        UIManager.isDeathScreenActive = true;
    }
    public void Retry()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        UIManager.isDeathScreenActive = false;
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }
    public void ReturnToHab()
    {
        UIManager.isDeathScreenActive = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        UIManager.isDeathScreenActive = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
