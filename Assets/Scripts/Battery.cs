using UnityEngine;

public class Battery : MonoBehaviour, IIntractable
{
    public void Interact()
    {
        GameManager.Instance.PickUpBattery();
        Debug.Log("Battery Interacted");
        this.gameObject.SetActive(false);
    }
}
