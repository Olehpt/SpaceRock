using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    int itemAmount = 0;
    int nonSavedItemAmount = 0;
    int batteries = 0;
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
        nonSavedItemAmount += i;
        Debug.Log("Item added");
    }
    public void LoadGame()
    {
        SaveData data = SaveManager.Load();
        itemAmount = data.itemCount;
        Debug.Log("Game loaded. Total items: " + itemAmount);
    }
    public void SaveGame()
    {
        itemAmount += nonSavedItemAmount;
        nonSavedItemAmount = 0;
        batteries = 0;
        SaveManager.Save(itemAmount);
        Debug.Log("Game saved. Total items: " + itemAmount);
    }
    public void ResetGame()
    {
        itemAmount = 0;
        SaveManager.ResetSave();
        Debug.Log("Game reset. Total items: " + itemAmount);
    }
    public void ResetTempProgress()
    {
        nonSavedItemAmount = 0;
        batteries = 0;
    }
    public int GetItemAmount()
    {
        return itemAmount;
    }
    public int GetNonSavedItemAmount()
    {
        return nonSavedItemAmount;
    }
    public void PickUpBattery()
    {
        batteries++;
        Debug.Log("Battery picked up. Total batteries: " + batteries);
    }
    public int GetBatteryCount()
    {
        return batteries;
    }
    public void UseBattery()
    {
        if (batteries > 0)
        {
            batteries--;
            Debug.Log("Battery used. Remaining batteries: " + batteries);
        }
        else
        {
            Debug.Log("No batteries left to use.");
        }
    }

}

