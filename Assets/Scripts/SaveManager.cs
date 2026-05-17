using System.IO;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private static string path = Application.persistentDataPath + "/save.json";
    public static void Save(int resourceCount)
    {
        SaveData data = new SaveData();
        data.itemCount = resourceCount;
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);
        Debug.Log("Saved to: " + path);
    }

    public static SaveData Load()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            return data;
        }

        return new SaveData();
    }
    public static void ResetSave()
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            Debug.Log("Save deleted");
        }
        else
        {
            Debug.Log("Save file does not exist");
        }
    }
}
