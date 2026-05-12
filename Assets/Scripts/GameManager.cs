using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    int itemAmount = 0;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("GameManager instance created");
        }
        else
        {
            Destroy(gameObject);
            Debug.Log("Duplicate GameManager found and destroyed.");
        }
    }
    private void Start()
    {
        Debug.Log("GameManager started");
    }
    public void AddItem()
    {
        itemAmount++;
        Debug.Log("Item added. Total items: " + itemAmount);
    }
}

