using UnityEngine;

public class DamageZone : MonoBehaviour
{
    public int Damage = 1;
    public float DamageDelay = 1f;
    float timer;
    Health targetHealth;
    private void OnTriggerEnter(Collider collision)
    {
        targetHealth = collision.GetComponent<Health>();
        timer = 0f;
    }
    private void OnTriggerStay(Collider other)
    {
        if (targetHealth == null) return;
        timer += Time.deltaTime;
        if (timer >= DamageDelay)
        {
            targetHealth.TakeDamage(Damage);
            timer = 0f;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        targetHealth = null;
        timer = 0f;
    }
}

