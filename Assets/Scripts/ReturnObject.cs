using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnObject : MonoBehaviour, IIntractable
{
    public void Interact()
    {
        Debug.Log("Return object interacting");
        GameManager.Instance.SaveGame();
        SceneManager.LoadScene(1);
    }
}
