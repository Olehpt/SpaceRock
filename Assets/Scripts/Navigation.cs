using UnityEngine;
using UnityEngine.SceneManagement;
public class Navigation : MonoBehaviour, IIntractable
{
    UImanager uiManager;
    public GameObject NavigationUI;
    private void Awake()
    {
        uiManager = FindFirstObjectByType<UImanager>();
    }
    public void Interact()
    {
        Debug.Log("Navigation object interacting");
        uiManager.OpenMenu(NavigationUI);
    }
    public void Back()
    {
        Debug.Log("Back button clicked");
        uiManager.CloseMenu();
    }
    public void LoadLevel(int levelIndex)
    {
        Debug.Log("Load level button clicked: " + levelIndex);
        uiManager.CloseMenu();
        SceneManager.LoadScene(levelIndex);
    }
}

