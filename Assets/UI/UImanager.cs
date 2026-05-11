using UnityEngine;

public class UImanager : MonoBehaviour
{
    public GameObject UI;
    public GameObject Hint;
    void Start()
    {
        UI.SetActive(true);
        Hint.SetActive(false);
    }
    public void ShowHint()
    {
        Hint.SetActive(true);
    }
    public void HideHint()
    {
        Hint.SetActive(false);
    }
}
