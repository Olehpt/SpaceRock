using UnityEngine;

public class Item : MonoBehaviour, IIntractable 
{
    public void Interact()
    {
        Debug.Log("Item object interacting");
        //
        GameManager.Instance.AddItem();
        this.gameObject.SetActive(false);
    }
}
