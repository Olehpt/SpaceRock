using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        Debug.Log("Play button clicked");
        SceneManager.LoadScene(1); //index?
    }
    public void Quit()
    {
        Debug.Log("Quit button clicked");
        Application.Quit();
    }
}
