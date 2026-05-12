using UnityEngine;

public class UImanager : MonoBehaviour
{
    GameObject currentMenu = null;
    public GameObject PauseMenu;
    public GameObject UI;
    public GameObject Hint;
    public GameObject NavigationUI;
    void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Start()
    {
        PauseMenu.SetActive(false);
        UI.SetActive(true);
        Hint.SetActive(false);
        NavigationUI.SetActive(false);
    }
    void Update()
    {
        if (currentMenu != null)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                CloseMenu();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenMenu(PauseMenu);
        }
    }
    public void OpenMenu(GameObject menu)
    {
        Debug.Log("Opening menu: " + menu.name);
        menu.SetActive(true);
        UnlockCursor();
        Time.timeScale = 0f;
        currentMenu = menu;
    }
    public void CloseMenu()
    {
        Debug.Log("Closing menu: " + currentMenu.name);
        currentMenu.SetActive(false);
        LockCursor();
        Time.timeScale = 1f;
        currentMenu = null;
    }
    //
    public void ShowHint()
    {
        Hint.SetActive(true);
    }
    public void HideHint()
    {
        Hint.SetActive(false);
    }
}
