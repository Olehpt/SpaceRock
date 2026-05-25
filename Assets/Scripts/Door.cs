using UnityEngine;

public class Door : MonoBehaviour, IIntractable
{
    public bool isOpen = false;
    void Start()
    {
        if (isOpen)
        {
            OpenDoor();
        }
        else
        {
            CloseDoor();
        }
    }
    public void Interact()
    {
        int batteryCount = GameManager.Instance.GetBatteryCount();
        if (batteryCount >= 1)
        {
            OpenDoor();
            GameManager.Instance.UseBattery();
        }
        else
        {
            Debug.Log("Not enough batteries to open the door.");
        }
    }
    void OpenDoor()
    {
        this.gameObject.SetActive(false);
    }
    void CloseDoor()
    {
        this.gameObject.SetActive(true);
    }
}
