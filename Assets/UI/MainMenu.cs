using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public void Start()
    {
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }
    public void Play()
    {
        Debug.Log("Play button clicked");
        SceneManager.LoadScene(1); 
    }
    public void Quit()
    {
        Debug.Log("Quit button clicked");
        Application.Quit();
    }
    public void SettingsOpen()
    {
        Debug.Log("Settings button clicked");
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
    public void SettingsClose()
    {
        Debug.Log("Back button clicked");
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }
    public void ResetSave()
    {
        Debug.Log("Reset save button clicked");
        GameManager.Instance.ResetGame();
    }
}
