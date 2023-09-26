using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    private int health;
    private int healthMax;
    public HealthSystem(int argHealth, int argHealthMax)
    {
        health = argHealth;
        healthMax = argHealthMax;
    }

    public int GetHealth() { return health; }

    public float GetHealthPercent()
    {
        return (float)health / healthMax;
    }

    public void Damage(int argDamageAmount)
    {
        health -= argDamageAmount;
        if (health < 0) health = 0;
    }

    public void Heal(int argHealAmount)
    {
        health += argHealAmount;
        if (health > healthMax) health = healthMax;
    }
}
