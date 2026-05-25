using UnityEngine;

public class Note : MonoBehaviour, IIntractable
{
    public UImanager UImanager;
    public GameObject NoteUI;
    void Start()
    {
        NoteUI.SetActive(false);
    }
    public void Interact()
    {
        UImanager.OpenMenu(NoteUI);
    }
}
