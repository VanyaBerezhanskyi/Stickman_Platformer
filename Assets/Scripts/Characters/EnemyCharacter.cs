using UnityEngine;

public class EnemyCharacter : Character
{
    public float health { get; private set; }

    void Awake()
    {
        health = maxHealth;
    }

    public override void ChangeHealth(float value)
    {
        health += value;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
