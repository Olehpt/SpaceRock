using UnityEngine;

public class FallDamage : MonoBehaviour
{
    public float DamageMinVelocity = 4f;
    public float DamageMultiplier = 1f;
    Health PlayerHealth;
    PlayerMovement PM;
    CharacterController CharController;
    float Speed;
    int HitDamage;
    bool ShouldTakeDamage = false;
    void Start()
    {
        PlayerHealth = GetComponent<Health>();
        PM = GetComponent<PlayerMovement>();
        CharController = GetComponent<CharacterController>();
    }
    private void Update()
    {
        if(!CharController.isGrounded)
        {
            Speed = PM.getMoveVelocity().magnitude;
            if (Speed > DamageMinVelocity)
            {
                ShouldTakeDamage = true;
                HitDamage = Mathf.Max(HitDamage, Mathf.RoundToInt(Speed*DamageMultiplier));
            }
        }
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (ShouldTakeDamage)
        {
            PlayerHealth.TakeDamage(HitDamage);
        }
        ShouldTakeDamage = false;
    }
}
