using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public int MaxHealth = 100;
    int currentHealth;
    public TMP_Text healthCounter;
    public DeathScreen DeathScreenUI;
    void Start()
    {
        currentHealth = MaxHealth;
        healthCounter.text = currentHealth.ToString();
    }
    public void TakeDamage(int dmg = 1)
    {
        Debug.Log("Player takes " + dmg + " damage.");
        currentHealth -= dmg;
        if (currentHealth > MaxHealth) currentHealth = MaxHealth;

        healthCounter.text = currentHealth.ToString();

        if (currentHealth <= 0) Death();
    }
    public void Death()
    {
        Debug.Log("Player has died.");
        //
        GameManager.Instance.ResetTempProgress();
        DeathScreenUI.ShowDeathScreen();
    }
}
