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
        LoadGame();
    }
    public void AddItem(int i = 1)
    {
        itemAmount += i;
        Debug.Log("Item added. Total items: " + itemAmount);
    }
    public void LoadGame()
    {
        SaveData data = SaveManager.Load();
        itemAmount = data.itemCount;
        Debug.Log("Game loaded. Total items: " + itemAmount);
    }
    public void SaveGame()
    {
        SaveManager.Save(itemAmount);
        Debug.Log("Game saved. Total items: " + itemAmount);
    }
    public void ResetGame()
    {
        itemAmount = 0;
        SaveManager.ResetSave();
        Debug.Log("Game reset. Total items: " + itemAmount);
    }
}

